
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBook)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(323, 407);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(121, 54);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(597, 407);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(121, 54);
            this.buttonEdit.TabIndex = 5;
            this.buttonEdit.Text = "Sửa";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(460, 407);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(121, 54);
            this.buttonDel.TabIndex = 6;
            this.buttonDel.Text = "Xoá";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(520, 472);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(121, 54);
            this.buttonFind.TabIndex = 7;
            this.buttonFind.Text = "Tìm";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Location = new System.Drawing.Point(392, 263);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(60, 16);
            this.text.TabIndex = 17;
            this.text.Text = "Số lượng";
            // 
            // Amount
            // 
            this.Amount.Location = new System.Drawing.Point(493, 257);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(260, 22);
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
            this.Genre.Location = new System.Drawing.Point(92, 354);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(283, 24);
            this.Genre.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Thể loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(775, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tác giả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tên Sách";
            // 
            // BookName
            // 
            this.BookName.Location = new System.Drawing.Point(92, 307);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(283, 22);
            this.BookName.TabIndex = 10;
            // 
            // dataGridBook
            // 
            this.dataGridBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBook.Location = new System.Drawing.Point(30, 27);
            this.dataGridBook.Name = "dataGridBook";
            this.dataGridBook.RowHeadersWidth = 51;
            this.dataGridBook.RowTemplate.Height = 24;
            this.dataGridBook.Size = new System.Drawing.Size(1115, 195);
            this.dataGridBook.TabIndex = 9;
            this.dataGridBook.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBook_CellDoubleClick);
            // 
            // BookID
            // 
            this.BookID.Location = new System.Drawing.Point(92, 256);
            this.BookID.Name = "BookID";
            this.BookID.Size = new System.Drawing.Size(283, 22);
            this.BookID.TabIndex = 18;
            // 
            // BookLocate
            // 
            this.BookLocate.Location = new System.Drawing.Point(493, 304);
            this.BookLocate.Name = "BookLocate";
            this.BookLocate.Size = new System.Drawing.Size(260, 22);
            this.BookLocate.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Mã Sách";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(392, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Vị trí";
            // 
            // Year
            // 
            this.Year.Location = new System.Drawing.Point(493, 352);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(260, 22);
            this.Year.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(392, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Năm xuất bản";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCancel.Location = new System.Drawing.Point(590, 532);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(121, 54);
            this.buttonCancel.TabIndex = 25;
            this.buttonCancel.Text = "Huỷ";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonDo
            // 
            this.buttonDo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDo.Location = new System.Drawing.Point(463, 532);
            this.buttonDo.Name = "buttonDo";
            this.buttonDo.Size = new System.Drawing.Size(121, 54);
            this.buttonDo.TabIndex = 26;
            this.buttonDo.Text = "Tiến hành";
            this.buttonDo.UseVisualStyleBackColor = false;
            this.buttonDo.Click += new System.EventHandler(this.buttonDo_Click);
            // 
            // Author
            // 
            this.Author.FormattingEnabled = true;
            this.Author.Location = new System.Drawing.Point(862, 249);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(283, 24);
            this.Author.TabIndex = 27;
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(736, 404);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(121, 54);
            this.buttonShow.TabIndex = 28;
            this.buttonShow.Text = "Hiển thị";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // AuthorName
            // 
            this.AuthorName.Location = new System.Drawing.Point(863, 305);
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.Size = new System.Drawing.Size(283, 22);
            this.AuthorName.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(775, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Tên Tác Giả";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Function
            // 
            this.Function.Location = new System.Drawing.Point(557, 228);
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
            this.menuStrip1.Size = new System.Drawing.Size(1188, 28);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hươngDânToolStripMenuItem
            // 
            this.hươngDânToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cacChưcNăngChinhToolStripMenuItem,
            this.hươngDânChungToolStripMenuItem});
            this.hươngDânToolStripMenuItem.Name = "hươngDânToolStripMenuItem";
            this.hươngDânToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
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
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thêmToolStripMenuItem.Text = "Thêm";
            // 
            // xoaToolStripMenuItem
            // 
            this.xoaToolStripMenuItem.Name = "xoaToolStripMenuItem";
            this.xoaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.xoaToolStripMenuItem.Text = "Xóa";
            // 
            // sưaToolStripMenuItem
            // 
            this.sưaToolStripMenuItem.Name = "sưaToolStripMenuItem";
            this.sưaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sưaToolStripMenuItem.Text = "Sửa";
            // 
            // hiênThiToolStripMenuItem
            // 
            this.hiênThiToolStripMenuItem.Name = "hiênThiToolStripMenuItem";
            this.hiênThiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.hiênThiToolStripMenuItem.Text = "Hiển thị";
            // 
            // timToolStripMenuItem
            // 
            this.timToolStripMenuItem.Name = "timToolStripMenuItem";
            this.timToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
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
            // BookManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1188, 613);
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
            this.Controls.Add(this.BookID);
            this.Controls.Add(this.text);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BookName);
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
    }
}