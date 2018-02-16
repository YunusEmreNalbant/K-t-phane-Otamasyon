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
    public partial class FrmKiralama : Form
    {
        public FrmKiralama()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmKiralama_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kütüphaneOtomasyonDataSet7.Tbl_KitapBilgi' table. You can move, or remove it, as needed.
            this.tbl_KitapBilgiTableAdapter.Fill(this.kütüphaneOtomasyonDataSet7.Tbl_KitapBilgi);
            // TODO: This line of code loads data into the 'kütüphaneOtomasyonDataSet6.Tbl_Okurlar' table. You can move, or remove it, as needed.
            this.tbl_OkurlarTableAdapter.Fill(this.kütüphaneOtomasyonDataSet6.Tbl_Okurlar);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TxtKiralananKitap.Clear();
            TxtKiralananOkurAd.Clear();

            TxtKiralananKitap.Focus();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.tbl_KitapBilgiTableAdapter.Fill(this.kütüphaneOtomasyonDataSet7.Tbl_KitapBilgi);
            this.tbl_OkurlarTableAdapter.Fill(this.kütüphaneOtomasyonDataSet6.Tbl_Okurlar);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtKiralananOkurAd.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtKiralananOkurSoyad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen2 = dataGridView2.SelectedCells[0].RowIndex;
            TxtKiralananKitap.Text = dataGridView2.Rows[secilen2].Cells[0].Value.ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SqlCommand kmt2 = new SqlCommand("insert into Tbl_Kirala ([Kitap Adı],[Üye Adı],[Üye Soyadı],[Alım Tarihi], [Teslim Tarihi]) values(@a1, @a2, @a3, @a4, @a5)", bgl.baglanti());
            kmt2.Parameters.AddWithValue("@a1", TxtKiralananKitap.Text);
            kmt2.Parameters.AddWithValue("@a2", TxtKiralananOkurAd.Text);
            kmt2.Parameters.AddWithValue("@a3", TxtKiralananOkurSoyad.Text);
            kmt2.Parameters.AddWithValue("@a4", SqlDbType.Date).Value = tarih1.Value;
            kmt2.Parameters.AddWithValue("@a5", SqlDbType.Date).Value = tarih2.Value;
            kmt2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Başarıyla eklendi.");

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            FrmAnasayfa frm12 = new FrmAnasayfa();
            this.Hide();
            frm12.Show();
        }
    }
}
