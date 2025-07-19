using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Library
{
    public partial class Hakkinda : Form
    {
        public Hakkinda()
        {
            InitializeComponent();
        }

        private void btnAnaSayfaGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete) && richTextBox1.SelectionStart < 1000)
            {
                e.Handled = true; 
            }
            richTextBox1.ReadOnly = true;
        }

        private void btnAnaSayfaGeriDon_MouseEnter(object sender, EventArgs e)
        {
            btnAnaSayfaGeriDon.BackColor = Color.Black;
        }

        private void btnAnaSayfaGeriDon_MouseLeave(object sender, EventArgs e)
        {
            btnAnaSayfaGeriDon.BackColor = Color.Silver;
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            string email = "yusufislamdeligoz333@gmail.com"; 
            string konu = "Kütüphane Hakkında";
            string icerik = "Merhaba, size bir konuda ulaşmak istiyorum.";

            string mailto = $"mailto:{email}?subject={Uri.EscapeDataString(konu)}&body={Uri.EscapeDataString(icerik)}";
            Process.Start(mailto);
        }

        private void btnEmail_MouseEnter(object sender, EventArgs e)
        {
            btnEmail.BackColor = Color.Black;
        }

        private void btnEmail_MouseLeave(object sender, EventArgs e)
        {
            btnEmail.BackColor = Color.Silver;
        }

        private void Hakkinda_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnAnaSayfaGeriDon, "Anasayfa'ya geri dönmek için tıkla.");
            toolTip1.SetToolTip(btnEmail, "E-Posta yollamak için tıkla.");
        }
    }
}
