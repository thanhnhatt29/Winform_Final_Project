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
            this.label4 = new System.Windows.Forms.Label();
            this.IDBook = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddBook
            // 
            this.AddBook.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBook.Location = new System.Drawing.Point(211, 260);
            this.AddBook.Name = "AddBook";
            this.AddBook.Size = new System.Drawing.Size(148, 47);
            this.AddBook.TabIndex = 0;
            this.AddBook.Text = "Thêm Sách";
            this.AddBook.UseVisualStyleBackColor = true;
            this.AddBook.Click += new System.EventHandler(this.AddBook_Click);
            // 
            // BookName
            // 
            this.BookName.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookName.Location = new System.Drawing.Point(169, 157);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(287, 30);
            this.BookName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên Sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Thể Loại";
            // 
            // Genre
            // 
            this.Genre.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genre.FormattingEnabled = true;
            this.Genre.Items.AddRange(new object[] {
            "trinh tham",
            "lang man",
            "kinh di",
            "hanh dong"});
            this.Genre.Location = new System.Drawing.Point(169, 205);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(287, 31);
            this.Genre.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mã Sách";
            // 
            // IDBook
            // 
            this.IDBook.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDBook.Location = new System.Drawing.Point(169, 97);
            this.IDBook.Name = "IDBook";
            this.IDBook.Size = new System.Drawing.Size(287, 30);
            this.IDBook.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.PaleGreen;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(569, 72);
            this.label6.TabIndex = 33;
            this.label6.Text = "Thêm sách";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BookAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(569, 328);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IDBook);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BookName);
            this.Controls.Add(this.AddBook);
            this.Controls.Add(this.label6);
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
        public System.Windows.Forms.ComboBox Genre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IDBook;
        private System.Windows.Forms.Label label6;
    }
}