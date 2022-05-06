namespace Final
{
    partial class ReaderAdd
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
            this.Phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IDCard = new System.Windows.Forms.TextBox();
            this.ReaderName = new System.Windows.Forms.TextBox();
            this.ReaderID = new System.Windows.Forms.TextBox();
            this.buttonAddR = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(169, 236);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(411, 22);
            this.Phone.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "So Dien thoai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "CMND";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ten Doc gia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ma Doc gia";
            // 
            // IDCard
            // 
            this.IDCard.Location = new System.Drawing.Point(169, 191);
            this.IDCard.Name = "IDCard";
            this.IDCard.Size = new System.Drawing.Size(411, 22);
            this.IDCard.TabIndex = 11;
            // 
            // ReaderName
            // 
            this.ReaderName.Location = new System.Drawing.Point(169, 151);
            this.ReaderName.Name = "ReaderName";
            this.ReaderName.Size = new System.Drawing.Size(411, 22);
            this.ReaderName.TabIndex = 10;
            // 
            // ReaderID
            // 
            this.ReaderID.Location = new System.Drawing.Point(169, 111);
            this.ReaderID.Name = "ReaderID";
            this.ReaderID.Size = new System.Drawing.Size(411, 22);
            this.ReaderID.TabIndex = 9;
            // 
            // buttonAddR
            // 
            this.buttonAddR.Location = new System.Drawing.Point(259, 285);
            this.buttonAddR.Name = "buttonAddR";
            this.buttonAddR.Size = new System.Drawing.Size(149, 31);
            this.buttonAddR.TabIndex = 17;
            this.buttonAddR.Text = "Them";
            this.buttonAddR.UseVisualStyleBackColor = true;
            this.buttonAddR.Click += new System.EventHandler(this.buttonAddR_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(242, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 45);
            this.label5.TabIndex = 18;
            this.label5.Text = "Thêm Độc giả";
            // 
            // ReaderAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 361);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonAddR);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDCard);
            this.Controls.Add(this.ReaderName);
            this.Controls.Add(this.ReaderID);
            this.Name = "ReaderAdd";
            this.Text = "ReaderAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDCard;
        private System.Windows.Forms.TextBox ReaderName;
        private System.Windows.Forms.TextBox ReaderID;
        private System.Windows.Forms.Button buttonAddR;
        private System.Windows.Forms.Label label5;
    }
}