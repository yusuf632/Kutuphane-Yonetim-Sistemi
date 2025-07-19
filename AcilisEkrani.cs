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
    public partial class AcilisEkrani : Form
    {
        public AcilisEkrani()
        {
            InitializeComponent();
        }
        int yuklemeOrani = 0;
        private void AcilisEkrani_Load(object sender, EventArgs e)
        {
            yuklemeOrani = 0;
            labelYuzde.Text = "%0";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            AcilisEkrani acilisEkrani = new AcilisEkrani();
            if(yuklemeOrani < 100)
            {
                yuklemeOrani++;
                labelYuzde.Text = "%" + yuklemeOrani.ToString();
            }
            else
            {
                timer1.Stop();
                admin.Visible = true;
                this.Hide();
            }
        }
    }
}
