using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidPass
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= a; j++)
                {
                    for (char n = 'a'; n < 'a' + b ; n++)
                    {
                        for (char m = 'a'; m < 'a'+b ; m++)
                        {
                            for (int k = 2; k <= a ; k++)
                            {
                                if (k > i && k >j)
                                {
                                    Console.Write("{0}{1}{2}{3}{4} ", i, j, n, m, k);
                                }                                         
                            }
                        }
                    }
                }
            }
        }
    }
}
