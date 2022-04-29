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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ConfirmBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // linkLog
            // 
            this.linkLog.AutoSize = true;
            this.linkLog.Location = new System.Drawing.Point(284, 293);
            this.linkLog.Name = "linkLog";
            this.linkLog.Size = new System.Drawing.Size(124, 16);
            this.linkLog.TabIndex = 15;
            this.linkLog.TabStop = true;
            this.linkLog.Text = "Quay lại Đăng nhập";
            this.linkLog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLog_LinkClicked);
            // 
            // ConcealPass
            // 
            this.ConcealPass.AutoSize = true;
            this.ConcealPass.Location = new System.Drawing.Point(244, 197);
            this.ConcealPass.Name = "ConcealPass";
            this.ConcealPass.Size = new System.Drawing.Size(130, 20);
            this.ConcealPass.TabIndex = 14;
            this.ConcealPass.Text = "Hiển thị mật khẩu";
            this.ConcealPass.UseVisualStyleBackColor = true;
            this.ConcealPass.CheckedChanged += new System.EventHandler(this.ConcealPass_CheckedChanged);
            // 
            // butt_Sign
            // 
            this.butt_Sign.Location = new System.Drawing.Point(276, 223);
            this.butt_Sign.Name = "butt_Sign";
            this.butt_Sign.Size = new System.Drawing.Size(141, 37);
            this.butt_Sign.TabIndex = 13;
            this.butt_Sign.Text = "Đăng kí";
            this.butt_Sign.UseVisualStyleBackColor = true;
            this.butt_Sign.Click += new System.EventHandler(this.butt_Sign_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password";
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(244, 136);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(288, 22);
            this.PasswordBox.TabIndex = 10;
            this.PasswordBox.UseSystemPasswordChar = true;
            // 
            // UNameBox
            // 
            this.UNameBox.Location = new System.Drawing.Point(244, 101);
            this.UNameBox.Name = "UNameBox";
            this.UNameBox.Size = new System.Drawing.Size(288, 22);
            this.UNameBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 42);
            this.label1.TabIndex = 8;
            this.label1.Text = "Đăng kí";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Confirm";
            // 
            // ConfirmBox
            // 
            this.ConfirmBox.Location = new System.Drawing.Point(244, 172);
            this.ConfirmBox.Name = "ConfirmBox";
            this.ConfirmBox.Size = new System.Drawing.Size(288, 22);
            this.ConfirmBox.TabIndex = 17;
            this.ConfirmBox.UseSystemPasswordChar = true;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 368);
            this.Controls.Add(this.ConfirmBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLog);
            this.Controls.Add(this.ConcealPass);
            this.Controls.Add(this.butt_Sign);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UNameBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ConfirmBox;
        public System.Windows.Forms.TextBox UNameBox;
    }
}