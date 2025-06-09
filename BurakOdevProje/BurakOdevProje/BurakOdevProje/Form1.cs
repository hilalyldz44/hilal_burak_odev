using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace BurakOdevProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        SqlConnection baglanti = new SqlConnection("Data source = DESKTOP-E8HSGO3; initial catalog = BurakOdev; integrated security = true;");
        int sonKaydedilenOyunID = -1;
        private void btn_oyunEkle_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data source = DESKTOP-E8HSGO3; initial catalog = BurakOdev; integrated security = true;"))
                {
                    conn.Open();
                    string sql = @"INSERT INTO Oyunlar (OyunAdi, OyunTuru, OyunPlatformu, OyunYapimcisi, OyunKonusu) 
                                   OUTPUT INSERTED.OyunID VALUES (@OyunAdi, @OyunTuru, @OyunPlatformu, @OyunYapimcisi, @OyunKonusu)";
                    using (SqlCommand komut = new SqlCommand(sql, conn))
                    {
                        komut.Parameters.AddWithValue("@OyunAdi", txt_oyunAdi.Text);
                        komut.Parameters.AddWithValue("@OyunTuru", cmb_OyunTuru.Text);
                        komut.Parameters.AddWithValue("@OyunPlatformu", cmb_oyunPlatformu.Text);
                        komut.Parameters.AddWithValue("@OyunYapimcisi", OyunYapımcısı.Text);
                        komut.Parameters.AddWithValue("@OyunKonusu", txt_oyunKonusu.Text);

                        // Veritabanına kaydeder ve ID'yi alır
                        sonKaydedilenOyunID = (int)komut.ExecuteScalar();
                    }
                }

                MessageBox.Show($"Oyun başarıyla kaydedildi! Oyun ID: {sonKaydedilenOyunID}", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oyun kaydederken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            OyunlarıGetir();

            
        }
        int sonKaydedilenFilmID = -1;
        private void btn_filmEkle_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data source = DESKTOP-E8HSGO3; initial catalog = BurakOdev; integrated security = true;"))
                {
                    conn.Open();
                    string sql = @"INSERT INTO Filmler (FilmAdi, FilmTuru, FilmYonetmeni, FilmSuresi, FilmKonusu) 
                                   OUTPUT INSERTED.FilmID VALUES (@FilmAdi, @FilmTuru, @FilmYonetmeni, @FilmSuresi, @FilmKonusu)";
                    using (SqlCommand komut = new SqlCommand(sql, conn))
                    {
                        komut.Parameters.AddWithValue("@FilmAdi", txt_filmAdi.Text);
                        komut.Parameters.AddWithValue("@FilmTuru", cmb_FilmTuru.Text);
                        komut.Parameters.AddWithValue("@FilmYonetmeni", txt_filmYonetmeni.Text);
                        komut.Parameters.AddWithValue("@FilmSuresi", txt_filmSuresi.Text);
                        komut.Parameters.AddWithValue("@FilmKonusu", txt_filmKonusu.Text);

                        // Veritabanına kaydeder ve ID'yi alır
                        sonKaydedilenFilmID = (int)komut.ExecuteScalar();
                    }
                }

                MessageBox.Show($"Film başarıyla kaydedildi! Film ID: {sonKaydedilenFilmID}", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Film kaydederken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FilmleriGetir();
            
                
        }
        int sonKaydedilenKitapId = -1;
        private void btn_KitapEkle_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data source = DESKTOP-E8HSGO3; initial catalog = BurakOdev; integrated security = true;"))
                {
                    conn.Open();
                    string sql = @"INSERT INTO Kitaplar2 (KitapAdi, KitapYazari, KitapTuru, KitapSayfaSayisi, KitapKonusu) 
                                   OUTPUT INSERTED.KitapID VALUES (@KitapAdi, @KitapYazari, @KitapTuru, @KitapSayfaSayisi, @KitapKonusu)";
                    using (SqlCommand komut = new SqlCommand(sql, conn))
                    {
                        komut.Parameters.AddWithValue("@KitapAdi", txt_kitapAdi.Text);
                        komut.Parameters.AddWithValue("@KitapYazari", txt_kitapYazari.Text);
                        komut.Parameters.AddWithValue("@KitapTuru", cmb_KitapTuru.Text);
                        komut.Parameters.AddWithValue("@KitapSayfaSayisi", txt_sayfaSayisi.Text);
                        komut.Parameters.AddWithValue("@KitapKonusu", txt_kitapKonusu.Text);

                        // Veritabanına kaydeder ve ID'yi alır
                        sonKaydedilenKitapId = (int)komut.ExecuteScalar();
                    }
                }

                MessageBox.Show($"Kitap başarıyla kaydedildi! Kitap ID: {sonKaydedilenKitapId}", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitap kaydederken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            KitaplariGetir();
        }

        

        private void KitapFotografEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (sonKaydedilenKitapId == -1)
                {
                    MessageBox.Show("Önce bir kitap kaydetmelisiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string anaDizin = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Kitaplar2");
                string kitapKlasoru = Path.Combine(anaDizin, sonKaydedilenKitapId.ToString());

                if (!Directory.Exists(kitapKlasoru))
                {
                    Directory.CreateDirectory(kitapKlasoru);
                }

                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Title = "Bir fotoğraf seçiniz";
                    ofd.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp";

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        string secilenFotoPath = ofd.FileName;
                        string hedefPath = Path.Combine(kitapKlasoru, Path.GetFileName(secilenFotoPath));

                        File.Copy(secilenFotoPath, hedefPath, true);

                        MessageBox.Show("Fotoğraf başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Fotoğraf seçilmedi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fotoğraf eklerken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_filmFotografiEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (sonKaydedilenFilmID == -1)
                {
                    MessageBox.Show("Önce bir film kaydetmelisiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string anaDizin = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Filmler");
                string filmKlasoru = Path.Combine(anaDizin, sonKaydedilenFilmID.ToString());

                if (!Directory.Exists(filmKlasoru))
                {
                    Directory.CreateDirectory(filmKlasoru);
                }

                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Title = "Bir fotoğraf seçiniz";
                    ofd.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp";

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        string secilenFotoPath = ofd.FileName;
                        string hedefPath = Path.Combine(filmKlasoru, Path.GetFileName(secilenFotoPath));

                        File.Copy(secilenFotoPath, hedefPath, true);

                        MessageBox.Show("Fotoğraf başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Fotoğraf seçilmedi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fotoğraf eklerken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_oyunFotografiEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (sonKaydedilenOyunID == -1)
                {
                    MessageBox.Show("Önce bir oyun kaydetmelisiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string anaDizin = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Oyunlar");
                string oyunKlasoru = Path.Combine(anaDizin, sonKaydedilenOyunID.ToString());

                if (!Directory.Exists(oyunKlasoru))
                {
                    Directory.CreateDirectory(oyunKlasoru);
                }

                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Title = "Bir fotoğraf seçiniz";
                    ofd.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp";

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        string secilenFotoPath = ofd.FileName;
                        string hedefPath = Path.Combine(oyunKlasoru, Path.GetFileName(secilenFotoPath));

                        File.Copy(secilenFotoPath, hedefPath, true);

                        MessageBox.Show("Fotoğraf başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Fotoğraf seçilmedi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fotoğraf eklerken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OyunlarıGetir()
        {
            baglanti.Open();
            string sorgu = "select * from oyunlar";
            SqlDataAdapter adp = new SqlDataAdapter(sorgu, baglanti);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgv_oyunlarıListele.DataSource = dt;
            baglanti.Close();
        }
        private void FilmleriGetir()
        {
            baglanti.Open();
            string sorgu = "select * from filmler";
            SqlDataAdapter apd = new SqlDataAdapter(sorgu,baglanti);
            DataTable dt = new DataTable();
            apd.Fill(dt);
            dgv_filmleriListele.DataSource = dt;
            baglanti.Close();
        }
        private void KitaplariGetir()
        {
            baglanti.Open();
            string sorgu = "select * from Kitaplar2";
            SqlDataAdapter adp = new SqlDataAdapter(sorgu,baglanti);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgv_kitaplariListele.DataSource = dt;
            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OyunlarıGetir();
            FilmleriGetir();
            KitaplariGetir();
        }

        private void dgv_oyunlarıListele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0) // Başlık satırına tıklamayı engeller
                {
                    // Seçilen satırı al
                    DataGridViewRow satir = dgv_oyunlarıListele.Rows[e.RowIndex];

                    // Satırdan bilgileri oku
                    string oyunAdi = satir.Cells["OyunAdi"].Value.ToString();
                    string oyunTuru = satir.Cells["OyunTuru"].Value.ToString();
                    string oyunPlatformu = satir.Cells["oyunPlatformu"].Value.ToString();
                    string oyunYapimcisi = satir.Cells["oyunYapimcisi"].Value.ToString();
                    string oyunKonusu = satir.Cells["oyunKonusu"].Value.ToString();
                    string oyunID = satir.Cells["oyunID"].Value.ToString(); // ID'yi alacağız

                    // Label'lara yaz
                    txt_OyunAdiGoruntule.Text = oyunAdi;
                    txt_oyunTuruGoruntule.Text = oyunTuru;
                    txt_oyunPlatformuGoruntule.Text = oyunPlatformu;
                    txt_OyunYapimcisiGoruntule.Text = oyunYapimcisi;
                    txt_oyunKonusuGoruntule.Text = oyunKonusu;

                    // Fotoğraf klasör yolunu ayarla
                    string anaDizin = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Oyunlar");
                    string oyunKlasoru = Path.Combine(anaDizin, oyunID);

                    // Oyun klasöründen fotoğrafı bul ve yükle
                    if (Directory.Exists(oyunKlasoru))
                    {
                        var fotoDosyalari = Directory.GetFiles(oyunKlasoru, "*.*", SearchOption.TopDirectoryOnly)
                            .Where(s => s.EndsWith(".jpg") || s.EndsWith(".jpeg") || s.EndsWith(".png") || s.EndsWith(".bmp"))
                            .ToArray();

                        if (fotoDosyalari.Length > 0)
                        {
                            string ilkFoto = fotoDosyalari[0]; // İlk bulduğu fotoğrafı alıyor
                            pictureBox1.Image = Image.FromFile(ilkFoto);
                            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                        else
                        {
                            pictureBox1.Image = null; // Fotoğraf yoksa boş bırak
                        }
                    }
                    else
                    {
                        pictureBox1.Image = null; // Klasör yoksa da boş bırak
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void txt_oyunAra_TextChanged(object sender, EventArgs e)
        {
            (dgv_oyunlarıListele.DataSource as DataTable).DefaultView.RowFilter = string.Format("OyunAdi LIKE '%{0}%'", txt_oyunAra.Text);
        }

        private void dgv_filmleriListele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0) // Başlık satırına tıklamayı engeller
                {
                    // Seçilen satırı al
                    DataGridViewRow satir = dgv_filmleriListele.Rows[e.RowIndex];

                    // Satırdan bilgileri oku
                    string filmAdi = satir.Cells["FilmAdi"].Value.ToString();
                    string FilmTuru = satir.Cells["FilmTuru"].Value.ToString();
                    string FilmYonetmeni = satir.Cells["FilmYonetmeni"].Value.ToString();
                    string FilmSuresi = satir.Cells["FilmSuresi"].Value.ToString();
                    string filmKonusu = satir.Cells["FilmKonusu"].Value.ToString();
                    string filmID = satir.Cells["FilmID"].Value.ToString(); // ID'yi alacağız

                    // Label'lara yaz
                    txt_filmAdiGetir.Text = filmAdi;
                    txt_filmTuruGetir.Text = FilmTuru;
                    txt_filmYonetmeniGetir.Text = FilmYonetmeni;
                    txt_filmSuresiGetir.Text = FilmSuresi;
                    txt_filmKonusuGetir.Text = filmKonusu;

                    // Fotoğraf klasör yolunu ayarla
                    string anaDizin = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Filmler");
                    string filmKlasoru = Path.Combine(anaDizin, filmID);

                    // Oyun klasöründen fotoğrafı bul ve yükle
                    if (Directory.Exists(filmKlasoru))
                    {
                        var fotoDosyalari = Directory.GetFiles(filmKlasoru, "*.*", SearchOption.TopDirectoryOnly)
                            .Where(s => s.EndsWith(".jpg") || s.EndsWith(".jpeg") || s.EndsWith(".png") || s.EndsWith(".bmp"))
                            .ToArray();

                        if (fotoDosyalari.Length > 0)
                        {
                            string ilkFoto = fotoDosyalari[0]; // İlk bulduğu fotoğrafı alıyor
                            pictureBox2.Image = Image.FromFile(ilkFoto);
                            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                        else
                        {
                            pictureBox2.Image = null; // Fotoğraf yoksa boş bırak
                        }
                    }
                    else
                    {
                        pictureBox2.Image = null; // Klasör yoksa da boş bırak
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void txt_FilmAra_TextChanged(object sender, EventArgs e)
        {
            (dgv_filmleriListele.DataSource as DataTable).DefaultView.RowFilter = string.Format("FilmAdi LIKE '%{0}%'", txt_FilmAra.Text);
        }

        private void dgv_kitaplariListele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0) // Başlık satırına tıklamayı engeller
                {
                    // Seçilen satırı al
                    DataGridViewRow satir = dgv_kitaplariListele.Rows[e.RowIndex];

                    // Satırdan bilgileri oku
                    string KitapAdi = satir.Cells["KitapAdi"].Value.ToString();
                    string KitapTuru = satir.Cells["KitapTuru"].Value.ToString();
                    string YazarAdi = satir.Cells["KitapYazari"].Value.ToString();
                    string KitapSayfaSayisi = satir.Cells["KitapSayfaSayisi"].Value.ToString();
                    string KitapKonusu = satir.Cells["KitapKonusu"].Value.ToString();
                    string KitapID = satir.Cells["KitapID"].Value.ToString(); // ID'yi alacağız

                    // Label'lara yaz
                    txt_kitapAdiGetir.Text = KitapAdi;
                    txt_kitapTuruGetir.Text = KitapTuru;
                    txt_yazarAdiGetir.Text = YazarAdi;
                    txt_sayfaSayisiGetir.Text = KitapSayfaSayisi;
                    txt_KitapKonusuGetir.Text = KitapKonusu;
                    

                    // Fotoğraf klasör yolunu ayarla
                    string anaDizin = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Kitaplar2");
                    string kitapKlasoru = Path.Combine(anaDizin, KitapID);

                    // Oyun klasöründen fotoğrafı bul ve yükle
                    if (Directory.Exists(kitapKlasoru))
                    {
                        var fotoDosyalari = Directory.GetFiles(kitapKlasoru, "*.*", SearchOption.TopDirectoryOnly)
                            .Where(s => s.EndsWith(".jpg") || s.EndsWith(".jpeg") || s.EndsWith(".png") || s.EndsWith(".bmp"))
                            .ToArray();

                        if (fotoDosyalari.Length > 0)
                        {
                            string ilkFoto = fotoDosyalari[0]; // İlk bulduğu fotoğrafı alıyor
                            pictureBox3.Image = Image.FromFile(ilkFoto);
                            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                        else
                        {
                            pictureBox3.Image = null; // Fotoğraf yoksa boş bırak
                        }
                    }
                    else
                    {
                        pictureBox3.Image = null; // Klasör yoksa da boş bırak
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void txt_kitapAra_TextChanged(object sender, EventArgs e)
        {
            (dgv_kitaplariListele.DataSource as DataTable).DefaultView.RowFilter = string.Format("KitapAdi LIKE '%{0}%'", txt_kitapAra.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
