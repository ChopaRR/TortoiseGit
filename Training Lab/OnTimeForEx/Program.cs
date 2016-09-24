using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTimeForEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int exH = int.Parse(Console.ReadLine());
            int exM = int.Parse(Console.ReadLine());
            int arH = int.Parse(Console.ReadLine());
            int arM = int.Parse(Console.ReadLine());

            int exTimeInM = (exH * 60) + exM;
            int stTimeInM = (arH * 60) + arM;

            int timeDiff = Math.Abs(exTimeInM - stTimeInM);
            int timeDiffInH = timeDiff / 60;
            int timeDiffInM = timeDiff % 60;

            if (stTimeInM > exTimeInM)
            {
                Console.WriteLine("Late");
                if (timeDiffInH > 0)
                {
                    Console.Write("{0}:", timeDiffInH);
                    Console.WriteLine("{0:00} hours after the start", timeDiffInM);
                }
                else if (timeDiffInM > 0)
                {
                    Console.WriteLine("{0} minutes after the start", timeDiffInM);
                }
            }
            else if (stTimeInM == exTimeInM)
            {
                Console.WriteLine("On time");
                if (stTimeInM < exTimeInM)
                {
                    Console.WriteLine("{0} minutes before the start", timeDiffInM);
                }
            }
            else if (stTimeInM < exTimeInM && timeDiffInM <= 30 && timeDiffInM > 0 && timeDiffInH == 0 )
            {
                Console.WriteLine("On time");
                if (stTimeInM < exTimeInM)
                {
                    Console.WriteLine("{0} minutes before the start", timeDiffInM);
                }
            }
            else if (stTimeInM < exTimeInM)
            {
                Console.WriteLine("Early");
                if (timeDiffInH > 0)
                {
                    Console.Write("{0}:", timeDiffInH);
                    Console.WriteLine("{0:00} hours before the start", timeDiffInM);
                }
                else if (timeDiffInM > 0)
                {
                    Console.WriteLine("{0} minutes before the start", timeDiffInM);
                }
            }
        }
    }
}

