using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Metotlar

            //()
            // 1. geriye değer döndürmeyen metotları - Void metotlar
            //void customerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}

            //customerList();

            //void sum()
            //{
            //    int x = 1; 
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //sum();





            #endregion

            #region Geriye Değer Döndürmeyen Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Mehmet Yıldırım");

            //void customerCard(string name, string surname)
            //{
            //    Console.WriteLine("Müşteri " + name + " " + surname);
            //}


            //customerCard("Ali", "Burgaz");
            //customerCard("Ayşegül", "Kaya");

            //void sum(int number1, int number2,int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //sum(4, 5, 6);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //2 

            //string customerName()
            //{
            //    return "Buse Yıldız";
            //}
            //customerName();

            //string studentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(studentCard());



            #endregion

            #region Geriye Değer Döndüren Parametreli Metotlar

            //string countryCard(string countryName,string capital,string flagColor)
            //{
            //    string cardInfo="Ülke : "+countryName+" - Başkent : "+capital+" - Bayrak Rengi : "+flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke Adı : ");
            //x= Console.ReadLine();
            //Console.Write("Başkent Adı : ");
            //y= Console.ReadLine();
            //Console.Write("Bayrak rengi: ");
            //z = Console.ReadLine();
            //Console.WriteLine(countryCard(x,y,z));


            //int sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(sum(45, 90));

            string examResult(string student, int exam1, int exam2)
            {
                int result = (exam1 + exam2) / 2;
                if (result >= 50)
                {
                    return student + " Sınavı geçti Ortalama : "+ result;
                }
                else
                {
                    return student + " Sınavdan kaldı Ortalama : "+result;
                }
            }

            Console.WriteLine(examResult("Ali", 45, 80));
            Console.WriteLine(examResult("Elif", 12, 30));

            #endregion



            Console.Read();

        }
    }
}
