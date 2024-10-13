using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Alt Alta 10 tane yıldız oluşturma

            //for(int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}

            #endregion

            #region Yan Yana 10 tane yıldız oluşturma

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}

            #endregion

            #region Alt Alta 10 tane yıldız oluşturma her satırda 10 yıldız olsun

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("**********");
            //}

            #endregion

            #region Dik Üçgen oluşturma

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i  ; j++) {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Ters Dik Üçgen

            //for (int i = 5; i >= 1; i--)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Dik ve Ters Dik Üçgen

            //for (int i = 1; i <= 5; i++)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");

            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 4; i >= 1; i--)
            //{
            //    for(int j=1; j <=i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Baklava dilimi

            //int yukseklik = 5; // kaç satırdan oluşacağını belirledi
            ////üst kısım
            //for(int i = 1; i <= yukseklik; i++)
            //{
            //    for(int j = yukseklik ; j > i; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int k=1;k<=2*i-1; k++) //2*i-1      1 - 3 - 5 - 7 yıldız sayısını sağlıyor
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //// alt kısım
            //for (int i = yukseklik - 1; i >= 1; i--)
            //{
            //    for (int j = yukseklik ; j > i; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            //}
            #endregion

            #region Piramit

            //int yukseklik = 5;

            //for (int i = 1; i <= yukseklik; i++) 
            //{
            //    // boşluklar
            //    for (int j = yukseklik - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    // yıldızlar
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Ters Piramit

            int yukseklik = 5;
            for (int i = yukseklik; i >=1; i--)
            {
                // boşluklar
                for(int j = yukseklik-i; j>0; j--)
                {
                    Console.Write(" ");
                }
                // yıldızlar
                for(int k = 1; k <= 2*i-1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            #endregion


            Console.Read();
        }
    }
}
