using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkL1._4b
{
    class Program
    {
        static void Main(string[] args)
        {

            //Шаповаленко Александр 
            //Написать программу обмена значениями двух переменных:
            //б) *без использования третьей переменной


            Console.WriteLine("Программа обмена двумя переменными");

            Console.WriteLine("Введите первое значение");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе значение");
            int num2 = Convert.ToInt32(Console.ReadLine());

            num2 = num1 + num2;
            
            num1 = num2 - num1;
            num2 = num2 - num1;

            Console.WriteLine($"Первое значение: {num1} \nВторое значение: {num2}");

            Console.ReadLine();
        }
    }
}
