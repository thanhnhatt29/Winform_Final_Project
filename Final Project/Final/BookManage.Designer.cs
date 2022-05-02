
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
            this.BookID = new System.Windows.Forms.TextBox();
            this.BookLocate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonDo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBook)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(92, 416);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(121, 54);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Them";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(366, 416);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(121, 54);
            this.buttonEdit.TabIndex = 5;
            this.buttonEdit.Text = "Sua";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(229, 416);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(121, 54);
            this.buttonDel.TabIndex = 6;
            this.buttonDel.Text = "Xoa";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(651, 413);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(121, 54);
            this.buttonFind.TabIndex = 7;
            this.buttonFind.Text = "Tim";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Location = new System.Drawing.Point(30, 385);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(64, 17);
            this.Amount.TabIndex = 17;
            this.Amount.Text = "So luong";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 385);
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
            this.Genre.Location = new System.Drawing.Point(92, 339);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(395, 24);
            this.Genre.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "The loai";
            // 
            // Author
            // 
            this.Author.Location = new System.Drawing.Point(92, 291);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(395, 22);
            this.Author.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tac gia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ten";
            // 
            // BookName
            // 
            this.BookName.Location = new System.Drawing.Point(92, 246);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(395, 22);
            this.BookName.TabIndex = 10;
            // 
            // dataGridBook
            // 
            this.dataGridBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBook.Location = new System.Drawing.Point(30, 12);
            this.dataGridBook.Name = "dataGridBook";
            this.dataGridBook.RowHeadersWidth = 51;
            this.dataGridBook.RowTemplate.Height = 24;
            this.dataGridBook.Size = new System.Drawing.Size(996, 195);
            this.dataGridBook.TabIndex = 9;
            // 
            // BookID
            // 
            this.BookID.Location = new System.Drawing.Point(651, 246);
            this.BookID.Name = "BookID";
            this.BookID.Size = new System.Drawing.Size(375, 22);
            this.BookID.TabIndex = 18;
            // 
            // BookLocate
            // 
            this.BookLocate.Location = new System.Drawing.Point(651, 291);
            this.BookLocate.Name = "BookLocate";
            this.BookLocate.Size = new System.Drawing.Size(375, 22);
            this.BookLocate.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(550, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Ma Sach";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(550, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Vi tri";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(651, 339);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(375, 22);
            this.textBox2.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(550, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Nam xuat ban";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(905, 413);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(121, 54);
            this.buttonCancel.TabIndex = 25;
            this.buttonCancel.Text = "Huy";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonDo
            // 
            this.buttonDo.Location = new System.Drawing.Point(778, 413);
            this.buttonDo.Name = "buttonDo";
            this.buttonDo.Size = new System.Drawing.Size(121, 54);
            this.buttonDo.TabIndex = 26;
            this.buttonDo.Text = "Tien hanh";
            this.buttonDo.UseVisualStyleBackColor = true;
            this.buttonDo.Click += new System.EventHandler(this.buttonDo_Click);
            // 
            // BookManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 482);
            this.Controls.Add(this.buttonDo);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BookLocate);
            this.Controls.Add(this.BookID);
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
        private System.Windows.Forms.TextBox BookID;
        private System.Windows.Forms.TextBox BookLocate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonDo;
    }
}