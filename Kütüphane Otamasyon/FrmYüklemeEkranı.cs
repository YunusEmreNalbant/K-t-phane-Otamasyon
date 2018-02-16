using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Otamasyon
{
    public partial class FrmYüklemeEkranı : Form
    {
        public FrmYüklemeEkranı()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            progressBar1.Value += 20;

            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                FrmAnasayfa frm2 = new FrmAnasayfa();
                this.Hide();
                frm2.Show();
            }
        }

        private void FrmYüklemeEkranı_Load(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.Text = label1.Text.Substring(1) + label1.Text.Substring(0, 1);
            
        }
    }
}
