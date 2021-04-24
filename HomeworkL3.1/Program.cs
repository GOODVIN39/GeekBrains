using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkL3._1
{
    //Александр Шаповаленко
    //1.
    //а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры.
    //б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса.
    //в) Добавить диалог с использованием switch демонстрирующий работу класса.

    class Complex
    {
        public int re;
        public int im;

       
        public Complex(int re, int im)
        {            
            this.re = re;            
            this.im = im;
        }
            
        public void Write()
        {
            if(this.im < 0)
            {
                Console.WriteLine($"{this.re}-{-this.im}i");
            }
            else if (this.re == 0)
            {
                Console.WriteLine($"{this.im}i");
            }
            else if (this.im == 0)
            {
                Console.WriteLine($"{this.re}");
            }
            else if (this.im > 0)
            {
                Console.WriteLine($"{this.re}+{this.im}i");
            }     
        }
            
           
        

        public static Complex Sum(Complex z1, Complex z2)
        {
            Complex result = new Complex(
                re: z1.re + z2.re,
                im: z1.im + z2.im);
            return result;
        }
        public static Complex Sub(Complex z1, Complex z2)
        {
            Complex result = new Complex(
                re: z1.re - z2.re,
                im: z1.im - z2.im);
            return result;
        }
        public static Complex Mul(Complex z1, Complex z2)
        {
            Complex result = new Complex(
               re: (z1.re * z2.re)-(z1.im * z2.im),
               im: (z1.re * z2.im)+(z2.re * z1.im));
            return result;
        }
        //public static Complex Div(Complex z1, Complex z2)
        //{
        //    Complex result = new Complex(
        //       re: ((z1.re * z2.re) + (z1.im * z2.im)) / (((z2.re) * 2) + ((z2.im) * 2),
        //       im: ((z1.re * z2.im) - (z2.re * z1.im)) / (((z2.re) * 2) + ((z2.im) * 2));
        //    return result;
        //}
    }

       
    
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа подсчета комплексных чисел");
            
            Console.WriteLine("Введите первое и второе комплексных числа z1: ");
            Complex z1 = new Complex(int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine()));
            
            Console.WriteLine("Введите метод подсчета: \n+ = сложение;\n- = вычитание;\n* = умножение;");
            string symbol = Console.ReadLine();
            
            Console.WriteLine("Введите первое и второе комплексных числа z2: ");
            Complex z2 = new Complex(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

            switch (symbol)
            {
                case "+":
            Console.WriteLine("Сложение комплексных чисел z1+z2:");
            Complex resultSum = Complex.Sum(z1, z2);
            resultSum.Write();
                break;

                case "-":
            Console.WriteLine("Вычитание комплексных чисел z1-z2:");
            Complex resultSub = Complex.Sub(z1, z2);            
            resultSub.Write();
                break;

                case "*":
            Console.WriteLine("Умножение комплексных чисел z1-z2:");
            Complex resultMul = Complex.Mul(z1, z2);
            resultMul.Write();
                break;

                    //Console.WriteLine("Деление комплексных чисел z1-z2:");
                    //Complex resultDiv = Complex.Div(z1, z2);
                    //resultDiv.Write();
            }
            Console.ReadLine();
        } 
        
    }
    
    
}
