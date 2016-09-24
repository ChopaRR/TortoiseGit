using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            var koridor = (h*100) - 100;
            var bord = Math.Truncate( koridor / 70);           
            var bord1 = Math.Truncate((w*100) / 120);
            var sumplaces = bord1 * bord - 3;
            Console.WriteLine("{0:00}",sumplaces);

        }
    }
}
