using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //Foreach(1;2;3;4)

            // 1 : değişken türü
            // 2 : değişken adı
            // 3 : In
            // 4 : liste, koleksiyon, dizi adı

            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };

            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 45, 78, 985, 645, 44, 12, 98, 56, 78, 192, 987, 4860 };

            //foreach (int sayi in numbers)
            //{
            //    Console.WriteLine(sayi);
            //}

            //int[] numbers = { 45, 78, 985, 645, 44, 12, 98, 56, 78, 192, 987, 4860 };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 45, 78, 985, 645, 44, 12, 98, 56, 78, 192, 987, 4860 };
            //int total = 0;

            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);

            #endregion

            #region Listeler

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}


            #endregion

            #region Kelimeyi Harflerine Ayırma

            //string word = "merhaba";

            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}
            #endregion

            #region Sınav Sistemi Uygulaması

            //Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("--------------------------------");
            //Console.Write("Sınıfınızda Kaç Öğrenci Var : ");
            //int studentCount=int.Parse(Console.ReadLine());
            //Console.WriteLine("--------------------------------");

            //// öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            //string[] studentNames=new string[studentCount];
            //double[] studentExamAvg=new double[studentCount];

            //for(int i=0; i<studentCount; i++)
            //{
            //    Console.Write($"{i + 1}. öğrencinin ismini giriniz : ");
            //    studentNames[i] = Console.ReadLine();

            //    double totalExamResult = 0;

            //    //her öğrenci için 3 sınav notu girişi

            //    for(int j=0; j < 3; j++)
            //    {
            //        Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz : ");
            //        double value=double.Parse(Console.ReadLine());
            //        totalExamResult += value; //notların toplamı
            //    }
            //    Console.WriteLine();
            //    studentExamAvg[i] = totalExamResult / 3; //öğrencinin ortalaması

            //}
            ////öğrencinin ortalaması ve geçip kalma durumları
            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması : {studentExamAvg[i]}");
            //    if (studentExamAvg[i] >= 50)
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci desten kaldı");
            //    }

            //    Console.WriteLine("---------------------------");
            //}
            #endregion

            Console.Read();
        }
    }
}
