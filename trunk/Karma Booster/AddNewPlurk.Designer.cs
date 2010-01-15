/*  
 * AddNewPlurk.Designer.cs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewPlurk));
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
            this.m_cbLanguage.AccessibleDescription = null;
            this.m_cbLanguage.AccessibleName = null;
            resources.ApplyResources(this.m_cbLanguage, "m_cbLanguage");
            this.m_cbLanguage.BackgroundImage = null;
            this.m_cbLanguage.Font = null;
            this.m_cbLanguage.FormattingEnabled = true;
            this.m_cbLanguage.Name = "m_cbLanguage";
            // 
            // m_cbQualifier
            // 
            this.m_cbQualifier.AccessibleDescription = null;
            this.m_cbQualifier.AccessibleName = null;
            resources.ApplyResources(this.m_cbQualifier, "m_cbQualifier");
            this.m_cbQualifier.BackgroundImage = null;
            this.m_cbQualifier.Font = null;
            this.m_cbQualifier.FormattingEnabled = true;
            this.m_cbQualifier.Name = "m_cbQualifier";
            // 
            // m_textContent
            // 
            this.m_textContent.AccessibleDescription = null;
            this.m_textContent.AccessibleName = null;
            resources.ApplyResources(this.m_textContent, "m_textContent");
            this.m_textContent.BackgroundImage = null;
            this.m_textContent.Font = null;
            this.m_textContent.Name = "m_textContent";
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleDescription = null;
            this.groupBox1.AccessibleName = null;
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.BackgroundImage = null;
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
            this.groupBox1.Font = null;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // m_rbImmediate
            // 
            this.m_rbImmediate.AccessibleDescription = null;
            this.m_rbImmediate.AccessibleName = null;
            resources.ApplyResources(this.m_rbImmediate, "m_rbImmediate");
            this.m_rbImmediate.BackgroundImage = null;
            this.m_rbImmediate.Font = null;
            this.m_rbImmediate.Name = "m_rbImmediate";
            this.m_rbImmediate.TabStop = true;
            this.m_rbImmediate.UseVisualStyleBackColor = true;
            // 
            // m_timePicker
            // 
            this.m_timePicker.AccessibleDescription = null;
            this.m_timePicker.AccessibleName = null;
            resources.ApplyResources(this.m_timePicker, "m_timePicker");
            this.m_timePicker.BackgroundImage = null;
            this.m_timePicker.CalendarFont = null;
            this.m_timePicker.Font = null;
            this.m_timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_timePicker.Name = "m_timePicker";
            this.m_timePicker.ShowUpDown = true;
            // 
            // label6
            // 
            this.label6.AccessibleDescription = null;
            this.label6.AccessibleName = null;
            resources.ApplyResources(this.label6, "label6");
            this.label6.Font = null;
            this.label6.Name = "label6";
            // 
            // label5
            // 
            this.label5.AccessibleDescription = null;
            this.label5.AccessibleName = null;
            resources.ApplyResources(this.label5, "label5");
            this.label5.Font = null;
            this.label5.Name = "label5";
            // 
            // label4
            // 
            this.label4.AccessibleDescription = null;
            this.label4.AccessibleName = null;
            resources.ApplyResources(this.label4, "label4");
            this.label4.Font = null;
            this.label4.Name = "label4";
            // 
            // m_textMinutes
            // 
            this.m_textMinutes.AccessibleDescription = null;
            this.m_textMinutes.AccessibleName = null;
            resources.ApplyResources(this.m_textMinutes, "m_textMinutes");
            this.m_textMinutes.BackgroundImage = null;
            this.m_textMinutes.Font = null;
            this.m_textMinutes.Name = "m_textMinutes";
            // 
            // m_textHours
            // 
            this.m_textHours.AccessibleDescription = null;
            this.m_textHours.AccessibleName = null;
            resources.ApplyResources(this.m_textHours, "m_textHours");
            this.m_textHours.BackgroundImage = null;
            this.m_textHours.Font = null;
            this.m_textHours.Name = "m_textHours";
            // 
            // m_datePicker
            // 
            this.m_datePicker.AccessibleDescription = null;
            this.m_datePicker.AccessibleName = null;
            resources.ApplyResources(this.m_datePicker, "m_datePicker");
            this.m_datePicker.BackgroundImage = null;
            this.m_datePicker.CalendarFont = null;
            this.m_datePicker.CustomFormat = null;
            this.m_datePicker.Font = null;
            this.m_datePicker.Name = "m_datePicker";
            // 
            // m_rbRepeat
            // 
            this.m_rbRepeat.AccessibleDescription = null;
            this.m_rbRepeat.AccessibleName = null;
            resources.ApplyResources(this.m_rbRepeat, "m_rbRepeat");
            this.m_rbRepeat.BackgroundImage = null;
            this.m_rbRepeat.Font = null;
            this.m_rbRepeat.Name = "m_rbRepeat";
            this.m_rbRepeat.TabStop = true;
            this.m_rbRepeat.UseVisualStyleBackColor = true;
            // 
            // m_rbOneTime
            // 
            this.m_rbOneTime.AccessibleDescription = null;
            this.m_rbOneTime.AccessibleName = null;
            resources.ApplyResources(this.m_rbOneTime, "m_rbOneTime");
            this.m_rbOneTime.BackgroundImage = null;
            this.m_rbOneTime.Font = null;
            this.m_rbOneTime.Name = "m_rbOneTime";
            this.m_rbOneTime.TabStop = true;
            this.m_rbOneTime.UseVisualStyleBackColor = true;
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
            // label3
            // 
            this.label3.AccessibleDescription = null;
            this.label3.AccessibleName = null;
            resources.ApplyResources(this.label3, "label3");
            this.label3.Font = null;
            this.label3.Name = "label3";
            // 
            // m_chkboxAllowComments
            // 
            this.m_chkboxAllowComments.AccessibleDescription = null;
            this.m_chkboxAllowComments.AccessibleName = null;
            resources.ApplyResources(this.m_chkboxAllowComments, "m_chkboxAllowComments");
            this.m_chkboxAllowComments.BackgroundImage = null;
            this.m_chkboxAllowComments.Font = null;
            this.m_chkboxAllowComments.Name = "m_chkboxAllowComments";
            this.m_chkboxAllowComments.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AccessibleDescription = null;
            this.label7.AccessibleName = null;
            resources.ApplyResources(this.label7, "label7");
            this.label7.Font = null;
            this.label7.Name = "label7";
            // 
            // m_btnAdd
            // 
            this.m_btnAdd.AccessibleDescription = null;
            this.m_btnAdd.AccessibleName = null;
            resources.ApplyResources(this.m_btnAdd, "m_btnAdd");
            this.m_btnAdd.BackgroundImage = null;
            this.m_btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.m_btnAdd.Font = null;
            this.m_btnAdd.Name = "m_btnAdd";
            this.m_btnAdd.UseVisualStyleBackColor = true;
            this.m_btnAdd.Click += new System.EventHandler(this.m_btnAdd_Click);
            // 
            // m_btnCancel
            // 
            this.m_btnCancel.AccessibleDescription = null;
            this.m_btnCancel.AccessibleName = null;
            resources.ApplyResources(this.m_btnCancel, "m_btnCancel");
            this.m_btnCancel.BackgroundImage = null;
            this.m_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m_btnCancel.Font = null;
            this.m_btnCancel.Name = "m_btnCancel";
            this.m_btnCancel.UseVisualStyleBackColor = true;
            // 
            // m_listviewLimitTo
            // 
            this.m_listviewLimitTo.AccessibleDescription = null;
            this.m_listviewLimitTo.AccessibleName = null;
            resources.ApplyResources(this.m_listviewLimitTo, "m_listviewLimitTo");
            this.m_listviewLimitTo.BackgroundImage = null;
            this.m_listviewLimitTo.CheckBoxes = true;
            this.m_listviewLimitTo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colUid,
            this.colNickName});
            this.m_listviewLimitTo.Font = null;
            this.m_listviewLimitTo.Name = "m_listviewLimitTo";
            this.m_listviewLimitTo.UseCompatibleStateImageBehavior = false;
            this.m_listviewLimitTo.View = System.Windows.Forms.View.Details;
            this.m_listviewLimitTo.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.m_listviewLimitTo_ColumnClick);
            // 
            // colUid
            // 
            resources.ApplyResources(this.colUid, "colUid");
            // 
            // colNickName
            // 
            resources.ApplyResources(this.colNickName, "colNickName");
            // 
            // AddNewPlurk
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
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
            this.Font = null;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = null;
            this.Name = "AddNewPlurk";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
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