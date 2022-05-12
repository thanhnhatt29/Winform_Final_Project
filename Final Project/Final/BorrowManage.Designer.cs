namespace Final
{
    partial class BorrowManage
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
            this.dataBook = new System.Windows.Forms.DataGridView();
            this.dataBorrow = new System.Windows.Forms.DataGridView();
            this.buttonBorrow = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonGiveBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBorrow)).BeginInit();
            this.SuspendLayout();
            // 
            // dataBook
            // 
            this.dataBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBook.Location = new System.Drawing.Point(12, 40);
            this.dataBook.Name = "dataBook";
            this.dataBook.RowHeadersWidth = 51;
            this.dataBook.RowTemplate.Height = 24;
            this.dataBook.Size = new System.Drawing.Size(481, 270);
            this.dataBook.TabIndex = 0;
            // 
            // dataBorrow
            // 
            this.dataBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBorrow.Location = new System.Drawing.Point(499, 40);
            this.dataBorrow.Name = "dataBorrow";
            this.dataBorrow.RowHeadersWidth = 51;
            this.dataBorrow.RowTemplate.Height = 24;
            this.dataBorrow.Size = new System.Drawing.Size(349, 270);
            this.dataBorrow.TabIndex = 1;
            // 
            // buttonBorrow
            // 
            this.buttonBorrow.Location = new System.Drawing.Point(499, 349);
            this.buttonBorrow.Name = "buttonBorrow";
            this.buttonBorrow.Size = new System.Drawing.Size(121, 54);
            this.buttonBorrow.TabIndex = 5;
            this.buttonBorrow.Text = "Muon";
            this.buttonBorrow.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 349);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(389, 22);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "ReaderID";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(104, 384);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(121, 54);
            this.buttonSearch.TabIndex = 8;
            this.buttonSearch.Text = "Tra cuu";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // buttonGiveBack
            // 
            this.buttonGiveBack.Location = new System.Drawing.Point(727, 349);
            this.buttonGiveBack.Name = "buttonGiveBack";
            this.buttonGiveBack.Size = new System.Drawing.Size(121, 54);
            this.buttonGiveBack.TabIndex = 9;
            this.buttonGiveBack.Text = "Tra sach";
            this.buttonGiveBack.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Danh sach Sach";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(625, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Danh sach Muon";
            // 
            // BorrowManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonGiveBack);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonBorrow);
            this.Controls.Add(this.dataBorrow);
            this.Controls.Add(this.dataBook);
            this.MaximizeBox = false;
            this.Name = "BorrowManage";
            this.Text = "BorrowManage";
            ((System.ComponentModel.ISupportInitialize)(this.dataBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBorrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataBook;
        private System.Windows.Forms.DataGridView dataBorrow;
        private System.Windows.Forms.Button buttonBorrow;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonGiveBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}