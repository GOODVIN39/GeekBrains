using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkL5._2
{
    //Александр Шаповаленко
    //2. Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
    //а) Вывести только те слова сообщения, которые содержат не более n букв.
    //б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
    //в) Найти самое длинное слово сообщения.
    //г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
    static class Message
    {
        public static void Write()
        {
            Console.WriteLine("Программа вывода слов сообщения, которые содержат не более n букв\n");
            string text = "Программа вывода слов сообщения, которые содержат не более n букв";           
            int n = 5;
            var word = text.Split(' ', ',', '.', '!', '?', '-' ).Where(x => x.Length == n).ToArray();
            foreach (var item in word)
            {
                Console.WriteLine(item);
            }
        }
        public static void Delete()
        {
            Console.WriteLine("Программа удаления слов сообщения, которые оканчиваются на заданный символ\n");
            string text = "Программа удаления слов сообщения, которые оканчиваются на заданный символ";
            string symbol = "а";
            var word = text.Split( ' ', ',', '.', '!', '?', '-' ).Where(x => x.EndsWith(symbol)).ToArray();
            foreach (var item in word)
            {
                Console.WriteLine($"{item}\n");
            }
        }
        public static void theMostBigWord()
        {
            Console.WriteLine("Программа вывода самого большого слова в сообщении");
            string text = "Программа вывода самого большого слова в сообщении";                  
            var word = text.Split(' ', ',', '.', '!', '?', '-');
            string maxWord="";
            int max = word[0].Length;
            for (int i = 0; i < word[i].Length; i++)
            {
                Console.WriteLine(word[i]);
                if (word[i].Length>max)
                {
                    max = word[i].Length;
                    maxWord = word[i];
                }                
            }
            Console.WriteLine(maxWord);
        }

        public static void SB()
        {
            Console.WriteLine("Программа вывода самых больших слов в сообщении");
            string text = "Программа вывода самых больших слов в сообщении";
            var word = text.Split(' ');
            StringBuilder sb = new StringBuilder();            
            int max = word[0].Length;                       
            
            for (int i = 0; i < word.Length; i++)
            {
                
                if (word[i].Length >= max)
                {                    
                    sb.Append($"{word[i]} \n");                    
                }
            }

            Console.WriteLine($"{sb}\t ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Message.Write();
            //Message.Delete();
            //Message.theMostBigWord();
            //Message.SB();                        
            
            Console.WriteLine("\nНажми Enter чтобы продолжить...");
            Console.ReadLine();
            
        }
    }
}
