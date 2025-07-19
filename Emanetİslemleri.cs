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
    public partial class Emanetİslemleri : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-QSULL7A\SQLEXPRESS;Initial Catalog=KutuphaneYonetim;Integrated Security=True");
        public Emanetİslemleri()
        {
            InitializeComponent();
        }

        private void Emanetİslemleri_Load(object sender, EventArgs e)
        {

            SqlDataAdapter kitapDa = new SqlDataAdapter("SELECT KitapID, KitapAdi FROM Kitaplar", baglanti);
            DataTable kitapDt = new DataTable();
            kitapDa.Fill(kitapDt);
            cmbKitaplar.DisplayMember = "KitapAdi";
            cmbKitaplar.ValueMember = "KitapID";
            cmbKitaplar.DataSource = kitapDt;

            SqlDataAdapter uyeDa = new SqlDataAdapter("SELECT UyeID, AdSoyad FROM Uyeler", baglanti);
            DataTable uyeDt = new DataTable();
            uyeDa.Fill(uyeDt);
            cmbUyeler.DisplayMember = "AdSoyad";
            cmbUyeler.ValueMember = "UyeID";
            cmbUyeler.DataSource = uyeDt;

            toolTip1.SetToolTip(btnAra, "Aramak için tıkla.");
            toolTip1.SetToolTip(btnEmanetVer, "Emanet vermek için tıkla.");
            toolTip1.SetToolTip(btnKapat, "Form'dan çıkmak için tıkla.");
            toolTip1.SetToolTip(btnTeslimAl, "Emanet almak için tıkla.");

            toolTip1.SetToolTip(txtArama, "Üye ara.");
            toolTip1.SetToolTip(cmbKitaplar, "Kitap seç veya ara.");
            toolTip1.SetToolTip(cmbUyeler, "Üye seç veya ara.");
            toolTip1.SetToolTip(dtpEmanetTarihi, "Emanet edilen tarihi gösterir.");
            toolTip1.SetToolTip(dtpIadeTarihi, "Iade edilen tarihi gösterir.");

            EmanetleriGetir();
        }
        private void btnEmanetVer_Click(object sender, EventArgs e)
        {
            int kitapId = Convert.ToInt32(cmbKitaplar.SelectedValue);
            int uyeId = Convert.ToInt32(cmbUyeler.SelectedValue);
            DateTime emanetTarihi = dtpEmanetTarihi.Value.Date;
            DateTime iadeTarihi = dtpIadeTarihi.Value.Date;

            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Emanetler (KitapID, UyeID, EmanetTarihi, IadeTarihi) VALUES (@kitap, @uye, @emanet, @iade)", baglanti);
            komut.Parameters.AddWithValue("@kitap", kitapId);
            komut.Parameters.AddWithValue("@uye", uyeId);
            komut.Parameters.AddWithValue("@emanet", emanetTarihi);
            komut.Parameters.AddWithValue("@iade", iadeTarihi);
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Emanet kaydı eklendi.","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            EmanetleriGetir();
        }

        private void btnTeslimAl_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int emanetID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                SqlCommand komut = new SqlCommand(
                    "UPDATE Emanetler SET TeslimEdildi = @TeslimEdildi WHERE EmanetlerID = @EmanetlerID",
                    baglanti);

                komut.Parameters.AddWithValue("@TeslimEdildi", DateTime.Now);
                komut.Parameters.AddWithValue("@EmanetlerID", emanetID);

                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Kitap başarıyla teslim alındı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EmanetleriGetir();
            }
            else
            {
                MessageBox.Show("Lütfen bir emanet seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string aranan = txtArama.Text.Trim();

            SqlDataAdapter da = new SqlDataAdapter(
                @"SELECT E.EmanetlerID, K.KitapAdi, U.AdSoyad, E.EmanetTarihi, E.IadeTarihi, E.TeslimEdildi
                  FROM Emanetler E
                  JOIN Kitaplar K ON E.KitapID = K.KitapID
                  JOIN Uyeler U ON E.UyeID = U.UyeID
                  WHERE K.KitapAdi LIKE @aranan OR U.AdSoyad LIKE @aranan", baglanti);
            da.SelectCommand.Parameters.AddWithValue("@aranan", "%" + aranan + "%");

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        

        private void EmanetleriGetir()
        {
            SqlDataAdapter da = new SqlDataAdapter(
                @"SELECT 
                    E.EmanetlerID AS [Emanet No],
                    K.KitapAdi AS [Kitap Adı],
                    U.AdSoyad AS [Üye Adı],
                    E.EmanetTarihi AS [Emanet Tarihi],
                    E.IadeTarihi AS [İade Tarihi],
                    E.TeslimEdildi AS [Teslim Durumu]
                  FROM Emanetler E
                  JOIN Kitaplar K ON E.KitapID = K.KitapID
                  JOIN Uyeler U ON E.UyeID = U.UyeID",
                baglanti);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dt;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                cmbKitaplar.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmbUyeler.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpEmanetTarihi.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                dtpIadeTarihi.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
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

        private void btnEmanetVer_MouseEnter(object sender, EventArgs e)
        {
            btnEmanetVer.BackColor = Color.Black;
        }

        private void btnEmanetVer_MouseLeave(object sender, EventArgs e)
        {
            btnEmanetVer.BackColor = Color.Silver;
        }

        private void btnTeslimAl_MouseEnter(object sender, EventArgs e)
        {
            btnTeslimAl.BackColor = Color.Black;
        }

        private void btnTeslimAl_MouseLeave(object sender, EventArgs e)
        {
            btnTeslimAl.BackColor = Color.Silver;
        }

        private void btnKapat_MouseEnter(object sender, EventArgs e)
        {
            btnKapat.BackColor = Color.Black;
        }

        private void btnKapat_MouseLeave(object sender, EventArgs e)
        {
            btnKapat.BackColor = Color.Silver;
        }
    }
}
