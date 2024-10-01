﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {

        static void Main(string[] args)
        {

            #region Double Değişkenler
            //double number;

            //number = 4.85; // . olarak girdiğimde , olarak görüntülenir.

            //Console.WriteLine(number);



            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();
            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("----- Elma Birim Fiyatı " + applePrice+" TL");
            //Console.WriteLine("----- Portakal Birim Fiyatı " + orangePrice + " TL");
            //Console.WriteLine("----- Çilek Birim Fiyatı " + strawberryPrice + " TL");
            //Console.WriteLine("----- Patates Birim Fiyatı " + potatoPrice + " TL");
            //Console.WriteLine("----- Domates Birim Fiyatı " + tomatoPrice + " TL₺");

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram* orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine();
            //Console.WriteLine("Alınan Ürün :Elma - "+ "Birim Fiyat : "+applePrice+" - Gramaj : "+appleGram+" - Toplam tutar " + appleTotalPrice+ " TL");
            //Console.WriteLine("Alınan Ürün :Portakal - "+ "Birim Fiyat : "+orangePrice+" - Gramaj : "+orangeGram+" - Toplam tutar " + orangeTotalPrice+ " TL");
            //Console.WriteLine("Alınan Ürün :Çilek - "+ "Birim Fiyat : "+strawberryPrice+" - Gramaj : "+strawberryGram+" - Toplam tutar " + strawberryTotalPrice+ " TL");
            //Console.WriteLine("Alınan Ürün :Patates - "+ "Birim Fiyat : "+potatoPrice+" - Gramaj : "+potatoGram+" - Toplam tutar " + potatoTotalPrice+ " TL");
            //Console.WriteLine("Alınan Ürün :Domates - "+ "Birim Fiyat : "+tomatoPrice+" - Gramaj : "+tomatoGram+" - Toplam tutar " + tomatoTotalPrice+ " TL");

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine("Alışveriş Toplam Tutarı : "+shoppingTotalPrice+ " TL ");



            #endregion

            #region Char Değişkenler


            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge,
            //    passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("-------------------------");
            //Console.WriteLine();
            //Console.WriteLine("Yolcu: " + passengerName + " " + passengerSurname+" "+passengerCity+ " / "+passengerDistrict+ " "+passengerAge+" "+passengerIdentityNumber);

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoeCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz ");
            //shoeCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz ");
            //computerCount= int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoeCount * shoePrice + computerCount * computerPrice + chairCount * chairPrice + tvPrice * tvCount;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice);


            #endregion

            #region Klavyeden Ondalıklı sayı işlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1. Sınav Notunu Giriniz: ");
            //exam1=double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. Sınav Notunu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. Sınav Notunu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);


            #endregion

            #region Klavyeden Karakter girişleri

            //char gender;
            //Console.Write("Lütfen Cinsiyet Seçiniz: ");
            //gender=char.Parse(Console.ReadLine());

            //Console.Write("Seçtiğiniz Cinsiyet: " + gender);
            #endregion

            Console.Read();
        }
    }
}
