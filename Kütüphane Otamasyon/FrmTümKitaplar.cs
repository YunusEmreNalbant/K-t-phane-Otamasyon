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
namespace Kütüphane_Otamasyon
{
    public partial class FrmTümKitaplar : Form
    {
        public FrmTümKitaplar()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmTümKitaplar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kütüphaneOtomasyonDataSet.Tbl_KitapBilgi' table. You can move, or remove it, as needed.
            this.tbl_KitapBilgiTableAdapter.Fill(this.kütüphaneOtomasyonDataSet.Tbl_KitapBilgi);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnasayfa frm = new FrmAnasayfa();
            frm.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmAnasayfa frm17 = new FrmAnasayfa();
            this.Hide();
            frm17.Show();
        }
    }
}
