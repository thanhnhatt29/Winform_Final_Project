namespace Final
{
    partial class Card
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
            this.textNote = new System.Windows.Forms.TextBox();
            this.dataGridCard = new System.Windows.Forms.DataGridView();
            this.ReaderBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Regis_card = new System.Windows.Forms.Button();
            this.Update_card = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hươngDânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngKyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nêuĐaLaThanhViênĐăngKyBinhThươngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nêuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giaHanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chonTheCânGiaHanVaYêuCâuGiaHanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCard)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textNote
            // 
            this.textNote.Location = new System.Drawing.Point(286, 257);
            this.textNote.Name = "textNote";
            this.textNote.Size = new System.Drawing.Size(319, 22);
            this.textNote.TabIndex = 1;
            // 
            // dataGridCard
            // 
            this.dataGridCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCard.Location = new System.Drawing.Point(21, 27);
            this.dataGridCard.Name = "dataGridCard";
            this.dataGridCard.RowHeadersWidth = 51;
            this.dataGridCard.RowTemplate.Height = 24;
            this.dataGridCard.Size = new System.Drawing.Size(721, 162);
            this.dataGridCard.TabIndex = 2;
            this.dataGridCard.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCard_CellClick);
            // 
            // ReaderBox
            // 
            this.ReaderBox.FormattingEnabled = true;
            this.ReaderBox.Location = new System.Drawing.Point(286, 209);
            this.ReaderBox.Name = "ReaderBox";
            this.ReaderBox.Size = new System.Drawing.Size(319, 24);
            this.ReaderBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã độc giả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ghi chú";
            // 
            // Regis_card
            // 
            this.Regis_card.Location = new System.Drawing.Point(325, 311);
            this.Regis_card.Name = "Regis_card";
            this.Regis_card.Size = new System.Drawing.Size(125, 40);
            this.Regis_card.TabIndex = 6;
            this.Regis_card.Text = "Đăng ký";
            this.Regis_card.UseVisualStyleBackColor = true;
            this.Regis_card.Click += new System.EventHandler(this.Regis_card_Click);
            // 
            // Update_card
            // 
            this.Update_card.Location = new System.Drawing.Point(325, 368);
            this.Update_card.Name = "Update_card";
            this.Update_card.Size = new System.Drawing.Size(125, 40);
            this.Update_card.TabIndex = 7;
            this.Update_card.Text = "Gia hạn";
            this.Update_card.UseVisualStyleBackColor = true;
            this.Update_card.Click += new System.EventHandler(this.Update_card_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hươngDânToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(763, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hươngDânToolStripMenuItem
            // 
            this.hươngDânToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngKyToolStripMenuItem,
            this.giaHanToolStripMenuItem});
            this.hươngDânToolStripMenuItem.Name = "hươngDânToolStripMenuItem";
            this.hươngDânToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.hươngDânToolStripMenuItem.Text = "Hướng dẫn";
            // 
            // đăngKyToolStripMenuItem
            // 
            this.đăngKyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nêuĐaLaThanhViênĐăngKyBinhThươngToolStripMenuItem,
            this.nêuToolStripMenuItem});
            this.đăngKyToolStripMenuItem.Name = "đăngKyToolStripMenuItem";
            this.đăngKyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đăngKyToolStripMenuItem.Text = "Đăng ký";
            // 
            // nêuĐaLaThanhViênĐăngKyBinhThươngToolStripMenuItem
            // 
            this.nêuĐaLaThanhViênĐăngKyBinhThươngToolStripMenuItem.Name = "nêuĐaLaThanhViênĐăngKyBinhThươngToolStripMenuItem";
            this.nêuĐaLaThanhViênĐăngKyBinhThươngToolStripMenuItem.Size = new System.Drawing.Size(570, 26);
            this.nêuĐaLaThanhViênĐăngKyBinhThươngToolStripMenuItem.Text = "Nếu đã là thành viên, đăng ký thẻ bình thường.";
            // 
            // nêuToolStripMenuItem
            // 
            this.nêuToolStripMenuItem.Name = "nêuToolStripMenuItem";
            this.nêuToolStripMenuItem.Size = new System.Drawing.Size(570, 26);
            this.nêuToolStripMenuItem.Text = "Nếu chưa là thành viên, xin hãy đăng ký thành viên trước khi đăng ký thẻ" +
    ".";
            // 
            // giaHanToolStripMenuItem
            // 
            this.giaHanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chonTheCânGiaHanVaYêuCâuGiaHanToolStripMenuItem});
            this.giaHanToolStripMenuItem.Name = "giaHanToolStripMenuItem";
            this.giaHanToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.giaHanToolStripMenuItem.Text = "Gia hạn";
            // 
            // chonTheCânGiaHanVaYêuCâuGiaHanToolStripMenuItem
            // 
            this.chonTheCânGiaHanVaYêuCâuGiaHanToolStripMenuItem.Name = "chonTheCânGiaHanVaYêuCâuGiaHanToolStripMenuItem";
            this.chonTheCânGiaHanVaYêuCâuGiaHanToolStripMenuItem.Size = new System.Drawing.Size(360, 26);
            this.chonTheCânGiaHanVaYêuCâuGiaHanToolStripMenuItem.Text = "Chọn thẻ cần gia hạn và yêu cầu gia hạn.";
            // 
            // Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 425);
            this.Controls.Add(this.Update_card);
            this.Controls.Add(this.Regis_card);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReaderBox);
            this.Controls.Add(this.dataGridCard);
            this.Controls.Add(this.textNote);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Card";
            this.Text = "Card";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCard)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textNote;
        private System.Windows.Forms.DataGridView dataGridCard;
        private System.Windows.Forms.ComboBox ReaderBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Regis_card;
        private System.Windows.Forms.Button Update_card;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hươngDânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngKyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nêuĐaLaThanhViênĐăngKyBinhThươngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nêuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giaHanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chonTheCânGiaHanVaYêuCâuGiaHanToolStripMenuItem;
    }
}