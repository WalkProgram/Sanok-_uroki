using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Minus(270, 110);
            Write(result);
            int result2 = Plus(150, 300);
            Write(result2);
            int result3 = Share(500, 50);
            Write(result3);
            int result4 = Multiple(50, 250);

        }

        static void Write(int x)
        {
            Console.WriteLine(x);
            Console.ReadKey();

        }

        static int Minus(int x, int y)
        {
            int result = x - y;
            return result;


        }
        static int Plus(int x, int y)
        {
            int result2 = x + y;
            return result2;
        }

        static int Share(int x, int y)
        {
            int result3 = x / y;
            return result3;
        }

        static int Multiple(int x, int y)
        {
            int result4 = x * y;
            return result4;

            Console.ReadKey();
        }

    
    }
}
