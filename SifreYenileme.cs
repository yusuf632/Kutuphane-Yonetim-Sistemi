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

namespace Library
{
    public partial class SifreYenileme : Form
    {
        
        public SifreYenileme()
        {
            InitializeComponent();
        }


        private void btnSifreDegistir_Click(object sender, EventArgs e)
        {
            string eskiSifre = txtEskiSifre.Text.Trim();
            string yeniSifre = txtYeniSifre.Text.Trim();
            string yeniSifreYeniden = txtYeniSifreYeniden.Text.Trim();
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            
            if(yeniSifre != yeniSifreYeniden)
            {
                MessageBox.Show("Yeni şifreler uyuşmuyor", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-QSULL7A\SQLEXPRESS;Initial Catalog=KutuphaneYonetim;Integrated Security=True"))
            {
                baglanti.Open();

                SqlCommand kontrolKomut = new SqlCommand("SELECT COUNT(*) FROM Kullanicilar WHERE KullaniciAdi = @kullanici AND Sifre = @sifre",baglanti);
                kontrolKomut.Parameters.AddWithValue("@kullanici", kullaniciAdi);
                kontrolKomut.Parameters.AddWithValue("@sifre", eskiSifre);

                int sonuc = (int)kontrolKomut.ExecuteScalar();
                if (sonuc == 0)
                {
                    MessageBox.Show("Eski şifre yanlış!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SqlCommand guncelleKomut = new SqlCommand("UPDATE Kullanicilar SET Sifre = @yeniSifre WHERE KullaniciAdi = @kullanici", baglanti);
                guncelleKomut.Parameters.AddWithValue("@yeniSifre", yeniSifre);
                guncelleKomut.Parameters.AddWithValue("@kullanici", kullaniciAdi);
                guncelleKomut.ExecuteNonQuery();

                MessageBox.Show("Şifre başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnİptalEt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSifreDegistir_MouseEnter(object sender, EventArgs e)
        {
            btnSifreDegistir.BackColor = Color.Black;
        }

        private void btnSifreDegistir_MouseLeave(object sender, EventArgs e)
        {
            btnSifreDegistir.BackColor = Color.Silver;
        }

        private void btnİptalEt_MouseEnter(object sender, EventArgs e)
        {
            btnİptalEt.BackColor = Color.Black;
        }

        private void btnİptalEt_MouseLeave(object sender, EventArgs e)
        {
            btnİptalEt.BackColor = Color.Silver;
        }

        private void txtEskiSifre_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtYeniSifre.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtYeniSifre_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtYeniSifreYeniden.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtYeniSifreYeniden_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSifreDegistir.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void SifreYenileme_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnSifreDegistir, "Şifreyi değiştirmek için tıkla.");
            toolTip1.SetToolTip(btnİptalEt, "Form'dan çıkmak için tıkla.");

            toolTip1.SetToolTip(txtKullaniciAdi, "Kullanıcı adını gir.");
            toolTip1.SetToolTip(txtEskiSifre, "Eski şifreni gir.");
            toolTip1.SetToolTip(txtYeniSifre, "Yeni sifreyi gir.");
            toolTip1.SetToolTip(txtYeniSifreYeniden, "Yeni sifreyi onaylamak için tekrar gir.");

        }
    }
}
