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
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCard)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textNote
            // 
            this.textNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textNote.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNote.Location = new System.Drawing.Point(808, 252);
            this.textNote.Name = "textNote";
            this.textNote.Size = new System.Drawing.Size(211, 30);
            this.textNote.TabIndex = 1;
            // 
            // dataGridCard
            // 
            this.dataGridCard.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dataGridCard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCard.Location = new System.Drawing.Point(30, 146);
            this.dataGridCard.Name = "dataGridCard";
            this.dataGridCard.RowHeadersWidth = 51;
            this.dataGridCard.RowTemplate.Height = 24;
            this.dataGridCard.Size = new System.Drawing.Size(701, 423);
            this.dataGridCard.TabIndex = 2;
            this.dataGridCard.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCard_CellClick);
            // 
            // ReaderBox
            // 
            this.ReaderBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReaderBox.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReaderBox.FormattingEnabled = true;
            this.ReaderBox.Location = new System.Drawing.Point(808, 172);
            this.ReaderBox.Name = "ReaderBox";
            this.ReaderBox.Size = new System.Drawing.Size(211, 31);
            this.ReaderBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(804, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã độc giả";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(804, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ghi chú";
            // 
            // Regis_card
            // 
            this.Regis_card.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Regis_card.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Regis_card.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regis_card.Location = new System.Drawing.Point(834, 352);
            this.Regis_card.Name = "Regis_card";
            this.Regis_card.Size = new System.Drawing.Size(142, 40);
            this.Regis_card.TabIndex = 6;
            this.Regis_card.Text = "Đăng ký";
            this.Regis_card.UseVisualStyleBackColor = false;
            this.Regis_card.Click += new System.EventHandler(this.Regis_card_Click);
            // 
            // Update_card
            // 
            this.Update_card.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Update_card.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Update_card.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_card.Location = new System.Drawing.Point(834, 438);
            this.Update_card.Name = "Update_card";
            this.Update_card.Size = new System.Drawing.Size(142, 40);
            this.Update_card.TabIndex = 7;
            this.Update_card.Text = "Gia hạn";
            this.Update_card.UseVisualStyleBackColor = false;
            this.Update_card.Click += new System.EventHandler(this.Update_card_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hươngDânToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1085, 28);
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
            this.đăngKyToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
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
            this.giaHanToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.giaHanToolStripMenuItem.Text = "Gia hạn";
            // 
            // chonTheCânGiaHanVaYêuCâuGiaHanToolStripMenuItem
            // 
            this.chonTheCânGiaHanVaYêuCâuGiaHanToolStripMenuItem.Name = "chonTheCânGiaHanVaYêuCâuGiaHanToolStripMenuItem";
            this.chonTheCânGiaHanVaYêuCâuGiaHanToolStripMenuItem.Size = new System.Drawing.Size(360, 26);
            this.chonTheCânGiaHanVaYêuCâuGiaHanToolStripMenuItem.Text = "Chọn thẻ cần gia hạn và yêu cầu gia hạn.";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.PaleGreen;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(0, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1085, 102);
            this.label3.TabIndex = 9;
            this.label3.Text = "Thẻ Thư Viện";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(49)))), ((int)(((byte)(120)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1075, 130);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 479);
            this.panel3.TabIndex = 112;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(49)))), ((int)(((byte)(120)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1075, 8);
            this.panel1.TabIndex = 113;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(49)))), ((int)(((byte)(120)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 138);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 471);
            this.panel4.TabIndex = 114;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(49)))), ((int)(((byte)(120)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(10, 601);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1065, 8);
            this.panel2.TabIndex = 115;
            // 
            // Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1085, 609);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
    }
}