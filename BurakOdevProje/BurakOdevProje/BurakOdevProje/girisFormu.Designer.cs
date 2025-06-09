namespace BurakOdevProje
{
    partial class girisFormu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_girisYap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_girisSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_GirisKullaniciAdi = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_kayitOl = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_KayitSifre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_KayitKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_KayitSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_kayitAd = new System.Windows.Forms.TextBox();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btn_girisYap);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_girisSifre);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_GirisKullaniciAdi);
            this.panel1.Location = new System.Drawing.Point(46, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 438);
            this.panel1.TabIndex = 0;
            // 
            // btn_girisYap
            // 
            this.btn_girisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_girisYap.Location = new System.Drawing.Point(95, 294);
            this.btn_girisYap.Margin = new System.Windows.Forms.Padding(2);
            this.btn_girisYap.Name = "btn_girisYap";
            this.btn_girisYap.Size = new System.Drawing.Size(110, 79);
            this.btn_girisYap.TabIndex = 4;
            this.btn_girisYap.Text = "Giriş Yap";
            this.btn_girisYap.UseVisualStyleBackColor = true;
            this.btn_girisYap.Click += new System.EventHandler(this.btn_girisYap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre :";
            // 
            // txt_girisSifre
            // 
            this.txt_girisSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_girisSifre.Location = new System.Drawing.Point(69, 158);
            this.txt_girisSifre.Name = "txt_girisSifre";
            this.txt_girisSifre.PasswordChar = '*';
            this.txt_girisSifre.Size = new System.Drawing.Size(168, 30);
            this.txt_girisSifre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // txt_GirisKullaniciAdi
            // 
            this.txt_GirisKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GirisKullaniciAdi.Location = new System.Drawing.Point(69, 107);
            this.txt_GirisKullaniciAdi.Name = "txt_GirisKullaniciAdi";
            this.txt_GirisKullaniciAdi.Size = new System.Drawing.Size(168, 30);
            this.txt_GirisKullaniciAdi.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btn_kayitOl);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txt_KayitSifre);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_KayitKullaniciAdi);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_KayitSoyad);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_kayitAd);
            this.panel2.Location = new System.Drawing.Point(414, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 438);
            this.panel2.TabIndex = 1;
            // 
            // btn_kayitOl
            // 
            this.btn_kayitOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kayitOl.Location = new System.Drawing.Point(97, 301);
            this.btn_kayitOl.Margin = new System.Windows.Forms.Padding(2);
            this.btn_kayitOl.Name = "btn_kayitOl";
            this.btn_kayitOl.Size = new System.Drawing.Size(110, 79);
            this.btn_kayitOl.TabIndex = 12;
            this.btn_kayitOl.Text = "Kayıt Ol";
            this.btn_kayitOl.UseVisualStyleBackColor = true;
            this.btn_kayitOl.Click += new System.EventHandler(this.btn_kayitOl_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(67, 230);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Şifre";
            // 
            // txt_KayitSifre
            // 
            this.txt_KayitSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_KayitSifre.Location = new System.Drawing.Point(71, 264);
            this.txt_KayitSifre.Name = "txt_KayitSifre";
            this.txt_KayitSifre.PasswordChar = '*';
            this.txt_KayitSifre.Size = new System.Drawing.Size(168, 30);
            this.txt_KayitSifre.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(67, 158);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Kullanıcı Adı";
            // 
            // txt_KayitKullaniciAdi
            // 
            this.txt_KayitKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_KayitKullaniciAdi.Location = new System.Drawing.Point(71, 188);
            this.txt_KayitKullaniciAdi.Name = "txt_KayitKullaniciAdi";
            this.txt_KayitKullaniciAdi.Size = new System.Drawing.Size(168, 30);
            this.txt_KayitKullaniciAdi.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Soyad";
            // 
            // txt_KayitSoyad
            // 
            this.txt_KayitSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_KayitSoyad.Location = new System.Drawing.Point(71, 121);
            this.txt_KayitSoyad.Name = "txt_KayitSoyad";
            this.txt_KayitSoyad.Size = new System.Drawing.Size(168, 30);
            this.txt_KayitSoyad.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ad";
            // 
            // txt_kayitAd
            // 
            this.txt_kayitAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kayitAd.Location = new System.Drawing.Point(71, 66);
            this.txt_kayitAd.Name = "txt_kayitAd";
            this.txt_kayitAd.Size = new System.Drawing.Size(168, 30);
            this.txt_kayitAd.TabIndex = 4;
            // 
            // btn_cikis
            // 
            this.btn_cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cikis.Location = new System.Drawing.Point(330, 501);
            this.btn_cikis.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(110, 58);
            this.btn_cikis.TabIndex = 13;
            this.btn_cikis.Text = "Çıkış";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // girisFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 569);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "girisFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "girisFormu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_GirisKullaniciAdi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_girisYap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_girisSifre;
        private System.Windows.Forms.Button btn_kayitOl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_KayitSifre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_KayitKullaniciAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_KayitSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_kayitAd;
        private System.Windows.Forms.Button btn_cikis;
    }
}