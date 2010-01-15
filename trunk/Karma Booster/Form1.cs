/*  
 * Form1.cs
 * 
 * This file is part of Karma Booster.
 * 
 * Karma Booster is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 2 of the License, or
 * (at your option) any later version.
 *  
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using PlurkApi;

namespace KarmaBooster__Windows_Form_version_
{
    public partial class Form1 : Form
    {
        /* To obtain your own Plurk API Key, please visit http://www.plurk.com/API . */
        private PlurkApi.PlurkApi plurk = new PlurkApi.PlurkApi("yRcSemzOzEGQbJtPcnPnDKGW7jXnGVLF");
        private PlurkMessages m_messagesInList;

        private System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        private int timerInterval;

        private List<ActionItem> m_ActionList = new List<ActionItem>();

        Dictionary<string, string> m_qualifierTable = new Dictionary<string, string>()
        {
            { "(none)", ":"},
            { "Loves", "loves"},
            { "Likes", "likes"},
            { "Shares", "shares"},
            { "Gives", "gives"},
            { "Hates", "hates"},
            { "Wants", "wants"},
            { "Wishes", "wishes"},
            { "Needs", "needs"},
            { "Will", "will"},
            { "Hopes", "hopes"},
            { "Asks", "asks"},
            { "Has", "has"},
            { "Was", "was"},
            { "Wonders", "wonders"},
            { "Feels", "feels"},
            { "Thinks", "thinks"},
            { "Says", "says"},
            { "Is", "is"}
        };

        Dictionary<string, string> m_languageTable = new Dictionary<string, string>()
        {
            { "English", "en"},
            { "Traditional Chinese", "tr_ch"},
            { "French", "fr"},
            { "Japanese", "ja"}
        };

        SortedDictionary<int, string> m_friendList = new SortedDictionary<int, string>();

        /// <summary>
        /// Constructor.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            myTimer.Tick += new EventHandler(myTimer_Tick);

            // Don't show notify icon when the window is in normal state
            m_notifyIcon.Visible = false;
        }

        /// <summary>
        /// Timer event handler:
        ///     1. Post a new Plurk message.
        ///     2. Increase m_messageIndex so that the next line in "Content"
        ///        will be posted next time.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void myTimer_Tick(object sender, EventArgs e)
        {
            myTimer.Stop();
            DateTime now = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, 0);

            for (int i = m_ActionList.Count - 1; i >= 0; i--)
            {
                switch (m_ActionList[i].Type)
                {
                case ActionType.Periodic:
                    m_ActionList[i].RemainedMinutes--;
                    if (m_ActionList[i].RemainedMinutes <= 0)
                    {
                        m_DoNewPlurk(m_ActionList[i].Message);
                        m_ActionList[i].RemainedMinutes = m_ActionList[i].Hours * 60 + m_ActionList[i].Minutes;
                    }
                    m_UpdateActionListUi();
                    break;

                case ActionType.OneShot:
                    if (m_ActionList[i].ExactTime == now)
                    {
                        m_DoNewPlurk(m_ActionList[i].Message);
                        m_ActionList.RemoveAt(i);
                        m_UpdateActionListUi();
                    }
                    break;

                case ActionType.Immediate:
                    m_DoNewPlurk(m_ActionList[i].Message);
                    m_ActionList.RemoveAt(i);
                    m_UpdateActionListUi();
                    break;
                }
            }
            myTimer.Enabled = true;
        }

        /// <summary>
        /// Post a new Plurk message.
        /// </summary>
        /// <param name="item">The message item to be plurked.</param>
        /// <returns>true: message posted successfully; false: otherwise.</returns>
        private bool m_DoNewPlurk(myPlurkMessage item)
        {
            if (!plurk.isLogged)
            {
                if (!m_LoginPlurk())
                {
                    m_Output("ERROR: Failed to log in as " + m_textUsername.Text + ".");
                    return false;
                }
                m_Output("Now logged on as " + m_textUsername.Text + ".");
            }

            // compose limit-to string
            string limit_to = "";
            for (int i = 0; i < item.limit_to.Count; i++)
            {
                if (i == 0)
                {
                    limit_to = "[";
                }
                else
                {
                    limit_to += ',';
                }
                limit_to += item.limit_to[i].ToString();
            }
            if (limit_to != "")
            {
                limit_to += ']';
            }


            // Post new Plurk message
            if (plurk.addMessage(item.language, item.qualifier, item.content, item.allow_comments, limit_to))
            {
                m_Output("Successfully added a new Plurk message!");
            }
            else
            {
                m_Output("ERROR: Failed to post....");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Print a piece of message in output field.
        /// </summary>
        /// <param name="msg">The message to be printed.</param>
        private void m_Output(string msg)
        {
            m_textOutput.AppendText(DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss] ") + msg + "\n");
        }

        /// <summary>
        /// Login using current username/password.
        /// </summary>
        /// <returns>true: successfully logged on; false: otherwise.</returns>
        private bool m_LoginPlurk()
        {
            if (m_textUsername.Text == "")
            {
                m_Output("ERROR: Username field cannot be empty.");
                return false;
            }

            return plurk.Login(m_textUsername.Text, m_textPassword.Text);
        }

        /// <summary>
        /// Close button event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void m_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Load Friend List button event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void m_btnLoadFriends_Click(object sender, EventArgs e)
        {
            if (!plurk.isLogged)
            {
                if (m_LoginPlurk())
                {
                    m_Output("Successfully logged in as " + m_textUsername.Text + ".");
                    m_Output("friends_count = " + plurk.friends_count.ToString());
                }
                else
                {
                    m_Output("ERROR: Log in failed!");
                }
            }

            if (plurk.myFriends != null)
            {
                m_friendList.Clear();

                m_friendList.Add(plurk.uid, "(me)");

                foreach (PlurkApi.PlurkFriend friend in plurk.myFriends)
                {
                    m_friendList.Add(friend.uid, friend.nick_name);
                }
            }
            else
            {
                m_Output("ERROR: Cannot obtain friend list.\n");
            }
        }

        /// <summary>
        /// Action (Go/Stop) button event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void m_btnAction_Click(object sender, EventArgs e)
        {
            if (myTimer.Enabled == false)
            {
                bool bUseTimer = false;
                ActionItem action;
                for (int i = m_ActionList.Count - 1; i >= 0; i--)
                {
                    action = m_ActionList[i];
                    switch (action.Type)
                    {
                        case ActionType.Immediate:
                            m_DoNewPlurk(action.Message);
                            m_ActionList.RemoveAt(i);
                            m_UpdateActionListUi();
                            break;

                        case ActionType.OneShot:
                            action.RemainedMinutes = action.Hours * 60 + action.Minutes;
                            bUseTimer = true;
                            break;

                        case ActionType.Periodic:
                            bUseTimer = true;
                            break;
                    }
                }

                if (bUseTimer)
                {
                    timerInterval = 60 * 1000;  // 1 minute
                    myTimer.Interval = timerInterval;
                    myTimer.Start();
                    m_btnAction.Text = "Stop";
                }
                else
                {
                    timerInterval = 0;
                }
            }
            else
            {
                myTimer.Stop();
                m_btnAction.Text = "Go";
            }
        }

        #region These 2 methods are operations for system-tray notify icon.

        /// <summary>
        /// Window resizing event handler.
        /// The form window will be hidden, and the notify icon will be shown.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                m_notifyIcon.Visible = true;
            }
        }

        /// <summary>
        /// The event handler when user double-clicked on the notify icon.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void m_notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            m_notifyIcon.Visible = false;
        }

        #endregion

        /// <summary>
        /// Show About box when clicked on the about link.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }

        private void m_btnFetchList_Click(object sender, EventArgs e)
        {
            int _uid = plurk.uid;
            if (m_comboUid.SelectedIndex == 0)
            {
                _uid = plurk.uid;
            }
            else
            {
                string full_name = m_comboUid.SelectedItem.ToString();
                foreach (PlurkFriend friend in plurk.myFriends)
                {
                    if (friend.display_name == full_name)
                    {
                        _uid = friend.uid;
                        break;
                    }
                }
            }

            string date_from = m_dtpDateFrom.Value.ToUniversalTime().ToString("s");
            string date_offset = m_dtpDateTo.Value.ToUniversalTime().ToString("s");

            m_messagesInList = plurk.getMessages(_uid, date_from, date_offset, false);

            if (m_messagesInList != null)
            {
                m_listMessages.Items.Clear();
                for (int i = 0; i < m_messagesInList.Count; i++)
                {
                    m_listMessages.Items.Add(m_messagesInList[i].content_raw.Substring(0, 20) + "...");
                }
            }
        }

        private void m_btnAdd_Click(object sender, EventArgs e)
        {
            //if (plurk.isLogged)
            if (true)
            {
                AddNewPlurk dlg = new AddNewPlurk();

                dlg.friendList = m_friendList;
                dlg.languageList = m_languageTable;
                dlg.qulifireList = m_qualifierTable;

                dlg.UpdateUi();
                dlg.ShowDialog(this);

                if (dlg.DialogResult == DialogResult.OK)
                {
                    m_ActionList.Add(dlg.actionResult);
                    m_UpdateActionListUi();
                }
            }
            else
            {
                MessageBox.Show("Please login first.");
            }
        }

        private void m_UpdateActionListUi()
        {
            string strTemp;

            m_listNewPlurks.Items.Clear();

            foreach (ActionItem item in m_ActionList)
            {
                ListViewItem viewItem = new ListViewItem();
                // Post time
                switch (item.Type)
                {
                    case ActionType.Immediate:
                        viewItem.Text = "(Immediate)";
                        break;

                    case ActionType.OneShot:
                        viewItem.Text = item.ExactTime.ToShortTimeString();
                        break;

                    case ActionType.Periodic:
                        viewItem.Text = "[" + item.RemainedMinutes.ToString() + "/" + (item.Hours*60+item.Minutes).ToString() + "min]";
                        break;
                }

                // Allow comments
                viewItem.SubItems.Add( item.Message.allow_comments?"Yes":"No");

                // Limit-to
                if (item.Message.limit_to.Count > 0)
                {
                    strTemp = "[";
                    foreach (int i in item.Message.limit_to)
                    {
                        if (strTemp != "[")
                        {
                            strTemp += ',';
                        }
                        strTemp += i.ToString();
                    }
                    strTemp += ']';

                    viewItem.SubItems.Add(strTemp);
                }
                else
                {
                    viewItem.SubItems.Add("--");
                }

                // Language
                viewItem.SubItems.Add(item.Message.language);

                // Qualifier
                viewItem.SubItems.Add(item.Message.qualifier);

                // Content
                viewItem.SubItems.Add(item.Message.content);



                m_listNewPlurks.Items.Add(viewItem);
            }
        }

        private void m_listNewPlurks_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            bool enable = false;
            foreach ( ListViewItem item in m_listNewPlurks.Items)
            {
                if (item.Selected)
                {
                    enable = true;
                    break;
                }
            }

            m_btnDelete.Enabled = enable;
        }

        private void m_btnDelete_Click(object sender, EventArgs e)
        {
            //ListViewItem item;
            for (int i = m_listNewPlurks.Items.Count - 1; i >= 0; i--)
            {
                if (m_listNewPlurks.Items[i].Selected)
                {
                    m_ActionList.RemoveAt(i);
                }
            }

            if (myTimer.Enabled && m_listNewPlurks.Items.Count == 0)
            {
                myTimer.Stop();
                m_btnAction.Text = "Go";
            }

            m_UpdateActionListUi();
        }

    }

    public class myPlurkMessage
    {
        public string language;
        public string qualifier;
        public List<int> limit_to;
        public string content;
        public bool allow_comments;

        public myPlurkMessage()
        {
            limit_to = new List<int>();
        }
    }

    public enum ActionType
    {
        None,
        Immediate,
        OneShot,
        Periodic
    }

    public class ActionItem
    {
        public ActionType Type;
        public DateTime ExactTime;
        public int Hours;
        public int Minutes;
        public int RemainedMinutes;
        public myPlurkMessage Message;

        public ActionItem()
        {
            Message = new myPlurkMessage();
        }
    }

}
