using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCSharpStudy
{
    public class ClassStudy
    {
        static void MainClass()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Loop {0}", i);
            }
            string[] array = new string[] { "AB", "CD", "EF" };
            foreach (string s in array)
            {
                Console.WriteLine(s);
            }

            string[,,] arr = new string[,,]
            {
                { {"1", "2"}, {"11", "22"} },
                {{"3", "4"}, {"33", "44"} }
            };
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        Debug.WriteLine(arr[i, j, k]);
                    }
                }
            }

            foreach (var s in arr)
            {
                Debug.WriteLine(s);
            }
        }
    }
}
