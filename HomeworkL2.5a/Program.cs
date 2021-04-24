using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkL2._5a
{
    class Program
    {
        //Шаповаленко Александр
        //5.а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
        //  б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
        static void Main(string[] args)
        {
            Console.WriteLine("Эта программа рассчитывает индекс массы твоего тела. Давай начнем!");

            Console.WriteLine("Введи свой вес в килограммах:");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введи свой рост в метрах:");
            double height = Convert.ToDouble(Console.ReadLine());

            double index = weight / (height * height);
                        
            if (index > 25)
            {
                Console.WriteLine($"Ваш индекс массы тела = {index:f1}. \nВам нужно похудеть на {index - 25:f1}кг для нормальзации веса");
            }
            else if (index < 25)
            {
                Console.WriteLine($"Ваш индекс массы тела = { index:f1}. \nВам нужно набрать {25 - index:f1}кг для нормальзации веса");
            }
            else
            {
                Console.WriteLine($"У вас идеальный индекс массы тела");
            }
            Console.ReadKey();
        }
    }
}
