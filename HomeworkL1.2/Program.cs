using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkL1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Шаповаленко Александр
            //Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I = m / (h * h); где m — масса тела в килограммах, h — рост в метрах.

                Console.WriteLine("Эта программа рассчитывает индекс массы твоего тела. Давай начнем!");

            Console.WriteLine("Введи свой вес в килограммах:");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введи свой рост в метрах:");
            double height = Convert.ToDouble(Console.ReadLine());

            double result = weight / (height * height);

            Console.WriteLine($"Индекс массы твоего тела: {result:f1}");
            Console.ReadKey();


        }
    }
}
