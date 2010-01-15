/*  
 * AddNewPlurk.cs
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
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace KarmaBooster__Windows_Form_version_
{
    public partial class AddNewPlurk : Form
    {
        public SortedDictionary<int, string> friendList;
        public Dictionary<string, string> languageList;
        public Dictionary<string, string> qulifireList;

        public ActionItem actionResult;

        private bool[] ascendingStatus;

        public AddNewPlurk()
        {
            InitializeComponent();

            m_chkboxAllowComments.Checked = true;
            m_rbImmediate.Checked = true;

            actionResult = new ActionItem();

            ascendingStatus = new bool[2];  // 2 columns
        }

        public void UpdateUi()
        {
            // update limit-to box
            if (friendList != null)
            {
            /*
                m_chklstLimitTo.Items.Clear();
                foreach (KeyValuePair<int, string> pair in friendList)
                {
                    m_chklstLimitTo.Items.Add(pair.Value + " (" + pair.Key.ToString() + ")");
                }
             */
                m_listviewLimitTo.Items.Clear();
                foreach( KeyValuePair<int,string> pair in friendList)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = pair.Key.ToString();
                    item.SubItems.Add(pair.Value.ToString());
                    m_listviewLimitTo.Items.Add(item);
                }
            }

            // update language list box
            if (languageList != null)
            {
                m_cbLanguage.Items.Clear();
                foreach (KeyValuePair<string, string> pair in languageList)
                {
                    m_cbLanguage.Items.Add(pair.Key);
                }
            }

            // update qualifier list box
            if (qulifireList != null)
            {
                m_cbQualifier.Items.Clear();
                foreach (KeyValuePair<string, string> pair in qulifireList)
                {
                    m_cbQualifier.Items.Add(pair.Key);
                }
            }
        }

        private void m_btnAdd_Click(object sender, EventArgs e)
        {
            string value;
            string errorString = "Error occurs!!\n\n";
            int i;
            bool bError = false;

            //actionResult.Message = new myPlurkMessage();
            //actionResult.Message.limit_to = new List<int>();

            // Get message content
            if (m_textContent.Text == "")
            {
                errorString += "- Content field cannot be empty.\n";
                bError = true;
            }
            actionResult.Message.content = m_textContent.Text;

            // Get qualifier language
            if ( languageList.TryGetValue(m_cbLanguage.SelectedItem.ToString(), out value))
                actionResult.Message.language = value;
            else
                actionResult.Message.language = "en";

            // Get qualifier string
            if (qulifireList.TryGetValue(m_cbQualifier.SelectedItem.ToString(), out value))
                actionResult.Message.qualifier = value;
            else
                actionResult.Message.qualifier = "says";

            // Get limitation string
            actionResult.Message.limit_to.Clear();
            for (i=0; i<m_listviewLimitTo.Items.Count; i++)
            {
                if ( m_listviewLimitTo.Items[i].Checked)
                {
                    actionResult.Message.limit_to.Add(Convert.ToInt32(m_listviewLimitTo.Items[i].Text));
                }
            }

            // Get allow-comment setting
            actionResult.Message.allow_comments = m_chkboxAllowComments.Checked;

            if (m_rbOneTime.Checked)
            {
                actionResult.Type = ActionType.OneShot;
                actionResult.ExactTime = new DateTime(
                    m_datePicker.Value.Year,
                    m_datePicker.Value.Month,
                    m_datePicker.Value.Day,
                    m_timePicker.Value.Hour,
                    m_timePicker.Value.Minute,
                    0);
            }
            else if (m_rbRepeat.Checked)
            {
                actionResult.Type = ActionType.Periodic;

                try
                {
                    actionResult.Hours = (m_textHours.Text == "")?(0):Convert.ToInt32(m_textHours.Text);
                    actionResult.Minutes = (m_textMinutes.Text == "")?(0):Convert.ToInt32(m_textMinutes.Text);
                    actionResult.RemainedMinutes = actionResult.Hours * 60 + actionResult.Minutes;
                }
                catch
                {
                    errorString += "- The time format is incorrect.\n";
                    bError = true;
                }

                if (actionResult.RemainedMinutes == 0)
                {
                    errorString += "- Time interval cannot be 0.\n";
                    bError = true;
                }
            }
            else if (m_rbImmediate.Checked)
            {
                actionResult.Type = ActionType.Immediate;
            }
            else
            {
                errorString += "- Action type not selected.";
                bError = true;
            }

            if (bError)
            {
                MessageBox.Show(errorString);
                // Do not close the dialog if error happens.
                DialogResult = DialogResult.None;
            }
        }

        private void m_listviewLimitTo_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column < 2)
            {
                ascendingStatus[e.Column] = !ascendingStatus[e.Column];
                m_listviewLimitTo.ListViewItemSorter = new ListViewItemComparer(e.Column, ascendingStatus[e.Column]);
            }
        }
    }

    // Implements the manual sorting of items by columns.
    class ListViewItemComparer : IComparer
    {
        private int col;
        private bool bAscending;

        public ListViewItemComparer()
        {
            col = 0;
            bAscending = true;
        }
        public ListViewItemComparer(int column, bool ascending)
        {
            col = column;
            bAscending = ascending;
        }
        public int Compare(object x, object y)
        {
            int result;

            if (col == 0)
            {
                try
                {
                    result = Convert.ToInt32(((ListViewItem)x).SubItems[col].Text) -
                             Convert.ToInt32(((ListViewItem)y).SubItems[col].Text);
                }
                catch
                {
                    result = String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
                }
            }
            else
            {
                result = String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
            }

            return (bAscending) ? (result) : (-result);
        }
    }


}
