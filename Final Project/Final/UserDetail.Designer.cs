namespace Final
{
    partial class UserDetail
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
            this.butt_Cancel = new System.Windows.Forms.Button();
            this.EditInfo = new System.Windows.Forms.Button();
            this.butt_Do = new System.Windows.Forms.Button();
            this.dateBirth = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.UName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butt_Cancel
            // 
            this.butt_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butt_Cancel.BackColor = System.Drawing.Color.DarkGreen;
            this.butt_Cancel.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butt_Cancel.ForeColor = System.Drawing.Color.Chartreuse;
            this.butt_Cancel.Location = new System.Drawing.Point(439, 421);
            this.butt_Cancel.Name = "butt_Cancel";
            this.butt_Cancel.Size = new System.Drawing.Size(141, 37);
            this.butt_Cancel.TabIndex = 30;
            this.butt_Cancel.Text = "Huỷ";
            this.butt_Cancel.UseVisualStyleBackColor = false;
            this.butt_Cancel.Click += new System.EventHandler(this.butt_Cancel_Click);
            // 
            // EditInfo
            // 
            this.EditInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditInfo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.EditInfo.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditInfo.ForeColor = System.Drawing.Color.Chartreuse;
            this.EditInfo.Location = new System.Drawing.Point(328, 361);
            this.EditInfo.Name = "EditInfo";
            this.EditInfo.Size = new System.Drawing.Size(141, 37);
            this.EditInfo.TabIndex = 29;
            this.EditInfo.Text = "Chỉnh sửa";
            this.EditInfo.UseVisualStyleBackColor = false;
            this.EditInfo.Click += new System.EventHandler(this.EditInfo_Click);
            // 
            // butt_Do
            // 
            this.butt_Do.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butt_Do.BackColor = System.Drawing.Color.DarkGreen;
            this.butt_Do.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butt_Do.ForeColor = System.Drawing.Color.Chartreuse;
            this.butt_Do.Location = new System.Drawing.Point(207, 421);
            this.butt_Do.Name = "butt_Do";
            this.butt_Do.Size = new System.Drawing.Size(141, 37);
            this.butt_Do.TabIndex = 28;
            this.butt_Do.Text = "Tiến hành";
            this.butt_Do.UseVisualStyleBackColor = false;
            this.butt_Do.Click += new System.EventHandler(this.butt_Do_Click);
            // 
            // dateBirth
            // 
            this.dateBirth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateBirth.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBirth.Location = new System.Drawing.Point(288, 218);
            this.dateBirth.Name = "dateBirth";
            this.dateBirth.Size = new System.Drawing.Size(292, 30);
            this.dateBirth.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(110, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 23);
            this.label5.TabIndex = 26;
            this.label5.Text = "Mật khẩu";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(110, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Họ và tên";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 22;
            this.label1.Text = "Mã Nhân viên";
            // 
            // Password
            // 
            this.Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Password.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(288, 315);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(292, 30);
            this.Password.TabIndex = 21;
            // 
            // Phone
            // 
            this.Phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Phone.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.Location = new System.Drawing.Point(288, 265);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(292, 30);
            this.Phone.TabIndex = 20;
            // 
            // NameBox
            // 
            this.NameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameBox.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.Location = new System.Drawing.Point(288, 168);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(292, 30);
            this.NameBox.TabIndex = 19;
            // 
            // UName
            // 
            this.UName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UName.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UName.Location = new System.Drawing.Point(288, 125);
            this.UName.Name = "UName";
            this.UName.Size = new System.Drawing.Size(292, 30);
            this.UName.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.PaleGreen;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(800, 85);
            this.label6.TabIndex = 32;
            this.label6.Text = "Thông tin Tài khoản";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(800, 525);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.butt_Cancel);
            this.Controls.Add(this.EditInfo);
            this.Controls.Add(this.butt_Do);
            this.Controls.Add(this.dateBirth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.UName);
            this.Name = "UserDetail";
            this.Text = "UserDetail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button butt_Cancel;
        private System.Windows.Forms.Button EditInfo;
        private System.Windows.Forms.Button butt_Do;
        private System.Windows.Forms.DateTimePicker dateBirth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox UName;
        private System.Windows.Forms.Label label6;
    }
}