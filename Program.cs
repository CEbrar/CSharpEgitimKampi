using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; //Burda yazanlar Kütüphane

namespace MY_C__DERS_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region   Yazdırma Komutları
            //Console.Write("Hi World!"); //İmleç cümlenin en sağında bekler
            //Console.WriteLine("Hi!");  //İmleç alt satıra geçer.
            #endregion

            #region String Değişkenler (String Variables)

            // Yazı değişkenleri

            //string name = "Murat";
            //Console.WriteLine(name);

            //string customerName;
            //string customerSurname;

            //customerName = "Murat";
            //customerSurname = "Yücedağ";

            //Console.WriteLine("Customer: " + customerName + "" + customerSurname);
            //Console.WriteLine();

            //customerName = "Henry";     //Aynı değişkene sonra başka bir isim de atanabilir
            //customerSurname = "Cavil";

            //Console.WriteLine("Customer: " + customerName + "" + customerSurname);
            //Console.WriteLine();

            #endregion

            #region Int Değişkenler

            //Tam sayı değişkenleri

            //int burgerPrice = 10;
            //int cokePrice = 2;
            //int friesPrice = 5;
            //Console.WriteLine("****Restourant Menu Price****");
            //Console.WriteLine();
            //Console.WriteLine("Coke: " + cokePrice+"$");
            //Console.WriteLine("Fries: " + friesPrice + "$");
            //Console.WriteLine("Burger " + burgerPrice + "$");
            //Console.WriteLine();
            //Console.WriteLine("****Restourant Menu Price****");
            //Console.WriteLine();

            //int burgercount = 3;
            //int cokecount = 3;
            //int friescount = 4;

            //int totalPrice = 0;

            //totalPrice = burgerPrice*burgercount + cokePrice*cokecount + friesPrice*friescount;

            //Console.WriteLine("---------------------------------");
            //Console.WriteLine("Total Payment: " + totalPrice + "$");

            #endregion

            #region Double Değişkenler
            //Ondalıklı sayılar

            //Console.WriteLine("****Fiyat Listesi****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı: "+applePrice + " TL" );
            //Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice + " TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice + " TL");
            //Console.WriteLine("---- Patates Birim Fiyatı: " + potatoPrice + " TL");
            //Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice + " TL");

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double totalPrice = applePrice * appleGram + orangePrice * orangeGram + strawberryPrice * strawberryGram + potatoPrice * potatoGram + tomatoPrice * tomatoGram;

            //Console.WriteLine("Toplam Ödeme: " + totalPrice + " TL");

            #endregion

            #region Char Değişkenler
            //Karakter türünde değişkenler. Mesela şifreler belirlemek için yeni karakterler vs koyabilirsin gibi.

            //char symbol = 'a';

            #endregion

            #region Klavyeden Veri Girişleri

            //String'ler

            //Console.WriteLine("**** C# Hava Yolları Yolcu Bilgisi****");
            //Console.WriteLine();

            //string pasName, pasSurname;

            //Console.Write("Yolcu Adı: ");
            //pasName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı:");
            //pasSurname = Console.ReadLine();
            //Console.WriteLine();
            //Console.WriteLine("-------------------");
            //Console.WriteLine("Yolcu: " + pasName + " " + pasSurname);

            //Int'lar

            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shCount, comCount, chCount, tvCount;
            //Console.Write("Aldığınız ayakkabı sayısını giriniz: ");
            //shCount = int.Parse(Console.ReadLine());   //Parse 32 bit formatında sayıları dönüştürür.

            //Console.Write("Aldığınız bilgisayar sayısını giriniz: ");
            //comCount = int.Parse(Console.ReadLine());

            //Console.Write("Aldığınız sandalye sayısını giriniz: ");
            //chCount = int.Parse(Console.ReadLine());

            //Console.Write("Aldığınız tv sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shCount * shoePrice + comCount * computerPrice + chCount * chairPrice + tvCount * tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Tutar: " + totalPrice + " TL");

            //Double'lar

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.sınav notunu gir: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.sınav notunu gir: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.sınav notunu gir: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);

            //Char'lar

            //char gender;
            //Console.WriteLine("Lütfen cinsiyet seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz cinsiyet: " + gender);

            //Burada bir karakter girilmesi bekleniyor. Birden fazla girilirse hata alınır.
           #endregion


            Console.Read();  //Ekran ben entere basana kadar kapanmasın diye
        }
    }
}
