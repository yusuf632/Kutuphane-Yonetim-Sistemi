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
    public partial class Admin : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-QSULL7A\SQLEXPRESS;Initial Catalog=KutuphaneYonetim;Integrated Security=True");
        public Admin()
        {
            InitializeComponent();
        }
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text.Trim();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT YetkiSeviyesi FROM Kullanicilar WHERE KullaniciAdi = @adi AND Sifre = @sifre", baglanti);
            komut.Parameters.AddWithValue("@adi", kullaniciAdi);
            komut.Parameters.AddWithValue("@sifre", sifre);

            SqlDataReader dr = komut.ExecuteReader();

            if(dr.Read())
            {
                AnaMenu anaMenu = new AnaMenu();
                anaMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            baglanti.Close();
        }
        
        private void linklblSifreUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("(0543 769 50 36) Numaralı kişiye başvurunuz.","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtKullaniciAdi_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtSifre.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtSifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGirisYap.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void btnGirisYap_MouseEnter(object sender, EventArgs e)
        {
            btnGirisYap.BackColor = Color.Black;
        }

        private void btnGirisYap_MouseLeave(object sender, EventArgs e)
        {
            btnGirisYap.BackColor = Color.Silver;
        }

        private void linklblSifreUnuttum_MouseEnter(object sender, EventArgs e)
        {
            linklblSifreUnuttum.LinkColor = Color.Black;
        }

        private void linklblSifreUnuttum_MouseLeave(object sender, EventArgs e)
        {
            linklblSifreUnuttum.LinkColor = Color.White;
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnGirisYap, "Giriş yapmak için tıkla.");

            toolTip1.SetToolTip(txtKullaniciAdi, "Kullanıcı adını gir.");
            toolTip1.SetToolTip(txtSifre, "Sifreni gir.");

        }
    }
}
