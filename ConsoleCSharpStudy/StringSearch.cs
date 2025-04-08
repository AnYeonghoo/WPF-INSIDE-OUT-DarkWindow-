using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleCSharpStudy
{
    internal class StringSearch
    {
        static void MainStringSearch()
        {
            string greeting = "Good Morning";

            WriteLine(greeting);
            WriteLine();

            // IndexOf
            WriteLine($"IndexOf 'Good' : {greeting.IndexOf("Good")}");
            WriteLine($"IndexOf 'o' : {greeting.IndexOf('o')}");

            // LastIndexOf
            WriteLine($"LastIndexOf : {greeting.LastIndexOf("Good")}");
            WriteLine($"{greeting.LastIndexOf('o')}");


            // StartWith
            WriteLine(greeting.StartsWith("Good"));
            WriteLine(greeting.StartsWith("Morning"));

            // EndWith
            WriteLine(greeting.EndsWith("Good"));
            WriteLine(greeting.EndsWith("Morning"));

            // Contains
            WriteLine(greeting.Contains("Evening"));
            WriteLine(greeting.Contains("Morning"));


            // Replace
            WriteLine(greeting.Replace("Morning", "Evening"));


        }

    }
}
