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
            this.apartmanVerileriLabel = new System.Windows.Forms.Label();
            this.apartmanVerileriPicture = new System.Windows.Forms.PictureBox();
            this.kalanAidatlarPicture = new System.Windows.Forms.PictureBox();
            this.anasayfaGroupBox = new System.Windows.Forms.GroupBox();
            this.aidatlarLabel = new System.Windows.Forms.Label();
            this.yonetimGroupBox = new System.Windows.Forms.GroupBox();
            this.ozelNotBilgisiList = new System.Windows.Forms.ListBox();
            this.aidatBedeliListYonetim = new System.Windows.Forms.ListBox();
            this.katBilgisiListYonetim = new System.Windows.Forms.ListBox();
            this.adSoyadListYonetim = new System.Windows.Forms.ListBox();
            this.ChangeButtonYonetim = new System.Windows.Forms.PictureBox();
            this.RemoveButtonYonetim = new System.Windows.Forms.PictureBox();
            this.AddButtonYonetim = new System.Windows.Forms.PictureBox();
            this.veriListeleriGroup = new System.Windows.Forms.PictureBox();
            this.veriGirisiGroup = new System.Windows.Forms.PictureBox();
            this.veriListeleriLabel = new System.Windows.Forms.Label();
            this.veriGirisiLabel = new System.Windows.Forms.Label();
            this.ozelNotBilgisiBGYonetim = new System.Windows.Forms.PictureBox();
            this.aidatBilgisiBGYonetim = new System.Windows.Forms.PictureBox();
            this.katVerisiBGYonetim = new System.Windows.Forms.PictureBox();
            this.adSoyadBGYonetim = new System.Windows.Forms.PictureBox();
            this.ozelNotBilgisiTextBoxYonetim = new System.Windows.Forms.TextBox();
            this.aidatBilgisiTextBoxYonetim = new System.Windows.Forms.TextBox();
            this.katVerisiTextBoxYonetim = new System.Windows.Forms.TextBox();
            this.adSoyadTextBoxYonetim = new System.Windows.Forms.TextBox();
            this.notificationYonetim = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.apartmanVerileriPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalanAidatlarPicture)).BeginInit();
            this.anasayfaGroupBox.SuspendLayout();
            this.yonetimGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChangeButtonYonetim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveButtonYonetim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddButtonYonetim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veriListeleriGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veriGirisiGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ozelNotBilgisiBGYonetim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aidatBilgisiBGYonetim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.katVerisiBGYonetim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adSoyadBGYonetim)).BeginInit();
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
            // apartmanVerileriLabel
            // 
            this.apartmanVerileriLabel.AutoSize = true;
            this.apartmanVerileriLabel.Font = new System.Drawing.Font("Nunito Sans", 13F, System.Drawing.FontStyle.Bold);
            this.apartmanVerileriLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.apartmanVerileriLabel.Location = new System.Drawing.Point(127, 28);
            this.apartmanVerileriLabel.Name = "apartmanVerileriLabel";
            this.apartmanVerileriLabel.Size = new System.Drawing.Size(165, 26);
            this.apartmanVerileriLabel.TabIndex = 2;
            this.apartmanVerileriLabel.Text = "Apartman Verileri";
            this.apartmanVerileriLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // apartmanVerileriPicture
            // 
            this.apartmanVerileriPicture.Image = global::deltaware.Properties.Resources.groupMain;
            this.apartmanVerileriPicture.Location = new System.Drawing.Point(6, 57);
            this.apartmanVerileriPicture.Name = "apartmanVerileriPicture";
            this.apartmanVerileriPicture.Size = new System.Drawing.Size(439, 412);
            this.apartmanVerileriPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.apartmanVerileriPicture.TabIndex = 0;
            this.apartmanVerileriPicture.TabStop = false;
            // 
            // kalanAidatlarPicture
            // 
            this.kalanAidatlarPicture.Image = global::deltaware.Properties.Resources.groupMain;
            this.kalanAidatlarPicture.Location = new System.Drawing.Point(557, 57);
            this.kalanAidatlarPicture.Name = "kalanAidatlarPicture";
            this.kalanAidatlarPicture.Size = new System.Drawing.Size(439, 412);
            this.kalanAidatlarPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kalanAidatlarPicture.TabIndex = 1;
            this.kalanAidatlarPicture.TabStop = false;
            // 
            // anasayfaGroupBox
            // 
            this.anasayfaGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.anasayfaGroupBox.Controls.Add(this.aidatlarLabel);
            this.anasayfaGroupBox.Controls.Add(this.apartmanVerileriLabel);
            this.anasayfaGroupBox.Controls.Add(this.apartmanVerileriPicture);
            this.anasayfaGroupBox.Controls.Add(this.kalanAidatlarPicture);
            this.anasayfaGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anasayfaGroupBox.Location = new System.Drawing.Point(12, 127);
            this.anasayfaGroupBox.Name = "anasayfaGroupBox";
            this.anasayfaGroupBox.Size = new System.Drawing.Size(1002, 517);
            this.anasayfaGroupBox.TabIndex = 5;
            this.anasayfaGroupBox.TabStop = false;
            // 
            // aidatlarLabel
            // 
            this.aidatlarLabel.AutoSize = true;
            this.aidatlarLabel.Font = new System.Drawing.Font("Nunito Sans", 13F, System.Drawing.FontStyle.Bold);
            this.aidatlarLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.aidatlarLabel.Location = new System.Drawing.Point(740, 28);
            this.aidatlarLabel.Name = "aidatlarLabel";
            this.aidatlarLabel.Size = new System.Drawing.Size(81, 26);
            this.aidatlarLabel.TabIndex = 3;
            this.aidatlarLabel.Text = "Aidatlar";
            this.aidatlarLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // yonetimGroupBox
            // 
            this.yonetimGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.yonetimGroupBox.Controls.Add(this.notificationYonetim);
            this.yonetimGroupBox.Controls.Add(this.ozelNotBilgisiTextBoxYonetim);
            this.yonetimGroupBox.Controls.Add(this.aidatBilgisiTextBoxYonetim);
            this.yonetimGroupBox.Controls.Add(this.ozelNotBilgisiBGYonetim);
            this.yonetimGroupBox.Controls.Add(this.katVerisiTextBoxYonetim);
            this.yonetimGroupBox.Controls.Add(this.aidatBilgisiBGYonetim);
            this.yonetimGroupBox.Controls.Add(this.adSoyadTextBoxYonetim);
            this.yonetimGroupBox.Controls.Add(this.katVerisiBGYonetim);
            this.yonetimGroupBox.Controls.Add(this.adSoyadBGYonetim);
            this.yonetimGroupBox.Controls.Add(this.ozelNotBilgisiList);
            this.yonetimGroupBox.Controls.Add(this.aidatBedeliListYonetim);
            this.yonetimGroupBox.Controls.Add(this.katBilgisiListYonetim);
            this.yonetimGroupBox.Controls.Add(this.adSoyadListYonetim);
            this.yonetimGroupBox.Controls.Add(this.ChangeButtonYonetim);
            this.yonetimGroupBox.Controls.Add(this.RemoveButtonYonetim);
            this.yonetimGroupBox.Controls.Add(this.AddButtonYonetim);
            this.yonetimGroupBox.Controls.Add(this.veriListeleriGroup);
            this.yonetimGroupBox.Controls.Add(this.veriGirisiGroup);
            this.yonetimGroupBox.Controls.Add(this.veriListeleriLabel);
            this.yonetimGroupBox.Controls.Add(this.veriGirisiLabel);
            this.yonetimGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yonetimGroupBox.Location = new System.Drawing.Point(12, 127);
            this.yonetimGroupBox.Name = "yonetimGroupBox";
            this.yonetimGroupBox.Size = new System.Drawing.Size(1002, 517);
            this.yonetimGroupBox.TabIndex = 12;
            this.yonetimGroupBox.TabStop = false;
            // 
            // ozelNotBilgisiList
            // 
            this.ozelNotBilgisiList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.ozelNotBilgisiList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ozelNotBilgisiList.Cursor = System.Windows.Forms.Cursors.Cross;
            this.ozelNotBilgisiList.Font = new System.Drawing.Font("Nunito Sans", 8.999998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ozelNotBilgisiList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.ozelNotBilgisiList.FormatString = "C1";
            this.ozelNotBilgisiList.FormattingEnabled = true;
            this.ozelNotBilgisiList.ItemHeight = 17;
            this.ozelNotBilgisiList.Location = new System.Drawing.Point(871, 101);
            this.ozelNotBilgisiList.Name = "ozelNotBilgisiList";
            this.ozelNotBilgisiList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.ozelNotBilgisiList.Size = new System.Drawing.Size(85, 340);
            this.ozelNotBilgisiList.TabIndex = 16;
            // 
            // aidatBedeliListYonetim
            // 
            this.aidatBedeliListYonetim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.aidatBedeliListYonetim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aidatBedeliListYonetim.Cursor = System.Windows.Forms.Cursors.Cross;
            this.aidatBedeliListYonetim.Font = new System.Drawing.Font("Nunito Sans", 8.999998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aidatBedeliListYonetim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.aidatBedeliListYonetim.FormatString = "C1";
            this.aidatBedeliListYonetim.FormattingEnabled = true;
            this.aidatBedeliListYonetim.ItemHeight = 17;
            this.aidatBedeliListYonetim.Location = new System.Drawing.Point(807, 101);
            this.aidatBedeliListYonetim.Name = "aidatBedeliListYonetim";
            this.aidatBedeliListYonetim.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.aidatBedeliListYonetim.Size = new System.Drawing.Size(58, 340);
            this.aidatBedeliListYonetim.TabIndex = 15;
            // 
            // katBilgisiListYonetim
            // 
            this.katBilgisiListYonetim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.katBilgisiListYonetim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.katBilgisiListYonetim.Cursor = System.Windows.Forms.Cursors.Cross;
            this.katBilgisiListYonetim.Font = new System.Drawing.Font("Nunito Sans", 8.999998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.katBilgisiListYonetim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.katBilgisiListYonetim.FormattingEnabled = true;
            this.katBilgisiListYonetim.ItemHeight = 17;
            this.katBilgisiListYonetim.Location = new System.Drawing.Point(746, 101);
            this.katBilgisiListYonetim.Name = "katBilgisiListYonetim";
            this.katBilgisiListYonetim.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.katBilgisiListYonetim.Size = new System.Drawing.Size(55, 340);
            this.katBilgisiListYonetim.TabIndex = 14;
            // 
            // adSoyadListYonetim
            // 
            this.adSoyadListYonetim.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.adSoyadListYonetim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.adSoyadListYonetim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adSoyadListYonetim.Cursor = System.Windows.Forms.Cursors.Cross;
            this.adSoyadListYonetim.Font = new System.Drawing.Font("Nunito Sans", 8.999998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adSoyadListYonetim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.adSoyadListYonetim.FormattingEnabled = true;
            this.adSoyadListYonetim.ItemHeight = 17;
            this.adSoyadListYonetim.Location = new System.Drawing.Point(599, 101);
            this.adSoyadListYonetim.Name = "adSoyadListYonetim";
            this.adSoyadListYonetim.Size = new System.Drawing.Size(141, 340);
            this.adSoyadListYonetim.TabIndex = 13;
            // 
            // ChangeButtonYonetim
            // 
            this.ChangeButtonYonetim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeButtonYonetim.Image = global::deltaware.Properties.Resources.Change;
            this.ChangeButtonYonetim.Location = new System.Drawing.Point(362, 322);
            this.ChangeButtonYonetim.Name = "ChangeButtonYonetim";
            this.ChangeButtonYonetim.Size = new System.Drawing.Size(170, 82);
            this.ChangeButtonYonetim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ChangeButtonYonetim.TabIndex = 8;
            this.ChangeButtonYonetim.TabStop = false;
            this.ChangeButtonYonetim.Click += new System.EventHandler(this.clickYonetimListChangeButtons);
            // 
            // RemoveButtonYonetim
            // 
            this.RemoveButtonYonetim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveButtonYonetim.Image = global::deltaware.Properties.Resources.Remove;
            this.RemoveButtonYonetim.Location = new System.Drawing.Point(362, 234);
            this.RemoveButtonYonetim.Name = "RemoveButtonYonetim";
            this.RemoveButtonYonetim.Size = new System.Drawing.Size(170, 82);
            this.RemoveButtonYonetim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RemoveButtonYonetim.TabIndex = 7;
            this.RemoveButtonYonetim.TabStop = false;
            this.RemoveButtonYonetim.Click += new System.EventHandler(this.clickYonetimListChangeButtons);
            // 
            // AddButtonYonetim
            // 
            this.AddButtonYonetim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButtonYonetim.Image = global::deltaware.Properties.Resources.Add;
            this.AddButtonYonetim.Location = new System.Drawing.Point(362, 146);
            this.AddButtonYonetim.Name = "AddButtonYonetim";
            this.AddButtonYonetim.Size = new System.Drawing.Size(170, 82);
            this.AddButtonYonetim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddButtonYonetim.TabIndex = 6;
            this.AddButtonYonetim.TabStop = false;
            this.AddButtonYonetim.Click += new System.EventHandler(this.clickYonetimListChangeButtons);
            // 
            // veriListeleriGroup
            // 
            this.veriListeleriGroup.Image = global::deltaware.Properties.Resources.groupYonetim;
            this.veriListeleriGroup.Location = new System.Drawing.Point(556, 57);
            this.veriListeleriGroup.Name = "veriListeleriGroup";
            this.veriListeleriGroup.Size = new System.Drawing.Size(440, 425);
            this.veriListeleriGroup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.veriListeleriGroup.TabIndex = 5;
            this.veriListeleriGroup.TabStop = false;
            // 
            // veriGirisiGroup
            // 
            this.veriGirisiGroup.Image = global::deltaware.Properties.Resources.groupYonetim;
            this.veriGirisiGroup.Location = new System.Drawing.Point(6, 57);
            this.veriGirisiGroup.Name = "veriGirisiGroup";
            this.veriGirisiGroup.Size = new System.Drawing.Size(335, 425);
            this.veriGirisiGroup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.veriGirisiGroup.TabIndex = 4;
            this.veriGirisiGroup.TabStop = false;
            // 
            // veriListeleriLabel
            // 
            this.veriListeleriLabel.AutoSize = true;
            this.veriListeleriLabel.Font = new System.Drawing.Font("Nunito Sans", 13F, System.Drawing.FontStyle.Bold);
            this.veriListeleriLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.veriListeleriLabel.Location = new System.Drawing.Point(713, 28);
            this.veriListeleriLabel.Name = "veriListeleriLabel";
            this.veriListeleriLabel.Size = new System.Drawing.Size(120, 26);
            this.veriListeleriLabel.TabIndex = 3;
            this.veriListeleriLabel.Text = "Veri Listeleri";
            this.veriListeleriLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // veriGirisiLabel
            // 
            this.veriGirisiLabel.AutoSize = true;
            this.veriGirisiLabel.Font = new System.Drawing.Font("Nunito Sans", 13F, System.Drawing.FontStyle.Bold);
            this.veriGirisiLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.veriGirisiLabel.Location = new System.Drawing.Point(115, 28);
            this.veriGirisiLabel.Name = "veriGirisiLabel";
            this.veriGirisiLabel.Size = new System.Drawing.Size(95, 26);
            this.veriGirisiLabel.TabIndex = 2;
            this.veriGirisiLabel.Text = "Veri Girişi";
            this.veriGirisiLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ozelNotBilgisiBGYonetim
            // 
            this.ozelNotBilgisiBGYonetim.BackColor = System.Drawing.Color.White;
            this.ozelNotBilgisiBGYonetim.Image = global::deltaware.Properties.Resources.unselectedTextBox;
            this.ozelNotBilgisiBGYonetim.Location = new System.Drawing.Point(34, 358);
            this.ozelNotBilgisiBGYonetim.Name = "ozelNotBilgisiBGYonetim";
            this.ozelNotBilgisiBGYonetim.Size = new System.Drawing.Size(276, 85);
            this.ozelNotBilgisiBGYonetim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ozelNotBilgisiBGYonetim.TabIndex = 20;
            this.ozelNotBilgisiBGYonetim.TabStop = false;
            // 
            // aidatBilgisiBGYonetim
            // 
            this.aidatBilgisiBGYonetim.BackColor = System.Drawing.Color.White;
            this.aidatBilgisiBGYonetim.Image = global::deltaware.Properties.Resources.unselectedTextBox;
            this.aidatBilgisiBGYonetim.Location = new System.Drawing.Point(34, 267);
            this.aidatBilgisiBGYonetim.Name = "aidatBilgisiBGYonetim";
            this.aidatBilgisiBGYonetim.Size = new System.Drawing.Size(276, 85);
            this.aidatBilgisiBGYonetim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aidatBilgisiBGYonetim.TabIndex = 19;
            this.aidatBilgisiBGYonetim.TabStop = false;
            // 
            // katVerisiBGYonetim
            // 
            this.katVerisiBGYonetim.BackColor = System.Drawing.Color.White;
            this.katVerisiBGYonetim.Image = global::deltaware.Properties.Resources.unselectedTextBox;
            this.katVerisiBGYonetim.Location = new System.Drawing.Point(34, 176);
            this.katVerisiBGYonetim.Name = "katVerisiBGYonetim";
            this.katVerisiBGYonetim.Size = new System.Drawing.Size(276, 85);
            this.katVerisiBGYonetim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.katVerisiBGYonetim.TabIndex = 18;
            this.katVerisiBGYonetim.TabStop = false;
            // 
            // adSoyadBGYonetim
            // 
            this.adSoyadBGYonetim.BackColor = System.Drawing.Color.White;
            this.adSoyadBGYonetim.Image = global::deltaware.Properties.Resources.unselectedTextBox;
            this.adSoyadBGYonetim.Location = new System.Drawing.Point(34, 85);
            this.adSoyadBGYonetim.Name = "adSoyadBGYonetim";
            this.adSoyadBGYonetim.Size = new System.Drawing.Size(276, 85);
            this.adSoyadBGYonetim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.adSoyadBGYonetim.TabIndex = 17;
            this.adSoyadBGYonetim.TabStop = false;
            // 
            // ozelNotBilgisiTextBoxYonetim
            // 
            this.ozelNotBilgisiTextBoxYonetim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.ozelNotBilgisiTextBoxYonetim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ozelNotBilgisiTextBoxYonetim.Font = new System.Drawing.Font("Nunito Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ozelNotBilgisiTextBoxYonetim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.ozelNotBilgisiTextBoxYonetim.Location = new System.Drawing.Point(65, 378);
            this.ozelNotBilgisiTextBoxYonetim.Name = "ozelNotBilgisiTextBoxYonetim";
            this.ozelNotBilgisiTextBoxYonetim.Size = new System.Drawing.Size(227, 26);
            this.ozelNotBilgisiTextBoxYonetim.TabIndex = 24;
            this.ozelNotBilgisiTextBoxYonetim.Text = "Özel Not";
            this.ozelNotBilgisiTextBoxYonetim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ozelNotBilgisiTextBoxYonetim.Click += new System.EventHandler(this.yonetimTextBoxClick);
            this.ozelNotBilgisiTextBoxYonetim.TextChanged += new System.EventHandler(this.textChangedTextBoxYonetim);
            this.ozelNotBilgisiTextBoxYonetim.MouseEnter += new System.EventHandler(this.yonetimTextBoxEnter);
            this.ozelNotBilgisiTextBoxYonetim.MouseLeave += new System.EventHandler(this.yonetimTextBoxLeave);
            // 
            // aidatBilgisiTextBoxYonetim
            // 
            this.aidatBilgisiTextBoxYonetim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.aidatBilgisiTextBoxYonetim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aidatBilgisiTextBoxYonetim.Font = new System.Drawing.Font("Nunito Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aidatBilgisiTextBoxYonetim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.aidatBilgisiTextBoxYonetim.Location = new System.Drawing.Point(65, 289);
            this.aidatBilgisiTextBoxYonetim.Name = "aidatBilgisiTextBoxYonetim";
            this.aidatBilgisiTextBoxYonetim.Size = new System.Drawing.Size(227, 26);
            this.aidatBilgisiTextBoxYonetim.TabIndex = 23;
            this.aidatBilgisiTextBoxYonetim.Text = "Aidat Bilgisi";
            this.aidatBilgisiTextBoxYonetim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.aidatBilgisiTextBoxYonetim.Click += new System.EventHandler(this.yonetimTextBoxClick);
            this.aidatBilgisiTextBoxYonetim.TextChanged += new System.EventHandler(this.textChangedTextBoxYonetim);
            this.aidatBilgisiTextBoxYonetim.MouseEnter += new System.EventHandler(this.yonetimTextBoxEnter);
            this.aidatBilgisiTextBoxYonetim.MouseLeave += new System.EventHandler(this.yonetimTextBoxLeave);
            // 
            // katVerisiTextBoxYonetim
            // 
            this.katVerisiTextBoxYonetim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.katVerisiTextBoxYonetim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.katVerisiTextBoxYonetim.Font = new System.Drawing.Font("Nunito Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.katVerisiTextBoxYonetim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.katVerisiTextBoxYonetim.Location = new System.Drawing.Point(65, 201);
            this.katVerisiTextBoxYonetim.Name = "katVerisiTextBoxYonetim";
            this.katVerisiTextBoxYonetim.Size = new System.Drawing.Size(227, 26);
            this.katVerisiTextBoxYonetim.TabIndex = 22;
            this.katVerisiTextBoxYonetim.Text = "Kat Bilgisi";
            this.katVerisiTextBoxYonetim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.katVerisiTextBoxYonetim.Click += new System.EventHandler(this.yonetimTextBoxClick);
            this.katVerisiTextBoxYonetim.TextChanged += new System.EventHandler(this.textChangedTextBoxYonetim);
            this.katVerisiTextBoxYonetim.MouseEnter += new System.EventHandler(this.yonetimTextBoxEnter);
            this.katVerisiTextBoxYonetim.MouseLeave += new System.EventHandler(this.yonetimTextBoxLeave);
            // 
            // adSoyadTextBoxYonetim
            // 
            this.adSoyadTextBoxYonetim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.adSoyadTextBoxYonetim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adSoyadTextBoxYonetim.Font = new System.Drawing.Font("Nunito Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adSoyadTextBoxYonetim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            this.adSoyadTextBoxYonetim.Location = new System.Drawing.Point(65, 108);
            this.adSoyadTextBoxYonetim.Name = "adSoyadTextBoxYonetim";
            this.adSoyadTextBoxYonetim.Size = new System.Drawing.Size(227, 26);
            this.adSoyadTextBoxYonetim.TabIndex = 21;
            this.adSoyadTextBoxYonetim.Text = "Ad Soyad";
            this.adSoyadTextBoxYonetim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.adSoyadTextBoxYonetim.Click += new System.EventHandler(this.yonetimTextBoxClick);
            this.adSoyadTextBoxYonetim.TextChanged += new System.EventHandler(this.textChangedTextBoxYonetim);
            this.adSoyadTextBoxYonetim.MouseEnter += new System.EventHandler(this.yonetimTextBoxEnter);
            this.adSoyadTextBoxYonetim.MouseLeave += new System.EventHandler(this.yonetimTextBoxLeave);
            // 
            // notificationYonetim
            // 
            this.notificationYonetim.AutoSize = true;
            this.notificationYonetim.Font = new System.Drawing.Font("Nunito Sans", 13F, System.Drawing.FontStyle.Bold);
            this.notificationYonetim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.notificationYonetim.Location = new System.Drawing.Point(6, 488);
            this.notificationYonetim.Name = "notificationYonetim";
            this.notificationYonetim.Size = new System.Drawing.Size(0, 26);
            this.notificationYonetim.TabIndex = 25;
            this.notificationYonetim.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::deltaware.Properties.Resources.resizedBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1026, 668);
            this.Controls.Add(this.yonetimGroupBox);
            this.Controls.Add(this.anasayfaGroupBox);
            this.Controls.Add(this.cikisButton);
            this.Controls.Add(this.giderButton);
            this.Controls.Add(this.aidatButton);
            this.Controls.Add(this.yonetimButton);
            this.Controls.Add(this.anasayfaButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "vv";
            ((System.ComponentModel.ISupportInitialize)(this.apartmanVerileriPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalanAidatlarPicture)).EndInit();
            this.anasayfaGroupBox.ResumeLayout(false);
            this.anasayfaGroupBox.PerformLayout();
            this.yonetimGroupBox.ResumeLayout(false);
            this.yonetimGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChangeButtonYonetim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveButtonYonetim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddButtonYonetim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veriListeleriGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veriGirisiGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ozelNotBilgisiBGYonetim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aidatBilgisiBGYonetim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.katVerisiBGYonetim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adSoyadBGYonetim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label anasayfaButton;
        private System.Windows.Forms.Label yonetimButton;
        private System.Windows.Forms.Label aidatButton;
        private System.Windows.Forms.Label giderButton;
        private System.Windows.Forms.Label cikisButton;
        private System.Windows.Forms.Label apartmanVerileriLabel;
        private System.Windows.Forms.PictureBox apartmanVerileriPicture;
        private System.Windows.Forms.PictureBox kalanAidatlarPicture;
        private System.Windows.Forms.GroupBox anasayfaGroupBox;
        private System.Windows.Forms.Label aidatlarLabel;
        private System.Windows.Forms.GroupBox yonetimGroupBox;
        private System.Windows.Forms.PictureBox ChangeButtonYonetim;
        private System.Windows.Forms.PictureBox RemoveButtonYonetim;
        private System.Windows.Forms.PictureBox AddButtonYonetim;
        private System.Windows.Forms.PictureBox veriListeleriGroup;
        private System.Windows.Forms.PictureBox veriGirisiGroup;
        private System.Windows.Forms.Label veriListeleriLabel;
        private System.Windows.Forms.Label veriGirisiLabel;
        private System.Windows.Forms.ListBox ozelNotBilgisiList;
        private System.Windows.Forms.ListBox aidatBedeliListYonetim;
        private System.Windows.Forms.ListBox katBilgisiListYonetim;
        private System.Windows.Forms.ListBox adSoyadListYonetim;
        private System.Windows.Forms.PictureBox ozelNotBilgisiBGYonetim;
        private System.Windows.Forms.PictureBox aidatBilgisiBGYonetim;
        private System.Windows.Forms.PictureBox katVerisiBGYonetim;
        private System.Windows.Forms.PictureBox adSoyadBGYonetim;
        private System.Windows.Forms.TextBox ozelNotBilgisiTextBoxYonetim;
        private System.Windows.Forms.TextBox aidatBilgisiTextBoxYonetim;
        private System.Windows.Forms.TextBox katVerisiTextBoxYonetim;
        private System.Windows.Forms.TextBox adSoyadTextBoxYonetim;
        private System.Windows.Forms.Label notificationYonetim;

        //

    }
}

