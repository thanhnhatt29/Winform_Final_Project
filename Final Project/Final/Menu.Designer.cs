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
            this.Greet = new System.Windows.Forms.Label();
            this.Book = new System.Windows.Forms.Button();
            this.Reader = new System.Windows.Forms.Button();
            this.Borrow = new System.Windows.Forms.Button();
            this.User = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.LinkLabel();
            this.Author = new System.Windows.Forms.Button();
            this.Card = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Greet
            // 
            this.Greet.BackColor = System.Drawing.Color.Transparent;
            this.Greet.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Greet.ForeColor = System.Drawing.Color.White;
            this.Greet.Location = new System.Drawing.Point(12, 29);
            this.Greet.Name = "Greet";
            this.Greet.Size = new System.Drawing.Size(776, 62);
            this.Greet.TabIndex = 0;
            this.Greet.Text = "Chào";
            this.Greet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Book
            // 
            this.Book.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book.Location = new System.Drawing.Point(78, 136);
            this.Book.Name = "Book";
            this.Book.Size = new System.Drawing.Size(175, 76);
            this.Book.TabIndex = 1;
            this.Book.Text = "Quản lý Sách";
            this.Book.UseVisualStyleBackColor = true;
            this.Book.Click += new System.EventHandler(this.Book_Click);
            // 
            // Reader
            // 
            this.Reader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reader.Location = new System.Drawing.Point(313, 136);
            this.Reader.Name = "Reader";
            this.Reader.Size = new System.Drawing.Size(175, 76);
            this.Reader.TabIndex = 2;
            this.Reader.Text = "Quản lý Độc giả";
            this.Reader.UseVisualStyleBackColor = true;
            this.Reader.Click += new System.EventHandler(this.Reader_Click);
            // 
            // Borrow
            // 
            this.Borrow.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Borrow.Location = new System.Drawing.Point(78, 244);
            this.Borrow.Name = "Borrow";
            this.Borrow.Size = new System.Drawing.Size(175, 76);
            this.Borrow.TabIndex = 3;
            this.Borrow.Text = "Mượn Trả sách";
            this.Borrow.UseVisualStyleBackColor = true;
            this.Borrow.Click += new System.EventHandler(this.Borrow_Click);
            // 
            // User
            // 
            this.User.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.Location = new System.Drawing.Point(313, 244);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(175, 76);
            this.User.TabIndex = 4;
            this.User.Text = "Thông tin Tài khoản";
            this.User.UseVisualStyleBackColor = true;
            this.User.Click += new System.EventHandler(this.User_Click);
            // 
            // Quit
            // 
            this.Quit.BackColor = System.Drawing.Color.Transparent;
            this.Quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quit.ForeColor = System.Drawing.Color.Bisque;
            this.Quit.LinkColor = System.Drawing.Color.Aqua;
            this.Quit.Location = new System.Drawing.Point(309, 369);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(189, 59);
            this.Quit.TabIndex = 5;
            this.Quit.TabStop = true;
            this.Quit.Text = "Trở về Đăng nhập";
            this.Quit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Quit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Quit_LinkClicked);
            // 
            // Author
            // 
            this.Author.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Author.Location = new System.Drawing.Point(546, 136);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(175, 76);
            this.Author.TabIndex = 6;
            this.Author.Text = "Quản lý Tác giả";
            this.Author.UseVisualStyleBackColor = true;
            this.Author.Click += new System.EventHandler(this.Author_Click);
            // 
            // Card
            // 
            this.Card.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Card.Location = new System.Drawing.Point(546, 244);
            this.Card.Name = "Card";
            this.Card.Size = new System.Drawing.Size(175, 76);
            this.Card.TabIndex = 7;
            this.Card.Text = "Quản lý Thẻ";
            this.Card.UseVisualStyleBackColor = true;
            this.Card.Click += new System.EventHandler(this.Card_Click);
            // 
            // MenuSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final.Properties.Resources.books;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Card);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.User);
            this.Controls.Add(this.Borrow);
            this.Controls.Add(this.Reader);
            this.Controls.Add(this.Book);
            this.Controls.Add(this.Greet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MenuSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Book;
        private System.Windows.Forms.Button Reader;
        private System.Windows.Forms.Button Borrow;
        private System.Windows.Forms.Button User;
        public System.Windows.Forms.Label Greet;
        private System.Windows.Forms.LinkLabel Quit;
        private System.Windows.Forms.Button Author;
        private System.Windows.Forms.Button Card;
    }
}