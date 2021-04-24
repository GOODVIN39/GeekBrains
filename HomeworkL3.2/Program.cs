using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkL3._2
{
    // Алекандр Шаповаленко
    // 2.
а)  //С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). Требуется подсчитать сумму всех нечётных положительных чисел.Сами числа и сумму вывести на экран, используя tryParse.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа подсчета суммы всех нечетных положительных чисел.");
            Console.WriteLine("Для выхода из программы введите 0");     
            
            int value;
            int result = 0;
            do
            {
                Console.WriteLine("\nВведите положительное не четное число:");
                int.TryParse(Console.ReadLine(), out value);
                if (value % 2 > 0)
                {
                    Console.WriteLine($"Число {value} не четное");
                     result += value;
                    Console.WriteLine($"Сумма всех введенных нечетных чисел = {result}");
                }
                else if (value < 0) Console.WriteLine("Вы ввели отрицательное число");
                else if (value == 0) break;
                
                
            } while (true);
            
            Console.ReadLine();
            
        }
    }
}
