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
            //Foreach(değişkenTürü değişkenAdı in Liste/Koleksiyon/Dizi)

            //string[] cities = { "Milano", "Roma", "Budapeşte", "Ankara", "İstanbul", "Varşova" };
            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 32, 41, 205, 6578 };
            //foreach(int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 32, 41, 205, 6578, 10394 };
            //int total = 0;
            //foreach (int number in numbers)
            //{
            //    total += number;
            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "Merhaba";
            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}
            #endregion

            #region Örnek Sınav Sistemi Uygulaması
            Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****\n\n\n");

            //Sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("--------------------------------");
            Console.Write("Sınıfınızdaki öğrenci sayısı: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------");

            // Öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin adını giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                //Her öğrenci için 3 sınav notu girişi
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value; //notları topladık
                }
                Console.WriteLine();

                //Sınav ortalamalarını hesaplama
                studentExamAvg[i] = totalExamResult / 3;

            }

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("--------------------------------");
                //Sınav ortalamalarını yazdırma
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");

                //Öğrencilerin derslerden geçme-kalma durumları
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti.");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı.");

                }
                Console.WriteLine("--------------------------------");

            }
            #endregion
            Console.Read();
        }
    }
}
