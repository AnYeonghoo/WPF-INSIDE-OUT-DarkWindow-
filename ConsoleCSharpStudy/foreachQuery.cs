
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCSharpStudy
{
    internal class foreachQuery
    {
        static void MainforeachQuery()
        {
            int[] scores = [97, 92, 81, 60];

            IEnumerable<int> scoreQuery =
                from score in scores
                where score > 80
                select score;

            foreach (var i in scoreQuery)
            {
                Console.Write(i + " ");
            }

            int[] numbers = [0, 1, 2, 3, 4, 5, 6];
            var numQuery = from num in numbers
                           where (num % 2) == 0
                           select num;

            Console.WriteLine();
            foreach (int num in numQuery)
            {
                Console.Write("{0,1}", num);
            }
        }
    }
}
