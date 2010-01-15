/*  
 * Form1.Designer.cs
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
namespace KarmaBooster__Windows_Form_version_
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
        ///
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.m_textUsername = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.m_textOutput = new System.Windows.Forms.TextBox();
            this.m_textPassword = new System.Windows.Forms.TextBox();
            this.m_btnLoadFriends = new System.Windows.Forms.Button();
            this.m_btnAction = new System.Windows.Forms.Button();
            this.m_btnClose = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.m_tabFunction = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.m_btnDelete = new System.Windows.Forms.Button();
            this.m_btnAdd = new System.Windows.Forms.Button();
            this.m_listNewPlurks = new System.Windows.Forms.ListView();
            this.colPostTime = new System.Windows.Forms.ColumnHeader();
            this.colComment = new System.Windows.Forms.ColumnHeader();
            this.colLimitTo = new System.Windows.Forms.ColumnHeader();
            this.colLanguage = new System.Windows.Forms.ColumnHeader();
            this.colQualifier = new System.Windows.Forms.ColumnHeader();
            this.colContent = new System.Windows.Forms.ColumnHeader();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.m_textMinutesComment = new System.Windows.Forms.TextBox();
            this.m_textHoursComment = new System.Windows.Forms.TextBox();
            this.m_textCommentContent = new System.Windows.Forms.TextBox();
            this.m_cbAutoComment = new System.Windows.Forms.CheckBox();
            this.m_comboUid = new System.Windows.Forms.ComboBox();
            this.m_dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.m_dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.m_listMessages = new System.Windows.Forms.ListBox();
            this.m_btnFetchList = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.m_tabFunction.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleDescription = null;
            this.label1.AccessibleName = null;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Font = null;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            this.label2.AccessibleDescription = null;
            this.label2.AccessibleName = null;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Font = null;
            this.label2.Name = "label2";
            // 
            // m_notifyIcon
            // 
            resources.ApplyResources(this.m_notifyIcon, "m_notifyIcon");
            this.m_notifyIcon.DoubleClick += new System.EventHandler(this.m_notifyIcon_DoubleClick);
            // 
            // m_textUsername
            // 
            this.m_textUsername.AccessibleDescription = null;
            this.m_textUsername.AccessibleName = null;
            resources.ApplyResources(this.m_textUsername, "m_textUsername");
            this.m_textUsername.BackgroundImage = null;
            this.m_textUsername.Font = null;
            this.m_textUsername.Name = "m_textUsername";
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleDescription = null;
            this.groupBox1.AccessibleName = null;
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.BackgroundImage = null;
            this.groupBox1.Controls.Add(this.m_textOutput);
            this.groupBox1.Font = null;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // m_textOutput
            // 
            this.m_textOutput.AccessibleDescription = null;
            this.m_textOutput.AccessibleName = null;
            resources.ApplyResources(this.m_textOutput, "m_textOutput");
            this.m_textOutput.BackColor = System.Drawing.SystemColors.Window;
            this.m_textOutput.BackgroundImage = null;
            this.m_textOutput.Font = null;
            this.m_textOutput.Name = "m_textOutput";
            this.m_textOutput.ReadOnly = true;
            // 
            // m_textPassword
            // 
            this.m_textPassword.AccessibleDescription = null;
            this.m_textPassword.AccessibleName = null;
            resources.ApplyResources(this.m_textPassword, "m_textPassword");
            this.m_textPassword.BackgroundImage = null;
            this.m_textPassword.Font = null;
            this.m_textPassword.Name = "m_textPassword";
            this.m_textPassword.UseSystemPasswordChar = true;
            // 
            // m_btnLoadFriends
            // 
            this.m_btnLoadFriends.AccessibleDescription = null;
            this.m_btnLoadFriends.AccessibleName = null;
            resources.ApplyResources(this.m_btnLoadFriends, "m_btnLoadFriends");
            this.m_btnLoadFriends.BackgroundImage = null;
            this.m_btnLoadFriends.Font = null;
            this.m_btnLoadFriends.Name = "m_btnLoadFriends";
            this.m_btnLoadFriends.UseVisualStyleBackColor = true;
            this.m_btnLoadFriends.Click += new System.EventHandler(this.m_btnLoadFriends_Click);
            // 
            // m_btnAction
            // 
            this.m_btnAction.AccessibleDescription = null;
            this.m_btnAction.AccessibleName = null;
            resources.ApplyResources(this.m_btnAction, "m_btnAction");
            this.m_btnAction.BackgroundImage = null;
            this.m_btnAction.Font = null;
            this.m_btnAction.Name = "m_btnAction";
            this.m_btnAction.UseVisualStyleBackColor = true;
            this.m_btnAction.Click += new System.EventHandler(this.m_btnAction_Click);
            // 
            // m_btnClose
            // 
            this.m_btnClose.AccessibleDescription = null;
            this.m_btnClose.AccessibleName = null;
            resources.ApplyResources(this.m_btnClose, "m_btnClose");
            this.m_btnClose.BackgroundImage = null;
            this.m_btnClose.Font = null;
            this.m_btnClose.Name = "m_btnClose";
            this.m_btnClose.UseVisualStyleBackColor = true;
            this.m_btnClose.Click += new System.EventHandler(this.m_btnClose_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AccessibleDescription = null;
            this.linkLabel1.AccessibleName = null;
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.Font = null;
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // m_tabFunction
            // 
            this.m_tabFunction.AccessibleDescription = null;
            this.m_tabFunction.AccessibleName = null;
            resources.ApplyResources(this.m_tabFunction, "m_tabFunction");
            this.m_tabFunction.BackgroundImage = null;
            this.m_tabFunction.Controls.Add(this.tabPage1);
            this.m_tabFunction.Controls.Add(this.tabPage2);
            this.m_tabFunction.Font = null;
            this.m_tabFunction.Multiline = true;
            this.m_tabFunction.Name = "m_tabFunction";
            this.m_tabFunction.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AccessibleDescription = null;
            this.tabPage1.AccessibleName = null;
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.BackgroundImage = null;
            this.tabPage1.Controls.Add(this.m_btnDelete);
            this.tabPage1.Controls.Add(this.m_btnAdd);
            this.tabPage1.Controls.Add(this.m_listNewPlurks);
            this.tabPage1.Font = null;
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // m_btnDelete
            // 
            this.m_btnDelete.AccessibleDescription = null;
            this.m_btnDelete.AccessibleName = null;
            resources.ApplyResources(this.m_btnDelete, "m_btnDelete");
            this.m_btnDelete.BackgroundImage = null;
            this.m_btnDelete.Font = null;
            this.m_btnDelete.Name = "m_btnDelete";
            this.m_btnDelete.UseVisualStyleBackColor = true;
            this.m_btnDelete.Click += new System.EventHandler(this.m_btnDelete_Click);
            // 
            // m_btnAdd
            // 
            this.m_btnAdd.AccessibleDescription = null;
            this.m_btnAdd.AccessibleName = null;
            resources.ApplyResources(this.m_btnAdd, "m_btnAdd");
            this.m_btnAdd.BackgroundImage = null;
            this.m_btnAdd.Font = null;
            this.m_btnAdd.Name = "m_btnAdd";
            this.m_btnAdd.UseVisualStyleBackColor = true;
            this.m_btnAdd.Click += new System.EventHandler(this.m_btnAdd_Click);
            // 
            // m_listNewPlurks
            // 
            this.m_listNewPlurks.AccessibleDescription = null;
            this.m_listNewPlurks.AccessibleName = null;
            resources.ApplyResources(this.m_listNewPlurks, "m_listNewPlurks");
            this.m_listNewPlurks.BackColor = System.Drawing.SystemColors.Window;
            this.m_listNewPlurks.BackgroundImage = null;
            this.m_listNewPlurks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPostTime,
            this.colComment,
            this.colLimitTo,
            this.colLanguage,
            this.colQualifier,
            this.colContent});
            this.m_listNewPlurks.Font = null;
            this.m_listNewPlurks.GridLines = true;
            this.m_listNewPlurks.Name = "m_listNewPlurks";
            this.m_listNewPlurks.UseCompatibleStateImageBehavior = false;
            this.m_listNewPlurks.View = System.Windows.Forms.View.Details;
            this.m_listNewPlurks.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.m_listNewPlurks_ItemSelectionChanged);
            // 
            // colPostTime
            // 
            resources.ApplyResources(this.colPostTime, "colPostTime");
            // 
            // colComment
            // 
            resources.ApplyResources(this.colComment, "colComment");
            // 
            // colLimitTo
            // 
            resources.ApplyResources(this.colLimitTo, "colLimitTo");
            // 
            // colLanguage
            // 
            resources.ApplyResources(this.colLanguage, "colLanguage");
            // 
            // colQualifier
            // 
            resources.ApplyResources(this.colQualifier, "colQualifier");
            // 
            // colContent
            // 
            resources.ApplyResources(this.colContent, "colContent");
            // 
            // tabPage2
            // 
            this.tabPage2.AccessibleDescription = null;
            this.tabPage2.AccessibleName = null;
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.BackgroundImage = null;
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.m_textMinutesComment);
            this.tabPage2.Controls.Add(this.m_textHoursComment);
            this.tabPage2.Controls.Add(this.m_textCommentContent);
            this.tabPage2.Controls.Add(this.m_cbAutoComment);
            this.tabPage2.Controls.Add(this.m_comboUid);
            this.tabPage2.Controls.Add(this.m_dtpDateTo);
            this.tabPage2.Controls.Add(this.m_dtpDateFrom);
            this.tabPage2.Controls.Add(this.m_listMessages);
            this.tabPage2.Controls.Add(this.m_btnFetchList);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Font = null;
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AccessibleDescription = null;
            this.label11.AccessibleName = null;
            resources.ApplyResources(this.label11, "label11");
            this.label11.Font = null;
            this.label11.Name = "label11";
            // 
            // label10
            // 
            this.label10.AccessibleDescription = null;
            this.label10.AccessibleName = null;
            resources.ApplyResources(this.label10, "label10");
            this.label10.Font = null;
            this.label10.Name = "label10";
            // 
            // m_textMinutesComment
            // 
            this.m_textMinutesComment.AccessibleDescription = null;
            this.m_textMinutesComment.AccessibleName = null;
            resources.ApplyResources(this.m_textMinutesComment, "m_textMinutesComment");
            this.m_textMinutesComment.BackgroundImage = null;
            this.m_textMinutesComment.Font = null;
            this.m_textMinutesComment.Name = "m_textMinutesComment";
            // 
            // m_textHoursComment
            // 
            this.m_textHoursComment.AccessibleDescription = null;
            this.m_textHoursComment.AccessibleName = null;
            resources.ApplyResources(this.m_textHoursComment, "m_textHoursComment");
            this.m_textHoursComment.BackgroundImage = null;
            this.m_textHoursComment.Font = null;
            this.m_textHoursComment.Name = "m_textHoursComment";
            // 
            // m_textCommentContent
            // 
            this.m_textCommentContent.AccessibleDescription = null;
            this.m_textCommentContent.AccessibleName = null;
            resources.ApplyResources(this.m_textCommentContent, "m_textCommentContent");
            this.m_textCommentContent.BackgroundImage = null;
            this.m_textCommentContent.Font = null;
            this.m_textCommentContent.Name = "m_textCommentContent";
            // 
            // m_cbAutoComment
            // 
            this.m_cbAutoComment.AccessibleDescription = null;
            this.m_cbAutoComment.AccessibleName = null;
            resources.ApplyResources(this.m_cbAutoComment, "m_cbAutoComment");
            this.m_cbAutoComment.BackgroundImage = null;
            this.m_cbAutoComment.Font = null;
            this.m_cbAutoComment.Name = "m_cbAutoComment";
            this.m_cbAutoComment.UseVisualStyleBackColor = true;
            // 
            // m_comboUid
            // 
            this.m_comboUid.AccessibleDescription = null;
            this.m_comboUid.AccessibleName = null;
            resources.ApplyResources(this.m_comboUid, "m_comboUid");
            this.m_comboUid.BackgroundImage = null;
            this.m_comboUid.Font = null;
            this.m_comboUid.FormattingEnabled = true;
            this.m_comboUid.Name = "m_comboUid";
            // 
            // m_dtpDateTo
            // 
            this.m_dtpDateTo.AccessibleDescription = null;
            this.m_dtpDateTo.AccessibleName = null;
            resources.ApplyResources(this.m_dtpDateTo, "m_dtpDateTo");
            this.m_dtpDateTo.BackgroundImage = null;
            this.m_dtpDateTo.CalendarFont = null;
            this.m_dtpDateTo.CustomFormat = null;
            this.m_dtpDateTo.Font = null;
            this.m_dtpDateTo.Name = "m_dtpDateTo";
            // 
            // m_dtpDateFrom
            // 
            this.m_dtpDateFrom.AccessibleDescription = null;
            this.m_dtpDateFrom.AccessibleName = null;
            resources.ApplyResources(this.m_dtpDateFrom, "m_dtpDateFrom");
            this.m_dtpDateFrom.BackgroundImage = null;
            this.m_dtpDateFrom.CalendarFont = null;
            this.m_dtpDateFrom.CustomFormat = null;
            this.m_dtpDateFrom.Font = null;
            this.m_dtpDateFrom.Name = "m_dtpDateFrom";
            // 
            // m_listMessages
            // 
            this.m_listMessages.AccessibleDescription = null;
            this.m_listMessages.AccessibleName = null;
            resources.ApplyResources(this.m_listMessages, "m_listMessages");
            this.m_listMessages.BackgroundImage = null;
            this.m_listMessages.Font = null;
            this.m_listMessages.FormattingEnabled = true;
            this.m_listMessages.Name = "m_listMessages";
            // 
            // m_btnFetchList
            // 
            this.m_btnFetchList.AccessibleDescription = null;
            this.m_btnFetchList.AccessibleName = null;
            resources.ApplyResources(this.m_btnFetchList, "m_btnFetchList");
            this.m_btnFetchList.BackgroundImage = null;
            this.m_btnFetchList.Font = null;
            this.m_btnFetchList.Name = "m_btnFetchList";
            this.m_btnFetchList.UseVisualStyleBackColor = true;
            this.m_btnFetchList.Click += new System.EventHandler(this.m_btnFetchList_Click);
            // 
            // label9
            // 
            this.label9.AccessibleDescription = null;
            this.label9.AccessibleName = null;
            resources.ApplyResources(this.label9, "label9");
            this.label9.Font = null;
            this.label9.Name = "label9";
            // 
            // label8
            // 
            this.label8.AccessibleDescription = null;
            this.label8.AccessibleName = null;
            resources.ApplyResources(this.label8, "label8");
            this.label8.Font = null;
            this.label8.Name = "label8";
            // 
            // label7
            // 
            this.label7.AccessibleDescription = null;
            this.label7.AccessibleName = null;
            resources.ApplyResources(this.label7, "label7");
            this.label7.Font = null;
            this.label7.Name = "label7";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AccessibleDescription = null;
            this.flowLayoutPanel1.AccessibleName = null;
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.BackgroundImage = null;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.m_textUsername);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.m_textPassword);
            this.flowLayoutPanel1.Controls.Add(this.m_btnLoadFriends);
            this.flowLayoutPanel1.Font = null;
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(500, 33);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // Form1
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = null;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.m_tabFunction);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.m_btnClose);
            this.Controls.Add(this.m_btnAction);
            this.Controls.Add(this.groupBox1);
            this.Font = null;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.m_tabFunction.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NotifyIcon m_notifyIcon;
        private System.Windows.Forms.TextBox m_textUsername;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox m_textOutput;
        private System.Windows.Forms.TextBox m_textPassword;
        private System.Windows.Forms.Button m_btnLoadFriends;
        private System.Windows.Forms.Button m_btnAction;
        private System.Windows.Forms.Button m_btnClose;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TabControl m_tabFunction;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button m_btnFetchList;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox m_listMessages;
        private System.Windows.Forms.DateTimePicker m_dtpDateTo;
        private System.Windows.Forms.DateTimePicker m_dtpDateFrom;
        private System.Windows.Forms.ComboBox m_comboUid;
        private System.Windows.Forms.TextBox m_textHoursComment;
        private System.Windows.Forms.TextBox m_textCommentContent;
        private System.Windows.Forms.CheckBox m_cbAutoComment;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox m_textMinutesComment;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ListView m_listNewPlurks;
        private System.Windows.Forms.ColumnHeader colPostTime;
        private System.Windows.Forms.ColumnHeader colComment;
        private System.Windows.Forms.ColumnHeader colLimitTo;
        private System.Windows.Forms.ColumnHeader colContent;
        private System.Windows.Forms.ColumnHeader colLanguage;
        private System.Windows.Forms.ColumnHeader colQualifier;
        private System.Windows.Forms.Button m_btnAdd;
        private System.Windows.Forms.Button m_btnDelete;
    }
}

