
namespace EntityFrameworkGiris
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUrunler = new System.Windows.Forms.Button();
            this.btnKategoriler = new System.Windows.Forms.Button();
            this.btnTedarikciler = new System.Windows.Forms.Button();
            this.btnKategoriKaydet = new System.Windows.Forms.Button();
            this.txtKategoriAd = new System.Windows.Forms.TextBox();
            this.txtTanimi = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.txtBirimdekiMiktari = new System.Windows.Forms.TextBox();
            this.btnUrunKaydet = new System.Windows.Forms.Button();
            this.btnKategoriSil = new System.Windows.Forms.Button();
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.btnTedarikciSil = new System.Windows.Forms.Button();
            this.btnKategoriGuncelle = new System.Windows.Forms.Button();
            this.brnUrunGuncelle = new System.Windows.Forms.Button();
            this.btnGoster = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSayilar = new System.Windows.Forms.Button();
            this.btnMusteriListele = new System.Windows.Forms.Button();
            this.btnAharf = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            this.txtAranan = new System.Windows.Forms.TextBox();
            this.btnBulLambda = new System.Windows.Forms.Button();
            this.btnAdaGore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 159);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnUrunler
            // 
            this.btnUrunler.Location = new System.Drawing.Point(12, 12);
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.Size = new System.Drawing.Size(75, 30);
            this.btnUrunler.TabIndex = 1;
            this.btnUrunler.Text = "Ürünler";
            this.btnUrunler.UseVisualStyleBackColor = true;
            this.btnUrunler.Click += new System.EventHandler(this.btnUrunler_Click);
            // 
            // btnKategoriler
            // 
            this.btnKategoriler.Location = new System.Drawing.Point(285, 12);
            this.btnKategoriler.Name = "btnKategoriler";
            this.btnKategoriler.Size = new System.Drawing.Size(87, 30);
            this.btnKategoriler.TabIndex = 2;
            this.btnKategoriler.Text = "Kategoriler";
            this.btnKategoriler.UseVisualStyleBackColor = true;
            this.btnKategoriler.Click += new System.EventHandler(this.btnKategoriler_Click);
            // 
            // btnTedarikciler
            // 
            this.btnTedarikciler.Location = new System.Drawing.Point(546, 12);
            this.btnTedarikciler.Name = "btnTedarikciler";
            this.btnTedarikciler.Size = new System.Drawing.Size(94, 30);
            this.btnTedarikciler.TabIndex = 3;
            this.btnTedarikciler.Text = "Tedarikçiler";
            this.btnTedarikciler.UseVisualStyleBackColor = true;
            this.btnTedarikciler.Click += new System.EventHandler(this.btnTedarikciler_Click);
            // 
            // btnKategoriKaydet
            // 
            this.btnKategoriKaydet.Location = new System.Drawing.Point(285, 87);
            this.btnKategoriKaydet.Name = "btnKategoriKaydet";
            this.btnKategoriKaydet.Size = new System.Drawing.Size(75, 31);
            this.btnKategoriKaydet.TabIndex = 4;
            this.btnKategoriKaydet.Text = "Kaydet";
            this.btnKategoriKaydet.UseVisualStyleBackColor = true;
            this.btnKategoriKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtKategoriAd
            // 
            this.txtKategoriAd.Location = new System.Drawing.Point(285, 54);
            this.txtKategoriAd.Name = "txtKategoriAd";
            this.txtKategoriAd.Size = new System.Drawing.Size(100, 22);
            this.txtKategoriAd.TabIndex = 5;
            // 
            // txtTanimi
            // 
            this.txtTanimi.Location = new System.Drawing.Point(391, 54);
            this.txtTanimi.Name = "txtTanimi";
            this.txtTanimi.Size = new System.Drawing.Size(100, 22);
            this.txtTanimi.TabIndex = 6;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(12, 54);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(100, 22);
            this.txtUrunAdi.TabIndex = 7;
            // 
            // txtBirimdekiMiktari
            // 
            this.txtBirimdekiMiktari.Location = new System.Drawing.Point(118, 54);
            this.txtBirimdekiMiktari.Name = "txtBirimdekiMiktari";
            this.txtBirimdekiMiktari.Size = new System.Drawing.Size(100, 22);
            this.txtBirimdekiMiktari.TabIndex = 8;
            // 
            // btnUrunKaydet
            // 
            this.btnUrunKaydet.Location = new System.Drawing.Point(12, 87);
            this.btnUrunKaydet.Name = "btnUrunKaydet";
            this.btnUrunKaydet.Size = new System.Drawing.Size(75, 31);
            this.btnUrunKaydet.TabIndex = 10;
            this.btnUrunKaydet.Text = "Kaydet";
            this.btnUrunKaydet.UseVisualStyleBackColor = true;
            this.btnUrunKaydet.Click += new System.EventHandler(this.btnUrunKaydet_Click);
            // 
            // btnKategoriSil
            // 
            this.btnKategoriSil.Location = new System.Drawing.Point(391, 87);
            this.btnKategoriSil.Name = "btnKategoriSil";
            this.btnKategoriSil.Size = new System.Drawing.Size(75, 31);
            this.btnKategoriSil.TabIndex = 11;
            this.btnKategoriSil.Text = "Sil";
            this.btnKategoriSil.UseVisualStyleBackColor = true;
            this.btnKategoriSil.Click += new System.EventHandler(this.btnKategoriSil_Click);
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.Location = new System.Drawing.Point(93, 87);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(75, 31);
            this.btnUrunSil.TabIndex = 12;
            this.btnUrunSil.Text = "Sil";
            this.btnUrunSil.UseVisualStyleBackColor = true;
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click);
            // 
            // btnTedarikciSil
            // 
            this.btnTedarikciSil.Location = new System.Drawing.Point(676, 19);
            this.btnTedarikciSil.Name = "btnTedarikciSil";
            this.btnTedarikciSil.Size = new System.Drawing.Size(75, 23);
            this.btnTedarikciSil.TabIndex = 13;
            this.btnTedarikciSil.Text = "Sil";
            this.btnTedarikciSil.UseVisualStyleBackColor = true;
            this.btnTedarikciSil.Click += new System.EventHandler(this.btnTedarikciSil_Click);
            // 
            // btnKategoriGuncelle
            // 
            this.btnKategoriGuncelle.Location = new System.Drawing.Point(481, 87);
            this.btnKategoriGuncelle.Name = "btnKategoriGuncelle";
            this.btnKategoriGuncelle.Size = new System.Drawing.Size(98, 31);
            this.btnKategoriGuncelle.TabIndex = 14;
            this.btnKategoriGuncelle.Text = "Güncelle";
            this.btnKategoriGuncelle.UseVisualStyleBackColor = true;
            this.btnKategoriGuncelle.Click += new System.EventHandler(this.btnKategoriGuncelle_Click);
            // 
            // brnUrunGuncelle
            // 
            this.brnUrunGuncelle.Location = new System.Drawing.Point(174, 87);
            this.brnUrunGuncelle.Name = "brnUrunGuncelle";
            this.brnUrunGuncelle.Size = new System.Drawing.Size(93, 31);
            this.brnUrunGuncelle.TabIndex = 15;
            this.brnUrunGuncelle.Text = "Güncelle";
            this.brnUrunGuncelle.UseVisualStyleBackColor = true;
            this.brnUrunGuncelle.Click += new System.EventHandler(this.brnUrunGuncelle_Click);
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(156, 314);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(93, 39);
            this.btnGoster.TabIndex = 16;
            this.btnGoster.Text = "linq Göster";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 314);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(138, 100);
            this.listBox1.TabIndex = 17;
            // 
            // btnSayilar
            // 
            this.btnSayilar.Location = new System.Drawing.Point(255, 314);
            this.btnSayilar.Name = "btnSayilar";
            this.btnSayilar.Size = new System.Drawing.Size(75, 39);
            this.btnSayilar.TabIndex = 18;
            this.btnSayilar.Text = "Sayılar";
            this.btnSayilar.UseVisualStyleBackColor = true;
            this.btnSayilar.Click += new System.EventHandler(this.btnSayilar_Click);
            // 
            // btnMusteriListele
            // 
            this.btnMusteriListele.Location = new System.Drawing.Point(156, 359);
            this.btnMusteriListele.Name = "btnMusteriListele";
            this.btnMusteriListele.Size = new System.Drawing.Size(93, 55);
            this.btnMusteriListele.TabIndex = 19;
            this.btnMusteriListele.Text = "Müşteri Listele";
            this.btnMusteriListele.UseVisualStyleBackColor = true;
            this.btnMusteriListele.Click += new System.EventHandler(this.btnMusteriListele_Click);
            // 
            // btnAharf
            // 
            this.btnAharf.Location = new System.Drawing.Point(255, 359);
            this.btnAharf.Name = "btnAharf";
            this.btnAharf.Size = new System.Drawing.Size(75, 55);
            this.btnAharf.TabIndex = 20;
            this.btnAharf.Text = "A harfi";
            this.btnAharf.UseVisualStyleBackColor = true;
            this.btnAharf.Click += new System.EventHandler(this.btnAharf_Click);
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(366, 342);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(75, 23);
            this.btnBul.TabIndex = 21;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // txtAranan
            // 
            this.txtAranan.Location = new System.Drawing.Point(366, 314);
            this.txtAranan.Name = "txtAranan";
            this.txtAranan.Size = new System.Drawing.Size(100, 22);
            this.txtAranan.TabIndex = 22;
            this.txtAranan.TextChanged += new System.EventHandler(this.btnBul_Click);
            // 
            // btnBulLambda
            // 
            this.btnBulLambda.Location = new System.Drawing.Point(366, 375);
            this.btnBulLambda.Name = "btnBulLambda";
            this.btnBulLambda.Size = new System.Drawing.Size(75, 23);
            this.btnBulLambda.TabIndex = 23;
            this.btnBulLambda.Text = "Bul lambda";
            this.btnBulLambda.UseVisualStyleBackColor = true;
            this.btnBulLambda.Click += new System.EventHandler(this.btnBulLambda_Click);
            // 
            // btnAdaGore
            // 
            this.btnAdaGore.Location = new System.Drawing.Point(366, 404);
            this.btnAdaGore.Name = "btnAdaGore";
            this.btnAdaGore.Size = new System.Drawing.Size(100, 37);
            this.btnAdaGore.TabIndex = 24;
            this.btnAdaGore.Text = "Ada Göre";
            this.btnAdaGore.UseVisualStyleBackColor = true;
            this.btnAdaGore.Click += new System.EventHandler(this.btnAdaGore_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdaGore);
            this.Controls.Add(this.btnBulLambda);
            this.Controls.Add(this.txtAranan);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.btnAharf);
            this.Controls.Add(this.btnMusteriListele);
            this.Controls.Add(this.btnSayilar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.brnUrunGuncelle);
            this.Controls.Add(this.btnKategoriGuncelle);
            this.Controls.Add(this.btnTedarikciSil);
            this.Controls.Add(this.btnUrunSil);
            this.Controls.Add(this.btnKategoriSil);
            this.Controls.Add(this.btnUrunKaydet);
            this.Controls.Add(this.txtBirimdekiMiktari);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.txtTanimi);
            this.Controls.Add(this.txtKategoriAd);
            this.Controls.Add(this.btnKategoriKaydet);
            this.Controls.Add(this.btnTedarikciler);
            this.Controls.Add(this.btnKategoriler);
            this.Controls.Add(this.btnUrunler);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUrunler;
        private System.Windows.Forms.Button btnKategoriler;
        private System.Windows.Forms.Button btnTedarikciler;
        private System.Windows.Forms.Button btnKategoriKaydet;
        private System.Windows.Forms.TextBox txtKategoriAd;
        private System.Windows.Forms.TextBox txtTanimi;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.TextBox txtBirimdekiMiktari;
        private System.Windows.Forms.Button btnUrunKaydet;
        private System.Windows.Forms.Button btnKategoriSil;
        private System.Windows.Forms.Button btnUrunSil;
        private System.Windows.Forms.Button btnTedarikciSil;
        private System.Windows.Forms.Button btnKategoriGuncelle;
        private System.Windows.Forms.Button brnUrunGuncelle;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSayilar;
        private System.Windows.Forms.Button btnMusteriListele;
        private System.Windows.Forms.Button btnAharf;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.TextBox txtAranan;
        private System.Windows.Forms.Button btnBulLambda;
        private System.Windows.Forms.Button btnAdaGore;
    }
}

