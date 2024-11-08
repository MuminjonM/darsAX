using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace darsAX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 30, b = 45;

            

            Console.WriteLine("ekub=" + ekub(a,b));
            Console.WriteLine("ekuk=" + ekuk(a,b));

            Console.ReadKey();  
        }

        public static int ekub(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else b -= a;

            }
            return a;
        }

        public static int ekuk (int a, int b) {

            return (a*b)/ekub(a,b);
        }

    }
}
