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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Greet
            // 
            this.Greet.BackColor = System.Drawing.Color.Transparent;
            this.Greet.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Greet.ForeColor = System.Drawing.Color.Pink;
            this.Greet.Location = new System.Drawing.Point(601, 62);
            this.Greet.Name = "Greet";
            this.Greet.Size = new System.Drawing.Size(633, 62);
            this.Greet.TabIndex = 0;
            this.Greet.Text = "Chào";
            this.Greet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Book
            // 
            this.Book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(53)))), ((int)(((byte)(83)))));
            this.Book.Dock = System.Windows.Forms.DockStyle.Top;
            this.Book.FlatAppearance.BorderSize = 0;
            this.Book.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.Book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Book.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Book.Location = new System.Drawing.Point(0, 151);
            this.Book.Name = "Book";
            this.Book.Size = new System.Drawing.Size(200, 81);
            this.Book.TabIndex = 1;
            this.Book.Text = "📚 Quản lý Sách";
            this.Book.UseVisualStyleBackColor = false;
            this.Book.Click += new System.EventHandler(this.Book_Click);
            // 
            // Reader
            // 
            this.Reader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(53)))), ((int)(((byte)(83)))));
            this.Reader.Dock = System.Windows.Forms.DockStyle.Top;
            this.Reader.FlatAppearance.BorderSize = 0;
            this.Reader.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.Reader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reader.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reader.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Reader.Location = new System.Drawing.Point(0, 311);
            this.Reader.Name = "Reader";
            this.Reader.Size = new System.Drawing.Size(200, 73);
            this.Reader.TabIndex = 2;
            this.Reader.Text = "👬 Quản lý Độc giả";
            this.Reader.UseVisualStyleBackColor = false;
            this.Reader.Click += new System.EventHandler(this.Reader_Click);
            // 
            // Borrow
            // 
            this.Borrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(53)))), ((int)(((byte)(83)))));
            this.Borrow.Dock = System.Windows.Forms.DockStyle.Top;
            this.Borrow.FlatAppearance.BorderSize = 0;
            this.Borrow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.Borrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Borrow.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Borrow.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Borrow.Location = new System.Drawing.Point(0, 73);
            this.Borrow.Name = "Borrow";
            this.Borrow.Size = new System.Drawing.Size(200, 78);
            this.Borrow.TabIndex = 3;
            this.Borrow.Text = "📖 Mượn Trả sách";
            this.Borrow.UseVisualStyleBackColor = false;
            this.Borrow.Click += new System.EventHandler(this.Borrow_Click);
            // 
            // User
            // 
            this.User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(53)))), ((int)(((byte)(83)))));
            this.User.Dock = System.Windows.Forms.DockStyle.Top;
            this.User.FlatAppearance.BorderSize = 0;
            this.User.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.User.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.User.Location = new System.Drawing.Point(0, 384);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(200, 71);
            this.User.TabIndex = 4;
            this.User.Text = "👤 Thông tin Tài khoản";
            this.User.UseVisualStyleBackColor = false;
            this.User.Click += new System.EventHandler(this.User_Click);
            // 
            // Quit
            // 
            this.Quit.BackColor = System.Drawing.Color.Transparent;
            this.Quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quit.ForeColor = System.Drawing.Color.Bisque;
            this.Quit.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.Quit.Location = new System.Drawing.Point(-17, 653);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(173, 34);
            this.Quit.TabIndex = 5;
            this.Quit.TabStop = true;
            this.Quit.Text = "Trở về";
            this.Quit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Quit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Quit_LinkClicked);
            // 
            // Author
            // 
            this.Author.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(53)))), ((int)(((byte)(83)))));
            this.Author.Dock = System.Windows.Forms.DockStyle.Top;
            this.Author.FlatAppearance.BorderSize = 0;
            this.Author.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.Author.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Author.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Author.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Author.Location = new System.Drawing.Point(0, 232);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(200, 79);
            this.Author.TabIndex = 6;
            this.Author.Text = "👬 Quản lý Tác giả";
            this.Author.UseVisualStyleBackColor = false;
            this.Author.Click += new System.EventHandler(this.Author_Click);
            // 
            // Card
            // 
            this.Card.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(53)))), ((int)(((byte)(83)))));
            this.Card.Dock = System.Windows.Forms.DockStyle.Top;
            this.Card.FlatAppearance.BorderSize = 0;
            this.Card.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.Card.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Card.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Card.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Card.Location = new System.Drawing.Point(0, 0);
            this.Card.Name = "Card";
            this.Card.Size = new System.Drawing.Size(200, 73);
            this.Card.TabIndex = 7;
            this.Card.Text = "💳 Quản lý Thẻ";
            this.Card.UseVisualStyleBackColor = false;
            this.Card.Click += new System.EventHandler(this.Card_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.Greet);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1275, 124);
            this.panel1.TabIndex = 10;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox3.Image = global::Final.Properties.Resources.library;
            this.pictureBox3.InitialImage = global::Final.Properties.Resources._3293466;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(200, 124);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Final.Properties.Resources.pngegg;
            this.pictureBox2.Location = new System.Drawing.Point(112, -100);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(689, 317);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Final.Properties.Resources._189254;
            this.pictureBox1.Location = new System.Drawing.Point(3, 650);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(53)))), ((int)(((byte)(83)))));
            this.panel2.Controls.Add(this.User);
            this.panel2.Controls.Add(this.Reader);
            this.panel2.Controls.Add(this.Author);
            this.panel2.Controls.Add(this.Book);
            this.panel2.Controls.Add(this.Borrow);
            this.panel2.Controls.Add(this.Card);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.Quit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 696);
            this.panel2.TabIndex = 11;
            // 
            // MenuSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Final.Properties.Resources.z3430786294749_ce797c89dcecec25b38c6497003e05b9;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1275, 820);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "MenuSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
    }
}