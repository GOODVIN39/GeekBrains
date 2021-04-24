using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworlL5._3
{
    //Александр Шаповаленко
    //Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
    //Например: badc являются перестановкой abcd.

    
    class Program
    {
        public static void CompareStr()
        {
            Console.WriteLine("Программа определяющая является ли одна строка перестановкой другой");

            string s1 = "qwerty";
            string s2 = "ytrewq";

            char[] invs1 =  s1.ToCharArray();
            Array.Reverse(invs1);
            
            string news1 = new string(invs1);
            Console.WriteLine(invs1);
           

            if (news1 == s2)
            {
                Console.WriteLine("Первая строка является перестановкой второй строки ");
            }
            else
            {
                Console.WriteLine("Первая строка не является перестановкой второй строки ");
            }
        }
        static void Main(string[] args)
        {
            CompareStr();
            Console.WriteLine("\nНажмите Enter чтобы продолжить...");
            Console.ReadLine();
        }
    }
}
