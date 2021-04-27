using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkL6._1
{
    //Александр Шаповаленко
    //1. Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double). 
    //   Продемонстрировать работу на функции с функцией a* x^2 и функцией a* sin(x).
  
        // Описываем делегат. В делегате описывается сигнатура методов, на
        // которые он сможет ссылаться в дальнейшем (хранить в себе)
    

    class Program
    {
       
        static void Main()
        {
            double a = 5; ProgramBase.Functions(a);            
            Console.WriteLine("Нажмите Enter чтобы продолжить..."); Console.ReadKey();
        }

        
    }


}
