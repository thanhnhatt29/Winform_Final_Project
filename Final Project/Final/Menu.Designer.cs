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
            this.Author = new System.Windows.Forms.Button();
            this.Card = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chào";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Book
            // 
            this.Book.Location = new System.Drawing.Point(188, 120);
            this.Book.Name = "Book";
            this.Book.Size = new System.Drawing.Size(175, 76);
            this.Book.TabIndex = 1;
            this.Book.Text = "Book Manage";
            this.Book.UseVisualStyleBackColor = true;
            this.Book.Click += new System.EventHandler(this.Book_Click);
            // 
            // Reader
            // 
            this.Reader.Location = new System.Drawing.Point(426, 120);
            this.Reader.Name = "Reader";
            this.Reader.Size = new System.Drawing.Size(175, 76);
            this.Reader.TabIndex = 2;
            this.Reader.Text = "Reader Manage ";
            this.Reader.UseVisualStyleBackColor = true;
            this.Reader.Click += new System.EventHandler(this.Reader_Click);
            // 
            // Borrow
            // 
            this.Borrow.Location = new System.Drawing.Point(188, 255);
            this.Borrow.Name = "Borrow";
            this.Borrow.Size = new System.Drawing.Size(175, 76);
            this.Borrow.TabIndex = 3;
            this.Borrow.Text = "Borrow_GiveBack";
            this.Borrow.UseVisualStyleBackColor = true;
            this.Borrow.Click += new System.EventHandler(this.Borrow_Click);
            // 
            // User
            // 
            this.User.Location = new System.Drawing.Point(426, 255);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(175, 76);
            this.User.TabIndex = 4;
            this.User.Text = "User";
            this.User.UseVisualStyleBackColor = true;
            this.User.Click += new System.EventHandler(this.User_Click);
            // 
            // Quit
            // 
            this.Quit.AutoSize = true;
            this.Quit.Location = new System.Drawing.Point(350, 396);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(114, 16);
            this.Quit.TabIndex = 5;
            this.Quit.TabStop = true;
            this.Quit.Text = "Trở về Đăng nhập";
            this.Quit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Quit_LinkClicked);
            // 
            // Author
            // 
            this.Author.Location = new System.Drawing.Point(313, 187);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(175, 76);
            this.Author.TabIndex = 6;
            this.Author.Text = "Author Manage";
            this.Author.UseVisualStyleBackColor = true;
            this.Author.Click += new System.EventHandler(this.Author_Click);
            // 
            // Card
            // 
            this.Card.Location = new System.Drawing.Point(595, 187);
            this.Card.Name = "Card";
            this.Card.Size = new System.Drawing.Size(175, 76);
            this.Card.TabIndex = 7;
            this.Card.Text = "Card Manage";
            this.Card.UseVisualStyleBackColor = true;
            this.Card.Click += new System.EventHandler(this.Card_Click);
            // 
            // MenuSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Card);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.User);
            this.Controls.Add(this.Borrow);
            this.Controls.Add(this.Reader);
            this.Controls.Add(this.Book);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MenuSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Book;
        private System.Windows.Forms.Button Reader;
        private System.Windows.Forms.Button Borrow;
        private System.Windows.Forms.Button User;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel Quit;
        private System.Windows.Forms.Button Author;
        private System.Windows.Forms.Button Card;
    }
}