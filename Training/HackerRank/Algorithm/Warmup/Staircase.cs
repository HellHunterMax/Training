using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.HackerRank.Algorithm.Warmup
{
    public class Staircase
    {
        public static void staircase(int n)
        {
            for (int i = 1; i < n +1; i++)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(' ', n -i);
                sb.Append('#', i);
                Console.WriteLine(sb.ToString());
            }
        }
    }
}
