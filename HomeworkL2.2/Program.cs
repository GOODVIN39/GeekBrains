using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkL2._2
{
    class Program
    {
        //Шаповалекно Александр
        //2. Написать метод подсчета количества цифр числа.
        static void Main(string[] args)
        {
            Console.WriteLine("Программа подсчета количества цифр из числа");
            CountMethod();
            
            Console.ReadLine();
        }

        private static void CountMethod()
        {
            Console.Write("Введите число: "); 
            int count1 = int.Parse(Console.ReadLine());
            int result;
            

            for (int i = count1; i > 0;)
            {
                result = 0;
                
                while (i> 0)
                {
                    result += i % 10;
                    i /= 10;
                    if (i == 0)
                    {
                        Console.WriteLine($"\nКоличество цифр в числе {count1} их сумма ровна {result}");
                        
                    }
                   
                }
                

            }
            
            
        }
    }
}
