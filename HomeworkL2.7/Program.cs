using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkL2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Шаповаленко Александр Не выполненно, т.к. не понимаю что такое рекурсия и как её правильно описывать.
            //7.
            //a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a < b).
            //б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.

                        Console.WriteLine("Вывод чисел от минимально до максимального значения с помощью рекурсии");


            Console.WriteLine("Введите минимально число: "); int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите максимальное число: "); int b = int.Parse(Console.ReadLine());
            int result;
            int value;
                if (a <= b)
                {
                    for (int i = a; i <= b; i++)
                    {
                        Console.WriteLine(a++);
                        result = 0;
                        value = i;
                    while (value > 0)
                    {
                        MethodSumm(ref result, ref value);
                    }
                    Console.WriteLine($"Сума цифр числа {i} = {result}");
                    }
                }
                else if (a >= b)
                {
                    Console.WriteLine("Ошибка: первое число больше второго");
                }

            

            Console.ReadLine();
        }

        private static void MethodSumm(ref int result, ref int value)
        {
            result += value % 10;
            value /= 10;
        }

    }
}
