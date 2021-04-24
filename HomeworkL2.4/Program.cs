using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkL2._4
{
    class Program
    {
        //Шаповалекно Александр
        //4. Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.
        static void Main(string[] args)
        {
            Console.WriteLine("Программа проверки логина и пароля");
            MethodLogin();

            Console.ReadLine();
        }

        private static void MethodLogin()
        {
            string loginAdmin = "root";
            string passwordAdmin = "GeekBrains";
            int attempt = 3;
            do
            {
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
}
