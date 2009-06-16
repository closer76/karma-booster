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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.m_cbScheduling = new System.Windows.Forms.CheckBox();
            this.m_notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.m_textUsername = new System.Windows.Forms.TextBox();
            this.m_textContent = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.m_textOutput = new System.Windows.Forms.TextBox();
            this.m_textPassword = new System.Windows.Forms.TextBox();
            this.m_chklstFriendList = new System.Windows.Forms.CheckedListBox();
            this.m_btnLoadFriends = new System.Windows.Forms.Button();
            this.m_textHour = new System.Windows.Forms.TextBox();
            this.m_textMinute = new System.Windows.Forms.TextBox();
            this.m_textSecond = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.m_labelSecond = new System.Windows.Forms.Label();
            this.m_btnAction = new System.Windows.Forms.Button();
            this.m_btnClose = new System.Windows.Forms.Button();
            this.m_cbAllowComments = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.m_tabFunction = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colPostTime = new System.Windows.Forms.ColumnHeader();
            this.colComment = new System.Windows.Forms.ColumnHeader();
            this.colLimitTo = new System.Windows.Forms.ColumnHeader();
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
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Limit-to:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Content:";
            // 
            // m_cbScheduling
            // 
            this.m_cbScheduling.AutoSize = true;
            this.m_cbScheduling.Location = new System.Drawing.Point(6, 153);
            this.m_cbScheduling.Name = "m_cbScheduling";
            this.m_cbScheduling.Size = new System.Drawing.Size(113, 16);
            this.m_cbScheduling.TabIndex = 11;
            this.m_cbScheduling.Text = "Post message every";
            this.m_cbScheduling.UseVisualStyleBackColor = true;
            this.m_cbScheduling.CheckedChanged += new System.EventHandler(this.m_cbScheduling_CheckedChanged);
            // 
            // m_notifyIcon
            // 
            this.m_notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("m_notifyIcon.Icon")));
            this.m_notifyIcon.Text = "Karma Booster";
            this.m_notifyIcon.Visible = true;
            this.m_notifyIcon.DoubleClick += new System.EventHandler(this.m_notifyIcon_DoubleClick);
            // 
            // m_textUsername
            // 
            this.m_textUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_textUsername.Location = new System.Drawing.Point(63, 3);
            this.m_textUsername.Name = "m_textUsername";
            this.m_textUsername.Size = new System.Drawing.Size(124, 22);
            this.m_textUsername.TabIndex = 6;
            // 
            // m_textContent
            // 
            this.m_textContent.Location = new System.Drawing.Point(6, 24);
            this.m_textContent.Multiline = true;
            this.m_textContent.Name = "m_textContent";
            this.m_textContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.m_textContent.Size = new System.Drawing.Size(174, 123);
            this.m_textContent.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_textOutput);
            this.groupBox1.Location = new System.Drawing.Point(12, 419);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 71);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log window";
            // 
            // m_textOutput
            // 
            this.m_textOutput.BackColor = System.Drawing.SystemColors.Window;
            this.m_textOutput.Location = new System.Drawing.Point(6, 21);
            this.m_textOutput.Multiline = true;
            this.m_textOutput.Name = "m_textOutput";
            this.m_textOutput.ReadOnly = true;
            this.m_textOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.m_textOutput.Size = new System.Drawing.Size(376, 44);
            this.m_textOutput.TabIndex = 15;
            // 
            // m_textPassword
            // 
            this.m_textPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_textPassword.Location = new System.Drawing.Point(250, 4);
            this.m_textPassword.Name = "m_textPassword";
            this.m_textPassword.Size = new System.Drawing.Size(124, 22);
            this.m_textPassword.TabIndex = 7;
            this.m_textPassword.UseSystemPasswordChar = true;
            // 
            // m_chklstFriendList
            // 
            this.m_chklstFriendList.CheckOnClick = true;
            this.m_chklstFriendList.FormattingEnabled = true;
            this.m_chklstFriendList.HorizontalScrollbar = true;
            this.m_chklstFriendList.Items.AddRange(new object[] {
            "6037 (karma_trends)"});
            this.m_chklstFriendList.Location = new System.Drawing.Point(190, 24);
            this.m_chklstFriendList.Name = "m_chklstFriendList";
            this.m_chklstFriendList.Size = new System.Drawing.Size(184, 123);
            this.m_chklstFriendList.TabIndex = 8;
            // 
            // m_btnLoadFriends
            // 
            this.m_btnLoadFriends.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_btnLoadFriends.Location = new System.Drawing.Point(380, 3);
            this.m_btnLoadFriends.Name = "m_btnLoadFriends";
            this.m_btnLoadFriends.Size = new System.Drawing.Size(112, 24);
            this.m_btnLoadFriends.TabIndex = 9;
            this.m_btnLoadFriends.Text = "Load friend list";
            this.m_btnLoadFriends.UseVisualStyleBackColor = true;
            this.m_btnLoadFriends.Click += new System.EventHandler(this.m_btnLoadFriends_Click);
            // 
            // m_textHour
            // 
            this.m_textHour.Enabled = false;
            this.m_textHour.Location = new System.Drawing.Point(125, 151);
            this.m_textHour.Name = "m_textHour";
            this.m_textHour.Size = new System.Drawing.Size(23, 22);
            this.m_textHour.TabIndex = 12;
            this.m_textHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // m_textMinute
            // 
            this.m_textMinute.Enabled = false;
            this.m_textMinute.Location = new System.Drawing.Point(199, 151);
            this.m_textMinute.Name = "m_textMinute";
            this.m_textMinute.Size = new System.Drawing.Size(25, 22);
            this.m_textMinute.TabIndex = 13;
            this.m_textMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // m_textSecond
            // 
            this.m_textSecond.Enabled = false;
            this.m_textSecond.Location = new System.Drawing.Point(288, 151);
            this.m_textSecond.Name = "m_textSecond";
            this.m_textSecond.Size = new System.Drawing.Size(25, 22);
            this.m_textSecond.TabIndex = 14;
            this.m_textSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "hour(s)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "minute(s)";
            // 
            // m_labelSecond
            // 
            this.m_labelSecond.AutoSize = true;
            this.m_labelSecond.Location = new System.Drawing.Point(319, 154);
            this.m_labelSecond.Name = "m_labelSecond";
            this.m_labelSecond.Size = new System.Drawing.Size(49, 12);
            this.m_labelSecond.TabIndex = 17;
            this.m_labelSecond.Text = "second(s)";
            // 
            // m_btnAction
            // 
            this.m_btnAction.Location = new System.Drawing.Point(68, 384);
            this.m_btnAction.Name = "m_btnAction";
            this.m_btnAction.Size = new System.Drawing.Size(94, 29);
            this.m_btnAction.TabIndex = 18;
            this.m_btnAction.Text = "Go";
            this.m_btnAction.UseVisualStyleBackColor = true;
            this.m_btnAction.Click += new System.EventHandler(this.m_btnAction_Click);
            // 
            // m_btnClose
            // 
            this.m_btnClose.Location = new System.Drawing.Point(250, 384);
            this.m_btnClose.Name = "m_btnClose";
            this.m_btnClose.Size = new System.Drawing.Size(94, 29);
            this.m_btnClose.TabIndex = 19;
            this.m_btnClose.Text = "Close";
            this.m_btnClose.UseVisualStyleBackColor = true;
            this.m_btnClose.Click += new System.EventHandler(this.m_btnClose_Click);
            // 
            // m_cbAllowComments
            // 
            this.m_cbAllowComments.AutoSize = true;
            this.m_cbAllowComments.Checked = true;
            this.m_cbAllowComments.CheckState = System.Windows.Forms.CheckState.Checked;
            this.m_cbAllowComments.Location = new System.Drawing.Point(6, 175);
            this.m_cbAllowComments.Name = "m_cbAllowComments";
            this.m_cbAllowComments.Size = new System.Drawing.Size(102, 16);
            this.m_cbAllowComments.TabIndex = 20;
            this.m_cbAllowComments.Text = "Allow comments";
            this.m_cbAllowComments.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(10, 493);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(116, 12);
            this.linkLabel1.TabIndex = 21;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "About Karma Booster...";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // m_tabFunction
            // 
            this.m_tabFunction.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.m_tabFunction.Controls.Add(this.tabPage1);
            this.m_tabFunction.Controls.Add(this.tabPage2);
            this.m_tabFunction.Location = new System.Drawing.Point(12, 57);
            this.m_tabFunction.Multiline = true;
            this.m_tabFunction.Name = "m_tabFunction";
            this.m_tabFunction.SelectedIndex = 0;
            this.m_tabFunction.Size = new System.Drawing.Size(476, 321);
            this.m_tabFunction.TabIndex = 22;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Controls.Add(this.m_chklstFriendList);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.m_cbAllowComments);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.m_textContent);
            this.tabPage1.Controls.Add(this.m_cbScheduling);
            this.tabPage1.Controls.Add(this.m_labelSecond);
            this.tabPage1.Controls.Add(this.m_textHour);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.m_textMinute);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.m_textSecond);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(468, 293);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Plurk";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Window;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPostTime,
            this.colComment,
            this.colLimitTo,
            this.colContent});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(8, 197);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(367, 89);
            this.listView1.TabIndex = 21;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colPostTime
            // 
            this.colPostTime.Text = "PostTime";
            // 
            // colComment
            // 
            this.colComment.Text = "Comment?";
            this.colComment.Width = 68;
            // 
            // colLimitTo
            // 
            this.colLimitTo.Text = "Limit To";
            // 
            // colContent
            // 
            this.colContent.Text = "Plurk Content";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
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
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(380, 293);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Comment on Plurk";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(257, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 12);
            this.label11.TabIndex = 13;
            this.label11.Text = "minute(s)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(172, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 12);
            this.label10.TabIndex = 12;
            this.label10.Text = "hour(s)";
            // 
            // m_textMinutesComment
            // 
            this.m_textMinutesComment.Location = new System.Drawing.Point(217, 129);
            this.m_textMinutesComment.Name = "m_textMinutesComment";
            this.m_textMinutesComment.Size = new System.Drawing.Size(34, 22);
            this.m_textMinutesComment.TabIndex = 11;
            // 
            // m_textHoursComment
            // 
            this.m_textHoursComment.Location = new System.Drawing.Point(132, 129);
            this.m_textHoursComment.Name = "m_textHoursComment";
            this.m_textHoursComment.Size = new System.Drawing.Size(33, 22);
            this.m_textHoursComment.TabIndex = 10;
            // 
            // m_textCommentContent
            // 
            this.m_textCommentContent.Location = new System.Drawing.Point(6, 164);
            this.m_textCommentContent.Multiline = true;
            this.m_textCommentContent.Name = "m_textCommentContent";
            this.m_textCommentContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.m_textCommentContent.Size = new System.Drawing.Size(368, 69);
            this.m_textCommentContent.TabIndex = 9;
            // 
            // m_cbAutoComment
            // 
            this.m_cbAutoComment.AutoSize = true;
            this.m_cbAutoComment.Location = new System.Drawing.Point(6, 135);
            this.m_cbAutoComment.Name = "m_cbAutoComment";
            this.m_cbAutoComment.Size = new System.Drawing.Size(122, 16);
            this.m_cbAutoComment.TabIndex = 8;
            this.m_cbAutoComment.Text = "Auto comment every";
            this.m_cbAutoComment.UseVisualStyleBackColor = true;
            // 
            // m_comboUid
            // 
            this.m_comboUid.FormattingEnabled = true;
            this.m_comboUid.Location = new System.Drawing.Point(54, 8);
            this.m_comboUid.Name = "m_comboUid";
            this.m_comboUid.Size = new System.Drawing.Size(111, 20);
            this.m_comboUid.TabIndex = 7;
            // 
            // m_dtpDateTo
            // 
            this.m_dtpDateTo.Location = new System.Drawing.Point(53, 64);
            this.m_dtpDateTo.Name = "m_dtpDateTo";
            this.m_dtpDateTo.Size = new System.Drawing.Size(112, 22);
            this.m_dtpDateTo.TabIndex = 6;
            // 
            // m_dtpDateFrom
            // 
            this.m_dtpDateFrom.Location = new System.Drawing.Point(53, 36);
            this.m_dtpDateFrom.Name = "m_dtpDateFrom";
            this.m_dtpDateFrom.Size = new System.Drawing.Size(112, 22);
            this.m_dtpDateFrom.TabIndex = 5;
            // 
            // m_listMessages
            // 
            this.m_listMessages.FormattingEnabled = true;
            this.m_listMessages.HorizontalScrollbar = true;
            this.m_listMessages.ItemHeight = 12;
            this.m_listMessages.Location = new System.Drawing.Point(174, 8);
            this.m_listMessages.Name = "m_listMessages";
            this.m_listMessages.ScrollAlwaysVisible = true;
            this.m_listMessages.Size = new System.Drawing.Size(200, 112);
            this.m_listMessages.TabIndex = 4;
            // 
            // m_btnFetchList
            // 
            this.m_btnFetchList.Location = new System.Drawing.Point(72, 92);
            this.m_btnFetchList.Name = "m_btnFetchList";
            this.m_btnFetchList.Size = new System.Drawing.Size(74, 27);
            this.m_btnFetchList.TabIndex = 3;
            this.m_btnFetchList.Text = "Fetch list";
            this.m_btnFetchList.UseVisualStyleBackColor = true;
            this.m_btnFetchList.Click += new System.EventHandler(this.m_btnFetchList_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "To:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "From:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "User ID:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.m_textUsername);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.m_textPassword);
            this.flowLayoutPanel1.Controls.Add(this.m_btnLoadFriends);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(500, 30);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(500, 30);
            this.flowLayoutPanel1.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(500, 538);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.m_tabFunction);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.m_btnClose);
            this.Controls.Add(this.m_btnAction);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(508, 565);
            this.Name = "Form1";
            this.Text = "Karma Booster";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.m_tabFunction.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox m_cbScheduling;
        private System.Windows.Forms.NotifyIcon m_notifyIcon;
        private System.Windows.Forms.TextBox m_textUsername;
        private System.Windows.Forms.TextBox m_textContent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox m_textOutput;
        private System.Windows.Forms.TextBox m_textPassword;
        private System.Windows.Forms.CheckedListBox m_chklstFriendList;
        private System.Windows.Forms.Button m_btnLoadFriends;
        private System.Windows.Forms.TextBox m_textHour;
        private System.Windows.Forms.TextBox m_textMinute;
        private System.Windows.Forms.TextBox m_textSecond;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label m_labelSecond;
        private System.Windows.Forms.Button m_btnAction;
        private System.Windows.Forms.Button m_btnClose;
        private System.Windows.Forms.CheckBox m_cbAllowComments;
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
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colPostTime;
        private System.Windows.Forms.ColumnHeader colComment;
        private System.Windows.Forms.ColumnHeader colLimitTo;
        private System.Windows.Forms.ColumnHeader colContent;
    }
}

