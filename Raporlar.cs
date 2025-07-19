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
    public partial class Raporlar : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-QSULL7A\SQLEXPRESS;Initial Catalog=KutuphaneYonetim;Integrated Security=True");
        public Raporlar()
        {
            InitializeComponent();
        }

        private void Raporlar_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT UyeID, AdSoyad FROM Uyeler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbUyeler.DisplayMember = "AdSoyad";
            cmbUyeler.ValueMember = "UyeID";
            cmbUyeler.DataSource = dt;

            RaporlariGetir();

            toolTip1.SetToolTip(btnKapat, "Form'dan çıkmak için tıkla.");
            toolTip1.SetToolTip(btnListele, "Listelemek için tıkla.");
            toolTip1.SetToolTip(btnTeslimEtmeyenler, "Teslim etmeyenleri görmek için tıkla.");

            toolTip1.SetToolTip(cmbUyeler, "Üye seç veya ara.");
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            int uyeID = Convert.ToInt32(cmbUyeler.SelectedValue);

            SqlDataAdapter da = new SqlDataAdapter(@"SELECT E.EmanetlerID, K.KitapAdi, E.EmanetTarihi, E.IadeTarihi, E.TeslimEdildi FROM Emanetler E JOIN Kitaplar K ON E.KitapID = K.KitapID WHERE E.UyeID = @uyeID", baglanti);

            da.SelectCommand.Parameters.AddWithValue("@uyeID", uyeID);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void RaporlariGetir()
        {

            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT E.EmanetlerID, K.KitapAdi, U.AdSoyad, E.EmanetTarihi, E.IadeTarihi, E.TeslimEdildi " +
                "FROM Emanetler E " +
                "JOIN Kitaplar K ON E.KitapID = K.KitapID " +
                "JOIN Uyeler U ON E.UyeID = U.UyeID",
                baglanti
            );

            DataTable dt = new DataTable();
            da.Fill(dt);

            // Otomatik kolon oluşturmayı AÇ
            dataGridView1.AutoGenerateColumns = true;

            // Veriyi DataGrid'e aktar
            dataGridView1.DataSource = dt;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListele_MouseEnter(object sender, EventArgs e)
        {
            btnListele.BackColor = Color.Black;
        }

        private void btnListele_MouseLeave(object sender, EventArgs e)
        {
            btnListele.BackColor = Color.Silver;
        }

        private void btnKapat_MouseEnter(object sender, EventArgs e)
        {
            btnKapat.BackColor = Color.Black;
        }

        private void btnKapat_MouseLeave(object sender, EventArgs e)
        {
            btnKapat.BackColor = Color.Silver;
        }

        private void btnTeslimEtmeyenler_Click(object sender, EventArgs e)
        {
            TeslimEtmeyenleriGetir();
        }

        private void TeslimEtmeyenleriGetir()
        {
                string sorgu = @"SELECT 
                        E.EmanetlerID AS [Emanet No],
                        U.AdSoyad AS [Üye Adı], 
                        K.KitapAdi AS [Kitap Adı], 
                        E.EmanetTarihi AS [Emanet Tarihi], 
                        E.IadeTarihi AS [İade Tarihi]
                    FROM Emanetler E
                    JOIN Kitaplar K ON E.KitapID = K.KitapID
                    JOIN Uyeler U ON E.UyeID = U.UyeID
                    WHERE E.TeslimEdildi IS NULL";

                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                // Otomatik kolon oluşturmayı AÇ
                dataGridView1.AutoGenerateColumns = true;

                // Veriyi DataGrid'e aktar
                dataGridView1.DataSource = dt;
            
        }

        private void btnTeslimEtmeyenler_MouseEnter(object sender, EventArgs e)
        {
            btnTeslimEtmeyenler.BackColor = Color.Black;
        }

        private void btnTeslimEtmeyenler_MouseLeave(object sender, EventArgs e)
        {
            btnTeslimEtmeyenler.BackColor = Color.Silver;
        }
    }
}
