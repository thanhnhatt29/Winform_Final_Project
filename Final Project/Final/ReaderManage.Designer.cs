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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReader)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewReader
            // 
            this.dataGridViewReader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReader.Location = new System.Drawing.Point(32, 31);
            this.dataGridViewReader.Name = "dataGridViewReader";
            this.dataGridViewReader.RowHeadersWidth = 51;
            this.dataGridViewReader.RowTemplate.Height = 24;
            this.dataGridViewReader.Size = new System.Drawing.Size(738, 246);
            this.dataGridViewReader.TabIndex = 0;
            this.dataGridViewReader.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewReader_MouseDoubleClick);
            // 
            // ReaderID
            // 
            this.ReaderID.Location = new System.Drawing.Point(144, 311);
            this.ReaderID.Name = "ReaderID";
            this.ReaderID.Size = new System.Drawing.Size(326, 22);
            this.ReaderID.TabIndex = 1;
            // 
            // ReaderName
            // 
            this.ReaderName.Location = new System.Drawing.Point(144, 351);
            this.ReaderName.Name = "ReaderName";
            this.ReaderName.Size = new System.Drawing.Size(326, 22);
            this.ReaderName.TabIndex = 2;
            this.ReaderName.TextChanged += new System.EventHandler(this.ReaderName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ma Doc gia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ten Doc gia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 442);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "So Dien thoai";
            // 
            // ReaderPhone
            // 
            this.ReaderPhone.Location = new System.Drawing.Point(144, 436);
            this.ReaderPhone.Name = "ReaderPhone";
            this.ReaderPhone.Size = new System.Drawing.Size(326, 22);
            this.ReaderPhone.TabIndex = 8;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(646, 397);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(121, 62);
            this.buttonFind.TabIndex = 12;
            this.buttonFind.Text = "Tim";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(504, 396);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(121, 62);
            this.buttonDel.TabIndex = 11;
            this.buttonDel.Text = "Xoa";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonEdit.Location = new System.Drawing.Point(504, 311);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(121, 62);
            this.buttonEdit.TabIndex = 10;
            this.buttonEdit.Text = "Sua";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(646, 311);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(121, 62);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Them";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dia Chi";
            // 
            // ReaderAdr
            // 
            this.ReaderAdr.Location = new System.Drawing.Point(144, 391);
            this.ReaderAdr.Name = "ReaderAdr";
            this.ReaderAdr.Size = new System.Drawing.Size(326, 22);
            this.ReaderAdr.TabIndex = 3;
            // 
            // buttonedit1
            // 
            this.buttonedit1.Location = new System.Drawing.Point(504, 311);
            this.buttonedit1.Name = "buttonedit1";
            this.buttonedit1.Size = new System.Drawing.Size(121, 62);
            this.buttonedit1.TabIndex = 14;
            this.buttonedit1.Text = "Sua";
            this.buttonedit1.UseVisualStyleBackColor = true;
            this.buttonedit1.Click += new System.EventHandler(this.buttonedit1_Click);
            // 
            // buttonUnFind
            // 
            this.buttonUnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonUnFind.Location = new System.Drawing.Point(646, 397);
            this.buttonUnFind.Name = "buttonUnFind";
            this.buttonUnFind.Size = new System.Drawing.Size(121, 62);
            this.buttonUnFind.TabIndex = 15;
            this.buttonUnFind.Text = "Tim";
            this.buttonUnFind.UseVisualStyleBackColor = false;
            this.buttonUnFind.Click += new System.EventHandler(this.buttonUnFind_Click);
            // 
            // ReaderManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 487);
            this.Controls.Add(this.buttonedit1);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
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
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.buttonUnFind);
            this.MaximizeBox = false;
            this.Name = "ReaderManage";
            this.Text = "ReaderManage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewReader;
        private System.Windows.Forms.TextBox ReaderID;
        private System.Windows.Forms.TextBox ReaderName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ReaderPhone;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ReaderAdr;
        private System.Windows.Forms.Button buttonedit1;
        private System.Windows.Forms.Button buttonUnFind;
    }
}