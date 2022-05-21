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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Greet
            // 
            this.Greet.BackColor = System.Drawing.Color.Transparent;
            this.Greet.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Greet.ForeColor = System.Drawing.Color.Pink;
            this.Greet.Location = new System.Drawing.Point(-28, 473);
            this.Greet.Name = "Greet";
            this.Greet.Size = new System.Drawing.Size(997, 76);
            this.Greet.TabIndex = 0;
            this.Greet.Text = "Chào";
            this.Greet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Book
            // 
            this.Book.BackColor = System.Drawing.Color.BlueViolet;
            this.Book.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Book.Location = new System.Drawing.Point(93, 216);
            this.Book.Name = "Book";
            this.Book.Size = new System.Drawing.Size(217, 102);
            this.Book.TabIndex = 1;
            this.Book.Text = "📚Quản lý Sách";
            this.Book.UseVisualStyleBackColor = false;
            this.Book.Click += new System.EventHandler(this.Book_Click);
            // 
            // Reader
            // 
            this.Reader.BackColor = System.Drawing.Color.BlueViolet;
            this.Reader.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reader.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Reader.Location = new System.Drawing.Point(353, 216);
            this.Reader.Name = "Reader";
            this.Reader.Size = new System.Drawing.Size(217, 102);
            this.Reader.TabIndex = 2;
            this.Reader.Text = "👬Quản lý Độc giả";
            this.Reader.UseVisualStyleBackColor = false;
            this.Reader.Click += new System.EventHandler(this.Reader_Click);
            // 
            // Borrow
            // 
            this.Borrow.BackColor = System.Drawing.Color.BlueViolet;
            this.Borrow.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Borrow.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Borrow.Location = new System.Drawing.Point(93, 353);
            this.Borrow.Name = "Borrow";
            this.Borrow.Size = new System.Drawing.Size(217, 102);
            this.Borrow.TabIndex = 3;
            this.Borrow.Text = "📖Mượn Trả sách";
            this.Borrow.UseVisualStyleBackColor = false;
            this.Borrow.Click += new System.EventHandler(this.Borrow_Click);
            // 
            // User
            // 
            this.User.BackColor = System.Drawing.Color.BlueViolet;
            this.User.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.User.Location = new System.Drawing.Point(353, 353);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(217, 102);
            this.User.TabIndex = 4;
            this.User.Text = "👤 Thông tin Tài khoản";
            this.User.UseVisualStyleBackColor = false;
            this.User.Click += new System.EventHandler(this.User_Click);
            // 
            // Quit
            // 
            this.Quit.BackColor = System.Drawing.Color.Purple;
            this.Quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quit.ForeColor = System.Drawing.Color.Bisque;
            this.Quit.LinkColor = System.Drawing.Color.Aqua;
            this.Quit.Location = new System.Drawing.Point(0, -2);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(178, 27);
            this.Quit.TabIndex = 5;
            this.Quit.TabStop = true;
            this.Quit.Text = "Trở về Đăng nhập";
            this.Quit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Quit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Quit_LinkClicked);
            // 
            // Author
            // 
            this.Author.BackColor = System.Drawing.Color.BlueViolet;
            this.Author.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Author.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Author.Location = new System.Drawing.Point(610, 216);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(217, 102);
            this.Author.TabIndex = 6;
            this.Author.Text = "👬Quản lý Tác giả";
            this.Author.UseVisualStyleBackColor = false;
            this.Author.Click += new System.EventHandler(this.Author_Click);
            // 
            // Card
            // 
            this.Card.BackColor = System.Drawing.Color.BlueViolet;
            this.Card.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Card.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Card.Location = new System.Drawing.Point(610, 353);
            this.Card.Name = "Card";
            this.Card.Size = new System.Drawing.Size(217, 102);
            this.Card.TabIndex = 7;
            this.Card.Text = "💳 Quản lý Thẻ";
            this.Card.UseVisualStyleBackColor = false;
            this.Card.Click += new System.EventHandler(this.Card_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Final.Properties.Resources.menu;
            this.pictureBox1.Location = new System.Drawing.Point(208, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(502, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // MenuSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final.Properties.Resources.z3430786294749_ce797c89dcecec25b38c6497003e05b9;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(920, 567);
            this.Controls.Add(this.pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}