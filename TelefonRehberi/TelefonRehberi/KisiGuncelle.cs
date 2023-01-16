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
    public partial class KisiGuncelle : Form
    {
        private MainForm _mainForm;
        Kurallar kurallar = new Kurallar();
        public KisiGuncelle(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }
        #region Karakter ve Sayı Kuralları
        private void adSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        } 
        private void telefonNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); 
        }
        #endregion


        public string seciliID;
        public string seciliAdSoyad;
        public string seciliEmail;
        public string seciliTelefonNo;
        private void KisiGuncelle_Load(object sender, EventArgs e)
        {
            id.Text = seciliID;
            adSoyad.Text = seciliAdSoyad;
            email.Text = seciliEmail;
            telefonNo.Text = seciliTelefonNo;
        }

        private void guncelle_Click(object sender, EventArgs e)
        { 
            if (adSoyad.Text != "" && kurallar.emailFormatKontrol(email.Text) && kurallar.telefonFormatKontrol(telefonNo.Text))
            {
                _mainForm.kisiGuncelle(id.Text, adSoyad.Text, email.Text, telefonNo.Text);
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
    }
}
