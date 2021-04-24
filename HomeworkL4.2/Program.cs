using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HomeworkL4._2
{
    //Александр Шаповаленко
    //2. Реализуйте задачу 1 в виде статического класса StaticClass;
    //а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
    //б) Добавьте статический метод для считывания массива из текстового файла.Метод должен возвращать массив целых чисел;
    //в)* Добавьте обработку ситуации отсутствия файла на диске.
    static class MyArray
    {
        static int[] array;
        static int count;
        static int value;
        static Random rand;

        public static void Array()
        {            
            array = new int[20];
            rand = new Random();
            count = 0;            
        }

        public static void Cycle()
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = rand.Next(-10000, 10000);
                value = i + 1;
                Console.Write($"{array[i]} ");
                if (array[i] % 3 == 0 || (value) % 3 == 0)
                {
                    count++;

                }
            }
        }
        public static void Write()
        {
            Console.WriteLine($"\nОтвет: {count}");
            Console.WriteLine("Нажми Enter чтобы продолжить.");
            Console.ReadKey();
        }

        public static void TextArray()
        {
            File.WriteAllText("Массив.txt", "10 \n5 \n67 \n6 ");
            var s = File.ReadAllLines("Массив.txt");
            var path = "Массив.txt";
            if (File.Exists(path))
            {
                File.ReadAllText("Массив.txt");                
            }
            else
            {
                Console.WriteLine("Такого файла нет");
            }
            
            int [] a = new int [s.Length];
            
            for (int i = 0; i < s.Length; i++)
            {
                a[i] = Convert.ToInt32(s[i]);         
                Console.WriteLine(a[i]);
            }
            Console.ReadLine();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            MyArray.Array();
            MyArray.Cycle();            
            MyArray.Write();            
            MyArray.TextArray();

        }
    }
}

