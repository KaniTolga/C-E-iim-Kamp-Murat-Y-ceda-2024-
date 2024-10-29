using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Veriables_Değişkenler_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Double Değişkenler
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);
            //price= fiyat
            //count= adet

            //Console.WriteLine("**** Fiyat Listesi ****");
            //Console.WriteLine();

            //double applePrice,orangePrice,strawberryPrice,potatoPrice,tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("----Elma Birim Fiyatı:" + applePrice + " " + "TL");
            //Console.WriteLine("----Portakal Birim Fiyatı:"+orangePrice+" "+"TL");
            //Console.WriteLine("----Çilek Birim Fiyatı:"+strawberryPrice+" "+"TL");
            //Console.WriteLine("----Patates Birim Fiyatı:"+potatoPrice+" "+"TL");
            //Console.WriteLine("----Domates Birim Fiyatı:"+tomatoPrice+" "+ "TL");

            //double appleGram,orangeGram,straberryGram,potatoGram,tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.600;
            //straberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;
            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrices=orangeGram* orangeGram;
            //double straberryTotalPrices=straberryGram* orangeGram;
            //double potatoTotalPrices=potatoGram* potatoPrice; ;
            //double tomatoTotalPrice = tomatoGram* tomatoGram;

            //Console.WriteLine();
            //Console.WriteLine("---- Ödenecek Tutar----");
            //Console.WriteLine();
            //Console.WriteLine("->Elmanın Toplam Fiyatı:" + appleTotalPrice + " " + "TL");
            //Console.WriteLine("->Portakalın Toplam Fiyatı:" + orangeTotalPrices + " " + "TL");
            //Console.WriteLine("->Çileğin Toplam Fiyatı:" + straberryTotalPrices + " " + "TL");
            //Console.WriteLine("->Patatesin Toplam Fiyatı:" + potatoTotalPrices + " " + "TL");
            //Console.WriteLine("->Domatesin Toplam Fiyatı:" + tomatoTotalPrice + " " + "TL");
            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("Alınan Ürün:Elma -" + "Birim Fiyatı:" + applePrice + "- Gramaj:" + appleGram + "- Toplam Tutar:" + appleTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün:Portakal -" + "Birim Fiyatı:" + orangePrice + "- Gramaj:" + orangeGram + "- Toplam Tutar:" + orangeTotalPrices + " TL");
            //Console.WriteLine("Alınan Ürün:Çilek -" + "Birim Fiyatı:" + strawberryPrice + "- Gramaj:" + straberryGram + "- Toplam Tutar:" + straberryTotalPrices + " TL");
            //Console.WriteLine("Alınan Ürün:Patates -" + "Birim Fiyatı:" + potatoPrice + "- Gramaj:" + potatoGram + "- Toplam Tutar:" + potatoTotalPrices + " TL");
            //Console.WriteLine("Alınan Ürün:Domates -" + "Birim Fiyatı:" + tomatoPrice + "- Gramaj:" + tomatoGram + "- Toplam Tutar:" + tomatoTotalPrice + " TL");
            //Console.WriteLine();
            //Console.WriteLine();
            //double shophingTotalPrice = appleTotalPrice + orangeTotalPrices + straberryTotalPrices + potatoTotalPrices + tomatoTotalPrice;
            //Console.WriteLine("Alışveriş Toplam Tutar:"+shophingTotalPrice);

            #endregion

            #region Char Değişkenler
            // char-> Karakter türünde değişkeni ifade eder.
            //ABCDEFGH
            //DEF...
            //TOPLANTI SAAT 20.00'DE
            //" ' ile tanımlanır.
            //char symbol;
            //symbol ='a';
            //Console.WriteLine(symbol)

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenleri
            //district=ilçe
            //age=yaş
            //Identity number= T.C. kimli no gibi düşünülebilir.
            // ctrl+f ile istediğin şeyleri bulup isimlerini değişitirebilirsin.

            //Console.WriteLine("**** CSharp Hava Yolları Hava Bilgisi ****");
            //Console.WriteLine();
            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge,passengerIdentityNumber;
            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            ////Console.WriteLine();
            ////Console.WriteLine("-------------------------");
            ////Console.WriteLine("Yolcu: "+passengerName+" "+passengerSurname);

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaşı: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu T.C.Kimlik No Bilgisi:");
            //passengerIdentityNumber = Console.ReadLine();
            //Console.WriteLine();
            //Console.WriteLine("-------------------");


            //Console.WriteLine("Yolcu T.C. Kimlik No: " + passengerIdentityNumber+" "+ "Yolcu Ad-Soyad: " + passengerName + " " + passengerSurname  + "Yolcu Yaşı: " + passengerAge  + "Yolcu Şehri: " + passengerCity  + "Yolcu İlçesi: " + passengerDistrict );


            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler
            // C# dili girilen değişkenleri ilk string olarak atar bu yüzden dönüşüm yapılmalıdır.
            //ABC12D
            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;
            //Console.Write("Lütfen aldığınız ayakkabı sayısını girinzi:");
            //shoesCount =int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz:");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz:");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz:");
            //tvCount = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;
            //Console.WriteLine("Toplam Maliyet: " + " " + totalPrice + " " + "TL");


            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;
            //Console.Write("Lütfen 1.sınav notunu giriniz: ");
            //exam1 =double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.sınav notunu giriniz: ");
            //exam2 =double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.sınav notunu giriniz: ");
            //exam3 =double.Parse(Console.ReadLine());

            //result=(exam1+exam2+exam3)/3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);         

            #endregion

            #region Klavyeden Karakter Girişleri
            ////dize karakteri 1 kelime uzunluğunda olmalıdır.
            //char gender;
            //Console.Write("Lütfen cinsiyetinizi seçiniz: ");
            //gender=char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz cinsiyet: " + gender);


            #endregion

            Console.Read();


        }
    }
}
