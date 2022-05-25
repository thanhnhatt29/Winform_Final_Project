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
            ((System.ComponentModel.ISupportInitialize)(this.dataBorrow)).BeginInit();
            this.SuspendLayout();
            // 
            // dataBorrow
            // 
            this.dataBorrow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBorrow.Location = new System.Drawing.Point(12, 53);
            this.dataBorrow.Name = "dataBorrow";
            this.dataBorrow.RowHeadersWidth = 51;
            this.dataBorrow.RowTemplate.Height = 24;
            this.dataBorrow.Size = new System.Drawing.Size(961, 270);
            this.dataBorrow.TabIndex = 1;
            // 
            // buttonBorrow
            // 
            this.buttonBorrow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBorrow.Location = new System.Drawing.Point(12, 329);
            this.buttonBorrow.Name = "buttonBorrow";
            this.buttonBorrow.Size = new System.Drawing.Size(199, 54);
            this.buttonBorrow.TabIndex = 5;
            this.buttonBorrow.Text = "Mượn";
            this.buttonBorrow.UseVisualStyleBackColor = true;
            this.buttonBorrow.Click += new System.EventHandler(this.buttonBorrow_Click);
            // 
            // txbSoThe
            // 
            this.txbSoThe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbSoThe.Location = new System.Drawing.Point(472, 17);
            this.txbSoThe.Name = "txbSoThe";
            this.txbSoThe.Size = new System.Drawing.Size(389, 22);
            this.txbSoThe.TabIndex = 6;
            this.txbSoThe.TextChanged += new System.EventHandler(this.txbSoThe_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(403, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Số Thẻ";
            // 
            // buttonGiveBack
            // 
            this.buttonGiveBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonGiveBack.Location = new System.Drawing.Point(852, 329);
            this.buttonGiveBack.Name = "buttonGiveBack";
            this.buttonGiveBack.Size = new System.Drawing.Size(121, 54);
            this.buttonGiveBack.TabIndex = 9;
            this.buttonGiveBack.Text = "Trả Sách";
            this.buttonGiveBack.UseVisualStyleBackColor = true;
            this.buttonGiveBack.Click += new System.EventHandler(this.buttonGiveBack_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Danh sách mượn";
            // 
            // cb_DaTra
            // 
            this.cb_DaTra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_DaTra.AutoSize = true;
            this.cb_DaTra.Location = new System.Drawing.Point(879, 20);
            this.cb_DaTra.Name = "cb_DaTra";
            this.cb_DaTra.Size = new System.Drawing.Size(84, 20);
            this.cb_DaTra.TabIndex = 12;
            this.cb_DaTra.Text = "Chưa Trả";
            this.cb_DaTra.UseVisualStyleBackColor = true;
            this.cb_DaTra.CheckedChanged += new System.EventHandler(this.cb_DaTra_CheckedChanged);
            this.cb_DaTra.CheckStateChanged += new System.EventHandler(this.cb_DaTra_CheckStateChanged);
            // 
            // BorrowManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 399);
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
    }
}