using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkL3._3
{
   
    class Rational
    {
        public int chis;
        public int znam;

        public Rational(int chis, int znam)
        {
            
            this.chis = chis;
            
            
            do
            {                        
            this.znam = znam;
                if (znam == 0)
                {
                    Console.WriteLine("Введите знаменатель больше 0");
                    znam = int.Parse(Console.ReadLine());
                }
                else break;
                
            } while (true);


        }

        public static Rational Sum(Rational m1, Rational m2)
        {
            Rational result = new Rational(
            chis: (m1.chis*m2.znam)+(m2.chis*m1.znam),
            znam: (m1.znam * m2.znam));            
            return result;
        }
        public static Rational Sub(Rational m1, Rational m2)
        {
            Rational result = new Rational(
            chis: (m1.chis * m2.znam) - (m2.chis * m1.znam),
            znam: (m1.znam * m2.znam));
            return result;
        }
        public static Rational Mul(Rational m1, Rational m2)
        {
            Rational result = new Rational(
            chis: (m1.chis * m2.chis),
            znam: (m1.znam * m2.znam));
            return result;
        }
        public static Rational Div(Rational m1, Rational m2)
        {
            Rational result = new Rational(
            chis: (m1.chis * m2.znam),
            znam: (m1.znam * m2.chis));
            return result;
        }


        public void Write()
        {
            if (znam == 0)
            {
                Console.WriteLine(this.chis);
            }            
            else if (chis % 2 == 0)
            {
                int j = 0;
                while (chis / 2 > 2 || znam / 2 > 2)
                {
                    chis /= 2;
                    znam /= 2;
                    j++;
                }
                Console.WriteLine($"{j} ({chis} / {znam})");
            }
            else if (chis % znam != 0)
            {
                Console.WriteLine($"({this.chis} / {this.znam})");
            }
            else Console.WriteLine(this.chis/this.znam);



        }
    }

    class Program
    {
        
        static void Main(string[] args)

        {
            // Алекандр Шаповаленко
            //3. *Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса.
            //Добавить свойства типа int для доступа к числителю и знаменателю;
            //Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа; **Добавить проверку, чтобы знаменатель не равнялся 0.Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0"); ***Добавить упрощение дробей.

        Console.WriteLine("Программа подсчета двух рациональных чисел");
            

            Console.WriteLine("Введите первое рациональное число m1 вида a/b");
            Rational m1 = new Rational(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

            Console.WriteLine("Введи метод подсчета рациональных чисел: \n+ = сложение;\n- = вычитание;\n* = умножение\n/ = деление");
            string znak;
            do
            {
                string met = Console.ReadLine();
                if (met == "+")
                {
                    znak = met;
                    break;
                }
                else if (met == "-")
                {
                    znak = met;
                    break;
                }
                else if (met == "*")
                {
                    znak = met;
                    break;
                }
                else if (met == "/")
                {
                    znak = met;
                    break;
                }
                else
                {
                    Console.WriteLine("Введите правельный метод подсчета рациональных чисел: \n+ = сложение;\n- = вычитание;\n* = умножение\n/ = деление");
                }
            } while (true);
            

            Console.WriteLine("Введите второе рациональное число m1");
            Rational m2 = new Rational(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));            
            
            switch (znak)
            {
                case "+":
                    Console.WriteLine("Сложение рациональных чисел");
                    Rational resultSum = Rational.Sum(m1, m2);
                    resultSum.Write();
                    break;

                case "-":
                    Console.WriteLine("Вычитание рациональных чисел");
                    Rational resultSub = Rational.Sub(m1, m2);
                    resultSub.Write();
                    break;

                case "*":
                    Console.WriteLine("Умножение рациональных чисел");
                    Rational resultMul = Rational.Mul(m1, m2);
                    resultMul.Write();
                    break;

                case "/":
                    Console.WriteLine("Деление рациональных чисел");
                    Rational resultDiv = Rational.Div(m1, m2);
                    resultDiv.Write();
                    break;
            }

            Console.ReadLine();

        }

        
    }

    
}

