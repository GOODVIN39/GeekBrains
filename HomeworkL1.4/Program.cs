using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkL1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Шаповаленко Александр 
            //Написать программу обмена значениями двух переменных:
            //а) с использованием третьей переменной;


            Console.WriteLine("Программа обмена двумя переменными");

            Console.WriteLine("Введите первое значение");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе значение");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double num3 = num1 + num2;

            Console.WriteLine($"Первое значение: { num3 - num1} \nВторое значение: {num3 - num2}");

            Console.ReadLine();
        }
    }
}
