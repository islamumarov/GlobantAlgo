using System;

namespace RemoveEachKthElement
{
    public class Program
    {
        public static void Main(string[] ars)
        {
            var list = KillPrisoners.FillList(9000);
            var prisoners = new KillPrisoners(list);
            prisoners.RemoveEveryKthPrisoner(1000000000,0);

            Console.WriteLine("das " + prisoners.last);
        }

    }

}