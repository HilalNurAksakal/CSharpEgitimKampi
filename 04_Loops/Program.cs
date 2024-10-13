using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region For Döngüsü

            //int i;
            //for(i=1; i<=5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for(int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i < 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen Başlangıç değeri giriniz : ");
            //int başlangıc = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen Bitiş değeri giriniz : ");
            //int bitis=int.Parse(Console.ReadLine());

            //for(int i = başlangıc; i <= bitis; i++)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region For Döngüsü ve Karar Yapıları

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalValue = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    totalValue += i;
            //}
            //Console.WriteLine(totalValue);

            //int totalValue = 0;
            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("-----------");
            //Console.WriteLine(totalValue);

            //int sayı = 0;
            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        sayı++;
            //    }
            //}
            //Console.Write(sayı);

            #endregion

            #region Örnek

            //1-2-4-8-16
            //int bacterium = 1;

            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i+". saat sonunda : "+bacterium);
            //}

            #endregion

            #region While Döngüsü

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0) {

            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;
            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);

            #endregion

            #region Örnek2

            //Console.Write("Sayı Giriniz : ");
            //int number=int.Parse(Console.ReadLine());
            //int ones, tens, hundred;
            //int sum = 0;
            ////487
            //ones = number % 10;
            //tens = (number % 100)/10;//          87 / 10: 8
            //hundred = number / 100; 

            //sum = ones + tens + hundred;
            //Console.WriteLine(sum);

            #endregion

            Console.Read();

        }
    }
}
