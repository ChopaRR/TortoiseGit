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
                     
            var bord1 = Math.Truncate((w*100) / 120);
            
            var koridor = (h*100) - 100;
            var bord = Math.Truncate( koridor / 70);           
        }
    }
}
