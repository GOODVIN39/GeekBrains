using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework4._4

//Александр Шаповаленко
//4. Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив. Создайте структуру Account, содержащую Login и Password.
{
    class Keys
    {
        public static void Account()
        {
            File.WriteAllText("Keys.txt", "root\nGeekBrains");
            var s = File.ReadAllLines("Keys.txt");
            var path = "Keys.txt";
            int attempt = 3;
            if (File.Exists(path))
            {
                File.ReadAllText(path);
            }
            else
            {
                Console.WriteLine("Такого файла нет");
            }
            string[] a = new string[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                a[i] = s[i];

            }

            do
            {
                string loginAdmin = a[0];
                string passwordAdmin = a[1];
                Console.Write("Введите Логин: "); string login = Console.ReadLine();
                Console.Write("Введите Пароль: "); string password = Console.ReadLine();
                if (login == loginAdmin && password == passwordAdmin)
                {
                    Console.WriteLine($"Здравствуйте {loginAdmin}, вы вошли в программу.");
                    break;
                }
                else
                {
                    attempt--;
                    Console.WriteLine($"Неверный логин или пароль. У вас осталось {attempt} попыток");
                }

            } while (attempt > 0);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа проверки логина и пароля");
            
            Keys.Account();

            Console.ReadLine();
        }

        
        
        
    }
}
