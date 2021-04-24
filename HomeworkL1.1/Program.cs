using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkL1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Шаповаленко Александр
            //Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
            //а) используя склеивание;
            //б) используя форматированный вывод;
            //в) используя вывод со знаком $.


            Console.WriteLine("Привет! Это анкета, давай её заполним.\n");

            Console.WriteLine("Как тебя зовут? Напиши своё ими и фамилию.");
            string name = Console.ReadLine();

            Console.WriteLine("Сколько тебе лет?");
            string age = Console.ReadLine();

            Console.WriteLine("Какой у тебя вес в килограммах?");
            string weight = Console.ReadLine();

            Console.WriteLine("Какой у тебя рост в метрах?");
            string height = Console.ReadLine();

            Console.WriteLine("Приятно познакомиться " + name +"!"  + " Твой возраст: " + age + " лет." + " Твой вес: " + weight + "кг." + " Твой рост: " + height +"м.");
            Console.WriteLine("Приятно познакомиться {0}! Твой возраст: {1} лет. Твой вес: {2}кг. Твой рост: {3}м.", name, age, weight, height);
            Console.WriteLine($"Приятно познакомиться {name}! Твой возраст: {age} лет. Твой вес: {weight}кг. Твой рост: {height}м.");


            Console.ReadLine();

        }
    }
}
