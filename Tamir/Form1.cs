using System.Windows.Forms;

namespace Tamir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<ArýzalýÜrün> ArýzaListesi = new List<ArýzalýÜrün>();
        private List<ürünTamir> TamirListesi = new List<ürünTamir>();


        public class ArýzalýÜrün
        {
            public string marka { get; set; }
            public string model { get; set; }
            public string serino { get; set; }
            public string ürünkayýt { get; set; }
            public string personelno { get; set; }
            public string kayýttarih { get; set; }
            public string MusteriAD { get; set; }
            public string MusteriSoyad { get; set; }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string marka = Marka_txt.Text;
            string model = model_txt.Text;
            string serino = serino_txt.Text;
            string ürünkayýt = kayýtno_txt.Text;
            string personelno = personno_txt.Text;
            string kayýttarih = kayýttarih_txt.Text;
            string MusteriAd = musteriad_txt.Text;
            string MusteriSoyad = musterisoyad_txt.Text;


            if (string.IsNullOrEmpty(marka) || string.IsNullOrEmpty(model) || string.IsNullOrEmpty(serino)
                || string.IsNullOrEmpty(personelno) || string.IsNullOrEmpty(kayýttarih) || string.IsNullOrEmpty(MusteriAd)
                || string.IsNullOrEmpty(MusteriSoyad))
            {
                MessageBox.Show("lütfen tüm bilgileri eksiksiz doldurun.");
                return;
            }

            ArýzalýÜrün YenüÜrün = new ArýzalýÜrün
            {
                marka = marka,
                model = model,
                serino = serino,
                personelno = personelno,
                ürünkayýt = ürünkayýt,
                kayýttarih = kayýttarih,
                MusteriAD = MusteriAd,
                MusteriSoyad = MusteriSoyad

            };

            if (ArýzaListesi.Any(u => u.serino == YenüÜrün.serino))
            {
                MessageBox.Show("bu seri numarasýna ait ürün zaten var.");
                return;
            }

            listBox1.Items.Clear();
            ArýzaListesi.Add(YenüÜrün);
            foreach (ArýzalýÜrün ürün in ArýzaListesi)
            {
                listBox1.Items.Add($"{ürün.ürünkayýt}-{ürün.MusteriAD}-{ürün.MusteriSoyad}-{ürün.model}");
            }



            Marka_txt.Text = "";
            model_txt.Text = "";
            serino_txt.Text = "";
            kayýtno_txt.Text = "";
            personno_txt.Text = "";
            kayýttarih_txt.Text = "";
            musteriad_txt.Text = "";
            musterisoyad_txt.Text = "";

            kayýtCombo.Items.Add(YenüÜrün.ürünkayýt.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen güncellenecek bir öðe seçin.");
                return;
            }
            int selectedýndex = listBox1.SelectedIndex;

            ArýzalýÜrün secilenArýza = ArýzaListesi[selectedýndex];
            //textboxlarý güncelle
            secilenArýza.marka = Marka_txt.Text;
            secilenArýza.model = model_txt.Text;
            secilenArýza.serino = serino_txt.Text;
            secilenArýza.ürünkayýt = kayýtno_txt.Text;
            secilenArýza.personelno = personno_txt.Text;
            secilenArýza.kayýttarih = kayýttarih_txt.Text;
            secilenArýza.MusteriAD = musteriad_txt.Text;
            secilenArýza.MusteriSoyad = musterisoyad_txt.Text;

            //listbox görünümü güncelle
            listBox1.Items[selectedýndex] = ($"{secilenArýza.marka}-{secilenArýza.model}-{secilenArýza.serino}-{secilenArýza.ürünkayýt}-{secilenArýza.kayýttarih}-{secilenArýza.MusteriAD}-{secilenArýza.MusteriSoyad}");



            Temizle();
        }

        private void Temizle()
        {
            Marka_txt.Clear();
            model_txt.Clear();
            serino_txt.Clear();
            kayýtno_txt.Clear();
            personno_txt.Clear();
            kayýttarih_txt.Clear();
            musteriad_txt.Clear();
            musterisoyad_txt.Clear();

        }





        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            foreach (ArýzalýÜrün ürün in ArýzaListesi)
            {
                Marka_txt.Text = ($"{ürün.marka}");
            }
            foreach (ArýzalýÜrün ürün in ArýzaListesi)
            {
                model_txt.Text = ($"{ürün.model}");
            }
            foreach (ArýzalýÜrün ürün in ArýzaListesi)
            {
                serino_txt.Text = ($"{ürün.serino}");
            }
            foreach (ArýzalýÜrün ürün in ArýzaListesi)
            {
                kayýtno_txt.Text = ($"{ürün.ürünkayýt}");
            }
            foreach (ArýzalýÜrün ürün in ArýzaListesi)
            {
                Marka_txt.Text = ($"{ürün.marka}");
            }
            foreach (ArýzalýÜrün ürün in ArýzaListesi)
            {
                personno_txt.Text = ($"{ürün.personelno}");
            }
            foreach (ArýzalýÜrün ürün in ArýzaListesi)
            {
                kayýttarih_txt.Text = ($"{ürün.kayýttarih}");
            }
            foreach (ArýzalýÜrün ürün in ArýzaListesi)
            {
                musteriad_txt.Text = ($"{ürün.MusteriAD}");
            }
            foreach (ArýzalýÜrün ürün in ArýzaListesi)
            {
                musterisoyad_txt.Text = ($"{ürün.MusteriSoyad}");
            }
        }

        public class ürünTamir
        {
            public string PersonelNo { get; set; }
            public string islem { get; set; }
            public string tamirTarih { get; set; }
            public string yedekParca { get; set; }

            public string Kayýt { get; set; } // ComboBox'ýn seçili öðesinin metin deðerini tutar
            public string Durum { get; set; } // ComboBox'ýn seçili öðesinin metin deðerini tutar
        }


        private void button3_Click(object sender, EventArgs e)
        {
            string PersonelNo = Personel_txt.Text;
            string islem = islem_txt.Text;
            string tamirTarih = Tarih_txt.Text;
            string yedekParca = yedek_txt.Text;

            if (string.IsNullOrEmpty(PersonelNo) || string.IsNullOrEmpty(islem) || string.IsNullOrEmpty(tamirTarih) || string.IsNullOrEmpty(yedekParca))
            {
                MessageBox.Show("Lütfen geçerli yerleri doldurun.");
                return;
            }

            // ComboBox'larýn seçili öðelerinin metinlerini al
            string selectedDurum = durumCombo.SelectedItem?.ToString();
            string selectedKayýt = kayýtCombo.SelectedItem?.ToString();

            // Yeni ürünTamir örneðini oluþtur
            ürünTamir yeniTamir = new ürünTamir
            {
                PersonelNo = PersonelNo,
                islem = islem,
                tamirTarih = tamirTarih,
                yedekParca = yedekParca,
                // ComboBox'larýn metin özelliklerini atar
                Durum = selectedDurum,
                Kayýt = selectedKayýt
            };

            // TamirListesi'ne yeniTamir öðesini ekle
            TamirListesi.Add(yeniTamir);

            // ListBox'a yeni öðeyi ekle
            TamirList.Items.Add($"{yeniTamir.PersonelNo}-{yeniTamir.islem}-{yeniTamir.yedekParca}-{yeniTamir.tamirTarih}-{selectedDurum}-{selectedKayýt}");

            // TextBox'larý temizle
            Personel_txt.Text = "";
            islem_txt.Text = "";
            Tarih_txt.Text = "";
            yedek_txt.Text = "";
            durumCombo.SelectedIndex = -1;
            kayýtCombo.SelectedIndex = -1;
        }



        private void TamirList_SelectedIndexChanged(object sender, EventArgs e)
        {


            foreach (ürünTamir yeni in TamirListesi)
            {
                Personel_txt.Text = ($"{yeni.PersonelNo}");
            }
            foreach (ürünTamir yeni in TamirListesi)
            {
                islem_txt.Text = ($"{yeni.islem}");
            }
            foreach (ürünTamir yeni in TamirListesi)
            {
                Tarih_txt.Text = ($"{yeni.tamirTarih}");
            }
            foreach (ürünTamir yeni in TamirListesi)
            {
                yedek_txt.Text = ($"{yeni.yedekParca}");
            }
            // ComboBox'larýn seçilen öðelerini belirlemek için doðrudan atama yapýn
            if (TamirListesi.Count > 0)
            {
                // ilk ürünTamir öðesinin durumunu seçili hale getir
                durumCombo.SelectedItem = TamirListesi[0].Durum;
                // ilk ürünTamir öðesinin kayýtýný seçili hale getir
                kayýtCombo.SelectedItem = TamirListesi[0].Kayýt;
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // ListBox'ta herhangi bir öðe seçilip seçilmediðini kontrol et
            if (TamirList.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen güncellenecek bir öðe seçin.");
                return;
            }

            // Seçilen öðenin index'ini al
            int selectedIndex = TamirList.SelectedIndex;

            // Seçilen öðenin bilgilerini al
            ürünTamir secilenTamir = TamirListesi[selectedIndex];

            // TextBox'larý güncelle
            secilenTamir.PersonelNo = Personel_txt.Text;
            secilenTamir.islem = islem_txt.Text;
            secilenTamir.tamirTarih = Tarih_txt.Text;
            secilenTamir.yedekParca = yedek_txt.Text;
            secilenTamir.Durum = durumCombo.Text;
            secilenTamir.Kayýt = kayýtCombo.Text;

            // ListBox görünümünü güncelle
            TamirList.Items[selectedIndex] = ($"{secilenTamir.PersonelNo}-{secilenTamir.islem}-{secilenTamir.yedekParca}-{secilenTamir.tamirTarih}-{secilenTamir.Durum}-{secilenTamir.Kayýt}");



            // Seçilen öðeyi iptal et
            TamirList.ClearSelected();
            Temizle1();
        }
        private void Temizle1()
        {
            Personel_txt.Clear();
            islem_txt.Clear();
            Tarih_txt.Clear();
            kayýtno_txt.Clear();
            yedek_txt.Clear();
            kayýtCombo.SelectedIndex = -1;
            durumCombo.SelectedIndex = -1;


        }
       

        private void personno_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void kayýtno_txt_TextChanged_1(object sender, EventArgs e)
        {
            // Eðer kayýtno_txt boþsa, kayýtCombo'yu temizle
            if (string.IsNullOrEmpty(kayýtno_txt.Text))
            {
                kayýtCombo.Items.Clear();
            }
            else
            {
                // Eðer kayýtno_txt doluysa, kayýtCombo'yu güncelle
                kayýtCombo.Items.Clear();
                foreach (ArýzalýÜrün arýza in ArýzaListesi)
                {
                    kayýtCombo.Items.Add(arýza.ürünkayýt);
                }
            }
        }
       

    }
}
