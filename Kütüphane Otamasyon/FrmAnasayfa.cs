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
    public partial class FrmAnasayfa : Form
    {
        public FrmAnasayfa()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmTümKitaplar frm = new FrmTümKitaplar();
            frm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmKitapKayıt frm = new FrmKitapKayıt();
            frm.Show();
            this.Hide();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FrmTümKitaplar frm = new FrmTümKitaplar();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmKitapKayıt frm = new FrmKitapKayıt();
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmTümOkuyucular frm2 = new FrmTümOkuyucular();
            frm2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmOkuyucuEkle frm3 = new FrmOkuyucuEkle();
            frm3.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmOkuyucuEkle frm3 = new FrmOkuyucuEkle();
            frm3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmKiralama frm4 = new FrmKiralama();
            frm4.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmKiralama frm4 = new FrmKiralama();
            frm4.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmKiralananKitaplar frm5 = new FrmKiralananKitaplar();
            frm5.Show();
            this.Hide();
        }
    }
}
