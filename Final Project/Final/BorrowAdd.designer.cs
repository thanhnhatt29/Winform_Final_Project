﻿namespace Final
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
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBorrow)).BeginInit();
            this.SuspendLayout();
            // 
            // dataBook
            // 
            this.dataBook.AllowUserToAddRows = false;
            this.dataBook.AllowUserToDeleteRows = false;
            this.dataBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBook.Location = new System.Drawing.Point(27, 144);
            this.dataBook.Name = "dataBook";
            this.dataBook.ReadOnly = true;
            this.dataBook.RowHeadersWidth = 51;
            this.dataBook.RowTemplate.Height = 24;
            this.dataBook.Size = new System.Drawing.Size(311, 410);
            this.dataBook.TabIndex = 0;
            // 
            // dataBorrow
            // 
            this.dataBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBorrow.Location = new System.Drawing.Point(456, 144);
            this.dataBorrow.Name = "dataBorrow";
            this.dataBorrow.RowHeadersWidth = 51;
            this.dataBorrow.RowTemplate.Height = 24;
            this.dataBorrow.Size = new System.Drawing.Size(534, 410);
            this.dataBorrow.TabIndex = 1;
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(164)))), ((int)(((byte)(82)))));
            this.btThem.FlatAppearance.BorderSize = 0;
            this.btThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThem.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(49)))), ((int)(((byte)(120)))));
            this.btThem.Location = new System.Drawing.Point(344, 144);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(106, 70);
            this.btThem.TabIndex = 2;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btMuon
            // 
            this.btMuon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(164)))), ((int)(((byte)(82)))));
            this.btMuon.FlatAppearance.BorderSize = 0;
            this.btMuon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMuon.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMuon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(49)))), ((int)(((byte)(120)))));
            this.btMuon.Location = new System.Drawing.Point(884, 576);
            this.btMuon.Name = "btMuon";
            this.btMuon.Size = new System.Drawing.Size(106, 46);
            this.btMuon.TabIndex = 3;
            this.btMuon.Text = "Mượn";
            this.btMuon.UseVisualStyleBackColor = false;
            this.btMuon.Click += new System.EventHandler(this.btMuon_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(164)))), ((int)(((byte)(82)))));
            this.btXoa.FlatAppearance.BorderSize = 0;
            this.btXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoa.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(49)))), ((int)(((byte)(120)))));
            this.btXoa.Location = new System.Drawing.Point(344, 220);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(106, 70);
            this.btXoa.TabIndex = 4;
            this.btXoa.Text = "Xoá";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(49)))), ((int)(((byte)(120)))));
            this.label1.Location = new System.Drawing.Point(26, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(49)))), ((int)(((byte)(120)))));
            this.label2.Location = new System.Drawing.Point(453, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mượn";
            // 
            // txbSoThe
            // 
            this.txbSoThe.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSoThe.Location = new System.Drawing.Point(524, 583);
            this.txbSoThe.Name = "txbSoThe";
            this.txbSoThe.Size = new System.Drawing.Size(339, 30);
            this.txbSoThe.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(49)))), ((int)(((byte)(120)))));
            this.label4.Location = new System.Drawing.Point(453, 586);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Số thẻ";
            // 
            // txbTimSach
            // 
            this.txbTimSach.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTimSach.Location = new System.Drawing.Point(109, 579);
            this.txbTimSach.Name = "txbTimSach";
            this.txbTimSach.Size = new System.Drawing.Size(229, 30);
            this.txbTimSach.TabIndex = 12;
            this.txbTimSach.TextChanged += new System.EventHandler(this.txbTimSach_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(49)))), ((int)(((byte)(120)))));
            this.label3.Location = new System.Drawing.Point(26, 583);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tên sách";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(114)))), ((int)(((byte)(83)))));
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(236)))), ((int)(((byte)(173)))));
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1022, 92);
            this.label6.TabIndex = 107;
            this.label6.Text = "Mượn Sách";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BorrowAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(236)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(1022, 648);
            this.Controls.Add(this.label6);
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
            this.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
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
        public System.Windows.Forms.Label label6;
    }
}