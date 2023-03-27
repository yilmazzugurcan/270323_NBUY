using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _270323_NBUY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rdErkek.Text = "Erkek";
            rdKadin.Text = "Kadin";
            rdIlkokul.Text = "İlkokul";
        }






        #region Kadın,Erkek Seçimi yapılıp ve girilen yaşa göre mezuniyet gösterme 
        /*  private void button1_Click(object sender, EventArgs e)
          {
              int yas;
              yas = int.Parse(textBox1.Text);

              string mezuniyet;

              if (radioButton1.Checked)
              {
                  if (yas < 18)
                      mezuniyet = "Lise Mezunu";
                  else if (yas >= 18 && yas < 22)
                      mezuniyet = "Üniversite";
                  else if (yas >= 22 && yas < 24)
                      mezuniyet = "Yüksek Lisans";
                  else
                  {
                      mezuniyet = "Doktora";
                  }
              }

              {
                  if (yas < 18)
                      mezuniyet = "Lise Mezunu";
                  else if (yas >= 18 && yas < 22)
                      mezuniyet = "Üniversite";
                  else if (yas >= 22 && yas < 24)
                      mezuniyet = "Yüksek Lisans";
                  else
                  {
                      mezuniyet = "Doktora";
                  }
              }
              label1.Text = mezuniyet;
          } */
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        string cinsiyet, egitim;
        private void btnGoster_Click(object sender, EventArgs e)
        {
            if (rdKadin.Checked)
            {
                cinsiyet = "Kadin";
            }
            else if (rdErkek.Checked)
            {
                cinsiyet = "Erkek";
            }
            else
            {
                btnGoster.Enabled = false;
            }

            if (rdIlkokul.Checked)
            {
                egitim = "İlkokul";
            }
            else if (rdOrta.Checked)
            {
                egitim = "Orta";
            }
            else if (rdLise.Checked)
            {
                egitim = "Lise";

            }
            else if (rdUni.Checked)
            {
                egitim = "Üniversite";
            }
            else
            {
                btnGoster.Enabled = false;
            }
        }
    }
}
