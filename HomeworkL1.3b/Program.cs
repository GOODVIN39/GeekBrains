using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkL1._3b
{
    class Program
    {
        //Шаповаленко Александр
        //а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
        //б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.

        static void Main(string[] args)
        {
            Console.WriteLine("Программа для подсчёта расстояния между точками с координатами.");

            Console.WriteLine("Введите 4 координаты:");

            Console.Write("x1:");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nx2:");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\ny1:");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\ny2:");
            double y2 = Convert.ToDouble(Console.ReadLine());
            
            double result = Calculation(x1, x2, y1, y2);

            Console.WriteLine($"\nРезультат = {result:f1}");


            Console.ReadKey();
        }

        private static double Calculation(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
