/****************************************************************************
** SAKARYA ÜNİVERSİTESİ
** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
** BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
** NESNEYE DAYALI PROGRAMLAMA DERSİ
** 2018-2019 BAHAR DÖNEMİ
**
** ÖDEV NUMARASI..........: B171210090
** ÖĞRENCİ ADI............: Miraç
** ÖĞRENCİ NUMARASI.......: Özal
** DERSİN ALINDIĞI GRUP...: 2-A
****************************************************************************/

using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp2
{
    abstract class Futbolcu // Oluşturulacak tüm sınıfların ortak özelliklerini barındıran Futbolcu isimli taban class'ımızı abstract class ile oluşturduk. 
    {
        public string AdSoyad; //Futbolcunun ad ve soyad bilgilerini tutacak string değişkenimiz
        public int FormaNo; //Futbolcunun forma numarası bilgisini tutacak int değişkenimiz
        public int Hiz { get; set; } //Futbolcunun rastgele atanacak olan hız bilgisini tutacak int değişkenimiz
        public int Dayaniklik { get; set; } //Futbolcunun rastgele atanacak olan dayanıklılık niteliği bilgisini tutacak int değişkenimiz
        public int Pas { get; set; } //Futbolcunun rastgele atanacak olan pas niteliği bilgisini tutacak int değişkenimiz
        public int Sut { get; set; } //Futbolcunun rastgele atanacak olan şut niteliği bilgisini tutacak int değişkenimiz
        public int Yetenek { get; set; } //Futbolcunun rastgele atanacak olan yetenek niteliği bilgisini tutacak int değişkenimiz
        public int Kararlik { get; set; } //Futbolcunun rastgele atanacak olan kararlılık niteliği bilgisini tutacak int değişkenimiz
        public int DogalForm { get; set; } //Futbolcunun rastgele atanacak olan doğal form niteliği bilgisini tutacak int değişkenimiz
        public int Sans { get; set; } //Futbolcunun rastgele atanacak olan şans niteliği bilgisini tutacak int değişkenimiz

        public Futbolcu(string adSoyad, int formaNo) //Her futbolcunun ortak niteliğini yansıtacak olan, temel olarak adSoyad ve formaNo bilgilerini parametre olarak alacak metodumuz
        {
            Random degerAtama = new Random(); //Rastgeleliği sağlayacak fonksiyon
            AdSoyad = adSoyad; //Parametreler aracılığıyla AdSoyad niteliği metoda atanacak
            FormaNo = formaNo; //Parametreler aracılığıyla FormaNo niteliği metoda atanacak
            Hiz = degerAtama.Next(50, 101); //Değişkene belirtilen değerler arasında rastgele bir değer atanacak
            Dayaniklik = degerAtama.Next(50, 101); //Değişkene belirtilen değerler arasında rastgele bir değer atanacak
            Pas = degerAtama.Next(50, 101); //Değişkene belirtilen değerler arasında rastgele bir değer atanacak
            Sut = degerAtama.Next(50, 101); //Değişkene belirtilen değerler arasında rastgele bir değer atanacak
            Yetenek = degerAtama.Next(50, 101); //Değişkene belirtilen değerler arasında rastgele bir değer atanacak
            Kararlik = degerAtama.Next(50, 101); //Değişkene belirtilen değerler arasında rastgele bir değer atanacak
            DogalForm = degerAtama.Next(50, 101); //Değişkene belirtilen değerler arasında rastgele bir değer atanacak
            Sans = degerAtama.Next(50, 101); //Değişkene belirtilen değerler arasında rastgele bir değer atanacak
        }

        public bool PasSkor() //Gerekli hesaplamalar ve kıyaslar sonucu true ya da false döndürecek olan ezilebilir metot
        {
            double passkor = Pas * 0.3 + Yetenek * 0.3 + Dayaniklik * 0.1 + DogalForm * 0.1 + Sans * 0.2;
            int PasSkor = Convert.ToInt32(passkor); //double değişken değeri int değişken tipine çevrilir
            if (60 <= PasSkor) //Hesaplanan PasSkor değişkeninin değerine göre true ya da false döndürecek olan yapı
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual bool GolSkor() //Gerekli hesaplamalar ve kıyaslar sonucu true ya da false döndürecek olan ezilebilir metot
        {
            double golskor = Yetenek * 0.3 + Sut * 0.2 + Kararlik * 0.1 + DogalForm * 0.1 + Hiz * 0.1 + Sans * 0.2;
            int GolSkor = Convert.ToInt32(golskor); //double değişken değeri int değişken tipine çevrilir
            if (70 <= GolSkor) //Hesaplanan GolSkor değişkeninin değerine göre true ya da false döndürecek olan yapı
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Defans : Futbolcu //Futbolcu class'ından kalıtım alan Defans class'ı
    {
        public int PozisyonAlma { get; set; } //Defans oyuncusunun rastgele atanacak olan pozisyon alma niteliği bilgisini tutacak int değişkenimiz
        public int Kafa { get; set; } //Defans oyuncusunun rastgele atanacak olan kafa vuruşu niteliği bilgisini tutacak int değişkenimiz
        public int Sicrama { get; set; } //Defans oyuncusunun rastgele atanacak olan sıçrama niteliği bilgisini tutacak int değişkenimiz

        public Defans(string adSoyad, int formaNo) : base(adSoyad, formaNo) //Futbolcu class'ından adSoyad ve formaNo bilgilerini kalıtım alacak metodumuz
        {
            Random degerAtama = new Random(); //Rastgeleliği sağlayacak fonksiyon
            int PozisyonAlma = degerAtama.Next(50, 91); //Değişkene belirtilen değerler arasında rastgele bir değer atanacak
            int Kafa = degerAtama.Next(50, 91); //Değişkene belirtilen değerler arasında rastgele bir değer atanacak
            int Sicrama = degerAtama.Next(50, 91); //Değişkene belirtilen değerler arasında rastgele bir değer atanacak
        }

        public bool PasSkor() //Gerekli hesaplamalar ve kıyaslar sonucu true ya da false döndürecek olan ezici metot
        {
            double passkor = Pas * 0.3 + Yetenek * 0.3 + Dayaniklik * 0.1 + DogalForm * 0.1 + PozisyonAlma * 0.1 + Sans * 0.2;
            int PasSkor = Convert.ToInt32(passkor); //double değişken değeri int değişken tipine çevrilir
            if (60 <= PasSkor) //Hesaplanan PasSkor değişkeninin değerine göre true ya da false döndürecek olan yapı
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool GolSkor() //Gerekli hesaplamalar ve kıyaslar sonucu true ya da false döndürecek olan ezici metot
        {
            double golskor = Yetenek * 0.3 + Sut * 0.2 + Kararlik * 0.1 + DogalForm * 0.1 + Kafa * 0.1 + Sicrama * 0.1 + Sans * 0.1;
            int GolSkor = Convert.ToInt32(golskor); //double değişken değeri int değişken tipine çevrilir
            if (70 <= GolSkor) //Hesaplanan GolSkor değişkeninin değerine göre true ya da false döndürecek olan yapı
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class OrtaSaha : Futbolcu //Futbolcu class'ından kalıtım alan OrtaSaha class'ı
    {
        public int UzunTop { get; set; } //Orta saha oyuncusunun rastgele atanacak olan uzun top niteliği bilgisini tutacak int değişkenimiz
        public int IlkDokunus { get; set; } //Orta saha oyuncusunun rastgele atanacak olan ilk dokunuş niteliği bilgisini tutacak int değişkenimiz
        public int Uretkenlik { get; set; } //Orta saha oyuncusunun rastgele atanacak olan üretkenlik niteliği bilgisini tutacak int değişkenimiz
        public int TopSurme { get; set; } //Orta saha oyuncusunun rastgele atanacak olan top sürme niteliği bilgisini tutacak int değişkenimiz
        public int OzelYetenek { get; set; } //Orta saha oyuncusunun rastgele atanacak olan özel yetenek niteliği bilgisini tutacak int değişkenimiz

        public OrtaSaha(string adSoyad, int formaNo) : base(adSoyad, formaNo) //Futbolcu class'ından adSoyad ve formaNo bilgilerini kalıtım alacak metodumuz
        {
            Random degerAtama = new Random(); //Rastgeleliği sağlayacak fonksiyon
            int UzunTop = degerAtama.Next(60, 101); //Değişkene belirtilen değerler arasında rastgele bir değer atanacak
            int IlkDokunus = degerAtama.Next(60, 101); //Değişkene belirtilen değerler arasında rastgele bir değer atanacak
            int Uretkenlik = degerAtama.Next(60, 101); //Değişkene belirtilen değerler arasında rastgele bir değer atanacak
            int TopSurme = degerAtama.Next(60, 101); //Değişkene belirtilen değerler arasında rastgele bir değer atanacak
            int OzelYetenek = degerAtama.Next(60, 101); //Değişkene belirtilen değerler arasında rastgele bir değer atanacak
        }

        public bool PasSkor() //Gerekli hesaplamalar ve kıyaslar sonucu true ya da false döndürecek olan ezici metot
        {
            double passkor = Pas * 0.3 + Yetenek * 0.2 + OzelYetenek * 0.2 + Dayaniklik * 0.1 + DogalForm * 0.1 + UzunTop * 0.1 + TopSurme * 0.1 + Sans * 0.1;
            int PasSkor = Convert.ToInt32(passkor); //double değişken değeri int değişken tipine çevrilir
            if (60 <= PasSkor) //Hesaplanan PasSkor değişkeninin değerine göre true ya da false döndürecek olan yapı
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool GolSkor() //Gerekli hesaplamalar ve kıyaslar sonucu true ya da false döndürecek olan ezici metot
        {
            double golskor = Yetenek * 0.3 + OzelYetenek * 0.2 + Sut * 0.2 + IlkDokunus * 0.1 + Kararlik * 0.1 + DogalForm * 0.1 + Sans * 0.1;
            int GolSkor = Convert.ToInt32(golskor); //double değişken değeri int değişken tipine çevrilir
            if (70 <= GolSkor) //Hesaplanan GolSkor değişkeninin değerine göre true ya da false döndürecek olan yapı
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class Forvet : Futbolcu //Futbolcu class'ından kalıtım alan Forvet class'ı
    {
        public int Bitiricilik { get; set; } //Forvet oyuncusunun rastgele atanacak olan bitiricilik niteliği bilgisini tutacak int değişkenimiz
        public int IlkDokunus { get; set; } //Forvet oyuncusunun rastgele atanacak olan ilk dokunuş niteliği bilgisini tutacak int değişkenimiz
        public int Kafa { get; set; } //Forvet oyuncusunun rastgele atanacak olan kafa vuruşu niteliği bilgisini tutacak int değişkenimiz
        public int SogukKanlilik { get; set; } //Forvet oyuncusunun rastgele atanacak olan soğukkanlılık niteliği bilgisini tutacak int değişkenimiz
        public int OzelYetenek { get; set; } //Forvet oyuncusunun rastgele atanacak olan özel yetenek niteliği bilgisini tutacak int değişkenimiz

        public Forvet(string adSoyad, int formaNo) : base(adSoyad, formaNo) //Futbolcu class'ından adSoyad ve formaNo bilgilerini kalıtım alacak metodumuz
        {
            Random degerAtama = new Random(); //Rastgeleliği sağlayacak fonksiyon
            int Bitiricilik = degerAtama.Next(70, 101); //Değişkene belirtilen değerler arasında rastgele bir değer atanacak
            int IlkDokunus = degerAtama.Next(70, 101); //Değişkene belirtilen değerler arasında rastgele bir değer atanacak
            int Kafa = degerAtama.Next(70, 101); //Değişkene belirtilen değerler arasında rastgele bir değer atanacak
            int SogukKanlilik = degerAtama.Next(70, 101); //Değişkene belirtilen değerler arasında rastgele bir değer atanacak
            int OzelYetenek = degerAtama.Next(70, 101); //Değişkene belirtilen değerler arasında rastgele bir değer atanacak
        }

        public bool PasSkor() //Gerekli hesaplamalar ve kıyaslar sonucu true ya da false döndürecek olan ezici metot
        {
            double passkor = Pas * 0.3 + Yetenek * 0.2 + OzelYetenek * 0.2 + Dayaniklik * 0.1 + DogalForm * 0.1 + Sans * 0.1;
            int PasSkor = Convert.ToInt32(passkor); //double değişken değeri int değişken tipine çevrilir
            if (60 <= PasSkor) //Hesaplanan PasSkor değişkeninin değerine göre true ya da false döndürecek olan yapı
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool GolSkor() //Gerekli hesaplamalar ve kıyaslar sonucu true ya da false döndürecek olan ezici metot
        {
            double golskor = Yetenek * 0.2 + OzelYetenek * 0.2 + Sut * 0.1 + Kafa * 0.1 + IlkDokunus * 0.1 + Bitiricilik * 0.1 + SogukKanlilik * 0.1 + Kararlik * 0.1 + DogalForm * 0.1 + Sans * 0.1;
            int GolSkor = Convert.ToInt32(golskor); //double değişken değeri int değişken tipine çevrilir
            if (70 <= GolSkor) //Hesaplanan GolSkor değişkeninin değerine göre true ya da false döndürecek olan yapı
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Futbolcu> takim1 = new List<Futbolcu>(); //takim1 isimli Futbolcu tipinden liste oluşturuluyor
            takim1.Add(new Defans("Mauricio Isla", 0)); //takim1 listesine eleman ekleniyor
            takim1.Add(new Defans("Zanka", 1)); //takim1 listesine eleman ekleniyor
            takim1.Add(new Defans("Serdar Aziz", 2)); //takim1 listesine eleman ekleniyor
            takim1.Add(new Defans("Hasan Ali Kaldirim", 3)); //takim1 listesine eleman ekleniyor
            takim1.Add(new OrtaSaha("Victor Moses", 4)); //takim1 listesine eleman ekleniyor
            takim1.Add(new OrtaSaha("Emre Belözoğlu", 5)); //takim1 listesine eleman ekleniyor
            takim1.Add(new OrtaSaha("Ozan Tufan", 6)); //takim1 listesine eleman ekleniyor
            takim1.Add(new OrtaSaha("Garry Rodriguez", 7)); //takim1 listesine eleman ekleniyor
            takim1.Add(new Forvet("Max Kruse", 8)); //takim1 listesine eleman ekleniyor
            takim1.Add(new Forvet("Vedat Muriqi", 9)); //takim1 listesine eleman ekleniyor

            List<Futbolcu> takim2 = new List<Futbolcu>(); //takim2 isimli Futbolcu tipinden liste oluşturuluyor
            takim2.Add(new Defans("Mariano", 0)); //takim2 listesine eleman ekleniyor
            takim2.Add(new Defans("Christian Luyindama", 1)); //takim2 listesine eleman ekleniyor
            takim2.Add(new Defans("Marcao", 2)); //takim2 listesine eleman ekleniyor
            takim2.Add(new Defans("Yuto Nagatomo", 3)); //takim2 listesine eleman ekleniyor
            takim2.Add(new OrtaSaha("Sofiane Feghouli", 4)); //takim2 listesine eleman ekleniyor
            takim2.Add(new OrtaSaha("Mario Lemina", 5)); //takim2 listesine eleman ekleniyor
            takim2.Add(new OrtaSaha("Steven Nzonzi", 6)); //takim2 listesine eleman ekleniyor
            takim2.Add(new OrtaSaha("Ryan Babel", 7)); //takim2 listesine eleman ekleniyor
            takim2.Add(new Forvet("Younes Belhanda", 8)); //takim2 listesine eleman ekleniyor
            takim2.Add(new Forvet("Radamel Falcao", 9)); //takim2 listesine eleman ekleniyor

            Random aralikBelirleme = new Random(); //Rastgeleliği sağlayacak fonksiyon
            int hangiTakim = aralikBelirleme.Next(1, 3); //Maça başlayacak takımın rastgele seçilmesini sağlayacak değişken değeri atanıyor.
            int oyuncuNo = -1; //
            int basariliPas = 0; //Arka arkaya yapılan başarılı pas sayısını tutacak değişken
            int EvGol = 0; //Ev sahibi takımın(1. takım) attığı gol sayısını tutacak, atamadığı takdirde 0 döndürecek değişken
            int DepGol = 0; //Dış sahibi takımın(2. takım) attığı gol sayısını tutacak, atamadığı takdirde 0 döndürecek değişken
            int sure = 0; //İşlem saniyesini tutacak değişken

            int[] KontrolDizisi = new int[1]; //Arka arkaya üretilen iki sayının aynı olmamasını kontrol için, üretilen sayıyı sonraki üretilecekle karşılaştırmak üzere ekleyeceğimiz tek elemanlık dizi

            while (sure < 30) //Maç süresi 30 saniyeyi geçtiği takdirde karşılaşma sona erecek ve maç skoru ekrana yazılacak. Tam 30 saniyede bitirmememin sebebi, atak esnasında maçın kesilmesini önleyerek programa biraz olsun gerçeklik kazandırma
            {
                if (hangiTakim == 1)
                {
                    System.Threading.Thread.Sleep(1000); //Kullanıcının takibini kolaylaştırmak adına işlemi 1 saniye bekleyerek ekrana yazdıracak fonksiyon
                    Console.WriteLine("Ev sahibi ekip oyunu hareketlendirecek.");
                    sure++; //İşlem sonucu 1 saniyenin geçtiği, süre niteliğini tutan değişkene eklenecek

                    for (int i = 1; i <= 3; i++) //Arka arkaya 3 başarılı pas olup olmayacağını kontrol amaçlı kurulan döngü
                    {
                        for (i = 0; i < 1; i++)
                            while (i < 1)
                            {
                                oyuncuNo = aralikBelirleme.Next(1, 10);

                                if (Array.IndexOf(KontrolDizisi, oyuncuNo) == -1) //Arka arkaya atanan iki değerin aynı olup olmadığını kontrol eden yapı
                                    KontrolDizisi[i++] = oyuncuNo;
                            }
                        if (takim1[oyuncuNo].PasSkor() == false)
                        {
                            System.Threading.Thread.Sleep(1000); //Kullanıcının takibini kolaylaştırmak adına işlemi 1 saniye bekleyerek ekrana yazdıracak fonksiyon
                            Console.WriteLine(takim1[oyuncuNo].AdSoyad + " adli oyuncudan kotu pas, top kaybedildi.\n");
                            sure++; //İşlem sonucu 1 saniyenin geçtiği, süre niteliğini tutan değişkene eklenecek
                            basariliPas = 0; //Hatalı pas atılması durumunda başarılı pasları tutan değişken sıfırlanacak
                            hangiTakim = 2; //Top takim2'ye geçecek
                            break;
                        }
                        else
                        {
                            System.Threading.Thread.Sleep(1000); //Kullanıcının takibini kolaylaştırmak adına işlemi 1 saniye bekleyerek ekrana yazdıracak fonksiyon
                            Console.WriteLine(takim1[oyuncuNo].AdSoyad + " adli futbolcudan basarili pas!");
                            sure++; //İşlem sonucu 1 saniyenin geçtiği, süre niteliğini tutan değişkene eklenecek
                            basariliPas++; //Atılan pasın başarılı olması durumunda basariliPas değişkeni 1 arttırılacak
                            if (basariliPas == 3) //Arka arkaya başarılı pas sayısını tutan değişken değerinin 3'e eşit olması durumunda şut çekilecek
                            {
                                if (takim1[oyuncuNo].GolSkor() == true) //Eğer oyuncunun niteliklerinin değerlerinden yapılan hesaplamalar sonucu GolSkor() metodu true değer döndürürse takim1'in gol attığı işlenecek
                                {
                                    for (i = 0; i < 1; i++)
                                        while (i < 1)
                                        {
                                            oyuncuNo = aralikBelirleme.Next(1, 10);

                                            if (Array.IndexOf(KontrolDizisi, oyuncuNo) == -1) //Arka arkaya atanan iki değerin aynı olup olmadığını kontrol eden yapı
                                                KontrolDizisi[i++] = oyuncuNo;
                                        }
                                    System.Threading.Thread.Sleep(1000); //Kullanıcının takibini kolaylaştırmak adına işlemi 1 saniye bekleyerek ekrana yazdıracak fonksiyon
                                    Console.WriteLine("Gooooooooool ! Topu aglara gonderen oyuncu " + takim1[oyuncuNo].AdSoyad + " !\n");
                                    sure++; //İşlem sonucu 1 saniyenin geçtiği, süre niteliğini tutan değişkene eklenecek
                                    basariliPas = 0; //Şut çekilmesi durumunda başarılı pasları tutan değişken sıfırlanacak
                                    EvGol++; //Ev sahibi takımın attığı gol sayısını tutan değişken 1 arttırılacak
                                    hangiTakim = 2; //Top takim2'ye geçecek
                                    break;
                                }
                                else
                                {
                                    for (i = 0; i < 1; i++)
                                        while (i < 1)
                                        {
                                            oyuncuNo = aralikBelirleme.Next(1, 10);

                                            if (Array.IndexOf(KontrolDizisi, oyuncuNo) == -1) //Arka arkaya atanan iki değerin aynı olup olmadığını kontrol eden yapı
                                                KontrolDizisi[i++] = oyuncuNo;
                                        }
                                    System.Threading.Thread.Sleep(1000); //Kullanıcının takibini kolaylaştırmak adına işlemi 1 saniye bekleyerek ekrana yazdıracak fonksiyon
                                    Console.WriteLine(takim1[oyuncuNo].AdSoyad + " isimli oyuncunun sutu golle sonuclanmadi.\n");
                                    sure++; //İşlem sonucu 1 saniyenin geçtiği, süre niteliğini tutan değişkene eklenecek
                                    basariliPas = 0; //Şut çekilmesi durumunda başarılı pasları tutan değişken sıfırlanacak
                                    hangiTakim = 2;  //Top takim2'ye geçecek
                                    break;
                                }
                            }
                        }
                    }
                }
                else if (hangiTakim == 2)
                {
                    System.Threading.Thread.Sleep(1000); //Kullanıcının takibini kolaylaştırmak adına işlemi 1 saniye bekleyerek ekrana yazdıracak fonksiyon
                    Console.WriteLine("Konuk ekip oyunu hareketlendirecek.");
                    sure++; //İşlem sonucu 1 saniyenin geçtiği, süre niteliğini tutan değişkene eklenecek

                    for (int i = 1; i <= 3; i++) //Arka arkaya 3 başarılı pas olup olmayacağını kontrol amaçlı kurulan döngü
                    {
                        for (i = 0; i < 1; i++)
                            while (i < 1)
                            {
                                oyuncuNo = aralikBelirleme.Next(1, 10);

                                if (Array.IndexOf(KontrolDizisi, oyuncuNo) == -1) //Arka arkaya atanan iki değerin aynı olup olmadığını kontrol eden yapı
                                    KontrolDizisi[i++] = oyuncuNo;
                            }
                        if (takim2[oyuncuNo].PasSkor() == false)
                        {
                            System.Threading.Thread.Sleep(1000); //Kullanıcının takibini kolaylaştırmak adına işlemi 1 saniye bekleyerek ekrana yazdıracak fonksiyon
                            Console.WriteLine(takim2[oyuncuNo].AdSoyad + " adli oyuncudan kotu pas, top kaybedildi.\n");
                            sure++; //İşlem sonucu 1 saniyenin geçtiği, süre niteliğini tutan değişkene eklenecek
                            hangiTakim = 1; //Top takim1'e geçecek
                            basariliPas = 0; //Hatalı pas atılması durumunda başarılı pasları tutan değişken sıfırlanacak
                            break;
                        }
                        else
                        {
                            System.Threading.Thread.Sleep(1000); //Kullanıcının takibini kolaylaştırmak adına işlemi 1 saniye bekleyerek ekrana yazdıracak fonksiyon
                            Console.WriteLine(takim2[oyuncuNo].AdSoyad + " adli futbolcudan basarili pas!");
                            sure++; //İşlem sonucu 1 saniyenin geçtiği, süre niteliğini tutan değişkene eklenecek
                            basariliPas++; //Atılan pasın başarılı olması durumunda basariliPas değişkeni 1 arttırılacak
                            if (basariliPas == 3) //Arka arkaya başarılı pas sayısını tutan değişken değerinin 3'e eşit olması durumunda şut çekilecek
                            {
                                if (takim2[oyuncuNo].GolSkor() == true) //Eğer oyuncunun niteliklerinin değerlerinden yapılan hesaplamalar sonucu GolSkor() metodu true değer döndürürse takim2'nin gol attığı işlenecek
                                {
                                    for (i = 0; i < 1; i++)
                                        while (i < 1)
                                        {
                                            oyuncuNo = aralikBelirleme.Next(1, 10);

                                            if (Array.IndexOf(KontrolDizisi, oyuncuNo) == -1) //Arka arkaya atanan iki değerin aynı olup olmadığını kontrol eden yapı
                                                KontrolDizisi[i++] = oyuncuNo;
                                        }
                                    System.Threading.Thread.Sleep(1000); //Kullanıcının takibini kolaylaştırmak adına işlemi 1 saniye bekleyerek ekrana yazdıracak fonksiyon
                                    Console.WriteLine("Gooooooooool ! Topu aglara gonderen oyuncu " + takim2[oyuncuNo].AdSoyad + " !\n");
                                    sure++; //İşlem sonucu 1 saniyenin geçtiği, süre niteliğini tutan değişkene eklenecek
                                    basariliPas = 0;//Şut çekilmesi durumunda başarılı pasları tutan değişken sıfırlanacak
                                    DepGol++; //Deplasman takımın attığı gol sayısını tutan değişken 1 arttırılacak
                                    hangiTakim = 1; //Top takim1'e geçecek
                                    break;
                                }
                                else
                                {
                                    for (i = 0; i < 1; i++)
                                        while (i < 1)
                                        {
                                            oyuncuNo = aralikBelirleme.Next(1, 10);

                                            if (Array.IndexOf(KontrolDizisi, oyuncuNo) == -1) //Arka arkaya atanan iki değerin aynı olup olmadığını kontrol eden yapı
                                                KontrolDizisi[i++] = oyuncuNo;
                                        }
                                    System.Threading.Thread.Sleep(1000); //Kullanıcının takibini kolaylaştırmak adına işlemi 1 saniye bekleyerek ekrana yazdıracak fonksiyon
                                    Console.WriteLine(takim2[oyuncuNo].AdSoyad + " isimli oyuncunun sutu golle sonuclanmadi.\n");
                                    sure++; //İşlem sonucu 1 saniyenin geçtiği, süre niteliğini tutan değişkene eklenecek
                                    basariliPas = 0; //Şut çekilmesi durumunda başarılı pasları tutan değişken sıfırlanacak
                                    hangiTakim = 1; //Top takim1'e geçecek
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Ev sahibi takim : " + EvGol + "-" + DepGol + " : Deplasman takim"); //Maç sonucu ekrana basılacak
            Console.ReadKey();
        }
    }
}



