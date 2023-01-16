using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonRehberi
{
    public partial class KisiEkle : Form
    {
        private MainForm _mainForm;
        Kurallar kurallar = new Kurallar();

        public KisiEkle(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        #region Karakter ve Sayı giriş kuralları
        private void telefonNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void AdSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
               && !char.IsSeparator(e.KeyChar);
        }
        #endregion
         
        private void kisiKaydet_Click(object sender, EventArgs e)
        { 
            if (AdSoyad.Text != "" && kurallar.emailFormatKontrol(email.Text) && kurallar.telefonFormatKontrol(telefonNo.Text))
            {
                _mainForm.kisiEkle(AdSoyad.Text, email.Text, telefonNo.Text);
                this.Hide();
            }
            else
            {
                if (!kurallar.emailFormatKontrol(email.Text))
                {
                    MessageBox.Show("Email hatalı. Lütfen kontrol ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!kurallar.telefonFormatKontrol(telefonNo.Text))
                {
                    MessageBox.Show("Telefon numarası hatalı. Lütfen kontrol ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Eksik veriler var.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void KisiEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
