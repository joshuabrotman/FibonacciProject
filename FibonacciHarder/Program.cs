using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciHarder
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = 0;
            Console.WriteLine("Enter the starting Value: ");
            firstNum = Convert.ToInt32(Console.ReadLine());
            int lastNum = 0;
            int nextNum = 0;
            for (double i = 0; i < 50; i++)
            {

                nextNum = firstNum + lastNum;
                Console.WriteLine(nextNum);
                firstNum = lastNum;
                lastNum = nextNum;



            }
            Console.ReadLine();
        }
    }
}


