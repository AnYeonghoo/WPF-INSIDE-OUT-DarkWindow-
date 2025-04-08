using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCSharpStudy
{
    internal class UsingVarStudy
    {
        static void MainUsingVarStudy()
        {
            var a = 20;
            Console.WriteLine($"Type: {a.GetType()}, Value: {a}");

            var b = 3.1415;
            Console.WriteLine($"Type: {b.GetType()}, Value: {b}");

            var c = "Hello, World";
            Console.WriteLine($"Type: {c.GetType()}, Value: {c}");

            var d = new int[] { 10, 20, 30 };
            Console.WriteLine($"Type: {d.GetType()}");
            foreach (var e in d)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine();
        }
    }
}
