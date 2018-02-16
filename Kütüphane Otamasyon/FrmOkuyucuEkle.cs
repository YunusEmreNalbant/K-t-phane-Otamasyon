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
    public partial class FrmOkuyucuEkle : Form
    {
        public FrmOkuyucuEkle()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TxtOkuyucuAd.Clear();
            TxtOkuyucuMail.Clear();
            TxtOkuyucuSoyad.Clear();
            MskOkuyucuTC.Clear();
            MskOkuyucuTelefon.Clear();

            MskOkuyucuTC.Focus();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmOkuyucuEkle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kütüphaneOtomasyonDataSet5.Tbl_Okurlar' table. You can move, or remove it, as needed.
            this.tbl_OkurlarTableAdapter2.Fill(this.kütüphaneOtomasyonDataSet5.Tbl_Okurlar);
            // TODO: This line of code loads data into the 'kütüphaneOtomasyonDataSet4.Tbl_Okurlar' table. You can move, or remove it, as needed.
            //this.tbl_OkurlarTableAdapter1.Fill(this.kütüphaneOtomasyonDataSet4.Tbl_Okurlar);
            /// bu niye hata veriyor
            // TODO: This line of code loads data into the 'kütüphaneOtomasyonDataSet3.Tbl_Okurlar' table. You can move, or remove it, as needed.
           // this.tbl_OkurlarTableAdapter.Fill(this.kütüphaneOtomasyonDataSet3.Tbl_Okurlar);

        }
      
        private void pictureBox3_Click(object sender, EventArgs e)
        {

          
            SqlCommand kmt = new SqlCommand("insert into Tbl_Okurlar ([Üye T.C. Numarası], Adı, Soyadı,[Doğum Tarihi], [Telefon Numarası], [E-Mail]) values (@p1, @p2, @p3,@p4, @p5, @p6)", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", MskOkuyucuTC.Text);
            kmt.Parameters.AddWithValue("@p2", TxtOkuyucuAd.Text);
            kmt.Parameters.AddWithValue("@p3", TxtOkuyucuSoyad.Text);
            kmt.Parameters.AddWithValue("@p4", SqlDbType.Date).Value= dateTimePicker1.Value;
            //MessageBox.Show(MskOkuyucuTelefon.Text.Length.ToString()); burda telefon kısmı kaç karakter alıyor diye baktım. ona göre sql de alan açtım.
            kmt.Parameters.AddWithValue("@p5", MskOkuyucuTelefon.Text);
            kmt.Parameters.AddWithValue("@p6", TxtOkuyucuMail.Text);

            kmt.ExecuteNonQuery();
         

           
            bgl.baglanti().Close();

            MessageBox.Show("Okuyucu Eklendi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            TxtOkuyucuAd.Clear();
            TxtOkuyucuMail.Clear();
            TxtOkuyucuSoyad.Clear();
            MskOkuyucuTC.Clear();
            MskOkuyucuTelefon.Clear();

            MskOkuyucuTC.Focus();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.tbl_OkurlarTableAdapter2.Fill(this.kütüphaneOtomasyonDataSet5.Tbl_Okurlar); // Kısa yoldan güncelleme.

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FrmAnasayfa frm9 = new FrmAnasayfa();
            this.Hide();
            frm9.Show();
        }
    }
}
