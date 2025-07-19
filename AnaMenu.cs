using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Library
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }
        Admin admin = new Admin();
        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show(
            "Çıkmak istediğinizden emin misiniz?","Çıkış",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void şifreDeğişikliğiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SifreYenileme sifreYenileme = new SifreYenileme();
            sifreYenileme.Show();
        }

        private void kullanımKılavuzuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullanimKlavuzu kullanimKlavuzu = new KullanimKlavuzu();
            kullanimKlavuzu.Show();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hakkinda hakkinda = new Hakkinda();
            hakkinda.Show();
        }

        Random rnd = new Random();

        private void AnaMenu_Load(object sender, EventArgs e)
        {
            dtpTarih.Value = DateTime.Today;
        }

        private void kitapEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kitapİslemleri kitapekle = new Kitapİslemleri();
            kitapekle.ShowDialog();
        }

        private void kitapİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kitapİslemleri kitapİslemleri = new Kitapİslemleri();
            kitapİslemleri.Show();
        }

        private void üyeİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uyeİslemleri uyeİslemleri = new Uyeİslemleri();
            uyeİslemleri.Show();
        }

        private void emanetİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Emanetİslemleri emanetİslemleri = new Emanetİslemleri();
            emanetİslemleri.Show();
        }

        private void raporlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Raporlar raporlar = new Raporlar();
            raporlar.Show();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(this, new Point(e.X, e.Y));
            }
        }

        private void kitapİşlemleriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Kitapİslemleri kitapİslemleri = new Kitapİslemleri();
            kitapİslemleri.Show();
        }

        private void üyeİşlemleriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Uyeİslemleri uyeİslemleri = new Uyeİslemleri();
            uyeİslemleri.Show();
        }

        private void emanetİşlemleriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Emanetİslemleri emanetİslemleri = new Emanetİslemleri();
            emanetİslemleri.Show();
        }

        private void raporlarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Raporlar raporlar = new Raporlar();
            raporlar.Show();
        }

        
    }
}
