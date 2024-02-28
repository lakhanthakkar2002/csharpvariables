using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable
{



    internal class Program
    {
        void GenerateFibonacci(int previousNum, int nextNum, int lastNum)
        {
            if (nextNum >= lastNum)
            {
                return;
            }
            int currentNum = previousNum + nextNum;
            Console.WriteLine(currentNum);
            Console.WriteLine("Hello World");

            Console.WriteLine("Hello World 2");
            Console.WriteLine("Hello World 3");


            previousNum = nextNum;
            nextNum = currentNum;
            GenerateFibonacci(previousNum, nextNum, lastNum);
            Console.ReadLine();

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number until you want a fubonacci series : ");
            int lastNum = Convert.ToInt32(Console.ReadLine());
            int previousNum = 1;
            int nextNum = 1;
            Program program = new Program();
            Console.WriteLine(previousNum);
            Console.WriteLine(nextNum);

            program.GenerateFibonacci(previousNum, nextNum, lastNum);


        }
    }
}
