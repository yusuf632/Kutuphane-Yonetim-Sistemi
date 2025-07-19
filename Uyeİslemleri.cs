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
    public partial class Uyeİslemleri : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-QSULL7A\SQLEXPRESS;Initial Catalog=KutuphaneYonetim;Integrated Security=True");
        public Uyeİslemleri()
        {
            InitializeComponent();
        }
        DataTable uyeTablosu = new DataTable();
        private void UyeleriListele()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Uyeler", baglanti);
            uyeTablosu.Clear();
            da.Fill(uyeTablosu);
            dataGridView1.DataSource = uyeTablosu;
        }

        private void Uyeİslemleri_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kutuphaneYonetimDataSet2.Uyeler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.uyelerTableAdapter.Fill(this.kutuphaneYonetimDataSet2.Uyeler);

            toolTip1.SetToolTip(btnAra, "Aramak için tıkla.");
            toolTip1.SetToolTip(btnEkle, "Üye eklemek için tıkla.");
            toolTip1.SetToolTip(btnGuncelle, "Güncellemek için hücreye tıklaman gerekir.");
            toolTip1.SetToolTip(btnKapat, "Form'dan çıkmak için tıkla");
            toolTip1.SetToolTip(btnSil, "Üye silmek için hücreye tıklaman gerekir.");

            toolTip1.SetToolTip(txtAdres, "Adresi gir.");
            toolTip1.SetToolTip(txtAdSoyad, "Adı ve soyadı gir.");
            toolTip1.SetToolTip(txtAra, "Üye ara.");
            toolTip1.SetToolTip(txtEmail, "E-mail adresini gir.");
            toolTip1.SetToolTip(txtTCNo, "TC Kimlik numarası gir.");
            toolTip1.SetToolTip(txtTelefon, "Telefon numarasını gir.");
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string adSoyad = txtAdSoyad.Text.Trim();
            string tcNo = txtTCNo.Text.Trim();
            string telefon = txtTelefon.Text.Trim();
            string email = txtEmail.Text.Trim();
            string adres = txtAdres.Text.Trim();

            if(adSoyad == "" || tcNo.Length !=11)
            {
                MessageBox.Show("Ad Soyad ve geçerli bir TC No girilmelidir.","Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sql = "INSERT INTO Uyeler (AdSoyad, TCNo, Telefon, Email, Adres) VALUES (@AdSoyad, @TCNo, @Telefon, @Email, @Adres)";

            using (SqlCommand cmd = new SqlCommand(sql, baglanti))
            {
                cmd.Parameters.AddWithValue("@AdSoyad", adSoyad);
                cmd.Parameters.AddWithValue("@TCNo", tcNo);
                cmd.Parameters.AddWithValue("@Telefon", telefon);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Adres", adres);

                baglanti.Open();
                cmd.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Üye başarıyla eklendi.","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UyeleriListele();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_MouseEnter(object sender, EventArgs e)
        {
            btnEkle.BackColor = Color.Black;
        }

        private void btnEkle_MouseLeave(object sender, EventArgs e)
        {
            btnEkle.BackColor = Color.Silver;
        }

        private void btnGuncelle_MouseEnter(object sender, EventArgs e)
        {
            btnGuncelle.BackColor = Color.Black;
        }

        private void btnGuncelle_MouseLeave(object sender, EventArgs e)
        {
            btnGuncelle.BackColor = Color.Silver;
        }

        private void btnSil_MouseEnter(object sender, EventArgs e)
        {
            btnSil.BackColor = Color.Black;
        }

        private void btnSil_MouseLeave(object sender, EventArgs e)
        {
            btnSil.BackColor = Color.Silver;
        }

        private void btnKapat_MouseEnter(object sender, EventArgs e)
        {
            btnKapat.BackColor = Color.Black;
        }

        private void btnKapat_MouseLeave(object sender, EventArgs e)
        {
            btnKapat.BackColor = Color.Silver;
        }

        private void btnAra_MouseEnter(object sender, EventArgs e)
        {
            btnAra.BackColor = Color.Black;
        }

        private void btnAra_MouseLeave(object sender, EventArgs e)
        {
            btnAra.BackColor = Color.Silver;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                int uyeID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                DialogResult result = MessageBox.Show("Seçili üyeyi silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string sql = "DELETE FROM Uyeler WHERE UyeID = @UyeID";

                    using(SqlCommand cmd = new SqlCommand(sql, baglanti))
                    {
                        cmd.Parameters.AddWithValue("@UyeID", uyeID);
                        baglanti.Open();
                        cmd.ExecuteNonQuery();
                        baglanti.Close();

                        MessageBox.Show("Üye başarıyla silindi.","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UyeleriListele();
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir üye seçiniz.","Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow != null)
            {
                int uyeID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                string sorgu = "UPDATE Uyeler SET AdSoyad = @AdSoyad, TCNo = @TCNo, Telefon = @Telefon, Email = @Email, Adres = @Adres WHERE UyeID = @UyeID";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@TCNo", txtTCNo.Text);
                komut.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@Email", txtEmail.Text);
                komut.Parameters.AddWithValue("@Adres", txtAdres.Text);
                komut.Parameters.AddWithValue("@UyeID", uyeID);

                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Üye bilgileri güncellendi.","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
                UyeleriListele();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                txtAdSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTCNo.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtTelefon.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtAdres.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string aranan = txtAra.Text.Trim();

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Uyeler WHERE AdSoyad LIKE @AdSoyad ORDER BY UyeID ASC", baglanti);
            da.SelectCommand.Parameters.AddWithValue("@AdSoyad", "%" + aranan + "%");

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            if (baglanti.State == ConnectionState.Open)
            {
                baglanti.Close();
            }
        }
    }
}
