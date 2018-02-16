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
    public partial class FrmKitapKayıt : Form
    {
        public FrmKitapKayıt()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmKitapKayıt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kütüphaneOtomasyonDataSet2.Tbl_KitapBilgi' table. You can move, or remove it, as needed.
            this.tbl_KitapBilgiTableAdapter.Fill(this.kütüphaneOtomasyonDataSet2.Tbl_KitapBilgi);

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TxtISBN.Clear();
            TxtKitapAd.Clear();
            TxtBaskiSayisi.Clear();
            TxtKitapYazar.Clear();
            TxtSayfaSayisi.Clear();
            TxtTarih.Clear();
            TxtYayinEvi.Clear();

            TxtISBN.Focus(); 

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SqlCommand komutekle = new SqlCommand("insert into Tbl_KitapBilgi (ISBN, [Kitap Adı], [Kitap Yazarı], [Yayın Tarihi], [Sayfa Sayısı], [Baskı Sayısı], [Yayın Evi]) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7)", bgl.baglanti());
            komutekle.Parameters.AddWithValue("@p1", TxtISBN.Text.ToString());
            komutekle.Parameters.AddWithValue("@p2", TxtKitapAd.Text);
            komutekle.Parameters.AddWithValue("@p3", TxtKitapYazar.Text);
            komutekle.Parameters.AddWithValue("@p4", TxtTarih.Text);
            komutekle.Parameters.AddWithValue("@p5", TxtSayfaSayisi.Text);
            komutekle.Parameters.AddWithValue("@p6", TxtBaskiSayisi.Text);
            komutekle.Parameters.AddWithValue("@p7", TxtYayinEvi.Text);
            komutekle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kitap başarıyla eklendi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            TxtISBN.Clear();
            TxtKitapAd.Clear();
            TxtBaskiSayisi.Clear();
            TxtKitapYazar.Clear();
            TxtSayfaSayisi.Clear();
            TxtTarih.Clear();
            TxtYayinEvi.Clear();

            TxtISBN.Focus();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.tbl_KitapBilgiTableAdapter.Fill(this.kütüphaneOtomasyonDataSet2.Tbl_KitapBilgi);   // Kayıt ekledikten sonra güncellemek için kısa yol.

            MessageBox.Show("Liste Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FrmAnasayfa frm8 = new FrmAnasayfa();
            this.Hide();
            frm8.Show();
        }
    }
}
