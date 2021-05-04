using System;

namespace HomeworkL8._2
{
    public class Reflexiya
    {
        public void Reflexion()
        {
            Type t = typeof(DateTime);
            foreach (var item in t.GetProperties())
                Console.WriteLine(item.Name);  
        }
    }
}