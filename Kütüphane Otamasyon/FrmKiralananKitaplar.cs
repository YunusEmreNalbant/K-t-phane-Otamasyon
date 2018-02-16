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
    public partial class FrmKiralananKitaplar : Form
    {
        public FrmKiralananKitaplar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmKiralananKitaplar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kütüphaneOtomasyonDataSet8.Tbl_Kirala' table. You can move, or remove it, as needed.
            this.tbl_KiralaTableAdapter.Fill(this.kütüphaneOtomasyonDataSet8.Tbl_Kirala);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SqlCommand kmt3 = new SqlCommand("Delete from Tbl_Kirala Where [Üye Adı]=@ad and [Üye Soyadı]=@soyad", bgl.baglanti());
            kmt3.Parameters.AddWithValue("@ad", TxtKiralananOkurAd.Text);
            kmt3.Parameters.AddWithValue("@soyad", TxtKiralananOkurSoyad.Text);
            kmt3.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Başarıyla Silindi.");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView7.SelectedCells[0].RowIndex;

            TxtKiralananKitap.Text = dataGridView7.Rows[secilen].Cells[0].Value.ToString();
            TxtKiralananOkurAd.Text = dataGridView7.Rows[secilen].Cells[1].Value.ToString();
            TxtKiralananOkurSoyad.Text = dataGridView7.Rows[secilen].Cells[2].Value.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.tbl_KiralaTableAdapter.Fill(this.kütüphaneOtomasyonDataSet8.Tbl_Kirala);
            TxtKiralananOkurAd.Clear();
            TxtKiralananOkurSoyad.Clear();
            TxtKiralananKitap.Clear();
                }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmAnasayfa frm11 = new FrmAnasayfa();
            this.Hide();
            frm11.Show();
        }
    }
}
