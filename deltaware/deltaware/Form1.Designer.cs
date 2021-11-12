namespace deltaware
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
            this.anasayfaButton = new System.Windows.Forms.Label();
            this.yonetimButton = new System.Windows.Forms.Label();
            this.aidatButton = new System.Windows.Forms.Label();
            this.giderButton = new System.Windows.Forms.Label();
            this.cikisButton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // anasayfaButton
            // 
            this.anasayfaButton.AutoSize = true;
            this.anasayfaButton.BackColor = System.Drawing.Color.White;
            this.anasayfaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anasayfaButton.Font = new System.Drawing.Font("Nunito Sans", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anasayfaButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.anasayfaButton.Location = new System.Drawing.Point(137, 27);
            this.anasayfaButton.Name = "anasayfaButton";
            this.anasayfaButton.Size = new System.Drawing.Size(138, 40);
            this.anasayfaButton.TabIndex = 0;
            this.anasayfaButton.Text = "Anasayfa";
            this.anasayfaButton.Click += new System.EventHandler(this.panelClick);
            this.anasayfaButton.MouseEnter += new System.EventHandler(this.panelMouseEnter);
            this.anasayfaButton.MouseLeave += new System.EventHandler(this.panelMouseLeave);
            // 
            // yonetimButton
            // 
            this.yonetimButton.AutoSize = true;
            this.yonetimButton.BackColor = System.Drawing.Color.White;
            this.yonetimButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yonetimButton.Font = new System.Drawing.Font("Nunito Sans", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yonetimButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(128)))), ((int)(((byte)(140)))));
            this.yonetimButton.Location = new System.Drawing.Point(297, 27);
            this.yonetimButton.Name = "yonetimButton";
            this.yonetimButton.Size = new System.Drawing.Size(122, 40);
            this.yonetimButton.TabIndex = 1;
            this.yonetimButton.Text = "Yönetim";
            this.yonetimButton.Click += new System.EventHandler(this.panelClick);
            this.yonetimButton.MouseEnter += new System.EventHandler(this.panelMouseEnter);
            this.yonetimButton.MouseLeave += new System.EventHandler(this.panelMouseLeave);
            // 
            // aidatButton
            // 
            this.aidatButton.AutoSize = true;
            this.aidatButton.BackColor = System.Drawing.Color.White;
            this.aidatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aidatButton.Font = new System.Drawing.Font("Nunito Sans", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aidatButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(128)))), ((int)(((byte)(140)))));
            this.aidatButton.Location = new System.Drawing.Point(456, 27);
            this.aidatButton.Name = "aidatButton";
            this.aidatButton.Size = new System.Drawing.Size(123, 40);
            this.aidatButton.TabIndex = 2;
            this.aidatButton.Text = "Aidatlar";
            this.aidatButton.Click += new System.EventHandler(this.panelClick);
            this.aidatButton.MouseEnter += new System.EventHandler(this.panelMouseEnter);
            this.aidatButton.MouseLeave += new System.EventHandler(this.panelMouseLeave);
            // 
            // giderButton
            // 
            this.giderButton.AutoSize = true;
            this.giderButton.BackColor = System.Drawing.Color.White;
            this.giderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.giderButton.Font = new System.Drawing.Font("Nunito Sans", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(128)))), ((int)(((byte)(140)))));
            this.giderButton.Location = new System.Drawing.Point(605, 27);
            this.giderButton.Name = "giderButton";
            this.giderButton.Size = new System.Drawing.Size(123, 40);
            this.giderButton.TabIndex = 3;
            this.giderButton.Text = "Giderler";
            this.giderButton.Click += new System.EventHandler(this.panelClick);
            this.giderButton.MouseEnter += new System.EventHandler(this.panelMouseEnter);
            this.giderButton.MouseLeave += new System.EventHandler(this.panelMouseLeave);
            // 
            // cikisButton
            // 
            this.cikisButton.AutoSize = true;
            this.cikisButton.BackColor = System.Drawing.Color.White;
            this.cikisButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikisButton.Font = new System.Drawing.Font("Nunito Sans", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(128)))), ((int)(((byte)(140)))));
            this.cikisButton.Location = new System.Drawing.Point(754, 27);
            this.cikisButton.Name = "cikisButton";
            this.cikisButton.Size = new System.Drawing.Size(79, 40);
            this.cikisButton.TabIndex = 4;
            this.cikisButton.Text = "Çıkış";
            this.cikisButton.Click += new System.EventHandler(this.panelClick);
            this.cikisButton.MouseEnter += new System.EventHandler(this.panelMouseEnter);
            this.cikisButton.MouseLeave += new System.EventHandler(this.panelMouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::deltaware.Properties.Resources.resizedMain1;
            this.ClientSize = new System.Drawing.Size(1026, 668);
            this.Controls.Add(this.cikisButton);
            this.Controls.Add(this.giderButton);
            this.Controls.Add(this.aidatButton);
            this.Controls.Add(this.yonetimButton);
            this.Controls.Add(this.anasayfaButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "vv";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label anasayfaButton;
        private System.Windows.Forms.Label yonetimButton;
        private System.Windows.Forms.Label aidatButton;
        private System.Windows.Forms.Label giderButton;
        private System.Windows.Forms.Label cikisButton;
    }
}

