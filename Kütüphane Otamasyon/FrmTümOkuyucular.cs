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
    public partial class FrmTümOkuyucular : Form
    {
        public FrmTümOkuyucular()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmTümOkuyucular_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kütüphaneOtomasyonDataSet9.Tbl_Okurlar' table. You can move, or remove it, as needed.
            this.tbl_OkurlarTableAdapter1.Fill(this.kütüphaneOtomasyonDataSet9.Tbl_Okurlar);
            // TODO: This line of code loads data into the 'kütüphaneOtomasyonDataSet1.Tbl_Okurlar' table. You can move, or remove it, as needed.
          //  this.tbl_OkurlarTableAdapter.Fill(this.kütüphaneOtomasyonDataSet1.Tbl_Okurlar);

        }

        private void dataGridView11_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

       
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SqlCommand kmt4 = new SqlCommand("Delete from Tbl_Okurlar Where Adı=@ad2 and Soyadı=@soyad2", bgl.baglanti());
            kmt4.Parameters.AddWithValue("@ad2", Txtüyead.Text);
            kmt4.Parameters.AddWithValue("@soyad2", Txtüyesoyad.Text);
            kmt4.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Başarıyla Silindi.");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

           Txtüyead.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
           Txtüyesoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.tbl_OkurlarTableAdapter1.Fill(this.kütüphaneOtomasyonDataSet9.Tbl_Okurlar);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmAnasayfa frm7 = new FrmAnasayfa();
            this.Hide();
            frm7.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // FİLTRELEME ÖZELLİGİ YAPTIM.


            if(radioButton1.Checked==true)
            {
                DataTable tbl = new DataTable();
                string var, cumle;
                var =TxtArama.Text;
                cumle = "Select * from Tbl_Okurlar where Soyadı like '%" + TxtArama.Text + "%'";
                SqlDataAdapter adptr = new SqlDataAdapter(cumle, bgl.baglanti());
                adptr.Fill(tbl);
                bgl.baglanti().Close();
                dataGridView1.DataSource = tbl;

            }
            if(radioButton2.Checked==true)
            {
                DataTable tbl2 = new DataTable();
                string var2, cumle2;
                var2 = TxtArama.Text;
                cumle2 = "Select * from Tbl_Okurlar where [Üye T.C. Numarası] like '%" + TxtArama.Text + "%'";
                SqlDataAdapter adptr = new SqlDataAdapter(cumle2, bgl.baglanti());
                adptr.Fill(tbl2);
                bgl.baglanti().Close();
                dataGridView1.DataSource = tbl2;
            }
        }
    }
}
