using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            var dayornight = Console.ReadLine();
            var taxi = 0.70;
            var bus = 0.09;
            var train = 0.06;

            if (n < 20)
            {
                if (dayornight == "day")
                {
                     Console.WriteLine(taxi + n * 0.79);
                }
                else
                {                    
                    Console.WriteLine(taxi + n * 0.90);
                }
            }
            else if (n >= 20 && n < 100)
            {
                Console.WriteLine(bus * n);
            }
            else
            {
                Console.WriteLine(train * n);
            }
        }
    }
}
