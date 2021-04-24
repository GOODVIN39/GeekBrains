using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkL2._6
{
    class Program
    {
        //Шаповаленко Александр
        //6. *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. «Хорошим» называется число, которое делится на сумму своих цифр. Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
        static void Main(string[] args)
        {
            Console.WriteLine("Программа подсчета хороших чисел с подчетом времени работы программы");
            DateTime start = DateTime.Now;

            int minCount = 1;
            int maxCount = 1000000000;
            int goodCount = 0;
            int value;
            int result;


            for (int i = minCount; i < maxCount; i++)
            {
                result = 0;
                value = i;
                while (value > 0)
                {
                    result += value % 10;
                    value /= 10;
                }
                if (i % result == 0)
                {
                    goodCount++;
                }
            }
            Console.WriteLine($"Количесво ХОРОШИХ чисел в дапазоне от 1 до 1 000 000 000 составляет: {goodCount}");
            
            DateTime finish = DateTime.Now;
            Console.WriteLine($"Время выполнения программы: {finish-start}");

            Console.ReadLine();
        }
    }
}
