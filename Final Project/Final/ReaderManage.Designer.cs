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
            this.IDCard = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.TextBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
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
            this.dataGridViewReader.Size = new System.Drawing.Size(523, 246);
            this.dataGridViewReader.TabIndex = 0;
            // 
            // ReaderID
            // 
            this.ReaderID.Location = new System.Drawing.Point(144, 311);
            this.ReaderID.Name = "ReaderID";
            this.ReaderID.Size = new System.Drawing.Size(411, 22);
            this.ReaderID.TabIndex = 1;
            // 
            // ReaderName
            // 
            this.ReaderName.Location = new System.Drawing.Point(144, 351);
            this.ReaderName.Name = "ReaderName";
            this.ReaderName.Size = new System.Drawing.Size(411, 22);
            this.ReaderName.TabIndex = 2;
            // 
            // IDCard
            // 
            this.IDCard.Location = new System.Drawing.Point(144, 391);
            this.IDCard.Name = "IDCard";
            this.IDCard.Size = new System.Drawing.Size(411, 22);
            this.IDCard.TabIndex = 3;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "CMND";
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
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(144, 436);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(411, 22);
            this.Phone.TabIndex = 8;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(586, 303);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(121, 54);
            this.buttonFind.TabIndex = 12;
            this.buttonFind.Text = "Tim";
            this.buttonFind.UseVisualStyleBackColor = true;
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(586, 223);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(121, 54);
            this.buttonDel.TabIndex = 11;
            this.buttonDel.Text = "Xoa";
            this.buttonDel.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(586, 123);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(121, 54);
            this.buttonEdit.TabIndex = 10;
            this.buttonEdit.Text = "Sua";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(586, 31);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(121, 54);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Them";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // ReaderManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 486);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDCard);
            this.Controls.Add(this.ReaderName);
            this.Controls.Add(this.ReaderID);
            this.Controls.Add(this.dataGridViewReader);
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
        private System.Windows.Forms.TextBox IDCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
    }
}