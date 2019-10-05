namespace StudentManagement.UserControls
{
    partial class EditStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.groupBox_sex = new System.Windows.Forms.GroupBox();
            this.radioButton_man = new System.Windows.Forms.RadioButton();
            this.radioButton_woman = new System.Windows.Forms.RadioButton();
            this.dateTimePicker_birthday = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox_sex.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(192, 323);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.Btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(277, 323);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "姓名：";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(50, 13);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(154, 21);
            this.txt_name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "年龄：";
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(50, 60);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(154, 21);
            this.txt_age.TabIndex = 5;
            // 
            // groupBox_sex
            // 
            this.groupBox_sex.Controls.Add(this.radioButton_woman);
            this.groupBox_sex.Controls.Add(this.radioButton_man);
            this.groupBox_sex.Location = new System.Drawing.Point(16, 105);
            this.groupBox_sex.Name = "groupBox_sex";
            this.groupBox_sex.Size = new System.Drawing.Size(120, 54);
            this.groupBox_sex.TabIndex = 6;
            this.groupBox_sex.TabStop = false;
            this.groupBox_sex.Text = "性别";
            // 
            // radioButton_man
            // 
            this.radioButton_man.AutoSize = true;
            this.radioButton_man.Location = new System.Drawing.Point(7, 21);
            this.radioButton_man.Name = "radioButton_man";
            this.radioButton_man.Size = new System.Drawing.Size(35, 16);
            this.radioButton_man.TabIndex = 0;
            this.radioButton_man.TabStop = true;
            this.radioButton_man.Text = "男";
            this.radioButton_man.UseVisualStyleBackColor = true;
            // 
            // radioButton_woman
            // 
            this.radioButton_woman.AutoSize = true;
            this.radioButton_woman.Location = new System.Drawing.Point(65, 21);
            this.radioButton_woman.Name = "radioButton_woman";
            this.radioButton_woman.Size = new System.Drawing.Size(35, 16);
            this.radioButton_woman.TabIndex = 1;
            this.radioButton_woman.TabStop = true;
            this.radioButton_woman.Text = "女";
            this.radioButton_woman.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_birthday
            // 
            this.dateTimePicker_birthday.Location = new System.Drawing.Point(50, 182);
            this.dateTimePicker_birthday.Name = "dateTimePicker_birthday";
            this.dateTimePicker_birthday.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker_birthday.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "生日：";
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 358);
            this.Controls.Add(this.dateTimePicker_birthday);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox_sex);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Name = "EditUser";
            this.Text = "编辑用户信息";
            this.groupBox_sex.ResumeLayout(false);
            this.groupBox_sex.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.GroupBox groupBox_sex;
        private System.Windows.Forms.RadioButton radioButton_woman;
        private System.Windows.Forms.RadioButton radioButton_man;
        private System.Windows.Forms.DateTimePicker dateTimePicker_birthday;
        private System.Windows.Forms.Label label3;
    }
}