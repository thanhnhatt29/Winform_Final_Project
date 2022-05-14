namespace Final
{
    partial class BorrowAdd
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
            this.btThem = new System.Windows.Forms.Button();
            this.btMuon = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbSoThe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbTimSach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBorrow)).BeginInit();
            this.SuspendLayout();
            // 
            // dataBook
            // 
            this.dataBook.AllowUserToAddRows = false;
            this.dataBook.AllowUserToDeleteRows = false;
            this.dataBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBook.Location = new System.Drawing.Point(27, 47);
            this.dataBook.Name = "dataBook";
            this.dataBook.ReadOnly = true;
            this.dataBook.RowHeadersWidth = 51;
            this.dataBook.RowTemplate.Height = 24;
            this.dataBook.Size = new System.Drawing.Size(311, 364);
            this.dataBook.TabIndex = 0;
            // 
            // dataBorrow
            // 
            this.dataBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBorrow.Location = new System.Drawing.Point(456, 47);
            this.dataBorrow.Name = "dataBorrow";
            this.dataBorrow.RowHeadersWidth = 51;
            this.dataBorrow.RowTemplate.Height = 24;
            this.dataBorrow.Size = new System.Drawing.Size(534, 364);
            this.dataBorrow.TabIndex = 1;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(344, 104);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(106, 41);
            this.btThem.TabIndex = 2;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btMuon
            // 
            this.btMuon.Location = new System.Drawing.Point(884, 428);
            this.btMuon.Name = "btMuon";
            this.btMuon.Size = new System.Drawing.Size(106, 41);
            this.btMuon.TabIndex = 3;
            this.btMuon.Text = "Mượn";
            this.btMuon.UseVisualStyleBackColor = true;
            this.btMuon.Click += new System.EventHandler(this.btMuon_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(344, 164);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(106, 41);
            this.btXoa.TabIndex = 4;
            this.btXoa.Text = "Xoá";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mượn";
            // 
            // txbSoThe
            // 
            this.txbSoThe.Location = new System.Drawing.Point(524, 437);
            this.txbSoThe.Name = "txbSoThe";
            this.txbSoThe.Size = new System.Drawing.Size(339, 22);
            this.txbSoThe.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 440);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Số thẻ";
            // 
            // txbTimSach
            // 
            this.txbTimSach.Location = new System.Drawing.Point(97, 434);
            this.txbTimSach.Name = "txbTimSach";
            this.txbTimSach.Size = new System.Drawing.Size(241, 22);
            this.txbTimSach.TabIndex = 12;
            this.txbTimSach.TextChanged += new System.EventHandler(this.txbTimSach_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tên sách";
            // 
            // BorrowAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 479);
            this.Controls.Add(this.txbTimSach);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbSoThe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btMuon);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.dataBorrow);
            this.Controls.Add(this.dataBook);
            this.Name = "BorrowAdd";
            this.Text = "BorrowAdd";
            ((System.ComponentModel.ISupportInitialize)(this.dataBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBorrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataBook;
        private System.Windows.Forms.DataGridView dataBorrow;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btMuon;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbSoThe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbTimSach;
        private System.Windows.Forms.Label label3;
    }
}