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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Limit-to:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Content:";
            // 
            // m_cbScheduling
            // 
            this.m_cbScheduling.AutoSize = true;
            this.m_cbScheduling.Location = new System.Drawing.Point(12, 247);
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
            this.m_textUsername.Location = new System.Drawing.Point(18, 34);
            this.m_textUsername.Name = "m_textUsername";
            this.m_textUsername.Size = new System.Drawing.Size(174, 22);
            this.m_textUsername.TabIndex = 6;
            // 
            // m_textContent
            // 
            this.m_textContent.Location = new System.Drawing.Point(18, 170);
            this.m_textContent.Multiline = true;
            this.m_textContent.Name = "m_textContent";
            this.m_textContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.m_textContent.Size = new System.Drawing.Size(376, 65);
            this.m_textContent.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_textOutput);
            this.groupBox1.Location = new System.Drawing.Point(12, 291);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 125);
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
            this.m_textOutput.Size = new System.Drawing.Size(376, 98);
            this.m_textOutput.TabIndex = 15;
            // 
            // m_textPassword
            // 
            this.m_textPassword.Location = new System.Drawing.Point(18, 81);
            this.m_textPassword.Name = "m_textPassword";
            this.m_textPassword.Size = new System.Drawing.Size(174, 22);
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
            this.m_chklstFriendList.Location = new System.Drawing.Point(206, 34);
            this.m_chklstFriendList.Name = "m_chklstFriendList";
            this.m_chklstFriendList.Size = new System.Drawing.Size(188, 123);
            this.m_chklstFriendList.TabIndex = 8;
            // 
            // m_btnLoadFriends
            // 
            this.m_btnLoadFriends.Location = new System.Drawing.Point(45, 119);
            this.m_btnLoadFriends.Name = "m_btnLoadFriends";
            this.m_btnLoadFriends.Size = new System.Drawing.Size(121, 24);
            this.m_btnLoadFriends.TabIndex = 9;
            this.m_btnLoadFriends.Text = "Load friend list";
            this.m_btnLoadFriends.UseVisualStyleBackColor = true;
            this.m_btnLoadFriends.Click += new System.EventHandler(this.m_btnLoadFriends_Click);
            // 
            // m_textHour
            // 
            this.m_textHour.Enabled = false;
            this.m_textHour.Location = new System.Drawing.Point(131, 245);
            this.m_textHour.Name = "m_textHour";
            this.m_textHour.Size = new System.Drawing.Size(33, 22);
            this.m_textHour.TabIndex = 12;
            this.m_textHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // m_textMinute
            // 
            this.m_textMinute.Enabled = false;
            this.m_textMinute.Location = new System.Drawing.Point(216, 245);
            this.m_textMinute.Name = "m_textMinute";
            this.m_textMinute.Size = new System.Drawing.Size(34, 22);
            this.m_textMinute.TabIndex = 13;
            this.m_textMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // m_textSecond
            // 
            this.m_textSecond.Enabled = false;
            this.m_textSecond.Location = new System.Drawing.Point(311, 245);
            this.m_textSecond.Name = "m_textSecond";
            this.m_textSecond.Size = new System.Drawing.Size(34, 22);
            this.m_textSecond.TabIndex = 14;
            this.m_textSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "hour(s)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "minute(s)";
            // 
            // m_labelSecond
            // 
            this.m_labelSecond.AutoSize = true;
            this.m_labelSecond.Location = new System.Drawing.Point(351, 248);
            this.m_labelSecond.Name = "m_labelSecond";
            this.m_labelSecond.Size = new System.Drawing.Size(49, 12);
            this.m_labelSecond.TabIndex = 17;
            this.m_labelSecond.Text = "second(s)";
            // 
            // m_btnAction
            // 
            this.m_btnAction.Location = new System.Drawing.Point(70, 428);
            this.m_btnAction.Name = "m_btnAction";
            this.m_btnAction.Size = new System.Drawing.Size(94, 29);
            this.m_btnAction.TabIndex = 18;
            this.m_btnAction.Text = "Go";
            this.m_btnAction.UseVisualStyleBackColor = true;
            this.m_btnAction.Click += new System.EventHandler(this.m_btnAction_Click);
            // 
            // m_btnClose
            // 
            this.m_btnClose.Location = new System.Drawing.Point(251, 428);
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
            this.m_cbAllowComments.Location = new System.Drawing.Point(12, 269);
            this.m_cbAllowComments.Name = "m_cbAllowComments";
            this.m_cbAllowComments.Size = new System.Drawing.Size(102, 16);
            this.m_cbAllowComments.TabIndex = 20;
            this.m_cbAllowComments.Text = "Allow comments";
            this.m_cbAllowComments.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(414, 475);
            this.Controls.Add(this.m_cbAllowComments);
            this.Controls.Add(this.m_btnClose);
            this.Controls.Add(this.m_btnAction);
            this.Controls.Add(this.m_labelSecond);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.m_textSecond);
            this.Controls.Add(this.m_textMinute);
            this.Controls.Add(this.m_textHour);
            this.Controls.Add(this.m_btnLoadFriends);
            this.Controls.Add(this.m_chklstFriendList);
            this.Controls.Add(this.m_textPassword);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.m_textContent);
            this.Controls.Add(this.m_textUsername);
            this.Controls.Add(this.m_cbScheduling);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Karma Booster";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}

