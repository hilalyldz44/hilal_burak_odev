using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurakOdevProje
{
    public partial class girisFormu : Form
    {
        public girisFormu()
        {
            InitializeComponent();
        }

        private void btn_girisYap_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-E8HSGO3;Initial Catalog=BurakOdev;Integrated Security=True"))
                {
                    conn.Open();
                    string sql = "SELECT COUNT(*) FROM Kullanicilar WHERE KullaniciAdi = @KullaniciAdi AND Sifre = @Sifre";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@KullaniciAdi", txt_GirisKullaniciAdi.Text);
                        cmd.Parameters.AddWithValue("@Sifre", txt_girisSifre.Text);

                        int kullaniciVarMi = (int)cmd.ExecuteScalar();

                        if (kullaniciVarMi > 0)
                        {
                            // Giriş başarılı
                            MessageBox.Show("Giriş başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // AnaForm'u aç
                            Form1 anaForm = new Form1();
                            anaForm.Show();

                            // GirişFormunu kapat
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı adı veya şifre yanlış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Giriş yaparken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_kayitOl_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-E8HSGO3;Initial Catalog=BurakOdev;Integrated Security=True"))
                {
                    conn.Open();
                    string sql = "INSERT INTO Kullanicilar (KullaniciAdi, Sifre, Ad, Soyad) VALUES (@KullaniciAdi, @Sifre, @Ad, @Soyad)";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@KullaniciAdi", txt_KayitKullaniciAdi.Text);
                        cmd.Parameters.AddWithValue("@Sifre", txt_KayitSifre.Text);
                        cmd.Parameters.AddWithValue("@Ad", txt_kayitAd.Text);
                        cmd.Parameters.AddWithValue("@Soyad", txt_KayitSoyad.Text);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Kayıt başarılı! Şimdi giriş yapabilirsiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_GirisKullaniciAdi.Clear();
                txt_girisSifre.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt olurken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
