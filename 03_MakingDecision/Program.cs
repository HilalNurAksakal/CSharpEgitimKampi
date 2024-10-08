using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Lütfen Şifreyi Giriniz : ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Başarılı Giriş");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;
            //Console.Write("Başkenti giriniz : ");
            //capital = Console.ReadLine();
            //Console.WriteLine("ülkeyi giriniz");
            //country = Console.ReadLine();

            //if(capital=="ankara" & country=="türkiye")
            //{
            //    Console.Write("Veri girişi doğru");
            //}
            //else
            //{
            //    Console.Write("Hatalı veri girişi");
            //}

            //int number;
            //Console.Write("sayıyı giriniz : ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("sayı hatalı");
            //}

            //int exam1, exam2, exam3, average;
            //string result = "Hata";
            //Console.Write("sınav 1 : ");
            //exam1=int.Parse(Console.ReadLine());
            //Console.Write("sınav 2 : ");
            //exam2=int.Parse(Console.ReadLine());
            //Console.Write("sınav 3 : ");
            //exam3=int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların Ortalaması : " +average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç Vasat";
            //}
            //if(average>50 & average <= 70)
            //{
            //    result = "Sonuç Orta";
            //}
            //if (average>70 & average<=84)
            //{
            //    result = "Sonuç İyi";
            //}
            //if (average > 84) 
            //{
            //    result = "Müthişsin broo";
            //}
            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen Şehir Girişi Yapınız : ");
            //city = Console.ReadLine();
            //if (city == "adana" | city == "ankara" | city == "bursa")
            //{
            //    Console.WriteLine("Şehir Mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir Mevcut Değil");
            //}

            //Console.Write("Lütfen Kullanıcı Adını Giriniz : ");
            //string username=Console.ReadLine();
            //if(username!="admin")
            //{
            //    Console.WriteLine("Hatalı Giriş");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş Geldiniz");
            //}



            #endregion

            #region Mod İşlemleri

            //int number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.WriteLine("Lütfen 1. sayıyı giriniz : ");
            //int number1=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz : ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.Write("1. sayının 2. sayıya bölümünden kalan : " + result);

            //Console.Write("Lütfen sayı giriniz : ");
            //int number=int.Parse(Console.ReadLine());

            //if (number %2== 0)
            //{
            //    Console.Write("Sayı Çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Tektir");
            //}
            #endregion

            #region Char değişkeniyle karar yapıları
            //char team;
            //Console.Write("Lütfen takımınızın baş harfini giriniz : ");
            //team=char.Parse(Console.ReadLine());   
            //if(team =='g' | team == 'G')
            //{
            //    Console.Write("Galatasaray");
            //}
            //if(team =='f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}
            //if(team =='b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}
            #endregion

            #region Örnek Uygulama

            //Console.WriteLine("***** C# Eğitim Kampı Restorant *****");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------");
            //Console.WriteLine("1- Ana Yemekler");
            //Console.WriteLine("2- Çorbalar");
            //Console.WriteLine("3- Pizzalar");
            //Console.WriteLine("4- İçecekler");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("---------------------------");
            //Console.WriteLine();

            //string menuItem;
            //Console.Write("Detayını görmek istediğiniz menüyü seçiniz : ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------- Ana Yemekler --------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Köri soslu tavuk");
            //    Console.WriteLine("2- Kızartma Tabağı");
            //    Console.WriteLine("3- Fasulye Pilav");
            //    Console.WriteLine("4- Fırında Somon");
            //    Console.WriteLine("5- Patlıcan Musakka");
            //    Console.WriteLine();
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------- Çorbalar --------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Mercimek");
            //    Console.WriteLine("2- Ezogelin");
            //    Console.WriteLine();
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------- Pizzalar --------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Akdeniz");
            //    Console.WriteLine("2- Margaritha");
            //    Console.WriteLine();
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------- İçecekler --------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Ayran");
            //    Console.WriteLine("2- Kola");
            //    Console.WriteLine("3- Su");
            //    Console.WriteLine();
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------- Tatlılar --------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Künefe");
            //    Console.WriteLine("2- Kazandibi");
            //    Console.WriteLine("3- Sütlaç");
            //    Console.WriteLine();
            //}

            #endregion

            #region Switch case

            //Console.Write("Lütfen Ay girişi yapınız : ");
            //int mounthNumber = int.Parse(Console.ReadLine());

            //switch(mounthNumber)
            //{
            //    case 1: Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("Şubat"); break;
            //    case 3: Console.WriteLine("Mart"); break;
            //    case 4: Console.WriteLine("Nisan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("Haziran"); break;
            //    case 7: Console.WriteLine("Temmuz"); break;
            //    case 8: Console.WriteLine("Ağustos"); break;
            //    case 9: Console.WriteLine("Eylül"); break;
            //    case 10: Console.WriteLine("Ekim"); break;
            //    case 11: Console.WriteLine("Kasım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;
            //    default:Console.Write("Hatalı Veri Girişi"); break;
            //}

            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("1. sayıyı giriniz : ");
            //number1=int.Parse(Console.ReadLine());
            //Console.Write("2. sayıyı giriniz : ");
            //number2=int.Parse(Console.ReadLine());

            //Console.Write("Yapmak istediğiniz işlemi seçiniz : ");
            //symbol=char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+' :
            //        result= number1 + number2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;
            //    case '-' :
            //        result= number1 - number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım: " + result);
            //        break;

            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm: " + result);
            //        break;

            //}

            #endregion
            Console.Read();

        }
    }
}
