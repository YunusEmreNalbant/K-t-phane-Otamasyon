namespace Kütüphane_Otamasyon
{
    partial class FrmKitapKayıt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKitapKayıt));
            this.TxtISBN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtKitapAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtKitapYazar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtTarih = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtSayfaSayisi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtBaskiSayisi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtYayinEvi = new System.Windows.Forms.TextBox();
            this.kütüphaneOtomasyonDataSet2 = new Kütüphane_Otamasyon.KütüphaneOtomasyonDataSet2();
            this.tblKitapBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_KitapBilgiTableAdapter = new Kütüphane_Otamasyon.KütüphaneOtomasyonDataSet2TableAdapters.Tbl_KitapBilgiTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapYazarıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayınTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sayfaSayısıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baskıSayısıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayınEviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneOtomasyonDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKitapBilgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtISBN
            // 
            this.TxtISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtISBN.Location = new System.Drawing.Point(140, 72);
            this.TxtISBN.Name = "TxtISBN";
            this.TxtISBN.Size = new System.Drawing.Size(170, 26);
            this.TxtISBN.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(80, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "ISBN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(48, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kitap Adı:";
            // 
            // TxtKitapAd
            // 
            this.TxtKitapAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKitapAd.Location = new System.Drawing.Point(140, 130);
            this.TxtKitapAd.Name = "TxtKitapAd";
            this.TxtKitapAd.Size = new System.Drawing.Size(170, 26);
            this.TxtKitapAd.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(29, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kitap Yazarı:";
            // 
            // TxtKitapYazar
            // 
            this.TxtKitapYazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKitapYazar.Location = new System.Drawing.Point(140, 191);
            this.TxtKitapYazar.Name = "TxtKitapYazar";
            this.TxtKitapYazar.Size = new System.Drawing.Size(170, 26);
            this.TxtKitapYazar.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(31, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Yayın Tarihi:";
            // 
            // TxtTarih
            // 
            this.TxtTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTarih.Location = new System.Drawing.Point(140, 253);
            this.TxtTarih.Name = "TxtTarih";
            this.TxtTarih.Size = new System.Drawing.Size(170, 26);
            this.TxtTarih.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(28, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sayfa Sayısı:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtSayfaSayisi
            // 
            this.TxtSayfaSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSayfaSayisi.Location = new System.Drawing.Point(140, 310);
            this.TxtSayfaSayisi.Name = "TxtSayfaSayisi";
            this.TxtSayfaSayisi.Size = new System.Drawing.Size(170, 26);
            this.TxtSayfaSayisi.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(30, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Baskı Sayısı:";
            // 
            // TxtBaskiSayisi
            // 
            this.TxtBaskiSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBaskiSayisi.Location = new System.Drawing.Point(140, 368);
            this.TxtBaskiSayisi.Name = "TxtBaskiSayisi";
            this.TxtBaskiSayisi.Size = new System.Drawing.Size(170, 26);
            this.TxtBaskiSayisi.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(50, 428);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Yayın Evi:";
            // 
            // TxtYayinEvi
            // 
            this.TxtYayinEvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtYayinEvi.Location = new System.Drawing.Point(140, 428);
            this.TxtYayinEvi.Name = "TxtYayinEvi";
            this.TxtYayinEvi.Size = new System.Drawing.Size(170, 26);
            this.TxtYayinEvi.TabIndex = 12;
            // 
            // kütüphaneOtomasyonDataSet2
            // 
            this.kütüphaneOtomasyonDataSet2.DataSetName = "KütüphaneOtomasyonDataSet2";
            this.kütüphaneOtomasyonDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblKitapBilgiBindingSource
            // 
            this.tblKitapBilgiBindingSource.DataMember = "Tbl_KitapBilgi";
            this.tblKitapBilgiBindingSource.DataSource = this.kütüphaneOtomasyonDataSet2;
            // 
            // tbl_KitapBilgiTableAdapter
            // 
            this.tbl_KitapBilgiTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 507);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(308, 507);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 83);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(165, 507);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(125, 83);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(35, 597);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 26);
            this.label8.TabIndex = 18;
            this.label8.Text = "İPTAL ET";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(320, 595);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 26);
            this.label9.TabIndex = 19;
            this.label9.Text = "GÜNCELLE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(181, 595);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 26);
            this.label10.TabIndex = 20;
            this.label10.Text = "KAYDET";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıSBNDataGridViewTextBoxColumn,
            this.kitapAdıDataGridViewTextBoxColumn,
            this.kitapYazarıDataGridViewTextBoxColumn,
            this.yayınTarihiDataGridViewTextBoxColumn,
            this.sayfaSayısıDataGridViewTextBoxColumn,
            this.baskıSayısıDataGridViewTextBoxColumn,
            this.yayınEviDataGridViewTextBoxColumn,
            this.id});
            this.dataGridView1.DataSource = this.tblKitapBilgiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(353, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1053, 379);
            this.dataGridView1.TabIndex = 14;
            // 
            // ıSBNDataGridViewTextBoxColumn
            // 
            this.ıSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.ıSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.ıSBNDataGridViewTextBoxColumn.Name = "ıSBNDataGridViewTextBoxColumn";
            // 
            // kitapAdıDataGridViewTextBoxColumn
            // 
            this.kitapAdıDataGridViewTextBoxColumn.DataPropertyName = "Kitap Adı";
            this.kitapAdıDataGridViewTextBoxColumn.HeaderText = "Kitap Adı";
            this.kitapAdıDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.kitapAdıDataGridViewTextBoxColumn.Name = "kitapAdıDataGridViewTextBoxColumn";
            this.kitapAdıDataGridViewTextBoxColumn.Width = 200;
            // 
            // kitapYazarıDataGridViewTextBoxColumn
            // 
            this.kitapYazarıDataGridViewTextBoxColumn.DataPropertyName = "Kitap Yazarı";
            this.kitapYazarıDataGridViewTextBoxColumn.HeaderText = "Kitap Yazarı";
            this.kitapYazarıDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.kitapYazarıDataGridViewTextBoxColumn.Name = "kitapYazarıDataGridViewTextBoxColumn";
            this.kitapYazarıDataGridViewTextBoxColumn.Width = 200;
            // 
            // yayınTarihiDataGridViewTextBoxColumn
            // 
            this.yayınTarihiDataGridViewTextBoxColumn.DataPropertyName = "Yayın Tarihi";
            this.yayınTarihiDataGridViewTextBoxColumn.HeaderText = "Yayın Tarihi";
            this.yayınTarihiDataGridViewTextBoxColumn.Name = "yayınTarihiDataGridViewTextBoxColumn";
            // 
            // sayfaSayısıDataGridViewTextBoxColumn
            // 
            this.sayfaSayısıDataGridViewTextBoxColumn.DataPropertyName = "Sayfa Sayısı";
            this.sayfaSayısıDataGridViewTextBoxColumn.HeaderText = "Sayfa Sayısı";
            this.sayfaSayısıDataGridViewTextBoxColumn.Name = "sayfaSayısıDataGridViewTextBoxColumn";
            // 
            // baskıSayısıDataGridViewTextBoxColumn
            // 
            this.baskıSayısıDataGridViewTextBoxColumn.DataPropertyName = "Baskı Sayısı";
            this.baskıSayısıDataGridViewTextBoxColumn.HeaderText = "Baskı Sayısı";
            this.baskıSayısıDataGridViewTextBoxColumn.Name = "baskıSayısıDataGridViewTextBoxColumn";
            // 
            // yayınEviDataGridViewTextBoxColumn
            // 
            this.yayınEviDataGridViewTextBoxColumn.DataPropertyName = "Yayın Evi";
            this.yayınEviDataGridViewTextBoxColumn.HeaderText = "Yayın Evi";
            this.yayınEviDataGridViewTextBoxColumn.MinimumWidth = 211;
            this.yayınEviDataGridViewTextBoxColumn.Name = "yayınEviDataGridViewTextBoxColumn";
            this.yayınEviDataGridViewTextBoxColumn.Width = 211;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(56, 43);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // FrmKitapKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 630);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtYayinEvi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtBaskiSayisi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtSayfaSayisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtTarih);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtKitapYazar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtKitapAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtISBN);
            this.Name = "FrmKitapKayıt";
            this.Text = "FrmKitapKayıt";
            this.Load += new System.EventHandler(this.FrmKitapKayıt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneOtomasyonDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKitapBilgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtISBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtKitapAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtKitapYazar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtTarih;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtSayfaSayisi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtBaskiSayisi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtYayinEvi;
        private KütüphaneOtomasyonDataSet2 kütüphaneOtomasyonDataSet2;
        private System.Windows.Forms.BindingSource tblKitapBilgiBindingSource;
        private KütüphaneOtomasyonDataSet2TableAdapters.Tbl_KitapBilgiTableAdapter tbl_KitapBilgiTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapYazarıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayınTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sayfaSayısıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baskıSayısıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayınEviDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}