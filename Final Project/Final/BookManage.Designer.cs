
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
            this.text = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.TextBox();
            this.Genre = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BookName = new System.Windows.Forms.TextBox();
            this.dataGridBook = new System.Windows.Forms.DataGridView();
            this.BookID = new System.Windows.Forms.TextBox();
            this.BookLocate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonDo = new System.Windows.Forms.Button();
            this.Author = new System.Windows.Forms.ComboBox();
            this.buttonShow = new System.Windows.Forms.Button();
            this.AuthorName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Function = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hươngDânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cacChưcNăngChinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sưaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiênThiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hươngDânChungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sưDungCacPhimChưcNăngĐêTuyChinhChêĐôToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sưDungPhimHanhĐôngTiênHanhĐêThưcHiênChưcNăngPhimHuyĐêThoatChưcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBook)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Navy;
            this.buttonAdd.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.Lime;
            this.buttonAdd.Location = new System.Drawing.Point(326, 496);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(121, 54);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Navy;
            this.buttonEdit.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.ForeColor = System.Drawing.Color.Lime;
            this.buttonEdit.Location = new System.Drawing.Point(600, 496);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(121, 54);
            this.buttonEdit.TabIndex = 5;
            this.buttonEdit.Text = "Sửa";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.Navy;
            this.buttonDel.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDel.ForeColor = System.Drawing.Color.Lime;
            this.buttonDel.Location = new System.Drawing.Point(463, 496);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(121, 54);
            this.buttonDel.TabIndex = 6;
            this.buttonDel.Text = "Xoá";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonFind
            // 
            this.buttonFind.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonFind.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFind.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.buttonFind.Location = new System.Drawing.Point(523, 561);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(121, 54);
            this.buttonFind.TabIndex = 7;
            this.buttonFind.Text = "Tìm";
            this.buttonFind.UseVisualStyleBackColor = false;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Location = new System.Drawing.Point(377, 351);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(60, 16);
            this.text.TabIndex = 17;
            this.text.Text = "Số lượng";
            // 
            // Amount
            // 
            this.Amount.Location = new System.Drawing.Point(478, 345);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(211, 22);
            this.Amount.TabIndex = 16;
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
            this.Genre.Location = new System.Drawing.Point(95, 443);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(234, 24);
            this.Genre.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 450);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Thể loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(726, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tác giả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tên Sách";
            // 
            // BookName
            // 
            this.BookName.Location = new System.Drawing.Point(95, 396);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(234, 22);
            this.BookName.TabIndex = 10;
            // 
            // dataGridBook
            // 
            this.dataGridBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBook.Location = new System.Drawing.Point(12, 116);
            this.dataGridBook.Name = "dataGridBook";
            this.dataGridBook.RowHeadersWidth = 51;
            this.dataGridBook.RowTemplate.Height = 24;
            this.dataGridBook.Size = new System.Drawing.Size(1036, 195);
            this.dataGridBook.TabIndex = 9;
            this.dataGridBook.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBook_CellDoubleClick);
            // 
            // BookID
            // 
            this.BookID.Location = new System.Drawing.Point(95, 345);
            this.BookID.Name = "BookID";
            this.BookID.Size = new System.Drawing.Size(234, 22);
            this.BookID.TabIndex = 18;
            // 
            // BookLocate
            // 
            this.BookLocate.Location = new System.Drawing.Point(478, 392);
            this.BookLocate.Name = "BookLocate";
            this.BookLocate.Size = new System.Drawing.Size(211, 22);
            this.BookLocate.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Mã Sách";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(377, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Vị trí";
            // 
            // Year
            // 
            this.Year.Location = new System.Drawing.Point(478, 440);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(211, 22);
            this.Year.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(377, 445);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Năm xuất bản";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCancel.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(606, 621);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(150, 72);
            this.buttonCancel.TabIndex = 25;
            this.buttonCancel.Text = "Huỷ";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonDo
            // 
            this.buttonDo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDo.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDo.Location = new System.Drawing.Point(434, 621);
            this.buttonDo.Name = "buttonDo";
            this.buttonDo.Size = new System.Drawing.Size(150, 72);
            this.buttonDo.TabIndex = 26;
            this.buttonDo.Text = "Tiến hành";
            this.buttonDo.UseVisualStyleBackColor = false;
            this.buttonDo.Click += new System.EventHandler(this.buttonDo_Click);
            // 
            // Author
            // 
            this.Author.FormattingEnabled = true;
            this.Author.Location = new System.Drawing.Point(813, 343);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(234, 24);
            this.Author.TabIndex = 27;
            // 
            // buttonShow
            // 
            this.buttonShow.BackColor = System.Drawing.Color.Navy;
            this.buttonShow.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShow.ForeColor = System.Drawing.Color.Lime;
            this.buttonShow.Location = new System.Drawing.Point(739, 493);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(121, 54);
            this.buttonShow.TabIndex = 28;
            this.buttonShow.Text = "Hiển thị";
            this.buttonShow.UseVisualStyleBackColor = false;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // AuthorName
            // 
            this.AuthorName.Location = new System.Drawing.Point(814, 399);
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.Size = new System.Drawing.Size(234, 22);
            this.AuthorName.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(726, 404);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Tên Tác Giả";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Function
            // 
            this.Function.Location = new System.Drawing.Point(527, 317);
            this.Function.Name = "Function";
            this.Function.Size = new System.Drawing.Size(116, 23);
            this.Function.TabIndex = 31;
            this.Function.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hươngDânToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1188, 30);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hươngDânToolStripMenuItem
            // 
            this.hươngDânToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cacChưcNăngChinhToolStripMenuItem,
            this.hươngDânChungToolStripMenuItem});
            this.hươngDânToolStripMenuItem.Name = "hươngDânToolStripMenuItem";
            this.hươngDânToolStripMenuItem.Size = new System.Drawing.Size(98, 26);
            this.hươngDânToolStripMenuItem.Text = "Hướng dẫn";
            // 
            // cacChưcNăngChinhToolStripMenuItem
            // 
            this.cacChưcNăngChinhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.xoaToolStripMenuItem,
            this.sưaToolStripMenuItem,
            this.hiênThiToolStripMenuItem,
            this.timToolStripMenuItem});
            this.cacChưcNăngChinhToolStripMenuItem.Name = "cacChưcNăngChinhToolStripMenuItem";
            this.cacChưcNăngChinhToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.cacChưcNăngChinhToolStripMenuItem.Text = "Các chức năng chính";
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.thêmToolStripMenuItem.Text = "Thêm";
            // 
            // xoaToolStripMenuItem
            // 
            this.xoaToolStripMenuItem.Name = "xoaToolStripMenuItem";
            this.xoaToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.xoaToolStripMenuItem.Text = "Xóa";
            // 
            // sưaToolStripMenuItem
            // 
            this.sưaToolStripMenuItem.Name = "sưaToolStripMenuItem";
            this.sưaToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.sưaToolStripMenuItem.Text = "Sửa";
            // 
            // hiênThiToolStripMenuItem
            // 
            this.hiênThiToolStripMenuItem.Name = "hiênThiToolStripMenuItem";
            this.hiênThiToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.hiênThiToolStripMenuItem.Text = "Hiển thị";
            // 
            // timToolStripMenuItem
            // 
            this.timToolStripMenuItem.Name = "timToolStripMenuItem";
            this.timToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.timToolStripMenuItem.Text = "Tìm";
            // 
            // hươngDânChungToolStripMenuItem
            // 
            this.hươngDânChungToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sưDungCacPhimChưcNăngĐêTuyChinhChêĐôToolStripMenuItem,
            this.sưDungPhimHanhĐôngTiênHanhĐêThưcHiênChưcNăngPhimHuyĐêThoatChưcNăngToolStripMenuItem});
            this.hươngDânChungToolStripMenuItem.Name = "hươngDânChungToolStripMenuItem";
            this.hươngDânChungToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.hươngDânChungToolStripMenuItem.Text = "Hướng dẫn chung";
            this.hươngDânChungToolStripMenuItem.Click += new System.EventHandler(this.hươngDânChungToolStripMenuItem_Click);
            // 
            // sưDungCacPhimChưcNăngĐêTuyChinhChêĐôToolStripMenuItem
            // 
            this.sưDungCacPhimChưcNăngĐêTuyChinhChêĐôToolStripMenuItem.Name = "sưDungCacPhimChưcNăngĐêTuyChinhChêĐôToolStripMenuItem";
            this.sưDungCacPhimChưcNăngĐêTuyChinhChêĐôToolStripMenuItem.Size = new System.Drawing.Size(712, 26);
            this.sưDungCacPhimChưcNăngĐêTuyChinhChêĐôToolStripMenuItem.Text = "Sử dụng các phím chức năng để tùy chỉnh chế độ";
            // 
            // sưDungPhimHanhĐôngTiênHanhĐêThưcHiênChưcNăngPhimHuyĐêThoatChưcNăngToolStripMenuItem
            // 
            this.sưDungPhimHanhĐôngTiênHanhĐêThưcHiênChưcNăngPhimHuyĐêThoatChưcNăngToolStripMenuItem.Name = "sưDungPhimHanhĐôngTiênHanhĐêThưcHiênChưcNăngPhimHuyĐêThoatChưcNăngToolStripMenuIt" +
    "em";
            this.sưDungPhimHanhĐôngTiênHanhĐêThưcHiênChưcNăngPhimHuyĐêThoatChưcNăngToolStripMenuItem.Size = new System.Drawing.Size(712, 26);
            this.sưDungPhimHanhĐôngTiênHanhĐêThưcHiênChưcNăngPhimHuyĐêThoatChưcNăngToolStripMenuItem.Text = "Sử dụng phím hành động \"Tiến hành\" để thực hiện chức năng. Phím \"Hủy" +
    "\" để thoát chức năng";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Final.Properties.Resources._718323;
            this.pictureBox2.Location = new System.Drawing.Point(538, 643);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pictureBox1.Image = global::Final.Properties.Resources._954591;
            this.pictureBox1.Location = new System.Drawing.Point(600, 574);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox3.Image = global::Final.Properties.Resources._4442016;
            this.pictureBox3.Location = new System.Drawing.Point(704, 643);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.PaleGreen;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1188, 85);
            this.label8.TabIndex = 36;
            this.label8.Text = "Quản lý Sách";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BookManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1188, 743);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.BookName);
            this.Controls.Add(this.BookID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Function);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AuthorName);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.buttonDo);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BookLocate);
            this.Controls.Add(this.text);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridBook);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "BookManage";
            this.Text = "BookManage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBook)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.TextBox Amount;
        private System.Windows.Forms.ComboBox Genre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BookName;
        private System.Windows.Forms.DataGridView dataGridBook;
        private System.Windows.Forms.TextBox BookID;
        private System.Windows.Forms.TextBox BookLocate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Year;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonDo;
        private System.Windows.Forms.ComboBox Author;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.TextBox AuthorName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Function;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hươngDânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cacChưcNăngChinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sưaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hiênThiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hươngDânChungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sưDungCacPhimChưcNăngĐêTuyChinhChêĐôToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sưDungPhimHanhĐôngTiênHanhĐêThưcHiênChưcNăngPhimHuyĐêThoatChưcNăngToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label8;
    }
}