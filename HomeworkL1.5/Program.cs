using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkL1._5
{
    class Program
    {
        //Шаповаленко Александр
        //а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
        //б) *Сделать задание, только вывод организовать в центре экрана.
        //в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).

        static void Print(string a)
        {
            Console.WriteLine(a);
        }
        static void Main(string[] args)
        {
            

            Console.WriteLine("Александр Шаповаленко г. Новокуйбышевск");

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\tАлександр Шаповаленко г. Новокуйбышевск");
            
            Print("\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\tАлександр Шаповаленко г. Новокуйбышевск");

            Console.ReadKey();
        }
    }
}
