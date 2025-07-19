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
    public partial class KullanimKlavuzu : Form
    {
        public KullanimKlavuzu()
        {
            InitializeComponent();
        }

        private void btnAnaSayfaGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnaSayfaGeriDon_MouseEnter(object sender, EventArgs e)
        {
            btnAnaSayfaGeriDon.BackColor = Color.Black;
        }

        private void btnAnaSayfaGeriDon_MouseLeave(object sender, EventArgs e)
        {
            btnAnaSayfaGeriDon.BackColor = Color.Silver;
        }

        private void KullanimKlavuzu_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnAnaSayfaGeriDon, "Anasayfa'ya geri dönmek için tıkla.");
        }
    }
}
