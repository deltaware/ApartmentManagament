using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deltaware
{
    public partial class Form1 : Form
    {
        public string selectedButtonName = "Anasayfa";
        public Form1()
        {
            InitializeComponent();
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
                    break;
                case "Yönetim":
                    yonetimButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
                    unSelectedButton(anasayfaButton);
                    unSelectedButton(aidatButton);
                    unSelectedButton(giderButton);
                    break;
                case "Aidatlar":
                    aidatButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
                    unSelectedButton(yonetimButton);
                    unSelectedButton(anasayfaButton);
                    unSelectedButton(giderButton);
                    break;
                case "Giderler":
                    giderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(133)))), ((int)(((byte)(198)))));
                    unSelectedButton(yonetimButton);
                    unSelectedButton(anasayfaButton);
                    unSelectedButton(aidatButton);
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
    }
}
