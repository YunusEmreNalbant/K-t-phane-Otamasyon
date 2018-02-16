namespace Kütüphane_Otamasyon
{
    partial class FrmTümOkuyucular
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTümOkuyucular));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.üyeTCNumarasıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doğumTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonNumarasıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblOkurlarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kütüphaneOtomasyonDataSet9 = new Kütüphane_Otamasyon.KütüphaneOtomasyonDataSet9();
            this.tblOkurlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kütüphaneOtomasyonDataSet1 = new Kütüphane_Otamasyon.KütüphaneOtomasyonDataSet1();
            this.tbl_OkurlarTableAdapter = new Kütüphane_Otamasyon.KütüphaneOtomasyonDataSet1TableAdapters.Tbl_OkurlarTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txtüyesoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txtüyead = new System.Windows.Forms.TextBox();
            this.tbl_OkurlarTableAdapter1 = new Kütüphane_Otamasyon.KütüphaneOtomasyonDataSet9TableAdapters.Tbl_OkurlarTableAdapter();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.TxtArama = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOkurlarBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneOtomasyonDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOkurlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneOtomasyonDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.üyeTCNumarasıDataGridViewTextBoxColumn,
            this.adıDataGridViewTextBoxColumn,
            this.soyadıDataGridViewTextBoxColumn,
            this.doğumTarihiDataGridViewTextBoxColumn,
            this.telefonNumarasıDataGridViewTextBoxColumn,
            this.eMailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblOkurlarBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(3, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(914, 362);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // üyeTCNumarasıDataGridViewTextBoxColumn
            // 
            this.üyeTCNumarasıDataGridViewTextBoxColumn.DataPropertyName = "Üye T_C_ Numarası";
            this.üyeTCNumarasıDataGridViewTextBoxColumn.HeaderText = "Üye T_C_ Numarası";
            this.üyeTCNumarasıDataGridViewTextBoxColumn.Name = "üyeTCNumarasıDataGridViewTextBoxColumn";
            // 
            // adıDataGridViewTextBoxColumn
            // 
            this.adıDataGridViewTextBoxColumn.DataPropertyName = "Adı";
            this.adıDataGridViewTextBoxColumn.HeaderText = "Adı";
            this.adıDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.adıDataGridViewTextBoxColumn.Name = "adıDataGridViewTextBoxColumn";
            this.adıDataGridViewTextBoxColumn.Width = 150;
            // 
            // soyadıDataGridViewTextBoxColumn
            // 
            this.soyadıDataGridViewTextBoxColumn.DataPropertyName = "Soyadı";
            this.soyadıDataGridViewTextBoxColumn.HeaderText = "Soyadı";
            this.soyadıDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.soyadıDataGridViewTextBoxColumn.Name = "soyadıDataGridViewTextBoxColumn";
            this.soyadıDataGridViewTextBoxColumn.Width = 150;
            // 
            // doğumTarihiDataGridViewTextBoxColumn
            // 
            this.doğumTarihiDataGridViewTextBoxColumn.DataPropertyName = "Doğum Tarihi";
            this.doğumTarihiDataGridViewTextBoxColumn.HeaderText = "Doğum Tarihi";
            this.doğumTarihiDataGridViewTextBoxColumn.Name = "doğumTarihiDataGridViewTextBoxColumn";
            // 
            // telefonNumarasıDataGridViewTextBoxColumn
            // 
            this.telefonNumarasıDataGridViewTextBoxColumn.DataPropertyName = "Telefon Numarası";
            this.telefonNumarasıDataGridViewTextBoxColumn.HeaderText = "Telefon Numarası";
            this.telefonNumarasıDataGridViewTextBoxColumn.Name = "telefonNumarasıDataGridViewTextBoxColumn";
            // 
            // eMailDataGridViewTextBoxColumn
            // 
            this.eMailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.eMailDataGridViewTextBoxColumn.DataPropertyName = "E-Mail";
            this.eMailDataGridViewTextBoxColumn.HeaderText = "E-Mail";
            this.eMailDataGridViewTextBoxColumn.MinimumWidth = 189;
            this.eMailDataGridViewTextBoxColumn.Name = "eMailDataGridViewTextBoxColumn";
            // 
            // tblOkurlarBindingSource1
            // 
            this.tblOkurlarBindingSource1.DataMember = "Tbl_Okurlar";
            this.tblOkurlarBindingSource1.DataSource = this.kütüphaneOtomasyonDataSet9;
            // 
            // kütüphaneOtomasyonDataSet9
            // 
            this.kütüphaneOtomasyonDataSet9.DataSetName = "KütüphaneOtomasyonDataSet9";
            this.kütüphaneOtomasyonDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblOkurlarBindingSource
            // 
            this.tblOkurlarBindingSource.DataMember = "Tbl_Okurlar";
            this.tblOkurlarBindingSource.DataSource = this.kütüphaneOtomasyonDataSet1;
            // 
            // kütüphaneOtomasyonDataSet1
            // 
            this.kütüphaneOtomasyonDataSet1.DataSetName = "KütüphaneOtomasyonDataSet1";
            this.kütüphaneOtomasyonDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_OkurlarTableAdapter
            // 
            this.tbl_OkurlarTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(164, 439);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(494, 524);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Listeyi Güncelle";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(473, 437);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(161, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(208, 524);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Okuru Sil";
            // 
            // Txtüyesoyad
            // 
            this.Txtüyesoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtüyesoyad.Location = new System.Drawing.Point(1090, 125);
            this.Txtüyesoyad.Name = "Txtüyesoyad";
            this.Txtüyesoyad.Size = new System.Drawing.Size(178, 24);
            this.Txtüyesoyad.TabIndex = 45;
            this.Txtüyesoyad.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(921, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 19);
            this.label5.TabIndex = 44;
            this.label5.Text = "Kiralanan Okur Soyad:";
            this.label5.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(945, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 19);
            this.label2.TabIndex = 40;
            this.label2.Text = "Kiralanan Okur Ad:";
            this.label2.Visible = false;
            // 
            // Txtüyead
            // 
            this.Txtüyead.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtüyead.Location = new System.Drawing.Point(1090, 84);
            this.Txtüyead.Name = "Txtüyead";
            this.Txtüyead.Size = new System.Drawing.Size(178, 24);
            this.Txtüyead.TabIndex = 41;
            this.Txtüyead.Visible = false;
            // 
            // tbl_OkurlarTableAdapter1
            // 
            this.tbl_OkurlarTableAdapter1.ClearBeforeFill = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 46;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(262, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(125, 17);
            this.radioButton1.TabIndex = 47;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Soyisime göre arama:";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(262, 35);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(111, 17);
            this.radioButton2.TabIndex = 48;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "TC\'ye göre arama:";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // TxtArama
            // 
            this.TxtArama.Location = new System.Drawing.Point(406, 24);
            this.TxtArama.Name = "TxtArama";
            this.TxtArama.Size = new System.Drawing.Size(147, 20);
            this.TxtArama.TabIndex = 50;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(569, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 32);
            this.button1.TabIndex = 51;
            this.button1.Text = "FİLTRELE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmTümOkuyucular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 574);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtArama);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Txtüyesoyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txtüyead);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmTümOkuyucular";
            this.Text = "FrmTümOkuyucular";
            this.Load += new System.EventHandler(this.FrmTümOkuyucular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOkurlarBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneOtomasyonDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOkurlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneOtomasyonDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private KütüphaneOtomasyonDataSet1 kütüphaneOtomasyonDataSet1;
        private System.Windows.Forms.BindingSource tblOkurlarBindingSource;
        private KütüphaneOtomasyonDataSet1TableAdapters.Tbl_OkurlarTableAdapter tbl_OkurlarTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txtüyesoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txtüyead;
        private KütüphaneOtomasyonDataSet9 kütüphaneOtomasyonDataSet9;
        private System.Windows.Forms.BindingSource tblOkurlarBindingSource1;
        private KütüphaneOtomasyonDataSet9TableAdapters.Tbl_OkurlarTableAdapter tbl_OkurlarTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn üyeTCNumarasıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doğumTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonNumarasıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox TxtArama;
        private System.Windows.Forms.Button button1;
    }
}