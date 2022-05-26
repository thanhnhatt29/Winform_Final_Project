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
            this.dataBorrow = new System.Windows.Forms.DataGridView();
            this.buttonBorrow = new System.Windows.Forms.Button();
            this.txbSoThe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGiveBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_DaTra = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTongMuon = new System.Windows.Forms.Label();
            this.buttonCSV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataBorrow)).BeginInit();
            this.SuspendLayout();
            // 
            // dataBorrow
            // 
            this.dataBorrow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBorrow.Location = new System.Drawing.Point(12, 158);
            this.dataBorrow.Name = "dataBorrow";
            this.dataBorrow.RowHeadersWidth = 51;
            this.dataBorrow.RowTemplate.Height = 24;
            this.dataBorrow.Size = new System.Drawing.Size(961, 429);
            this.dataBorrow.TabIndex = 1;
            // 
            // buttonBorrow
            // 
            this.buttonBorrow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBorrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(164)))), ((int)(((byte)(82)))));
            this.buttonBorrow.FlatAppearance.BorderSize = 0;
            this.buttonBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBorrow.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBorrow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(49)))), ((int)(((byte)(120)))));
            this.buttonBorrow.Location = new System.Drawing.Point(12, 600);
            this.buttonBorrow.Name = "buttonBorrow";
            this.buttonBorrow.Size = new System.Drawing.Size(199, 54);
            this.buttonBorrow.TabIndex = 5;
            this.buttonBorrow.Text = "Mượn";
            this.buttonBorrow.UseVisualStyleBackColor = false;
            this.buttonBorrow.Click += new System.EventHandler(this.buttonBorrow_Click);
            // 
            // txbSoThe
            // 
            this.txbSoThe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbSoThe.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSoThe.Location = new System.Drawing.Point(459, 118);
            this.txbSoThe.Name = "txbSoThe";
            this.txbSoThe.Size = new System.Drawing.Size(389, 30);
            this.txbSoThe.TabIndex = 6;
            this.txbSoThe.TextChanged += new System.EventHandler(this.txbSoThe_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(49)))), ((int)(((byte)(120)))));
            this.label1.Location = new System.Drawing.Point(376, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Số Thẻ";
            // 
            // buttonGiveBack
            // 
            this.buttonGiveBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonGiveBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(164)))), ((int)(((byte)(82)))));
            this.buttonGiveBack.FlatAppearance.BorderSize = 0;
            this.buttonGiveBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGiveBack.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGiveBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(49)))), ((int)(((byte)(120)))));
            this.buttonGiveBack.Location = new System.Drawing.Point(852, 600);
            this.buttonGiveBack.Name = "buttonGiveBack";
            this.buttonGiveBack.Size = new System.Drawing.Size(121, 54);
            this.buttonGiveBack.TabIndex = 9;
            this.buttonGiveBack.Text = "Trả Sách";
            this.buttonGiveBack.UseVisualStyleBackColor = false;
            this.buttonGiveBack.Click += new System.EventHandler(this.buttonGiveBack_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(49)))), ((int)(((byte)(120)))));
            this.label3.Location = new System.Drawing.Point(8, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Danh sách mượn";
            // 
            // cb_DaTra
            // 
            this.cb_DaTra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_DaTra.AutoSize = true;
            this.cb_DaTra.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_DaTra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(49)))), ((int)(((byte)(120)))));
            this.cb_DaTra.Location = new System.Drawing.Point(867, 125);
            this.cb_DaTra.Name = "cb_DaTra";
            this.cb_DaTra.Size = new System.Drawing.Size(105, 27);
            this.cb_DaTra.TabIndex = 12;
            this.cb_DaTra.Text = "Chưa Trả";
            this.cb_DaTra.UseVisualStyleBackColor = true;
            this.cb_DaTra.CheckedChanged += new System.EventHandler(this.cb_DaTra_CheckedChanged);
            this.cb_DaTra.CheckStateChanged += new System.EventHandler(this.cb_DaTra_CheckStateChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(114)))), ((int)(((byte)(83)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(236)))), ((int)(((byte)(173)))));
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(985, 99);
            this.label5.TabIndex = 106;
            this.label5.Text = "Quản lý Mượn trả";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTongMuon
            // 
            this.lbTongMuon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTongMuon.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongMuon.Location = new System.Drawing.Point(233, 600);
            this.lbTongMuon.Name = "lbTongMuon";
            this.lbTongMuon.Size = new System.Drawing.Size(431, 54);
            this.lbTongMuon.TabIndex = 107;
            this.lbTongMuon.Text = "label2";
            this.lbTongMuon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCSV
            // 
            this.buttonCSV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(164)))), ((int)(((byte)(82)))));
            this.buttonCSV.FlatAppearance.BorderSize = 0;
            this.buttonCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCSV.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCSV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(49)))), ((int)(((byte)(120)))));
            this.buttonCSV.Location = new System.Drawing.Point(632, 600);
            this.buttonCSV.Name = "buttonCSV";
            this.buttonCSV.Size = new System.Drawing.Size(199, 54);
            this.buttonCSV.TabIndex = 108;
            this.buttonCSV.Text = "Xuất ra Excel";
            this.buttonCSV.UseVisualStyleBackColor = false;
            this.buttonCSV.Click += new System.EventHandler(this.buttonCSV_Click);
            // 
            // BorrowManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(236)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(985, 666);
            this.Controls.Add(this.buttonCSV);
            this.Controls.Add(this.lbTongMuon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_DaTra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonGiveBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbSoThe);
            this.Controls.Add(this.buttonBorrow);
            this.Controls.Add(this.dataBorrow);
            this.MaximizeBox = false;
            this.Name = "BorrowManage";
            this.Text = "BorrowManage";
            ((System.ComponentModel.ISupportInitialize)(this.dataBorrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataBorrow;
        private System.Windows.Forms.Button buttonBorrow;
        private System.Windows.Forms.TextBox txbSoThe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGiveBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cb_DaTra;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTongMuon;
        private System.Windows.Forms.Button buttonCSV;
    }
}