
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCSharpStudy
{
    public class MyList
    {
        private int[] data = { 1, 2, 3, 4, 5 };
        public IEnumerator GetEnumerator()
        {
            int i = 0;
            while (i < data.Length)
            {
                yield return data[i];
                i++;
            }
        }
    }
    internal class YieldStudy
    {
        static IEnumerable<int> GetNumber()
        {
            yield return 10;
            yield return 20;
            yield return 30;
        }
        static void MainYieldStudy()
        {
            foreach (int num in GetNumber())
            {
                Console.WriteLine(num);
            }

            var list = new MyList();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            IEnumerator it = list.GetEnumerator();
            it.MoveNext();
            Console.WriteLine(it.Current);
            it.MoveNext();
            Console.WriteLine(it.Current);

        }
    }
}
