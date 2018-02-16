namespace Kütüphane_Otamasyon
{
    partial class FrmTümKitaplar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTümKitaplar));
            this.tblKitapBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kütüphaneOtomasyonDataSet = new Kütüphane_Otamasyon.KütüphaneOtomasyonDataSet();
            this.tbl_KitapBilgiTableAdapter = new Kütüphane_Otamasyon.KütüphaneOtomasyonDataSetTableAdapters.Tbl_KitapBilgiTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapYazarıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayınTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sayfaSayısıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baskıSayısıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayınEviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblKitapBilgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneOtomasyonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tblKitapBilgiBindingSource
            // 
            this.tblKitapBilgiBindingSource.DataMember = "Tbl_KitapBilgi";
            this.tblKitapBilgiBindingSource.DataSource = this.kütüphaneOtomasyonDataSet;
            // 
            // kütüphaneOtomasyonDataSet
            // 
            this.kütüphaneOtomasyonDataSet.DataSetName = "KütüphaneOtomasyonDataSet";
            this.kütüphaneOtomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_KitapBilgiTableAdapter
            // 
            this.tbl_KitapBilgiTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(312, 656);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(348, 90);
            this.button1.TabIndex = 1;
            this.button1.Text = "ÇIKIŞ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(312, 656);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(2, 44);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1148, 590);
            this.dataGridView1.TabIndex = 0;
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
            this.yayınEviDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.yayınEviDataGridViewTextBoxColumn.Name = "yayınEviDataGridViewTextBoxColumn";
            this.yayınEviDataGridViewTextBoxColumn.Width = 200;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(2, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // FrmTümKitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 759);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmTümKitaplar";
            this.Text = "FrmTümKitaplar";
            this.Load += new System.EventHandler(this.FrmTümKitaplar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblKitapBilgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneOtomasyonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private KütüphaneOtomasyonDataSet kütüphaneOtomasyonDataSet;
        private System.Windows.Forms.BindingSource tblKitapBilgiBindingSource;
        private KütüphaneOtomasyonDataSetTableAdapters.Tbl_KitapBilgiTableAdapter tbl_KitapBilgiTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapYazarıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayınTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sayfaSayısıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baskıSayısıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayınEviDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}