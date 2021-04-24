using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkL4._1
{
    //Александр Шаповаленко
    //1. Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно. Заполнить случайными числами. Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих элемента массива.

    class MyArray
    {
        int[] array;
        int count;
        int value;        
        Random rand;
        
        public void Array()
        {
            array = new int[20];
            rand = new Random();
            count = 0;
        }

        public void Cycle()
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
        public void Write()
        {
            Console.WriteLine($"\nОтвет: {count}");
            Console.ReadKey();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            MyArray elArr = new MyArray();
            elArr.Array();
            elArr.Cycle();
            elArr.Write();

        }
    }
}
