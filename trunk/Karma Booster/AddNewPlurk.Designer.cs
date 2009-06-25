namespace KarmaBooster__Windows_Form_version_
{
    partial class AddNewPlurk
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
            this.m_cbLanguage = new System.Windows.Forms.ComboBox();
            this.m_cbQualifier = new System.Windows.Forms.ComboBox();
            this.m_textContent = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.m_rbImmediate = new System.Windows.Forms.RadioButton();
            this.m_timePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.m_textMinutes = new System.Windows.Forms.TextBox();
            this.m_textHours = new System.Windows.Forms.TextBox();
            this.m_datePicker = new System.Windows.Forms.DateTimePicker();
            this.m_rbRepeat = new System.Windows.Forms.RadioButton();
            this.m_rbOneTime = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.m_chkboxAllowComments = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.m_btnAdd = new System.Windows.Forms.Button();
            this.m_btnCancel = new System.Windows.Forms.Button();
            this.m_listviewLimitTo = new System.Windows.Forms.ListView();
            this.colUid = new System.Windows.Forms.ColumnHeader();
            this.colNickName = new System.Windows.Forms.ColumnHeader();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_cbLanguage
            // 
            this.m_cbLanguage.FormattingEnabled = true;
            this.m_cbLanguage.Location = new System.Drawing.Point(81, 20);
            this.m_cbLanguage.Name = "m_cbLanguage";
            this.m_cbLanguage.Size = new System.Drawing.Size(160, 20);
            this.m_cbLanguage.TabIndex = 0;
            // 
            // m_cbQualifier
            // 
            this.m_cbQualifier.FormattingEnabled = true;
            this.m_cbQualifier.Location = new System.Drawing.Point(81, 46);
            this.m_cbQualifier.Name = "m_cbQualifier";
            this.m_cbQualifier.Size = new System.Drawing.Size(160, 20);
            this.m_cbQualifier.TabIndex = 1;
            // 
            // m_textContent
            // 
            this.m_textContent.Location = new System.Drawing.Point(81, 72);
            this.m_textContent.Multiline = true;
            this.m_textContent.Name = "m_textContent";
            this.m_textContent.Size = new System.Drawing.Size(158, 123);
            this.m_textContent.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_rbImmediate);
            this.groupBox1.Controls.Add(this.m_timePicker);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.m_textMinutes);
            this.groupBox1.Controls.Add(this.m_textHours);
            this.groupBox1.Controls.Add(this.m_datePicker);
            this.groupBox1.Controls.Add(this.m_rbRepeat);
            this.groupBox1.Controls.Add(this.m_rbOneTime);
            this.groupBox1.Location = new System.Drawing.Point(12, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 147);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scheduling Options";
            // 
            // m_rbImmediate
            // 
            this.m_rbImmediate.AutoSize = true;
            this.m_rbImmediate.Location = new System.Drawing.Point(6, 115);
            this.m_rbImmediate.Name = "m_rbImmediate";
            this.m_rbImmediate.Size = new System.Drawing.Size(178, 16);
            this.m_rbImmediate.TabIndex = 11;
            this.m_rbImmediate.TabStop = true;
            this.m_rbImmediate.Text = "Post immediately (no scheduling)";
            this.m_rbImmediate.UseVisualStyleBackColor = true;
            // 
            // m_timePicker
            // 
            this.m_timePicker.CustomFormat = "HH:mm";
            this.m_timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_timePicker.Location = new System.Drawing.Point(156, 43);
            this.m_timePicker.Name = "m_timePicker";
            this.m_timePicker.ShowUpDown = true;
            this.m_timePicker.Size = new System.Drawing.Size(59, 22);
            this.m_timePicker.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "minute(s)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "hour(s)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Every";
            // 
            // m_textMinutes
            // 
            this.m_textMinutes.Location = new System.Drawing.Point(150, 87);
            this.m_textMinutes.Name = "m_textMinutes";
            this.m_textMinutes.Size = new System.Drawing.Size(50, 22);
            this.m_textMinutes.TabIndex = 4;
            // 
            // m_textHours
            // 
            this.m_textHours.Location = new System.Drawing.Point(57, 87);
            this.m_textHours.Name = "m_textHours";
            this.m_textHours.Size = new System.Drawing.Size(43, 22);
            this.m_textHours.TabIndex = 3;
            // 
            // m_datePicker
            // 
            this.m_datePicker.Location = new System.Drawing.Point(20, 43);
            this.m_datePicker.Name = "m_datePicker";
            this.m_datePicker.Size = new System.Drawing.Size(124, 22);
            this.m_datePicker.TabIndex = 2;
            // 
            // m_rbRepeat
            // 
            this.m_rbRepeat.AutoSize = true;
            this.m_rbRepeat.Location = new System.Drawing.Point(6, 71);
            this.m_rbRepeat.Name = "m_rbRepeat";
            this.m_rbRepeat.Size = new System.Drawing.Size(55, 16);
            this.m_rbRepeat.TabIndex = 1;
            this.m_rbRepeat.TabStop = true;
            this.m_rbRepeat.Text = "Repeat";
            this.m_rbRepeat.UseVisualStyleBackColor = true;
            // 
            // m_rbOneTime
            // 
            this.m_rbOneTime.AutoSize = true;
            this.m_rbOneTime.Location = new System.Drawing.Point(6, 21);
            this.m_rbOneTime.Name = "m_rbOneTime";
            this.m_rbOneTime.Size = new System.Drawing.Size(70, 16);
            this.m_rbOneTime.TabIndex = 0;
            this.m_rbOneTime.TabStop = true;
            this.m_rbOneTime.Text = "One-Time";
            this.m_rbOneTime.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lanuage:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Qualifier:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Content:";
            // 
            // m_chkboxAllowComments
            // 
            this.m_chkboxAllowComments.AutoSize = true;
            this.m_chkboxAllowComments.Location = new System.Drawing.Point(264, 22);
            this.m_chkboxAllowComments.Name = "m_chkboxAllowComments";
            this.m_chkboxAllowComments.Size = new System.Drawing.Size(105, 16);
            this.m_chkboxAllowComments.TabIndex = 7;
            this.m_chkboxAllowComments.Text = "Allow Comments";
            this.m_chkboxAllowComments.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(262, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "Private Message:";
            // 
            // m_btnAdd
            // 
            this.m_btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.m_btnAdd.Location = new System.Drawing.Point(102, 354);
            this.m_btnAdd.Name = "m_btnAdd";
            this.m_btnAdd.Size = new System.Drawing.Size(81, 28);
            this.m_btnAdd.TabIndex = 10;
            this.m_btnAdd.Text = "Add";
            this.m_btnAdd.UseVisualStyleBackColor = true;
            this.m_btnAdd.Click += new System.EventHandler(this.m_btnAdd_Click);
            // 
            // m_btnCancel
            // 
            this.m_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m_btnCancel.Location = new System.Drawing.Point(263, 354);
            this.m_btnCancel.Name = "m_btnCancel";
            this.m_btnCancel.Size = new System.Drawing.Size(81, 28);
            this.m_btnCancel.TabIndex = 11;
            this.m_btnCancel.Text = "Cancel";
            this.m_btnCancel.UseVisualStyleBackColor = true;
            // 
            // m_listviewLimitTo
            // 
            this.m_listviewLimitTo.CheckBoxes = true;
            this.m_listviewLimitTo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colUid,
            this.colNickName});
            this.m_listviewLimitTo.Location = new System.Drawing.Point(283, 72);
            this.m_listviewLimitTo.Name = "m_listviewLimitTo";
            this.m_listviewLimitTo.Size = new System.Drawing.Size(188, 276);
            this.m_listviewLimitTo.TabIndex = 12;
            this.m_listviewLimitTo.UseCompatibleStateImageBehavior = false;
            this.m_listviewLimitTo.View = System.Windows.Forms.View.Details;
            this.m_listviewLimitTo.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.m_listviewLimitTo_ColumnClick);
            // 
            // colUid
            // 
            this.colUid.Text = "UID";
            this.colUid.Width = 79;
            // 
            // colNickName
            // 
            this.colNickName.Text = "Nick Name";
            this.colNickName.Width = 96;
            // 
            // AddNewPlurk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 391);
            this.ControlBox = false;
            this.Controls.Add(this.m_listviewLimitTo);
            this.Controls.Add(this.m_btnCancel);
            this.Controls.Add(this.m_btnAdd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.m_chkboxAllowComments);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.m_textContent);
            this.Controls.Add(this.m_cbQualifier);
            this.Controls.Add(this.m_cbLanguage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddNewPlurk";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Add New Plurk....";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox m_cbLanguage;
        private System.Windows.Forms.ComboBox m_cbQualifier;
        private System.Windows.Forms.TextBox m_textContent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox m_textMinutes;
        private System.Windows.Forms.TextBox m_textHours;
        private System.Windows.Forms.DateTimePicker m_datePicker;
        private System.Windows.Forms.RadioButton m_rbRepeat;
        private System.Windows.Forms.RadioButton m_rbOneTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox m_chkboxAllowComments;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button m_btnAdd;
        private System.Windows.Forms.Button m_btnCancel;
        private System.Windows.Forms.DateTimePicker m_timePicker;
        private System.Windows.Forms.RadioButton m_rbImmediate;
        private System.Windows.Forms.ListView m_listviewLimitTo;
        private System.Windows.Forms.ColumnHeader colUid;
        private System.Windows.Forms.ColumnHeader colNickName;
    }
}