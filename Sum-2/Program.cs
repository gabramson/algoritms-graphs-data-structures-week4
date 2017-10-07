using Sum2FilterLib;
using System;
using System.IO;

namespace Sum_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum2Filter = new Sum2Filter(-10000, 10000);
            string line;
            using (StreamReader srStreamRdr = new StreamReader(@"2sum.txt"))
            {
                while ((line = srStreamRdr.ReadLine()) != null)
                {
                    sum2Filter.Add(long.Parse(line));
                }
            }
            sum2Filter.ApplyFilter();
            Console.WriteLine(sum2Filter.Count);
            Console.ReadKey();
        }
    }
}
