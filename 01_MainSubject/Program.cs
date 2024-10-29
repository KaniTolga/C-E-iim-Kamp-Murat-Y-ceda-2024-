using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Yazdırma Komutları
            //Console.WriteLine("MERHABA DÜNYA");
            //Console.Write("Selam");
            //Console.WriteLine("***** YEMEK KATEGORİLERİ *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıç");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** YEMEK KATEGORİLERİ *****");
            #endregion

            #region String Değişkenler
            ////string -> metinsel türlerdeki değişkenlerdir.
            ////Değişken_türü değişken_adı;
            ////string name;
            ////name = "Tolga";
            ////Console.Write(name);
            ////string customerName; //camelcase 1.küçük 2.diğerleri büyük
            ////string customerSurname;
            ////string customerPhone;
            ////string customerEmail, district, city;

            ////customerName = "Kani";
            ////customerSurname = "Gök";
            ////customerPhone = "05";
            ////customerEmail = "t";
            ////district = "Merkez";
            ////city = "Kırşehir";

            ////Console.WriteLine("**** Rezervasyon Kartı ****");
            ////Console.WriteLine();
            ////Console.WriteLine("---------------------------------");
            ////Console.WriteLine("Müşteri:" + customerName + " " + customerSurname);
            ////Console.WriteLine("İletişim:" + customerPhone);
            ////Console.WriteLine("Email Adresi:" + customerEmail);
            ////Console.WriteLine("İlçe:" + district);
            ////Console.WriteLine("Şehir:" + city);

            ////Console.WriteLine("--------------------------------------------");

            ////// ilk kaniyi oku sonra hilali okur.

            ////customerName = "Hilal";
            ////customerSurname = "Oya";
            ////customerPhone = "05";
            ////customerEmail = "aaa";
            ////district = "Tarsus";
            ////city = "Mersin";

            ////Console.WriteLine("Müşteri:"+customerName+" "+customerSurname);
            ////Console.WriteLine("İletişim:" + customerPhone);
            ////Console.WriteLine("Email Adresi:"+ customerEmail);
            ////Console.WriteLine("İlçe:"+ district);
            ////Console.WriteLine("Şehir:"+ city);

            //Console.WriteLine("------------------------------");




            #endregion

            #region İnteger Değişkenler
            // int -> Sayısal türlerdeki değişkenlerdir.
            //int number = 24;
            //Console.WriteLine(number);
            int hamburgerPrices = 300;
            int cokePrices = 35;
            int waterPrices = 10;
            int friesPrices = 50;
            int pizzaPrices = 250;
            int lemonadePrices = 30;

            // ctrl+d komutu ile bloğun aynısını alttada yazar.
            // price=fiyat
            // count=adet
            Console.WriteLine("**** Restoran Menü Fiyatları ****");
            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("-----Hamburger: " + hamburgerPrices + "TL");
            Console.WriteLine("-----Kola: " + cokePrices + "TL");
            Console.WriteLine("-----Su: " + waterPrices + "TL");
            Console.WriteLine("-----Kızartma:" + friesPrices + "TL");
            Console.WriteLine("-----Pizza: " + pizzaPrices + "TL");
            Console.WriteLine("-----Limonata: " + lemonadePrices + "TL");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            Console.WriteLine("**** Ödenecek Tutar ****");
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;
            int totalCount = 0;

            int totalHamgurgerPrices = 0;
            int totalcokePrices = 0;
            int totalwaterPrices = 0;
            int totalfriesPrices = 0;
            int totalpizzaPrices = 0;
            int totallemonadePrices = 0;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 1;
            lemonadeCount = 2;

            totalHamgurgerPrices = hamburgerCount * hamburgerPrices;
            totalcokePrices = cokeCount * cokePrices;
            totalwaterPrices = waterCount * waterPrices;
            totalfriesPrices = friesCount * friesPrices;
            totallemonadePrices = lemonadeCount * lemonadePrices;


            Console.WriteLine("--------------------------");
            Console.WriteLine("Hamburger Tutarı:" + totalHamgurgerPrices + " " + "TL");
            Console.WriteLine("Kola Tutarı:" + totalcokePrices + " " + "TL");
            Console.WriteLine("Su Tutarı:" + totalwaterPrices + " " + "TL");
            Console.WriteLine("Kızartma Tutarı:" + totalfriesPrices + " " + "TL");
            Console.WriteLine("Pizza Tutarı:" + totalpizzaPrices + " " + "TL");
            Console.WriteLine("Limonata Tutarı:" + totallemonadePrices + " " + "TL");
            Console.WriteLine("--------------------------------");
            Console.WriteLine();
            int totalPrices = totalcokePrices + totalfriesPrices + totalwaterPrices + totalHamgurgerPrices + totalpizzaPrices + totallemonadePrices;
            Console.WriteLine("Toplam Ödenecek Tutar:" + totalPrices + " " + "TL");



            #endregion

            Console.Read();




        }
    }
}
