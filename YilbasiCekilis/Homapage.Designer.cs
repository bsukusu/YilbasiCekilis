namespace YilbasiCekilis
{
    partial class Homapage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homapage));
            this.NoelpictureBox = new System.Windows.Forms.PictureBox();
            this.isimlabel = new System.Windows.Forms.Label();
            this.isimlercomboBox = new System.Windows.Forms.ComboBox();
            this.isimcekbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NoelpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NoelpictureBox
            // 
            this.NoelpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("NoelpictureBox.Image")));
            this.NoelpictureBox.Location = new System.Drawing.Point(181, 21);
            this.NoelpictureBox.Name = "NoelpictureBox";
            this.NoelpictureBox.Size = new System.Drawing.Size(111, 84);
            this.NoelpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NoelpictureBox.TabIndex = 0;
            this.NoelpictureBox.TabStop = false;
            this.NoelpictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // isimlabel
            // 
            this.isimlabel.AutoSize = true;
            this.isimlabel.Location = new System.Drawing.Point(62, 161);
            this.isimlabel.Name = "isimlabel";
            this.isimlabel.Size = new System.Drawing.Size(44, 13);
            this.isimlabel.TabIndex = 1;
            this.isimlabel.Text = "İsminiz: ";
            // 
            // isimlercomboBox
            // 
            this.isimlercomboBox.FormattingEnabled = true;
            this.isimlercomboBox.Location = new System.Drawing.Point(181, 153);
            this.isimlercomboBox.Name = "isimlercomboBox";
            this.isimlercomboBox.Size = new System.Drawing.Size(97, 21);
            this.isimlercomboBox.TabIndex = 2;
            // 
            // isimcekbutton
            // 
            this.isimcekbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("isimcekbutton.BackgroundImage")));
            this.isimcekbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.isimcekbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.isimcekbutton.Location = new System.Drawing.Point(115, 204);
            this.isimcekbutton.Name = "isimcekbutton";
            this.isimcekbutton.Size = new System.Drawing.Size(105, 92);
            this.isimcekbutton.TabIndex = 3;
            this.isimcekbutton.Text = "Çekilişi Yap";
            this.isimcekbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.isimcekbutton.UseVisualStyleBackColor = true;
            this.isimcekbutton.Click += new System.EventHandler(this.isimcekbutton_Click);
            // 
            // Homapage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.isimcekbutton);
            this.Controls.Add(this.isimlercomboBox);
            this.Controls.Add(this.isimlabel);
            this.Controls.Add(this.NoelpictureBox);
            this.Name = "Homapage";
            this.Text = "Yılbaşı Çekilişi";
            this.Load += new System.EventHandler(this.Homapage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NoelpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox NoelpictureBox;
        private System.Windows.Forms.Label isimlabel;
        private System.Windows.Forms.ComboBox isimlercomboBox;
        private System.Windows.Forms.Button isimcekbutton;
    }
}

