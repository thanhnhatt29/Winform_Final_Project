namespace Final
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.label1 = new System.Windows.Forms.Label();
            this.UNameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.butt_Login = new System.Windows.Forms.Button();
            this.ConcealPass = new System.Windows.Forms.CheckBox();
            this.linkSign = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // UNameBox
            // 
            resources.ApplyResources(this.UNameBox, "UNameBox");
            this.UNameBox.Name = "UNameBox";
            // 
            // PasswordBox
            // 
            resources.ApplyResources(this.PasswordBox, "PasswordBox");
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // butt_Login
            // 
            resources.ApplyResources(this.butt_Login, "butt_Login");
            this.butt_Login.Name = "butt_Login";
            this.butt_Login.UseVisualStyleBackColor = true;
            this.butt_Login.Click += new System.EventHandler(this.butt_Login_Click);
            // 
            // ConcealPass
            // 
            resources.ApplyResources(this.ConcealPass, "ConcealPass");
            this.ConcealPass.Name = "ConcealPass";
            this.ConcealPass.UseVisualStyleBackColor = true;
            this.ConcealPass.CheckedChanged += new System.EventHandler(this.ConcealPass_CheckedChanged);
            // 
            // linkSign
            // 
            resources.ApplyResources(this.linkSign, "linkSign");
            this.linkSign.Name = "linkSign";
            this.linkSign.TabStop = true;
            this.linkSign.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSign_LinkClicked);
            // 
            // LogIn
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkSign);
            this.Controls.Add(this.ConcealPass);
            this.Controls.Add(this.butt_Login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UNameBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UNameBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butt_Login;
        private System.Windows.Forms.CheckBox ConcealPass;
        private System.Windows.Forms.LinkLabel linkSign;
    }
}

