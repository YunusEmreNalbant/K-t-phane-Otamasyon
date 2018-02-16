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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
         
            if(textBox1.Text=="admin" && textBox2.Text=="12345")
            {
                FrmYüklemeEkranı frm = new FrmYüklemeEkranı();
                frm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı bir giriş yaptınız !");
                sayac = sayac + 1;
                if(sayac>=3)
                {
                    MessageBox.Show("Çok kez yanlış giriş yaptınız. Uygulama kapatılıyor.");
                    Application.Exit();
                }
            }

        }

       
    }
}
