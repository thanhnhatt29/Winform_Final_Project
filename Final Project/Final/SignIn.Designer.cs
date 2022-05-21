namespace Final
{
    partial class SignIn
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
            this.linkLog = new System.Windows.Forms.LinkLabel();
            this.ConcealPass = new System.Windows.Forms.CheckBox();
            this.butt_Sign = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.UNameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ConfirmBox = new System.Windows.Forms.TextBox();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.dateOBirth = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLog
            // 
            this.linkLog.AutoSize = true;
            this.linkLog.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLog.Location = new System.Drawing.Point(132, 700);
            this.linkLog.Name = "linkLog";
            this.linkLog.Size = new System.Drawing.Size(162, 23);
            this.linkLog.TabIndex = 15;
            this.linkLog.TabStop = true;
            this.linkLog.Text = "Quay lại Đăng nhập";
            this.linkLog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLog_LinkClicked);
            // 
            // ConcealPass
            // 
            this.ConcealPass.AutoSize = true;
            this.ConcealPass.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConcealPass.Location = new System.Drawing.Point(77, 580);
            this.ConcealPass.Name = "ConcealPass";
            this.ConcealPass.Size = new System.Drawing.Size(170, 27);
            this.ConcealPass.TabIndex = 14;
            this.ConcealPass.Text = "Hiển thị mật khẩu";
            this.ConcealPass.UseVisualStyleBackColor = true;
            this.ConcealPass.CheckedChanged += new System.EventHandler(this.ConcealPass_CheckedChanged);
            // 
            // butt_Sign
            // 
            this.butt_Sign.BackColor = System.Drawing.Color.BlueViolet;
            this.butt_Sign.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butt_Sign.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.butt_Sign.Location = new System.Drawing.Point(136, 613);
            this.butt_Sign.Name = "butt_Sign";
            this.butt_Sign.Size = new System.Drawing.Size(158, 67);
            this.butt_Sign.TabIndex = 13;
            this.butt_Sign.Text = "Đăng kí";
            this.butt_Sign.UseVisualStyleBackColor = false;
            this.butt_Sign.Click += new System.EventHandler(this.butt_Sign_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mã Nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mật khẩu";
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordBox.Location = new System.Drawing.Point(76, 465);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(288, 30);
            this.PasswordBox.TabIndex = 10;
            this.PasswordBox.UseSystemPasswordChar = true;
            // 
            // UNameBox
            // 
            this.UNameBox.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UNameBox.Location = new System.Drawing.Point(76, 176);
            this.UNameBox.Name = "UNameBox";
            this.UNameBox.Size = new System.Drawing.Size(288, 30);
            this.UNameBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 518);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Xác nhận mật khẩu";
            // 
            // ConfirmBox
            // 
            this.ConfirmBox.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmBox.Location = new System.Drawing.Point(76, 544);
            this.ConfirmBox.Name = "ConfirmBox";
            this.ConfirmBox.Size = new System.Drawing.Size(288, 30);
            this.ConfirmBox.TabIndex = 17;
            this.ConfirmBox.UseSystemPasswordChar = true;
            // 
            // PhoneBox
            // 
            this.PhoneBox.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneBox.Location = new System.Drawing.Point(76, 393);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(288, 30);
            this.PhoneBox.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(72, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "Số Điện Thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 23);
            this.label6.TabIndex = 19;
            this.label6.Text = "Họ và tên";
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.Location = new System.Drawing.Point(76, 246);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(288, 30);
            this.NameBox.TabIndex = 18;
            // 
            // dateOBirth
            // 
            this.dateOBirth.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOBirth.Location = new System.Drawing.Point(76, 319);
            this.dateOBirth.Name = "dateOBirth";
            this.dateOBirth.Size = new System.Drawing.Size(288, 30);
            this.dateOBirth.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(72, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 23);
            this.label7.TabIndex = 23;
            this.label7.Text = "Ngày Sinh";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.BlueViolet;
            this.pictureBox1.Image = global::Final.Properties.Resources.signin;
            this.pictureBox1.Location = new System.Drawing.Point(76, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.BlueViolet;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(-213, -3);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(991, 129);
            this.label8.TabIndex = 25;
            this.label8.Text = "Đăng ký";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SignIn
            // 
            this.AcceptButton = this.butt_Sign;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(433, 733);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateOBirth);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.ConfirmBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLog);
            this.Controls.Add(this.ConcealPass);
            this.Controls.Add(this.butt_Sign);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UNameBox);
            this.MaximizeBox = false;
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLog;
        private System.Windows.Forms.CheckBox ConcealPass;
        private System.Windows.Forms.Button butt_Sign;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ConfirmBox;
        public System.Windows.Forms.TextBox UNameBox;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.DateTimePicker dateOBirth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
    }
}