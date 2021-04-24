using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkL4._3
{
    //Александр Шаповаленко
    //3.
    //а) Дописать класс для работы с одномерным массивом.Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом.Создать свойство Sum, которое возвращает сумму элементов массива, метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива(старый массив, остается без изменений), метод Multi, умножающий каждый элемент массива на определённое число, свойство MaxCount, возвращающее количество максимальных элементов.
    //б)** Создать библиотеку содержащую класс для работы с массивом.Продемонстрировать работу библиотеки
    //в) *** Подсчитать частоту вхождения каждого элемента в массив(коллекция Dictionary<int, int>)
    class MyArray
    {
        int[] array;
        Random rand;
        public MyArray(int start, int step, int count)
        {
            array = new int[count];
            array[0] = start;
            for (int i = 1; i < count; i++)
            {
                array[i] = array[i - 1] + step;
            }

        }

        public void ToString()
        {
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
            Console.ReadKey();
        }

        public void Sum(int count)
        {
            array = new int[count];
            int sum = 0;
            rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(10);
                
                sum += array[i];
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
        public void Inverse(int count)
        {
            array = new int[count];
            int inv;
            rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(10);
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine("");
            for (int j = 0; j < array.Length; j++)
            {
                inv = array[j] * (-1);
                Console.Write(inv);
            }
            Console.ReadKey();
        }
        public void Multi(int count, int value)
        {
            array = new int[count];
            rand = new Random();
            int mul = 0; 
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(10);
                mul = array[i] * value;
                Console.WriteLine(mul);
            }
            Console.WriteLine(mul);
            Console.ReadKey();
        }

        public void MaxCount(int count, int maxValue)
        {
            array = new int[count];
            rand = new Random();
            int value = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(maxValue);
                Console.WriteLine(array[i]);                
                if (array[i] == maxValue - 1)
                {
                    value++;
                }
            }
            Console.WriteLine($"Количество максимальных элементов массива = {value} \nНажми Enter чтобы продолжить.");
            Console.ReadKey();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            MyArray a = new MyArray(1, 1, 20);
            //a.ToString();
            //a.Sum(5);
            //a.Inverse(10);
            //a.Multi(5, 2);
            a.MaxCount(20, 15);
        }
    }
}
