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
    public partial class Kitapİslemleri : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-QSULL7A\SQLEXPRESS;Initial Catalog=KutuphaneYonetim;Integrated Security=True");
        public Kitapİslemleri()
        {
            InitializeComponent();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            
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

        private void btnKapat_MouseEnter(object sender, EventArgs e)
        {
            btnKapat.BackColor = Color.Black;
        }

        private void btnKapat_MouseLeave(object sender, EventArgs e)
        {
            btnKapat.BackColor = Color.Silver;
        }

        private void KitaplariListele()
        {
            if(baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlDataAdapter da = new SqlDataAdapter("SELECT KitapID, KitapAdi, Yazar, ISBN, SayfaSayisi, Yayinevi, BasimTarihi FROM Kitaplar", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            if(baglanti.State == ConnectionState.Open)
            {
                baglanti.Close();
            }
        }

        private void Kitapİslemleri_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kutuphaneYonetimDataSet2.Kitaplar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kitaplarTableAdapter.Fill(this.kutuphaneYonetimDataSet2.Kitaplar);
            KitaplariListele();
            toolTip1.SetToolTip(btnKapat, "Formu kapatmak için tıkla.");
            toolTip1.SetToolTip(btnEkle, "Kitap eklemek için tıkla.");
            toolTip1.SetToolTip(btnSil, "Kitap silmek için hücreye tıklaman gerekir.");
            toolTip1.SetToolTip(btnGuncelle, "Verileri güncellemek için hücreye tıklaman gerekir.");
            toolTip1.SetToolTip(btnAra, "Kitap aramak için tıklayın.");

            toolTip1.SetToolTip(txtAra, "Kitap ara.");
            toolTip1.SetToolTip(txtISBNNo, "ISBN No gir.");
            toolTip1.SetToolTip(txtKitapAdi, "Kitap adını gir.");
            toolTip1.SetToolTip(txtSayfaSayisi, "Kitabın sayfasını gir.");
            toolTip1.SetToolTip(txtYayinevi, "Kitabın Yayınevini gir.");
            toolTip1.SetToolTip(txtYazar, "Kitabın yazarını gir.");
            toolTip1.SetToolTip(dtpBasimTarihi, "Kitabın basim tarihini gir.");
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if(baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlCommand komut = new SqlCommand("INSERT INTO Kitaplar (KitapAdi, Yazar, ISBN, SayfaSayisi, Yayinevi, BasimTarihi) VALUES (@KitapAdi, @Yazar, @ISBN, @SayfaSayisi, @Yayinevi, @BasimTarihi)", baglanti);
            komut.Parameters.AddWithValue("@KitapAdi", txtKitapAdi.Text);
            komut.Parameters.AddWithValue("@Yazar", txtYazar.Text);
            komut.Parameters.AddWithValue("@ISBN", txtISBNNo.Text);
            komut.Parameters.AddWithValue("@SayfaSayisi", Convert.ToInt32(txtSayfaSayisi.Text));
            komut.Parameters.AddWithValue("@Yayinevi", txtYayinevi.Text);
            komut.Parameters.AddWithValue("@BasimTarihi", dtpBasimTarihi.Value);

            komut.ExecuteNonQuery();
            MessageBox.Show("Kitap başarıyla eklendi.","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);

            KitaplariListele();

            if(baglanti.State == ConnectionState.Open)
            {
                baglanti.Close();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                int kitapID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                if(baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                SqlCommand cmd = new SqlCommand("DELETE FROM Kitaplar WHERE KitapID = @KitapID", baglanti);
                cmd.Parameters.AddWithValue("@KitapID", kitapID);
                cmd.ExecuteNonQuery();

                if(baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
                MessageBox.Show("Kitap başarıyla silindi.","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
                KitaplariListele();
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir kitap seçin.","Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSil_MouseEnter(object sender, EventArgs e)
        {
            btnSil.BackColor = Color.Black;
        }

        private void btnSil_MouseLeave(object sender, EventArgs e)
        {
            btnSil.BackColor = Color.Silver;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                int kitapID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                string kitapAdi = txtKitapAdi.Text;
                string yazar = txtYazar.Text;
                string isbn = txtISBNNo.Text;
                int sayfaSayisi = Convert.ToInt32(txtSayfaSayisi.Text);
                string yayinevi = txtYayinevi.Text;
                DateTime basimTarihi = dtpBasimTarihi.Value;

                if(baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                SqlCommand cmd = new SqlCommand("UPDATE Kitaplar SET KitapAdi=@KitapAdi, Yazar=@Yazar, ISBN=@ISBN, SayfaSayisi=@SayfaSayisi, Yayinevi=@Yayinevi, BasimTarihi=@BasimTarihi WHERE KitapID=@KitapID", baglanti);
                cmd.Parameters.AddWithValue("@KitapAdi", kitapAdi);
                cmd.Parameters.AddWithValue("@Yazar", yazar);
                cmd.Parameters.AddWithValue("@ISBN", isbn);
                cmd.Parameters.AddWithValue("@SayfaSayisi", sayfaSayisi);
                cmd.Parameters.AddWithValue("@Yayinevi", yayinevi);
                cmd.Parameters.AddWithValue("@BasimTarihi", basimTarihi);
                cmd.Parameters.AddWithValue("@KitapID", kitapID);

                cmd.ExecuteNonQuery();

                if(baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
                MessageBox.Show("Kitap başarıyla güncellendi.","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KitaplariListele();
            }
            else
            {
                MessageBox.Show("Lütfen güncellenecek kitabı seçiniz.","Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                txtKitapAdi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtYazar.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtISBNNo.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtSayfaSayisi.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtYayinevi.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                dtpBasimTarihi.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[6].Value);
            }
        }

        private void btnGuncelle_MouseEnter(object sender, EventArgs e)
        {
            btnGuncelle.BackColor = Color.Black;
        }

        private void btnGuncelle_MouseLeave(object sender, EventArgs e)
        {
            btnGuncelle.BackColor = Color.Silver;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string aranan = txtAra.Text.Trim();

            if(baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Kitaplar WHERE KitapAdi LIKE @kitapadi ORDER BY KitapID ASC", baglanti);
            da.SelectCommand.Parameters.AddWithValue("@kitapadi", "%" + aranan + "%");

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            if(baglanti.State == ConnectionState.Open)
            {
                baglanti.Close();
            }
        }

        private void btnAra_MouseEnter(object sender, EventArgs e)
        {
            btnAra.BackColor = Color.Black;
        }

        private void btnAra_MouseLeave(object sender, EventArgs e)
        {
            btnAra.BackColor = Color.Silver;
        }
    }
}
