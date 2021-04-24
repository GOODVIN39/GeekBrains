using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace HomeworkL4._5
{   // Александр Шаповаленко
    //    5.
    //а) Реализовать библиотеку с классом для работы с двумерным массивом.Реализовать конструктор, заполняющий массив случайными числами.Создать методы, которые возвращают сумму всех элементов массива, сумму всех элементов массива больше заданного, свойство, возвращающее минимальный элемент массива, свойство, возвращающее максимальный элемент массива, метод, возвращающий номер максимального элемента массива(через параметры, используя модификатор ref или out).
    
    
    class DimArray
    {
        int [,] array;
        Random rand;
        int count;

        
        public void RandELements(int countFirst, int countSecond)
        {
            array = new int[countFirst, countSecond];
            rand = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(10);
                    Console.Write(array[i,j]);
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Нажми Enter чтобы продолжить...");
            Console.ReadKey();
        }
        public void Sum(int countFirst, int countSecond)
        {
            array = new int[countFirst, countSecond];
            rand = new Random();
            count = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(10);
                    count += array[i, j];
                    Console.Write(array[i, j]);
                }
                
            }
            Console.WriteLine($"Cумма всех элементов массива = {count}");
            Console.WriteLine("Нажми Enter чтобы продолжить...");
            Console.ReadKey();
        }
        public void SumMaxCount(int countFirst, int countSecond)
        {
            array = new int[countFirst, countSecond];
            rand = new Random();
            count = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(10);
                    if (array[i,j] > countFirst || array[i, j] > countSecond)
                    {
                        count += array[i, j];
                    }
                    
                    Console.Write($"{array[i, j]} ");
                }

            }
            Console.WriteLine($"Cумма всех больщших элементов массива = {count}");
            Console.WriteLine("Нажми Enter чтобы продолжить...");
            Console.ReadKey();
        }
        public void MinCount(int countFirst, int countSecond)
        {
            array = new int[countFirst, countSecond];
            rand = new Random();
            int minCount = array[0,0];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(-100, 500);
                    if (array[i, j] < minCount)
                    {
                        minCount = array[i,j];
                    }
                    Console.Write($"{array[i, j]} ");
                }
            }
            Console.WriteLine($"\nСамый маленький элемент массива = {minCount}");
            Console.WriteLine("Нажми Enter чтобы продолжить...");
            Console.ReadKey();
        }
        public void MaxCount(int countFirst, int countSecond, ref int numMaxCount)
        {
            array = new int[countFirst, countSecond];
            rand = new Random();
            int maxCount = array[0, 0];
            numMaxCount = 0;
            int value = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(-100, 500);
                    value++;
                    if (array[i, j] > maxCount)
                    {                        
                        maxCount = array[i, j];
                        numMaxCount = value;
                    }
                    Console.Write($"{array[i, j]} ");
                }
            }            
            Console.WriteLine($"\nСамый большай элемент массива = {maxCount} и он находится под номером {numMaxCount}");
            Console.WriteLine("Нажми Enter чтобы продолжить...");
            Console.ReadKey();
        }
        
    }
    
    
    class Program
    {        
        static void Main(string[] args)
        {            
            DimArray a = new DimArray();

            a.RandELements(5, 5);
            a.Sum(5, 5);
            a.SumMaxCount(5, 5);
            a.MinCount(5, 5);
            int numMaxCount = 0;
            a.MaxCount(5, 5, ref numMaxCount);
            Console.WriteLine(numMaxCount);
            Console.ReadKey();
        }
    }
}
