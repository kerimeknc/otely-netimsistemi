namespace otelSistemi
{
    partial class MüşteriListe
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listeleBtn = new System.Windows.Forms.Button();
            this.silBtn = new System.Windows.Forms.Button();
            this.araBtn = new System.Windows.Forms.Button();
            this.musteriidLbl = new System.Windows.Forms.Label();
            this.musteriidTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.araTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 27);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1400, 367);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 57;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ad";
            this.columnHeader2.Width = 139;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyad";
            this.columnHeader3.Width = 157;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telefon";
            this.columnHeader4.Width = 145;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mail";
            this.columnHeader5.Width = 171;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "TC";
            this.columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Oda";
            this.columnHeader7.Width = 165;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "G.Tarih";
            this.columnHeader8.Width = 164;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Ç.Tarih";
            this.columnHeader9.Width = 176;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Ücret";
            // 
            // listeleBtn
            // 
            this.listeleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listeleBtn.Location = new System.Drawing.Point(1303, 409);
            this.listeleBtn.Name = "listeleBtn";
            this.listeleBtn.Size = new System.Drawing.Size(109, 47);
            this.listeleBtn.TabIndex = 1;
            this.listeleBtn.Text = "Listele";
            this.listeleBtn.UseVisualStyleBackColor = true;
            this.listeleBtn.Click += new System.EventHandler(this.listeleBtn_Click);
            // 
            // silBtn
            // 
            this.silBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silBtn.Location = new System.Drawing.Point(113, 126);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(144, 47);
            this.silBtn.TabIndex = 3;
            this.silBtn.Text = "Sil";
            this.silBtn.UseVisualStyleBackColor = true;
            this.silBtn.Click += new System.EventHandler(this.silBtn_Click);
            // 
            // araBtn
            // 
            this.araBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.araBtn.Location = new System.Drawing.Point(851, 506);
            this.araBtn.Name = "araBtn";
            this.araBtn.Size = new System.Drawing.Size(109, 47);
            this.araBtn.TabIndex = 4;
            this.araBtn.Text = "Ara";
            this.araBtn.UseVisualStyleBackColor = true;
            this.araBtn.Click += new System.EventHandler(this.araBtn_Click);
            // 
            // musteriidLbl
            // 
            this.musteriidLbl.AutoSize = true;
            this.musteriidLbl.BackColor = System.Drawing.Color.White;
            this.musteriidLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteriidLbl.Location = new System.Drawing.Point(6, 64);
            this.musteriidLbl.Name = "musteriidLbl";
            this.musteriidLbl.Size = new System.Drawing.Size(138, 29);
            this.musteriidLbl.TabIndex = 5;
            this.musteriidLbl.Text = "Müşteri ID:";
            // 
            // musteriidTxt
            // 
            this.musteriidTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteriidTxt.Location = new System.Drawing.Point(193, 64);
            this.musteriidTxt.Name = "musteriidTxt";
            this.musteriidTxt.Size = new System.Drawing.Size(117, 35);
            this.musteriidTxt.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.silBtn);
            this.groupBox1.Controls.Add(this.musteriidLbl);
            this.groupBox1.Controls.Add(this.musteriidTxt);
            this.groupBox1.Location = new System.Drawing.Point(85, 442);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 211);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SİL";
            // 
            // araTextBox
            // 
            this.araTextBox.Location = new System.Drawing.Point(1005, 514);
            this.araTextBox.Name = "araTextBox";
            this.araTextBox.Size = new System.Drawing.Size(183, 26);
            this.araTextBox.TabIndex = 8;
            // 
            // MüşteriListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1424, 1015);
            this.Controls.Add(this.araTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.araBtn);
            this.Controls.Add(this.listeleBtn);
            this.Controls.Add(this.listView1);
            this.Name = "MüşteriListe";
            this.Text = "MüşteriListe";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button listeleBtn;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button silBtn;
        private System.Windows.Forms.Button araBtn;
        private System.Windows.Forms.Label musteriidLbl;
        private System.Windows.Forms.TextBox musteriidTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox araTextBox;
    }
}