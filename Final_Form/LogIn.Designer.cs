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
            this.butt_Login = new System.Windows.Forms.Button();
            this.ConcealPass = new System.Windows.Forms.CheckBox();
            this.linkSign = new System.Windows.Forms.LinkLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
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
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Final.Properties.Resources._2353441;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Final.Properties.Resources._1144760;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Final.Properties.Resources._3293466;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.InitialImage = global::Final.Properties.Resources._3293466;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // LogIn
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkSign);
            this.Controls.Add(this.ConcealPass);
            this.Controls.Add(this.butt_Login);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UNameBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LogIn";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UNameBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Button butt_Login;
        private System.Windows.Forms.CheckBox ConcealPass;
        private System.Windows.Forms.LinkLabel linkSign;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

