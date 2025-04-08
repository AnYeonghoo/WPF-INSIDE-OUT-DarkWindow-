using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCSharpStudy
{
    internal class WhileStudy
    {
        static void MainWhileStudy()
        {
            List<char> KeyList = new List<char>();
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey();
                KeyList.Add(key.KeyChar);
            } while (key.Key != ConsoleKey.Q);

            Console.WriteLine();
            foreach (char ch in KeyList)
            {
                Console.Write(ch);
            }
        }
    }
}
