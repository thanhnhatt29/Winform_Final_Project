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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCard)).BeginInit();
            this.SuspendLayout();
            // 
            // textNote
            // 
            this.textNote.Location = new System.Drawing.Point(150, 248);
            this.textNote.Name = "textNote";
            this.textNote.Size = new System.Drawing.Size(319, 22);
            this.textNote.TabIndex = 1;
            // 
            // dataGridCard
            // 
            this.dataGridCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCard.Location = new System.Drawing.Point(21, 12);
            this.dataGridCard.Name = "dataGridCard";
            this.dataGridCard.RowHeadersWidth = 51;
            this.dataGridCard.RowTemplate.Height = 24;
            this.dataGridCard.Size = new System.Drawing.Size(448, 162);
            this.dataGridCard.TabIndex = 2;
            // 
            // ReaderBox
            // 
            this.ReaderBox.FormattingEnabled = true;
            this.ReaderBox.Location = new System.Drawing.Point(150, 200);
            this.ReaderBox.Name = "ReaderBox";
            this.ReaderBox.Size = new System.Drawing.Size(319, 24);
            this.ReaderBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID Doc gia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ghi chu";
            // 
            // Regis_card
            // 
            this.Regis_card.Location = new System.Drawing.Point(184, 304);
            this.Regis_card.Name = "Regis_card";
            this.Regis_card.Size = new System.Drawing.Size(125, 40);
            this.Regis_card.TabIndex = 6;
            this.Regis_card.Text = "Dang ky";
            this.Regis_card.UseVisualStyleBackColor = true;
            this.Regis_card.Click += new System.EventHandler(this.Regis_card_Click);
            // 
            // Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 371);
            this.Controls.Add(this.Regis_card);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReaderBox);
            this.Controls.Add(this.dataGridCard);
            this.Controls.Add(this.textNote);
            this.Name = "Card";
            this.Text = "Card";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCard)).EndInit();
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
    }
}