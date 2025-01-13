using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Form1 : Form
    {
        private string[] sehirler =  {"Adana", "Adiyaman", "Afyonkarahisar", "Agri", "Aksaray", "Amasya", "Ankara",
            "Antalya", "Ardahan", "Artvin", "Aydin", "Balikesir", "Bartin", "Batman",
            "Bayburt", "Bilecik", "Bingol", "Bitlis", "Bolu", "Burdur", "Bursa", "Canakkale",
            "Cankiri", "Corum", "Denizli", "Diyarbakir", "Duzce", "Edirne", "Elazig", "Erzincan",
            "Erzurum", "Eskisehir", "Gaziantep", "Giresun", "Gumushane", "Hakkari", "Hatay",
            "Igdir", "Isparta", "Istanbul", "Izmir", "Kahramanmaras", "Karabuk", "Karaman",
            "Kars", "Kastamonu", "Kayseri", "Kirikale", "Kirklareli", "Kirsehir", "Kilis",
            "Kocaeli", "Konya", "Kutahya", "Malatya", "Manisa", "Mardin", "Mersin", "Mugla",
            "Mus", "Nevsehir", "Nigde", "Ordu", "Osmaniye", "Rize", "Sakarya", "Samsun",
            "Siirt", "Sinop", "Sivas", "Sanliurfa", "Sirnak", "Tekirdag", "Tokat", "Trabzon",
            "Tunceli", "Usak", "Van", "Yalova", "Yozgat", "Zonguldak"};
        // sehirlerin isimlerini turkce karakter olmadan diziye tanimladik.

        private string secilenSehir; 
        private int kalanHak = 6;
        private char[] dogruHarfler;
        private string acilmamisSehir;
        //Programda ilerde isimize yarayacak degiskenleri tanimladik.

        //Oyunu baslatacak olan metot. 
        private void oyunuBaslat()
        {
            Random rnd = new Random();
            int rastgeleSayi = rnd.Next(0, 81);
            //Rastgele bir sayi seciliyor bu sayi sehrin rastgele secilmesini saglayacak.

            secilenSehir = sehirler[rastgeleSayi].ToUpper();
            //rastgele secilen sehiri ilerde kontrol edebilmek icin secilenSehir degiskenine atadık.

            dogruHarfler = secilenSehir.ToCharArray();
            //secilen sehrin harflerini bir diziye atadik bu sayede kullanicinin girdigi harfin kontrolunu yapabilecegiz.

            for (int i = 0; i < dogruHarfler.Length; i++)
            {
                lblKelime.Text += "_ ";  
            }
            //secilen sehir kac harfli ise o kadar _ atacak dongu blogu.

            lblKalanHak.Text = "Kalan Hak: " + kalanHak;
            lblDurum.Text = "";
            pictureBox1.Image = Properties.Resources.adam;
            //oyun basinda kalan hak, oyun durumu ve fotografi sifirladik.

        }
        

        public Form1()
        {
            InitializeComponent();
            oyunuBaslat();
            //metotu kullanmak icin form1 altinda cagirdik.
        }

        //butona basilinca yapilacak islemler.
        private void btnGiris_Click(object sender, EventArgs e)
        {
            string tahmin = txtTahmin.Text.ToUpper();
            bool dogruTahmin = false;
            //kullanicinin tahmini buyuk harfe cevirip tahmin adli degiskene atadik.
            //tahminin dogrulugunun kontrolu icin dogruTahmin adinda boolean bir degisken tanimladik.

            StringBuilder yeniKelime = new StringBuilder(lblKelime.Text.Replace(" ", "")); 
            //kelimenin acilmamis halini dogru harf geldikce degisterecegimiz icin stringBuilder'dan yararlaniyoruz.

            //kullanicinin girdigi harfin kelime icinde olup olmadigini kontrol edecegimiz dongu.
            for (int i = 0; i < dogruHarfler.Length; i++)
            {
                //eger harf kelimenin icinde ise burdaki if blogu calisir.
                if (dogruHarfler[i].Equals(tahmin[0]))
                {
                    yeniKelime[i] = tahmin[0];  
                    //harf dogru ise _ 'nın yerine gececek.

                    dogruTahmin = true;
                    //dogruTahmin adli degiskeni true olarak ayarladik.
                }
            }

            lblKelime.Text = string.Join(" ", yeniKelime.ToString().ToCharArray()); 
            //kelimenin gizli halinin oldugu labeli dogru harf yerine yazilmis sekilde guncelledik.

            //eger tahmin dogru degilse bu if blogu calisacak.
            if (!dogruTahmin)
            {
                kalanHak--; 
                //kalan Hak 1 azaltildi.

                int j = 6 - kalanHak;
                string resourceName = $"adam_{j}";
                var image = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject(resourceName);
                pictureBox1.Image = image;
                //Burada pictureBox'taki adam asmaca fotografini guncelledik. Bunu yaparken j diye bir degisken tanimladik.
                //Bu degisken dosyalarda saklanan adam_1, adam_2 ...  gibi dosyalari cagirirken pratiklik saglayacaktir.
                //Dogru yerden baslamak icinde 6'dan kalan hakki cikararak j'ye atadik
                
            }
            lblKalanHak.Text = "Kalan Hak: " + kalanHak;
            //Kullanicinin guncel kalan hakkinin yazdigi labeli guncelledik.

            //Oyunun durumu yani kazanip kaybetme durumunun kontrolu bu if blogunda incelenecek.
            if (!lblKelime.Text.Contains("_"))
                //eger kelimenin yazdigi labelde _ kalmadiysa kullanici kazanmis olacaktir.
            {
                lblDurum.Text = "Tebrikler, Kazandınız!";
                lblDurum.ForeColor = Color.Green;
                btnGiris.Enabled = false;
                //durumun yazdigi labeli guncelledik ve butonu deaktif hale getirdik.
            }
            if (kalanHak <= 0)
                // eger kullanicinin hakki kalmadiysa kullanici kaybetmis olacaktir.
            {
                lblDurum.Text = "Kaybettiniz! Doğru cevap: " + secilenSehir;
                lblDurum.ForeColor = Color.Red;
                btnGiris.Enabled = false;
                //durumun yazdigi labeli guncelledik ve butonu deaktif hale getirdik.
            }
        }

        private void lblKalanHak_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblDurum_Click(object sender, EventArgs e)
        {

        }

        private void txtTahmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblKelime_Click(object sender, EventArgs e)
        {

        }
    }
}
