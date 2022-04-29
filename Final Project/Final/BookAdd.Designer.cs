namespace Final
{
    partial class BookAdd
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
            this.AddBook = new System.Windows.Forms.Button();
            this.BookName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Genre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IDBook = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddBook
            // 
            this.AddBook.Location = new System.Drawing.Point(215, 178);
            this.AddBook.Name = "AddBook";
            this.AddBook.Size = new System.Drawing.Size(148, 23);
            this.AddBook.TabIndex = 0;
            this.AddBook.Text = "Them Sach";
            this.AddBook.UseVisualStyleBackColor = true;
            this.AddBook.Click += new System.EventHandler(this.AddBook_Click);
            // 
            // BookName
            // 
            this.BookName.Location = new System.Drawing.Point(189, 103);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(227, 22);
            this.BookName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ten Sach";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "The loai";
            // 
            // Genre
            // 
            this.Genre.FormattingEnabled = true;
            this.Genre.Items.AddRange(new object[] {
            "trinh tham",
            "lang man",
            "kinh di",
            "hanh dong"});
            this.Genre.Location = new System.Drawing.Point(189, 141);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(227, 24);
            this.Genre.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(183, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 47);
            this.label2.TabIndex = 7;
            this.label2.Text = "Thêm sách";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "IDSach";
            // 
            // IDBook
            // 
            this.IDBook.Location = new System.Drawing.Point(189, 59);
            this.IDBook.Name = "IDBook";
            this.IDBook.Size = new System.Drawing.Size(227, 22);
            this.IDBook.TabIndex = 8;
            // 
            // BookAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 213);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IDBook);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BookName);
            this.Controls.Add(this.AddBook);
            this.Name = "BookAdd";
            this.Text = "BookAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddBook;
        private System.Windows.Forms.TextBox BookName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox Genre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IDBook;
    }
}