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


    class Program
    {
        static void Main(string[] args)
        {
            BodyOfProgram.Start();
            Console.WriteLine("Нажмите Enter чтобы продолжить..."); Console.ReadKey();
        }
    }

}
