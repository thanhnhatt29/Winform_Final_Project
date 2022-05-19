namespace Final
{
    partial class MenuSelect
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
            this.label1 = new System.Windows.Forms.Label();
            this.Book = new System.Windows.Forms.Button();
            this.Reader = new System.Windows.Forms.Button();
            this.Borrow = new System.Windows.Forms.Button();
            this.User = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chào";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Book
            // 
            this.Book.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Book.Location = new System.Drawing.Point(0, 48);
            this.Book.Name = "Book";
            this.Book.Size = new System.Drawing.Size(200, 66);
            this.Book.TabIndex = 1;
            this.Book.Text = "Book Manage";
            this.Book.UseVisualStyleBackColor = true;
            this.Book.Click += new System.EventHandler(this.Book_Click);
            // 
            // Reader
            // 
            this.Reader.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reader.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Reader.Location = new System.Drawing.Point(0, 374);
            this.Reader.Name = "Reader";
            this.Reader.Size = new System.Drawing.Size(200, 77);
            this.Reader.TabIndex = 2;
            this.Reader.Text = "Reader Manage ";
            this.Reader.UseVisualStyleBackColor = true;
            this.Reader.Click += new System.EventHandler(this.Reader_Click);
            // 
            // Borrow
            // 
            this.Borrow.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Borrow.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Borrow.Location = new System.Drawing.Point(3, 265);
            this.Borrow.Name = "Borrow";
            this.Borrow.Size = new System.Drawing.Size(197, 62);
            this.Borrow.TabIndex = 3;
            this.Borrow.Text = "Borrow GiveBack";
            this.Borrow.UseVisualStyleBackColor = true;
            this.Borrow.Click += new System.EventHandler(this.Borrow_Click);
            // 
            // User
            // 
            this.User.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.ForeColor = System.Drawing.SystemColors.Highlight;
            this.User.Location = new System.Drawing.Point(0, 174);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(200, 52);
            this.User.TabIndex = 4;
            this.User.Text = "User";
            this.User.UseVisualStyleBackColor = true;
            this.User.Click += new System.EventHandler(this.User_Click);
            // 
            // Quit
            // 
            this.Quit.AutoSize = true;
            this.Quit.LinkColor = System.Drawing.Color.DarkSlateGray;
            this.Quit.Location = new System.Drawing.Point(3, 494);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(114, 16);
            this.Quit.TabIndex = 5;
            this.Quit.TabStop = true;
            this.Quit.Text = "Trở về Đăng nhập";
            this.Quit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Quit_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.Quit);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.Reader);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Borrow);
            this.panel1.Controls.Add(this.Book);
            this.panel1.Controls.Add(this.User);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 519);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Final.Properties.Resources._3145866;
            this.pictureBox4.Location = new System.Drawing.Point(3, 320);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(197, 60);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Final.Properties.Resources._5773685;
            this.pictureBox3.Location = new System.Drawing.Point(0, 220);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(197, 46);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Final.Properties.Resources._32934661;
            this.pictureBox2.Location = new System.Drawing.Point(0, 112);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Final.Properties.Resources._3389081;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // MenuSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final.Properties.Resources._0_library_center___media_library_original_1600_900;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(925, 519);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MenuSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Book;
        private System.Windows.Forms.Button Reader;
        private System.Windows.Forms.Button Borrow;
        private System.Windows.Forms.Button User;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel Quit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}