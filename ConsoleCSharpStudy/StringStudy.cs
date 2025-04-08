using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCSharpStudy
{
    internal class StringStudy
    {
        static void MainStringStudy()
        {
            string a = "Hello, World";
            string b = "Im Yh";
            Console.WriteLine(a);
            Console.WriteLine(b);

            string multiLine = """
                별 하나에 추억과
                별 하나에 사람과
                별 하나에 동동
                """;
            Console.WriteLine(multiLine);
        }
    }
}
