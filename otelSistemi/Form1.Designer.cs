namespace otelSistemi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kullaniciAditxt = new System.Windows.Forms.TextBox();
            this.sifretxt = new System.Windows.Forms.TextBox();
            this.girisbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.baglantibtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(550, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(600, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // kullaniciAditxt
            // 
            this.kullaniciAditxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.kullaniciAditxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciAditxt.Location = new System.Drawing.Point(833, 355);
            this.kullaniciAditxt.Name = "kullaniciAditxt";
            this.kullaniciAditxt.Size = new System.Drawing.Size(191, 32);
            this.kullaniciAditxt.TabIndex = 2;
            // 
            // sifretxt
            // 
            this.sifretxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sifretxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifretxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.sifretxt.Location = new System.Drawing.Point(833, 428);
            this.sifretxt.Name = "sifretxt";
            this.sifretxt.Size = new System.Drawing.Size(191, 35);
            this.sifretxt.TabIndex = 3;
            this.sifretxt.UseSystemPasswordChar = true;
            // 
            // girisbtn
            // 
            this.girisbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.girisbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisbtn.Location = new System.Drawing.Point(887, 546);
            this.girisbtn.Name = "girisbtn";
            this.girisbtn.Size = new System.Drawing.Size(103, 42);
            this.girisbtn.TabIndex = 4;
            this.girisbtn.Text = "Giriş";
            this.girisbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.girisbtn.UseVisualStyleBackColor = false;
            this.girisbtn.Click += new System.EventHandler(this.girisbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(157, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(703, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Huzur Rüzgarı Otel Yönetim Sistemine Hoşgeldiniz";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // baglantibtn
            // 
            this.baglantibtn.Location = new System.Drawing.Point(110, 235);
            this.baglantibtn.Name = "baglantibtn";
            this.baglantibtn.Size = new System.Drawing.Size(89, 35);
            this.baglantibtn.TabIndex = 6;
            this.baglantibtn.Text = "Bağlantı";
            this.baglantibtn.UseVisualStyleBackColor = true;
            this.baglantibtn.Click += new System.EventHandler(this.baglantibtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1162, 680);
            this.Controls.Add(this.baglantibtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.girisbtn);
            this.Controls.Add(this.sifretxt);
            this.Controls.Add(this.kullaniciAditxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "            Kullanıcı Girişi                   ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kullaniciAditxt;
        private System.Windows.Forms.TextBox sifretxt;
        private System.Windows.Forms.Button girisbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button baglantibtn;
    }
}

