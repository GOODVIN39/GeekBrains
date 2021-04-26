using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HomeworkL6._2
{
    //Александр Шаповаленко
    //2. Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
    //а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум.
    //   Использовать массив(или список) делегатов, в котором хранятся различные функции.
    //б) *Переделать функцию Load, чтобы она возвращала массив считанных значений.Пусть она возвращает минимум через параметр (с использованием модификатора out).

    public delegate double Del(double x);
    class Program
    {
        public static double F1(double x)
        {
            return x * x - 50 * x + 10;
        }
        public static double F2(double x)
        {
            return x * x - 5 * x + 1;
        }
        public static void SaveFunc(string fileName, double a, double b, double h, Del F)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(F(x));
                x += h;// x=x+h; 
                //Console.WriteLine(x);
                
            }
            bw.Close();
            fs.Close();
        }
        public static double Load(string fileName, out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
                Console.Write($"{min} ");
            }
            bw.Close();
            fs.Close();
            return min;
        }
        static void Main(string[] args)
        {
            do
            {            
            Del[] F = { F1, F2 };
            Console.WriteLine("Выберите функцию 1 или 2\nИли нажмите 0 чтобы выйти из программы");
            int func = int.Parse(Console.ReadLine());
                if (func == 1 || func == 2)
                {
                SaveFunc("data.bin", -2, 2, 1, F[func-1]);
                Load("data.bin", out double min);
                    Console.WriteLine($"\nСамое минимальное значение  = {min}\n");
                }
                else if (func == 0)
                {
                    Console.WriteLine("Нажмите Enter чтобы продолжить...");
                    break;
                }
                else Console.WriteLine("Вы ввели не верное значение\n");
                           
            } while (true);
            Console.ReadKey();
        }
    }

}
