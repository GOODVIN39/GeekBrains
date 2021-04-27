using System;
using System.IO;

namespace HomeworkL6._2
{
    public delegate double Del(double x);
    internal class BodyOfProgram
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

        public static void Start()
        {
            do
            {
                Del[] F = { F1, F2 };
                Console.WriteLine("Выберите функцию 1 или 2\nИли нажмите 0 чтобы выйти из программы");
                int func = int.Parse(Console.ReadLine());
                if (func == 1 || func == 2)
                {
                    SaveFunc("data.bin", -2, 2, 1, F[func - 1]);
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
        }
    }
}