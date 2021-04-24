using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HomeworkL5._1
{
        //Шаповаленко Александр
        //1. Создать программу, которая будет проверять корректность ввода логина.Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
        //а) без использования регулярных выражений;
        //б) ** с использованием регулярных выражений.
    class LoginCheck
    {       
        public void CheckLength(ref string login)
        {
            
            do
            {                
                login = Console.ReadLine();
                if (login.Length < 2)
                {
                    Console.Write("Вашлогин слишком короткий!\nВведите другой логин:");
                }
                else if (login.Length > 10)
                {
                    Console.Write("Вашлогин слишком длинный!\nВведите другой логин:");
                }
                else if (char.IsDigit(login[0]))
                {
                    Console.Write("Первый символ логина не должен быть цифрой!\nВведите другой логин:");
                }
                else break;

            } while (true);
            CheckFrNum(ref login);
        }
        public void CheckFrNum(ref string login)
        {
            for (int i = 0; i < login.Length; i++)
            {
                if (char.IsDigit(login[i]) || login[i] >= 'a' && login[i] <= 'z'|| login[i] >= 'A' && login[i] <= 'Z')
                {
                    Console.WriteLine("Ваш логин корректен"); break;
                }
                else
                {
                    Console.Write("Присудствуют недопустимые символы!\nВведите другой логин:");
                    CheckLength(ref login);
                }
                
                    
            }
        }
        public void RegularCheck(ref string login)
        {
            Regex regex = new Regex(@"^[A-z]([A-z0-9]{1,9})$");
            regex.IsMatch(login);
            if (true)
            {
                Console.WriteLine("Логин корректен");
            }
            else
            {
                Console.WriteLine("Логин не корректен");
            }
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа проверки логина");
            Console.Write("Введите логин:");
            string login = "";
            LoginCheck start = new LoginCheck();            
            start.CheckLength(ref login);
            start.RegularCheck(ref login);
            Console.WriteLine("Нажмите Enter чтобы продолжить...");
            
            Console.ReadKey();
        }       
    }
}
