using System.Windows.Forms;

namespace Tamir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<Ar�zal��r�n> Ar�zaListesi = new List<Ar�zal��r�n>();
        private List<�r�nTamir> TamirListesi = new List<�r�nTamir>();


        public class Ar�zal��r�n
        {
            public string marka { get; set; }
            public string model { get; set; }
            public string serino { get; set; }
            public string �r�nkay�t { get; set; }
            public string personelno { get; set; }
            public string kay�ttarih { get; set; }
            public string MusteriAD { get; set; }
            public string MusteriSoyad { get; set; }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string marka = Marka_txt.Text;
            string model = model_txt.Text;
            string serino = serino_txt.Text;
            string �r�nkay�t = kay�tno_txt.Text;
            string personelno = personno_txt.Text;
            string kay�ttarih = kay�ttarih_txt.Text;
            string MusteriAd = musteriad_txt.Text;
            string MusteriSoyad = musterisoyad_txt.Text;


            if (string.IsNullOrEmpty(marka) || string.IsNullOrEmpty(model) || string.IsNullOrEmpty(serino)
                || string.IsNullOrEmpty(personelno) || string.IsNullOrEmpty(kay�ttarih) || string.IsNullOrEmpty(MusteriAd)
                || string.IsNullOrEmpty(MusteriSoyad))
            {
                MessageBox.Show("l�tfen t�m bilgileri eksiksiz doldurun.");
                return;
            }

            Ar�zal��r�n Yen��r�n = new Ar�zal��r�n
            {
                marka = marka,
                model = model,
                serino = serino,
                personelno = personelno,
                �r�nkay�t = �r�nkay�t,
                kay�ttarih = kay�ttarih,
                MusteriAD = MusteriAd,
                MusteriSoyad = MusteriSoyad

            };

            if (Ar�zaListesi.Any(u => u.serino == Yen��r�n.serino))
            {
                MessageBox.Show("bu seri numaras�na ait �r�n zaten var.");
                return;
            }

            listBox1.Items.Clear();
            Ar�zaListesi.Add(Yen��r�n);
            foreach (Ar�zal��r�n �r�n in Ar�zaListesi)
            {
                listBox1.Items.Add($"{�r�n.�r�nkay�t}-{�r�n.MusteriAD}-{�r�n.MusteriSoyad}-{�r�n.model}");
            }



            Marka_txt.Text = "";
            model_txt.Text = "";
            serino_txt.Text = "";
            kay�tno_txt.Text = "";
            personno_txt.Text = "";
            kay�ttarih_txt.Text = "";
            musteriad_txt.Text = "";
            musterisoyad_txt.Text = "";

            kay�tCombo.Items.Add(Yen��r�n.�r�nkay�t.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("L�tfen g�ncellenecek bir ��e se�in.");
                return;
            }
            int selected�ndex = listBox1.SelectedIndex;

            Ar�zal��r�n secilenAr�za = Ar�zaListesi[selected�ndex];
            //textboxlar� g�ncelle
            secilenAr�za.marka = Marka_txt.Text;
            secilenAr�za.model = model_txt.Text;
            secilenAr�za.serino = serino_txt.Text;
            secilenAr�za.�r�nkay�t = kay�tno_txt.Text;
            secilenAr�za.personelno = personno_txt.Text;
            secilenAr�za.kay�ttarih = kay�ttarih_txt.Text;
            secilenAr�za.MusteriAD = musteriad_txt.Text;
            secilenAr�za.MusteriSoyad = musterisoyad_txt.Text;

            //listbox g�r�n�m� g�ncelle
            listBox1.Items[selected�ndex] = ($"{secilenAr�za.marka}-{secilenAr�za.model}-{secilenAr�za.serino}-{secilenAr�za.�r�nkay�t}-{secilenAr�za.kay�ttarih}-{secilenAr�za.MusteriAD}-{secilenAr�za.MusteriSoyad}");



            Temizle();
        }

        private void Temizle()
        {
            Marka_txt.Clear();
            model_txt.Clear();
            serino_txt.Clear();
            kay�tno_txt.Clear();
            personno_txt.Clear();
            kay�ttarih_txt.Clear();
            musteriad_txt.Clear();
            musterisoyad_txt.Clear();

        }





        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            foreach (Ar�zal��r�n �r�n in Ar�zaListesi)
            {
                Marka_txt.Text = ($"{�r�n.marka}");
            }
            foreach (Ar�zal��r�n �r�n in Ar�zaListesi)
            {
                model_txt.Text = ($"{�r�n.model}");
            }
            foreach (Ar�zal��r�n �r�n in Ar�zaListesi)
            {
                serino_txt.Text = ($"{�r�n.serino}");
            }
            foreach (Ar�zal��r�n �r�n in Ar�zaListesi)
            {
                kay�tno_txt.Text = ($"{�r�n.�r�nkay�t}");
            }
            foreach (Ar�zal��r�n �r�n in Ar�zaListesi)
            {
                Marka_txt.Text = ($"{�r�n.marka}");
            }
            foreach (Ar�zal��r�n �r�n in Ar�zaListesi)
            {
                personno_txt.Text = ($"{�r�n.personelno}");
            }
            foreach (Ar�zal��r�n �r�n in Ar�zaListesi)
            {
                kay�ttarih_txt.Text = ($"{�r�n.kay�ttarih}");
            }
            foreach (Ar�zal��r�n �r�n in Ar�zaListesi)
            {
                musteriad_txt.Text = ($"{�r�n.MusteriAD}");
            }
            foreach (Ar�zal��r�n �r�n in Ar�zaListesi)
            {
                musterisoyad_txt.Text = ($"{�r�n.MusteriSoyad}");
            }
        }

        public class �r�nTamir
        {
            public string PersonelNo { get; set; }
            public string islem { get; set; }
            public string tamirTarih { get; set; }
            public string yedekParca { get; set; }

            public string Kay�t { get; set; } // ComboBox'�n se�ili ��esinin metin de�erini tutar
            public string Durum { get; set; } // ComboBox'�n se�ili ��esinin metin de�erini tutar
        }


        private void button3_Click(object sender, EventArgs e)
        {
            string PersonelNo = Personel_txt.Text;
            string islem = islem_txt.Text;
            string tamirTarih = Tarih_txt.Text;
            string yedekParca = yedek_txt.Text;

            if (string.IsNullOrEmpty(PersonelNo) || string.IsNullOrEmpty(islem) || string.IsNullOrEmpty(tamirTarih) || string.IsNullOrEmpty(yedekParca))
            {
                MessageBox.Show("L�tfen ge�erli yerleri doldurun.");
                return;
            }

            // ComboBox'lar�n se�ili ��elerinin metinlerini al
            string selectedDurum = durumCombo.SelectedItem?.ToString();
            string selectedKay�t = kay�tCombo.SelectedItem?.ToString();

            // Yeni �r�nTamir �rne�ini olu�tur
            �r�nTamir yeniTamir = new �r�nTamir
            {
                PersonelNo = PersonelNo,
                islem = islem,
                tamirTarih = tamirTarih,
                yedekParca = yedekParca,
                // ComboBox'lar�n metin �zelliklerini atar
                Durum = selectedDurum,
                Kay�t = selectedKay�t
            };

            // TamirListesi'ne yeniTamir ��esini ekle
            TamirListesi.Add(yeniTamir);

            // ListBox'a yeni ��eyi ekle
            TamirList.Items.Add($"{yeniTamir.PersonelNo}-{yeniTamir.islem}-{yeniTamir.yedekParca}-{yeniTamir.tamirTarih}-{selectedDurum}-{selectedKay�t}");

            // TextBox'lar� temizle
            Personel_txt.Text = "";
            islem_txt.Text = "";
            Tarih_txt.Text = "";
            yedek_txt.Text = "";
            durumCombo.SelectedIndex = -1;
            kay�tCombo.SelectedIndex = -1;
        }



        private void TamirList_SelectedIndexChanged(object sender, EventArgs e)
        {


            foreach (�r�nTamir yeni in TamirListesi)
            {
                Personel_txt.Text = ($"{yeni.PersonelNo}");
            }
            foreach (�r�nTamir yeni in TamirListesi)
            {
                islem_txt.Text = ($"{yeni.islem}");
            }
            foreach (�r�nTamir yeni in TamirListesi)
            {
                Tarih_txt.Text = ($"{yeni.tamirTarih}");
            }
            foreach (�r�nTamir yeni in TamirListesi)
            {
                yedek_txt.Text = ($"{yeni.yedekParca}");
            }
            // ComboBox'lar�n se�ilen ��elerini belirlemek i�in do�rudan atama yap�n
            if (TamirListesi.Count > 0)
            {
                // ilk �r�nTamir ��esinin durumunu se�ili hale getir
                durumCombo.SelectedItem = TamirListesi[0].Durum;
                // ilk �r�nTamir ��esinin kay�t�n� se�ili hale getir
                kay�tCombo.SelectedItem = TamirListesi[0].Kay�t;
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // ListBox'ta herhangi bir ��e se�ilip se�ilmedi�ini kontrol et
            if (TamirList.SelectedIndex == -1)
            {
                MessageBox.Show("L�tfen g�ncellenecek bir ��e se�in.");
                return;
            }

            // Se�ilen ��enin index'ini al
            int selectedIndex = TamirList.SelectedIndex;

            // Se�ilen ��enin bilgilerini al
            �r�nTamir secilenTamir = TamirListesi[selectedIndex];

            // TextBox'lar� g�ncelle
            secilenTamir.PersonelNo = Personel_txt.Text;
            secilenTamir.islem = islem_txt.Text;
            secilenTamir.tamirTarih = Tarih_txt.Text;
            secilenTamir.yedekParca = yedek_txt.Text;
            secilenTamir.Durum = durumCombo.Text;
            secilenTamir.Kay�t = kay�tCombo.Text;

            // ListBox g�r�n�m�n� g�ncelle
            TamirList.Items[selectedIndex] = ($"{secilenTamir.PersonelNo}-{secilenTamir.islem}-{secilenTamir.yedekParca}-{secilenTamir.tamirTarih}-{secilenTamir.Durum}-{secilenTamir.Kay�t}");



            // Se�ilen ��eyi iptal et
            TamirList.ClearSelected();
            Temizle1();
        }
        private void Temizle1()
        {
            Personel_txt.Clear();
            islem_txt.Clear();
            Tarih_txt.Clear();
            kay�tno_txt.Clear();
            yedek_txt.Clear();
            kay�tCombo.SelectedIndex = -1;
            durumCombo.SelectedIndex = -1;


        }
       

        private void personno_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void kay�tno_txt_TextChanged_1(object sender, EventArgs e)
        {
            // E�er kay�tno_txt bo�sa, kay�tCombo'yu temizle
            if (string.IsNullOrEmpty(kay�tno_txt.Text))
            {
                kay�tCombo.Items.Clear();
            }
            else
            {
                // E�er kay�tno_txt doluysa, kay�tCombo'yu g�ncelle
                kay�tCombo.Items.Clear();
                foreach (Ar�zal��r�n ar�za in Ar�zaListesi)
                {
                    kay�tCombo.Items.Add(ar�za.�r�nkay�t);
                }
            }
        }
       

    }
}
