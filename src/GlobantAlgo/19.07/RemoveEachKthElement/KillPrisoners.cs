using System;
using System.Collections.Generic;

namespace RemoveEachKthElement
{
    public class KillPrisoners
    {
        public int last = 0;
        public List<int> Prisoners;

        public KillPrisoners(List<int> _prisoners)
        {
            this.Prisoners = _prisoners;
        }

        public static List<int> FillList(int n)
        {
            var list = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                list.Add(i);
            }

            return list;
        }


        public void RemoveEveryKthPrisoner(int k, int startIndex=0)
        {
            var action = 0;
            var removeIndex = startIndex;
            while (this.Prisoners.Count !=1 )
            {
                if (k > Prisoners.Count)
                {
                    removeIndex= (k+startIndex) % Prisoners.Count;
                    startIndex = removeIndex-1;
                    this.Prisoners.RemoveAt(removeIndex-1);
                    action++;
                    Console.WriteLine(action);
                    if(action == 6055)
                        Console.WriteLine("SOme");
                    continue;
                }

                if ((startIndex + k - 1) % Prisoners.Count == 0)
                {
                    Prisoners.RemoveAt(0);
                    startIndex = 0;
                     continue;///RemoveEveryKthPrisoner(k, startIndex);
                }
                else
                {
                    var c = Prisoners.Count / k;
                    for (int i = 0; i < c; i++)
                    {
                        this.Prisoners.RemoveAt(startIndex + k - 1);
                        startIndex = startIndex + k - 1;
                    }
                    continue; ///RemoveEveryKthPrisoner(k, startIndex);
                }
            }
            last = Prisoners[0];
        }
    }
}