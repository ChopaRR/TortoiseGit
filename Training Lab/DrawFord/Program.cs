using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n;
            int line = 1;
            int caps = n / 2;
            int underlinesoftop;
            //top
            if (n % 2 == 0)
            {
                underlinesoftop = n - 4;
            }
            else
            {
                underlinesoftop = n - 3;
            }
            string a = StringCreater("^", caps);
            string b = StringCreater("_", underlinesoftop);
            Console.WriteLine(@"/{0}\{1}/{0}\", a, b);
            string c = StringCreater("|", line);
            string d = StringCreater(" ", width - 2);
            //middle
            for (int i = 0; i < n - 3; i++)
            {
                Console.WriteLine("{0}{1}{0}", c, d);

            }
            string e = StringCreater(" ", caps + 1);
            Console.WriteLine("{0}{2}{1}{2}{0}", c, b, e);
            //bot
            string f = StringCreater("_", caps);
            string g = StringCreater(" ", underlinesoftop);
            Console.WriteLine(@"\{0}/{1}\{0}/", f, g);

        }


        public static string StringCreater(string text, int repeatCount)
        {
            string repeatedText = string.Empty;
            for (int currentCount = 0; currentCount < repeatCount; currentCount++)
            {
                repeatedText += text;
            }

            return repeatedText;
        }
    }
    }

    