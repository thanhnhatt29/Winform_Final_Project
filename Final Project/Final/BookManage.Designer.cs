
namespace Final
{
    partial class BookManage
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonFind = new System.Windows.Forms.Button();
            this.Amount = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Genre = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BookName = new System.Windows.Forms.TextBox();
            this.dataGridBook = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBook)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(519, 25);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(121, 54);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Them";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(519, 117);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(121, 54);
            this.buttonEdit.TabIndex = 5;
            this.buttonEdit.Text = "Sua";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(519, 217);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(121, 54);
            this.buttonDel.TabIndex = 6;
            this.buttonDel.Text = "Xoa";
            this.buttonDel.UseVisualStyleBackColor = true;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(519, 297);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(121, 54);
            this.buttonFind.TabIndex = 7;
            this.buttonFind.Text = "Tim";
            this.buttonFind.UseVisualStyleBackColor = true;
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Location = new System.Drawing.Point(30, 440);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(60, 16);
            this.Amount.TabIndex = 17;
            this.Amount.Text = "So luong";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 440);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(395, 22);
            this.textBox1.TabIndex = 16;
            // 
            // Genre
            // 
            this.Genre.FormattingEnabled = true;
            this.Genre.Items.AddRange(new object[] {
            "trinh tham",
            "lang man",
            "kinh di",
            "hanh dong",
            "phieu luu"});
            this.Genre.Location = new System.Drawing.Point(92, 394);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(395, 24);
            this.Genre.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "The loai";
            // 
            // Author
            // 
            this.Author.Location = new System.Drawing.Point(92, 346);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(395, 22);
            this.Author.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tac gia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ten";
            // 
            // BookName
            // 
            this.BookName.Location = new System.Drawing.Point(92, 301);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(395, 22);
            this.BookName.TabIndex = 10;
            // 
            // dataGridBook
            // 
            this.dataGridBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBook.Location = new System.Drawing.Point(30, 25);
            this.dataGridBook.Name = "dataGridBook";
            this.dataGridBook.RowHeadersWidth = 51;
            this.dataGridBook.RowTemplate.Height = 24;
            this.dataGridBook.Size = new System.Drawing.Size(457, 245);
            this.dataGridBook.TabIndex = 9;
            // 
            // BookManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 482);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BookName);
            this.Controls.Add(this.dataGridBook);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Name = "BookManage";
            this.Text = "BookManage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox Genre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Author;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BookName;
        private System.Windows.Forms.DataGridView dataGridBook;
    }
}