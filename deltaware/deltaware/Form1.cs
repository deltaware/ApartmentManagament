using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deltaware
{
    public partial class Form1 : Form
    {
        public string selectedButtonName = "Anasayfa";
        public bool check = false;
        public int timer = 0;
        public Form1()
        {
            InitializeComponent();
            anasayfaGroupBox.Visible = true;
            yonetimGroupBox.Visible = false;
        }

        private void panelClick(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            string buttonName = label.Text;
            switch (buttonName)
            {
                case "Anasayfa":
                    anasayfaButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
                    unSelectedButton(yonetimButton);
                    unSelectedButton(aidatButton);
                    unSelectedButton(giderButton);
                    anasayfaGroupBox.Visible = true;
                    yonetimGroupBox.Visible = false;
                    break;
                case "Yönetim":
                    yonetimButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
                    unSelectedButton(anasayfaButton);
                    unSelectedButton(aidatButton);
                    unSelectedButton(giderButton);
                    anasayfaGroupBox.Visible = false;
                    yonetimGroupBox.Visible = true;
                    break;
                case "Aidatlar":
                    aidatButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
                    unSelectedButton(yonetimButton);
                    unSelectedButton(anasayfaButton);
                    unSelectedButton(giderButton);
                    anasayfaGroupBox.Visible = false;
                    yonetimGroupBox.Visible = false;
                    break;
                case "Giderler":
                    giderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
                    unSelectedButton(yonetimButton);
                    unSelectedButton(anasayfaButton);
                    unSelectedButton(aidatButton);
                    anasayfaGroupBox.Visible = false;
                    yonetimGroupBox.Visible = false;
                    break;
                case "Çıkış":
                    exit();
                    break;
                default:
                    break;
            }
            selectedButtonName = buttonName;

        }

        private void panelMouseEnter(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            if (selectedButtonName.Equals(label.Text))
            {
                label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(152)))), ((int)(((byte)(187)))));
            }else
            {
                label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(199)))), ((int)(((byte)(212)))));
            }
        }

        private void panelMouseLeave(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            if (selectedButtonName.Equals(label.Text))
            {
                label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
            }else
            {
                label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(128)))), ((int)(((byte)(140)))));
            }
        }

        public void unSelectedButton(Label label)
        {
            label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(128)))), ((int)(((byte)(140)))));
        }

        public void exit()
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Çıkış yapılsın mı?", "Deltaware Projects - Apartman Yönetim Sistemi", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }
        }

        private void clickYonetimListChangeButtons(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            if (!check)
            {
                switch (pictureBox.Name)
                {
                    case "AddButtonYonetim":
                        if (!adSoyadListYonetim.Items.Contains(adSoyadTextBoxYonetim.Text) && !katBilgisiListYonetim.Items.Contains(katVerisiTextBoxYonetim.Text) &&
                            adSoyadTextBoxYonetim.Text != "" && katVerisiTextBoxYonetim.Text != "" && aidatBilgisiTextBoxYonetim.Text != "" &&
                            adSoyadTextBoxYonetim.Text != "Ad Soyad" && katVerisiTextBoxYonetim.Text != "Kat Bilgisi" && aidatBilgisiTextBoxYonetim.Text != "Aidat Bilgisi")
                        {
                            adSoyadListYonetim.Items.Add(adSoyadTextBoxYonetim.Text);
                            katBilgisiListYonetim.Items.Add(katVerisiTextBoxYonetim.Text);
                            aidatBedeliListYonetim.Items.Add(aidatBilgisiTextBoxYonetim.Text);
                            if (ozelNotBilgisiTextBoxYonetim.Text == "" || ozelNotBilgisiTextBoxYonetim.Text == "Özel Not")
                                ozelNotBilgisiList.Items.Add("-");
                            else
                                ozelNotBilgisiList.Items.Add(ozelNotBilgisiTextBoxYonetim.Text);
                            clearTextBox();
                            notification(2);
                        }else if (adSoyadListYonetim.Items.Contains(adSoyadTextBoxYonetim.Text))
                        {
                            int id = 0;
                            for (int i = 0; i < adSoyadListYonetim.Items.Count; i++)
                            {
                                if (adSoyadListYonetim.Items[i].Equals(adSoyadTextBoxYonetim.Text)) {
                                    id = i;
                                }
                            }
                            adSoyadListYonetim.Items[id] = adSoyadTextBoxYonetim.Text;
                            if (!katBilgisiListYonetim.Items.Contains(katVerisiTextBoxYonetim.Text))
                            {
                                katBilgisiListYonetim.Items[id] = katVerisiTextBoxYonetim.Text;
                            }
                            else
                            {
                                SystemSounds.Beep.Play();
                                notification(6);
                            }
                            aidatBedeliListYonetim.Items[id] = aidatBilgisiTextBoxYonetim.Text;
                            ozelNotBilgisiList.Items[id] = ozelNotBilgisiTextBoxYonetim.Text;
                        }else if (katBilgisiListYonetim.Items.Contains(katVerisiTextBoxYonetim.Text)) {
                            SystemSounds.Beep.Play();
                            notification(6);
                        }else if (adSoyadListYonetim.Items.Contains(adSoyadTextBoxYonetim.Text)){
                            SystemSounds.Beep.Play();
                            notification(7);
                        }
                        else
                        {
                            SystemSounds.Beep.Play();
                            notification(1);
                        }
                        break;
                    case "RemoveButtonYonetim":
                        if (adSoyadListYonetim.SelectedItem != null)
                        {
                            int id = adSoyadListYonetim.SelectedIndex;
                            adSoyadListYonetim.Items.RemoveAt(id);
                            katBilgisiListYonetim.Items.RemoveAt(id);
                            aidatBedeliListYonetim.Items.RemoveAt(id);
                            ozelNotBilgisiList.Items.RemoveAt(id);
                            notification(3);
                        }else
                        {
                            SystemSounds.Beep.Play();
                            notification(4);
                        }
                        break;
                    case "ChangeButtonYonetim":
                        if (adSoyadListYonetim.SelectedItem != null)
                        {
                            int id = adSoyadListYonetim.SelectedIndex;
                            adSoyadTextBoxYonetim.Text = adSoyadListYonetim.Items[id].ToString();
                            katVerisiTextBoxYonetim.Text = katBilgisiListYonetim.Items[id].ToString();
                            aidatBilgisiTextBoxYonetim.Text = aidatBedeliListYonetim.Items[id].ToString();
                            ozelNotBilgisiTextBoxYonetim.Text = ozelNotBilgisiList.Items[id].ToString();
                            notification(5);
                        }else
                        {
                            SystemSounds.Beep.Play();
                            notification(4);
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        public void clearTextBox()
        {
            adSoyadTextBoxYonetim.Text = "";
            katVerisiTextBoxYonetim.Text = "";
            aidatBilgisiTextBoxYonetim.Text = "";
            ozelNotBilgisiTextBoxYonetim.Text = "";
        }

        private void yonetimTextBoxClick(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "Ad Soyad")
            {
                textBox.Text = "";
            }else if (textBox.Text == "Kat Bilgisi")
            {
                textBox.Text = "";
            }else if (textBox.Text == "Aidat Bilgisi")
            {
                textBox.Text = "";
            }else if (textBox.Text == "Özel Not")
            {
                textBox.Text = "";
            }
            else
            {
                textBox.Text = textBox.Text;
            }
        }

        private void yonetimTextBoxEnter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            switch (textBox.Name)
            {
                case "adSoyadTextBoxYonetim":
                    adSoyadBGYonetim.Image = global::deltaware.Properties.Resources.selectedTextBox;
                    textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
                    textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((246)))), ((int)(((247)))), ((int)(((251)))));
                    break;
                case "katVerisiTextBoxYonetim":
                    katVerisiBGYonetim.Image = global::deltaware.Properties.Resources.selectedTextBox;
                    textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
                    textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((246)))), ((int)(((247)))), ((int)(((251)))));
                    break;
                case "aidatBilgisiTextBoxYonetim":
                    aidatBilgisiBGYonetim.Image = global::deltaware.Properties.Resources.selectedTextBox;
                    textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
                    textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((246)))), ((int)(((247)))), ((int)(((251)))));
                    break;
                case "ozelNotBilgisiTextBoxYonetim":
                     ozelNotBilgisiBGYonetim.Image = global::deltaware.Properties.Resources.selectedTextBox;
                    textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
                    textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((246)))), ((int)(((247)))), ((int)(((251)))));
                    break;
                default:
                    break;
            }
        }

        private void yonetimTextBoxLeave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            switch (textBox.Name)
            {
                case "adSoyadTextBoxYonetim":
                    adSoyadBGYonetim.Image = global::deltaware.Properties.Resources.unselectedTextBox;
                    textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((246)))), ((int)(((247)))), ((int)(((251)))));
                    textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
                    if (!IsAlpha(textBox.Text) && textBox.Text != "" && textBox.Text != "Ad Soyad")
                    {
                        SystemSounds.Hand.Play();
                        check = true;
                        notification(0);
                        textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
                    }else
                    {
                        textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
                        check = false;
                        clearNotification();
                    }
                    break;
                case "katVerisiTextBoxYonetim":
                    katVerisiBGYonetim.Image = global::deltaware.Properties.Resources.unselectedTextBox;
                    textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((246)))), ((int)(((247)))), ((int)(((251)))));
                    textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
                    if (!IsAlphaNumeric(textBox.Text) && textBox.Text != "" && textBox.Text != "Kat Bilgisi")
                    {
                        SystemSounds.Hand.Play();
                        textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
                        check = true;
                        notification(0);
                    }
                    else
                    {
                        textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
                        check = false;
                        clearNotification();
                    }
                    break;
                case "aidatBilgisiTextBoxYonetim":
                    aidatBilgisiBGYonetim.Image = global::deltaware.Properties.Resources.unselectedTextBox;
                    textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((246)))), ((int)(((247)))), ((int)(((251)))));
                    textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
                    if (!IsNumeric(textBox.Text) && textBox.Text != "" && textBox.Text != "Aidat Bilgisi")
                    {
                        SystemSounds.Hand.Play();
                        textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
                        check = true;
                        notification(0);
                    }
                    else
                    {
                        textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
                        check = false;
                        clearNotification();
                    }
                    break;
                case "ozelNotBilgisiTextBoxYonetim":
                    ozelNotBilgisiBGYonetim.Image = global::deltaware.Properties.Resources.unselectedTextBox;
                    textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((246)))), ((int)(((247)))), ((int)(((251)))));
                    textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
                    break;
                default:
                    break;
            }
        }
        public void notification(int id)
        {
            string message = "";
            switch (id)
            {
                case 0:
                    message = "Girilen verilerde hata bulunmaktadır.";
                    notificationYonetim.ForeColor = System.Drawing.Color.FromArgb(198, 45, 45);
                    break;
                case 1:
                    message = "Boş veya geçersiz bir veri girişi yapılmaya çalışıldı.";
                    notificationYonetim.ForeColor = System.Drawing.Color.FromArgb(198, 45, 45);
                    break;
                case 2:
                    message = "Başarılı bir şekilde veri oluşturuldu.";
                    notificationYonetim.ForeColor = System.Drawing.Color.FromArgb(80, 198, 45);
                    break;
                case 3:
                    message = "Başarılı bir şekilde veri silindi.";
                    notificationYonetim.ForeColor = System.Drawing.Color.FromArgb(80, 198, 45);
                    break;
                case 4:
                    message = "Lütfen sağdaki veri liste bölümünden silmek istediğiniz Ad Soyad'ı seçin.";
                    notificationYonetim.ForeColor = System.Drawing.Color.FromArgb(198, 45, 45);
                    break;
                case 5:
                    message = "Veriler yazı kutularına çekildi. **Ad Soyad verisi değişirse yeni kullanıcı atanır.**";
                    notificationYonetim.ForeColor = System.Drawing.Color.FromArgb(80, 198, 45);
                    break;
                case 6:
                    message = "Böyle bir kat bilgisi bulunmaktadır.";
                    notificationYonetim.ForeColor = System.Drawing.Color.FromArgb(198, 45, 45);
                    break;
                case 7:
                    message = "Böyle bir Ad Soyad bilgisi bulunmaktadır.";
                    notificationYonetim.ForeColor = System.Drawing.Color.FromArgb(198, 45, 45);
                    break;
                default:
                    break;
            }
            if (timer < 1500)
            {
                notificationTimer.Start();
                notificationYonetim.Text = message;
            }else
            {
                notificationTimer.Stop();
                clearNotification();
            }
        }

        public void clearNotification()
        {
            notificationYonetim.Text = "";
        }
        private void textChangedTextBoxYonetim(object sender, EventArgs e)
        {

        }
        public bool IsAlpha(string input)
        {
            return Regex.IsMatch(input.Replace(" ", ""), "^[a-zA-Z]+$");
        }

        public bool IsAlphaNumeric(string input)
        {
            return Regex.IsMatch(input, "^[a-zA-Z0-9]+$");
        }
        public bool IsNumeric(string input)
        {
            return Regex.IsMatch(input, "^[0-9]+$");
        }
        public bool IsAlphaNumericWithUnderscore(string input)
        {
            return Regex.IsMatch(input, "^[a-zA-Z0-9_]+$");
        }

        private void notificationTimer_Tick(object sender, EventArgs e)
        {
            timer++;
        }
    }
}
