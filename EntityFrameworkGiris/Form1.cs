using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkGiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NorthwindEntities db = new NorthwindEntities();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Urunler.ToList();
        }

        private void btnKategoriler_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Kategoriler.ToList();
        }

        private void btnTedarikciler_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Tedarikciler.ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kategoriler k = new Kategoriler();
            k.KategoriAdi = txtKategoriAd.Text;
            k.Tanimi = txtTanimi.Text;
            db.Kategoriler.Add(k);
            db.SaveChanges();
            KategoriListele();

        }

        private void KategoriListele()
        {
            dataGridView1.DataSource = db.Kategoriler.ToList();
        }
        private void UrunleriListele()
        {
            dataGridView1.DataSource = db.Urunler.ToList();
        }

        private void TedarikcileriListele()
        {
            dataGridView1.DataSource = db.Tedarikciler.ToList();
        }

        private void btnUrunKaydet_Click(object sender, EventArgs e)
        {

            if (txtUrunAdi.Text == string.Empty)
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz");
            }
            else
            {
                Urunler u = new Urunler();
                u.UrunAdi = txtUrunAdi.Text.ToUpper();
                u.BirimdekiMiktar = txtBirimdekiMiktari.Text.ToUpper();
                db.Urunler.Add(u);
                db.SaveChanges();
                UrunleriListele();
            }

        }

        private void btnKategoriSil_Click(object sender, EventArgs e)
        {
            if (txtKategoriAd.Text == string.Empty)
            {
                MessageBox.Show("Lütfen silinecek ID giriniz");
            }
            else
            {
                int id = Convert.ToInt32(txtKategoriAd.Text);
                var x = db.Kategoriler.Find(id);
                db.Kategoriler.Remove(x);
                db.SaveChanges();
                MessageBox.Show("İstediğiniz kategori silindi");
                KategoriListele();
            }
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            if (txtUrunAdi.Text == string.Empty)
            {
                MessageBox.Show("Lütfen silinecek ID giriniz");
            }
            else
            {
                int id = Convert.ToInt32(txtUrunAdi.Text);
                var x = db.Urunler.Find(id);
                db.Urunler.Remove(x);
                db.SaveChanges();
                MessageBox.Show("İstediğiniz ürün silindi");
                UrunleriListele();

            }
        }

        private void btnTedarikciSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtUrunAdi.Text);
            var x = db.Tedarikciler.Find(id);
            db.Tedarikciler.Remove(x);
            db.SaveChanges();
            MessageBox.Show("İstediğiniz tedarikçi silindi");
            TedarikcileriListele();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtKategoriAd.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //txtTanimi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            txtUrunAdi.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtBirimdekiMiktari.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnKategoriGuncelle_Click(object sender, EventArgs e)
        {
            if (txtKategoriAd.Text == string.Empty)
            {
                MessageBox.Show("Seçim yap");
            }
            else
            {
                int id = Convert.ToInt32(txtKategoriAd.Text);
                var x = db.Kategoriler.Find(id);
                x.KategoriAdi = txtKategoriAd.Text.ToUpper();
                x.Tanimi = txtTanimi.Text.ToUpper();
                db.SaveChanges();
                KategoriListele();
            }
        }

        private void brnUrunGuncelle_Click(object sender, EventArgs e)
        {
            if (txtUrunAdi.Text == string.Empty)
            {
                MessageBox.Show("Seçim yap");
            }
            else
            {
                int id = Convert.ToInt32(txtUrunAdi.Text);
                var x = db.Urunler.Find(id);
                x.UrunAdi = txtUrunAdi.Text.ToUpper();
                x.BirimdekiMiktar = txtBirimdekiMiktari.Text.ToUpper();
                db.SaveChanges();
                UrunleriListele();
            }
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            //kategorisi 5 olan ürünleri getirecek sorgu
            var result = from i in db.Urunler
                         where i.UrunID == 5
                         select i;
            dataGridView1.DataSource = result.ToList();                 //datagride yazdırmak için

            foreach (var item in result)
            {
                listBox1.Items.Add(item.UrunAdi + item.BirimFiyati);    //listboxa yazdırmak için
            }

        }

        private void btnSayilar_Click(object sender, EventArgs e)
        {
            //bir dizi tanımlayalım, 5den büyük olan sayıları hem klasik yöntemle hem linq ile yapalım

            int[] sayilar = new int[] { 3, 22, 65, 4, 2, 29, 35, 27, 98, 54, 87, 6, 0, 68, 99 };

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] > 5)
            //    {
            //        listBox1.Items.Add(sayilar[i]);
            //    }
            //}

            var result = from i in sayilar
                         where i > 5
                         select i;

            foreach (var item in result)
            {
                listBox1.Items.Add(item);
            }

        }

        private void btnMusteriListele_Click(object sender, EventArgs e)
        {
            List<Musteriler> musterilers = (from musteri in db.Musteriler
                                            where musteri.Ulke == "USA"
                                            orderby musteri.Bolge
                                            select musteri).ToList();

            dataGridView1.DataSource = musterilers.ToList();
        }

        private void btnAharf_Click(object sender, EventArgs e)
        {
            var sonuc = from musteri in db.Musteriler
                        where musteri.MusteriAdi.Contains("MAR")
                        select new
                        {
                            musteri.MusteriAdi,
                            musteri.Satislar

                        };

            foreach (var musteri in sonuc)
            {
                listBox1.Items.Add(musteri.MusteriAdi);
                foreach (var satis in musteri.Satislar)
                {
                    listBox1.Items.Add(satis.SatisID);
                }
            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            string text = txtAranan.Text;
            var deger = from urun in db.Urunler
                        where urun.UrunAdi==text
                        select new
                        {
                            urun.UrunAdi,
                            urun.BirimFiyati
                        };
            dataGridView1.DataSource = deger.ToList();
        }

        private void btnBulLambda_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = db.Urunler.Where(x => x.UrunAdi == txtAranan.Text).ToList(); //x dediğimiz ürün
        }

        private void btnAdaGore_Click(object sender, EventArgs e)
        {
            //ürün adına göre tersten sıralanan ilk 3 kaydı getiren sorgu
            //dataGridView1.DataSource = db.Urunler.OrderByDescending(p => p.UrunAdi).Take(3).ToList();

            //a ile başlayan kayıtlar
            //dataGridView1.DataSource = db.Urunler.Where(p => p.UrunAdi.StartsWith("a")).ToList();

            //a ile biten kayıtlar
            dataGridView1.DataSource = db.Urunler.Where(p => p.UrunAdi.EndsWith("a")).ToList();
        }
    }
}
