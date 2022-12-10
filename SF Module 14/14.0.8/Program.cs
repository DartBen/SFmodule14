using System;
using System.Collections.Generic;
using System.Linq;

namespace _14._0._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var objects = new List<object>()
                {
                   1,
                   "Сергей ",
                   "Андрей ",
                   300,
                };

            var result = from p in objects
                         where (p is string)
                         orderby p
                         select p;

            foreach (var r in result)
                Console.WriteLine(r);


            Console.WriteLine();
            foreach (var r in objects.Where(p => p is string).OrderBy(p => p))
                Console.WriteLine(r);
        }
    }
}
