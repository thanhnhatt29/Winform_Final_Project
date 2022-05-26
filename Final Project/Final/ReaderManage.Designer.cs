namespace Final
{
    partial class ReaderManage
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
            this.dataGridViewReader = new System.Windows.Forms.DataGridView();
            this.ReaderID = new System.Windows.Forms.TextBox();
            this.ReaderName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ReaderPhone = new System.Windows.Forms.TextBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ReaderAdr = new System.Windows.Forms.TextBox();
            this.buttonedit1 = new System.Windows.Forms.Button();
            this.buttonUnFind = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewReader
            // 
            this.dataGridViewReader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReader.Location = new System.Drawing.Point(34, 126);
            this.dataGridViewReader.Name = "dataGridViewReader";
            this.dataGridViewReader.RowHeadersWidth = 51;
            this.dataGridViewReader.RowTemplate.Height = 24;
            this.dataGridViewReader.Size = new System.Drawing.Size(604, 527);
            this.dataGridViewReader.TabIndex = 0;
            this.dataGridViewReader.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewReader_MouseDoubleClick);
            // 
            // ReaderID
            // 
            this.ReaderID.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReaderID.Location = new System.Drawing.Point(669, 153);
            this.ReaderID.Name = "ReaderID";
            this.ReaderID.Size = new System.Drawing.Size(328, 30);
            this.ReaderID.TabIndex = 1;
            // 
            // ReaderName
            // 
            this.ReaderName.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReaderName.Location = new System.Drawing.Point(669, 221);
            this.ReaderName.Name = "ReaderName";
            this.ReaderName.Size = new System.Drawing.Size(328, 30);
            this.ReaderName.TabIndex = 2;
            this.ReaderName.TextChanged += new System.EventHandler(this.ReaderName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(49)))), ((int)(((byte)(120)))));
            this.label1.Location = new System.Drawing.Point(665, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã Độc giả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(49)))), ((int)(((byte)(120)))));
            this.label2.Location = new System.Drawing.Point(665, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên Độc giả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(49)))), ((int)(((byte)(120)))));
            this.label4.Location = new System.Drawing.Point(665, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số Điện thoại";
            // 
            // ReaderPhone
            // 
            this.ReaderPhone.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReaderPhone.Location = new System.Drawing.Point(669, 357);
            this.ReaderPhone.Name = "ReaderPhone";
            this.ReaderPhone.Size = new System.Drawing.Size(328, 30);
            this.ReaderPhone.TabIndex = 8;
            // 
            // buttonFind
            // 
            this.buttonFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(164)))), ((int)(((byte)(82)))));
            this.buttonFind.FlatAppearance.BorderSize = 0;
            this.buttonFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFind.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(49)))), ((int)(((byte)(120)))));
            this.buttonFind.Location = new System.Drawing.Point(847, 585);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(150, 68);
            this.buttonFind.TabIndex = 12;
            this.buttonFind.Text = "Tìm";
            this.buttonFind.UseVisualStyleBackColor = false;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(164)))), ((int)(((byte)(82)))));
            this.buttonDel.FlatAppearance.BorderSize = 0;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(49)))), ((int)(((byte)(120)))));
            this.buttonDel.Location = new System.Drawing.Point(669, 584);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(155, 69);
            this.buttonDel.TabIndex = 11;
            this.buttonDel.Text = "Xoá";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(164)))), ((int)(((byte)(82)))));
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(49)))), ((int)(((byte)(120)))));
            this.buttonEdit.Location = new System.Drawing.Point(669, 491);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(155, 70);
            this.buttonEdit.TabIndex = 10;
            this.buttonEdit.Text = "Sửa";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(164)))), ((int)(((byte)(82)))));
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(49)))), ((int)(((byte)(120)))));
            this.buttonAdd.Location = new System.Drawing.Point(847, 491);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(150, 70);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(49)))), ((int)(((byte)(120)))));
            this.label3.Location = new System.Drawing.Point(665, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Địa Chỉ";
            // 
            // ReaderAdr
            // 
            this.ReaderAdr.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReaderAdr.Location = new System.Drawing.Point(669, 289);
            this.ReaderAdr.Name = "ReaderAdr";
            this.ReaderAdr.Size = new System.Drawing.Size(328, 30);
            this.ReaderAdr.TabIndex = 3;
            // 
            // buttonedit1
            // 
            this.buttonedit1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(164)))), ((int)(((byte)(82)))));
            this.buttonedit1.FlatAppearance.BorderSize = 0;
            this.buttonedit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonedit1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonedit1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(49)))), ((int)(((byte)(120)))));
            this.buttonedit1.Location = new System.Drawing.Point(669, 491);
            this.buttonedit1.Name = "buttonedit1";
            this.buttonedit1.Size = new System.Drawing.Size(155, 70);
            this.buttonedit1.TabIndex = 14;
            this.buttonedit1.Text = "Sửa";
            this.buttonedit1.UseVisualStyleBackColor = false;
            this.buttonedit1.Click += new System.EventHandler(this.buttonedit1_Click);
            // 
            // buttonUnFind
            // 
            this.buttonUnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(164)))), ((int)(((byte)(82)))));
            this.buttonUnFind.FlatAppearance.BorderSize = 0;
            this.buttonUnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUnFind.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUnFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(49)))), ((int)(((byte)(120)))));
            this.buttonUnFind.Location = new System.Drawing.Point(847, 584);
            this.buttonUnFind.Name = "buttonUnFind";
            this.buttonUnFind.Size = new System.Drawing.Size(150, 66);
            this.buttonUnFind.TabIndex = 15;
            this.buttonUnFind.Text = "Tìm";
            this.buttonUnFind.UseVisualStyleBackColor = false;
            this.buttonUnFind.Click += new System.EventHandler(this.buttonUnFind_Click);
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
            this.label5.Size = new System.Drawing.Size(1017, 99);
            this.label5.TabIndex = 105;
            this.label5.Text = "Quản lý Độc giả";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(164)))), ((int)(((byte)(82)))));
            this.pictureBox5.Image = global::Final.Properties.Resources.update;
            this.pictureBox5.Location = new System.Drawing.Point(679, 510);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(43, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 111;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(164)))), ((int)(((byte)(82)))));
            this.pictureBox4.Image = global::Final.Properties.Resources.add;
            this.pictureBox4.Location = new System.Drawing.Point(856, 510);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(27, 34);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 110;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(164)))), ((int)(((byte)(82)))));
            this.pictureBox3.Image = global::Final.Properties.Resources._4442016;
            this.pictureBox3.Location = new System.Drawing.Point(679, 602);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 109;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(164)))), ((int)(((byte)(82)))));
            this.pictureBox2.Image = global::Final.Properties.Resources._954591;
            this.pictureBox2.Location = new System.Drawing.Point(856, 602);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 108;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(114)))), ((int)(((byte)(83)))));
            this.pictureBox1.Image = global::Final.Properties.Resources.reader;
            this.pictureBox1.Location = new System.Drawing.Point(194, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 107;
            this.pictureBox1.TabStop = false;
            // 
            // ReaderManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(236)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(1017, 682);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.ReaderPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReaderAdr);
            this.Controls.Add(this.ReaderName);
            this.Controls.Add(this.ReaderID);
            this.Controls.Add(this.dataGridViewReader);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.buttonUnFind);
            this.Controls.Add(this.buttonedit1);
            this.Controls.Add(this.buttonEdit);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.Name = "ReaderManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ReaderManage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewReader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonedit1;
        private System.Windows.Forms.Button buttonUnFind;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox ReaderID;
        private System.Windows.Forms.TextBox ReaderName;
        private System.Windows.Forms.TextBox ReaderPhone;
        private System.Windows.Forms.TextBox ReaderAdr;
    }
}