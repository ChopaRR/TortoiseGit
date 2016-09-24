using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = 0;
            var p1 = 0.0;
            var p2 = 0.0;
            var p3 = 0.0;
            var p4 = 0.0;
            var p5 = 0.0;
                      
            for (int i = 0; i < n; i++)
            {
                m = int.Parse(Console.ReadLine());
                if (m < 200)
                {
                    p1++;
                }
                else if (200 <= m && m <= 399)
                {
                    p2++;
                }
                else if (400 <= m && m <= 599)
                {
                    p3++;
                }
                else if (600 <= m && m <= 799)
                {
                    p4++;
                }
                else if (m >= 800)
                {
                    p5++;
                }               
            }           

            Console.WriteLine("{0:p}", p1 / n);
            Console.WriteLine("{0:p}", p2 / n);
            Console.WriteLine("{0:p}", p3 / n);
            Console.WriteLine("{0:p}", p4 / n);
            Console.WriteLine("{0:p}", p5 / n);
        }
    }
}
