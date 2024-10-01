using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects //projeye verdiğimiz isim 01_MainSubject
{
    internal class Program //erişim belirleyici
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları

            //Console.WriteLine("Hello World");
            //Console.Write("Hi!");

            //Console.WriteLine("****** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4.Salatalar");
            //Console.WriteLine("5.Tatlılar");
            //Console.WriteLine("6.İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("****** Yemek Kategorileri *****");

            #endregion


            #region StringDeğişkenler
            //Değişkenler
            // Değişken_türü değişken_adi = değer;

            //string name;
            //name = "Murat";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "+90 500 400 30 20";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------");
            //Console.WriteLine("Müşteri: "+customerName+ " "+customerSurname);
            //Console.WriteLine("İletişim: "+customerPhone);
            //Console.WriteLine("Email:" + customerEmail );
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("------------------------------------");

            #endregion


            #region İntDeğişkenler

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("***** Restoran Menü Fiyatı *****");
            Console.WriteLine();
            Console.WriteLine("----- Hamburger " + hamburgerPrice+" TL");
            Console.WriteLine("----- Kola " + cokePrice+ " TL");
            Console.WriteLine("----- Su " + waterPrice+ " TL");
            Console.WriteLine("----- Kızartmalar " + friesPrice+ " TL");
            Console.WriteLine("----- Pizza " + pizzaPrice+ " TL");
            Console.WriteLine("----- Limonata " + lemonadePrice+ " TL");

            #endregion

            Console.Read(); //Enter tuşuna basana kadar konsol durur.
        }
    }
}


// Yazdırma komutları