using System.Data.SqlClient;

namespace TelefonRehberi
{
    public partial class MainForm : Form
    {
        static sqlConnection m_Connect = new sqlConnection();
        public SqlCommand sqlCommand;
        public SqlDataReader sqlDataReader;

        public MainForm()
        {
            InitializeComponent();
        } 

        #region Buton
        private void listele_Click(object sender, EventArgs e)
        {
            kisiListele();
        }
        private void ekle_Click(object sender, EventArgs e)
        {
            KisiEkle kisiEkle = new KisiEkle(this);
            kisiEkle.ShowDialog();
        }
        private void guncelle_Click(object sender, EventArgs e)
        {
            if (dataGridRehber.SelectedCells.Count == 1 || dataGridRehber.SelectedRows.Count == 1) // herhangi bir kiþi seçilmiþ mi diye bakar
            {
                try
                {
                    KisiGuncelle kisiGuncelle = new KisiGuncelle(this);

                    int currentRowIndex = dataGridRehber.CurrentRow.Index; // secili satýr numarasý alýndý 

                    kisiGuncelle.seciliID = dataGridRehber.Rows[currentRowIndex].Cells[0].Value.ToString(); // secili satýrdaki id sütun'undaki veriyi güncelle formuna gönderir.
                    kisiGuncelle.seciliAdSoyad = dataGridRehber.Rows[currentRowIndex].Cells[1].Value.ToString();
                    kisiGuncelle.seciliEmail = dataGridRehber.Rows[currentRowIndex].Cells[2].Value.ToString();
                    kisiGuncelle.seciliTelefonNo = dataGridRehber.Rows[currentRowIndex].Cells[3].Value.ToString();

                    kisiGuncelle.ShowDialog();
                }
                catch
                {
                    MessageBox.Show("Hatalý satýr seçtiniz.");
                }
            }
            else
            {
                MessageBox.Show("Kiþi seçilmedi.");
            }
        }
        private void sil_Click(object sender, EventArgs e)
        {
            kisiSil();
        }
        #endregion 

        #region Metotlar
        public void kisiListele()
        {
            try
            {
                sqlCommand = new SqlCommand("Select * from Kisiler", m_Connect.DBConnection); 
                sqlDataReader = sqlCommand.ExecuteReader(); 

                dataGridRehber.Rows.Clear(); // listeleme yapmadan önce satýrlarý temizledik

                while (sqlDataReader.Read()) // gelen verileri okuyup datagrid'e yazdýk
                {
                    dataGridRehber.Rows.Add(sqlDataReader.GetInt32(0), 
                                            sqlDataReader.GetString(1),
                                            sqlDataReader.GetString(2), 
                                            sqlDataReader.GetString(3) 
                                            );
                }
                sqlDataReader.Close(); 
            }
            catch (Exception)
            {
                MessageBox.Show("Kiþiler getirilemedi. Hata var.");
            }
        }
        public void kisiEkle(string adsoyad, string email, string telefonNumarasi)
        {
            try
            {
                sqlCommand = new SqlCommand("insert into Kisiler(AdSoyad, Email, TelefonNo) values (@AdSoyad, @Email, @TelefonNo)", m_Connect.DBConnection);
                sqlCommand.Parameters.AddWithValue("@AdSoyad", adsoyad.Trim());
                sqlCommand.Parameters.AddWithValue("@Email", email.Trim());
                sqlCommand.Parameters.AddWithValue("@TelefonNo", telefonNumarasi.Trim());
                sqlCommand.ExecuteNonQuery();
                kisiListele();
            }
            catch (Exception e)
            {
                MessageBox.Show("Kiþi eklenemedi. \nHATA:" + e.Message);
            }
        }
        public void kisiGuncelle(string id, string adsoyad, string email, string telefonNumarasi)
        {
            if (dataGridRehber.SelectedCells.Count == 1 || dataGridRehber.SelectedRows.Count == 1) 
            {
                try
                {
                    sqlCommand = new SqlCommand("update Kisiler set AdSoyad=@AdSoyad, Email=@Email, TelefonNo=@TelefonNo where Id=@Id", m_Connect.DBConnection); // güncelleme sorgusu yazýldý
                    sqlCommand.Parameters.AddWithValue("@Id", id);
                    sqlCommand.Parameters.AddWithValue("@AdSoyad", adsoyad.Trim());
                    sqlCommand.Parameters.AddWithValue("@Email", email.Trim());
                    sqlCommand.Parameters.AddWithValue("@TelefonNo", telefonNumarasi.Trim());
                    sqlCommand.ExecuteNonQuery(); //sorgu çalýþtýrýldý
                    kisiListele(); //liste tekrar getirildi.
                }
                catch (Exception)
                {
                    MessageBox.Show("Kiþi güncellemedi.");
                }
            }
            else
            {
                MessageBox.Show("Kiþi seçilmedi.");
            } 
        }
        public void kisiSil()
        {
            if (dataGridRehber.SelectedCells.Count == 1 || dataGridRehber.SelectedRows.Count == 1)
            {
                try
                {
                    DialogResult Secim = new DialogResult();
                    Secim = MessageBox.Show("Kiþiyi silmek istiyor musunuz?", "Uyarý", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                    if (Secim == DialogResult.Yes) 
                    {
                        int currentRowIndex = dataGridRehber.CurrentRow.Index; //secili satýr index alýnýr
                        sqlCommand = new SqlCommand("delete Kisiler where ID=@id", m_Connect.DBConnection); 
                        sqlCommand.Parameters.AddWithValue("@id", dataGridRehber.Rows[currentRowIndex].Cells[0].Value.ToString()); // secili satýr numarasýný currentRowIndex'e aldýk ve 0. sutün yani Id alanýndaki veriyi yazdýrdýk.
                        sqlCommand.ExecuteNonQuery();
                        kisiListele();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString() + "Kiþi silinemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Kiþi seçilmedi.");
            }
        }
        #endregion

        private void dataGridRehber_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}