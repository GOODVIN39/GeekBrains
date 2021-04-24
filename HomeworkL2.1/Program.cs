using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkL2._1
{
    class Program
    {
        //Шаповалекно Александр
        //1. Написать метод, возвращающий минимальное из трёх чисел.
        static void Main(string[] args)
        {
            Console.WriteLine("Вывод минимального числа из трех");

            MinCount();
            Console.ReadLine();
        }

        private static void MinCount()
        {
            Console.WriteLine("Введи 3 числа");
            Console.Write("Первое число: "); int count1 = int.Parse(Console.ReadLine());
            Console.Write("Второе число: "); int count2 = int.Parse(Console.ReadLine());
            Console.Write("Третье число: "); int count3 = int.Parse(Console.ReadLine());

            if (count1 > count2)
            {
                Console.WriteLine($"\nПервое {count1} число  самое большое");
            }
            else if (count2 > count3)
            {
                Console.WriteLine($"Второе {count2} число  самое большое");
            }
            else
            {
                Console.WriteLine($"Третье {count3} число  самое большое");
            }
        }
    }
}
