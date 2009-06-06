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
        private PlurkApi.PlurkApi plurk = new PlurkApi.PlurkApi();

        private System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        private int timerInterval;

        private string[] m_messagesToPlurk;
        private int m_messageIndex;

        /// <summary>
        /// Constructor.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            myTimer.Tick += new EventHandler(myTimer_Tick);

            // Hide "seconds" control
            m_textSecond.Hide();
            m_labelSecond.Hide();

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

            m_DoNewPlurk();

            m_messageIndex++;
            if (m_messageIndex >= m_messagesToPlurk.Length)
            {
                m_messageIndex = 0;
            }

            myTimer.Enabled = true;
        }

        /// <summary>
        /// Post a new Plurk message.
        /// </summary>
        /// <returns>true: message posted successfully; false: otherwise.</returns>
        private bool m_DoNewPlurk()
        {
            if (!m_LoginPlurk())
            {
                return false;
            }
            m_Output("Now logged on as " + m_textUsername.Text + ".");

            // compose limit-to string
            string limit_to = "";
            string[] tokens;
            for (int i = 0; i < m_chklstFriendList.Items.Count; i++)
            {
                if (m_chklstFriendList.GetItemChecked(i))
                {
                    if (limit_to == "")
                    {
                        limit_to = "[";
                    }
                    tokens = Regex.Split(m_chklstFriendList.Items[i].ToString(), " \\(");
                    limit_to += (tokens[0] + ",");
                }
            }
            if (limit_to != "")
            {
                limit_to = limit_to.Remove(limit_to.Length - 1);
                limit_to += ']';
            }


            // Post new Plurk message
            if (plurk.addMessage("en", "says", m_textContent.Text, m_cbAllowComments.Checked, limit_to))
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

            return plurk.Login( m_textUsername.Text, m_textPassword.Text);
        }

        /// <summary>
        /// Scheduling checkbox event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void m_cbScheduling_CheckedChanged(object sender, EventArgs e)
        {
            if (m_cbScheduling.Checked)
            {
                m_textHour.Enabled = true;
                m_textMinute.Enabled = true;
                m_textSecond.Enabled = true;
            }
            else
            {
                m_textHour.Enabled = false;
                m_textMinute.Enabled = false;
                m_textSecond.Enabled = false;
            }
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
                m_LoginPlurk();

            if (plurk.myFriends != null)
            {
                m_chklstFriendList.Items.Clear();
                SortedDictionary<int, PlurkFriend> sorted_friend_array = new SortedDictionary<int, PlurkFriend>();

                foreach (PlurkApi.PlurkFriend friend in plurk.myFriends)
                {
                    sorted_friend_array.Add(friend.uid, friend);
                }

                foreach ( PlurkFriend friend in sorted_friend_array.Values)
                {
                    m_chklstFriendList.Items.Add(friend.uid.ToString() + " (" + friend.nick_name + ")");
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
                timerInterval = 0;
                try
                {
                    if (m_textHour.Text != "")
                        timerInterval += System.Int32.Parse(m_textHour.Text);
                    timerInterval *= 60;
                    if (m_textMinute.Text != "")
                        timerInterval += System.Int32.Parse(m_textMinute.Text);
                    timerInterval *= 60;
                    if (m_textSecond.Text != "")
                        timerInterval += System.Int32.Parse(m_textSecond.Text);
                    timerInterval *= 1000;
                }
                catch
                {
                    m_Output("ERROR: Time format error.");
                    return;
                }

                // Prepare for the messages to plurk.
                m_messagesToPlurk = m_textContent.Text.Split( new char[]{'\n', '\r'}, StringSplitOptions.RemoveEmptyEntries);
                if (m_messagesToPlurk.Length == 0)
                {
                    m_Output("ERROR: Content field cannot be empty.");
                }
                else
                {
                    m_messageIndex = 0;

                    if (timerInterval == 0)
                    {
                        m_DoNewPlurk();
                    }
                    else
                    {
                        myTimer.Interval = timerInterval;
                        myTimer.Start();
                        m_btnAction.Text = "Stop";
                    }
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
    }
}
