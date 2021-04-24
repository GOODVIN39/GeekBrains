using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkL2._3
{
    class Program
    {   //Шаповалекно Александр
        //3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для подсчета нечетных положительных чисел");
            int summ = 0;
            
            while (true)
                
            {
                Console.Write("Введите число:"); int count = int.Parse(Console.ReadLine());

                if (count !=0)
                {
                    if (count % 2 == 1)
                    {
                        summ = summ + count;
                        
                    }
                    else
                    {
                        Console.WriteLine($"Сумма нечетных положительных чисел = {summ}");
                        break;
                    }
                }
                
            }
            Console.ReadLine();
        }
    }
}
