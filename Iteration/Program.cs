using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {

        // Repeat 50 times
        for (int i = 0; i < 50; i++)
        {
            Console.WriteLine("Hello World number " + (i+1));
        }

        // Repeat until the user says "yes"
        bool nearlyThere = false;

        while (nearlyThere == false)
        {
            Console.WriteLine("Are we there yet?");
            nearlyThere = Console.ReadLine().ToLower() == "yes";
        }
        
        // repeat from 1 to 50
        for(int i = 1; i < 50; i++)
        {
            // say if a number is odd or even
            string oddOrEven = "odd";
            if (i % 2 == 0)
            {
                oddOrEven = "even";
            }
            else
            {
                    oddOrEven = "odd";
            }

            Console.WriteLine($"{i} is {oddOrEven}");

            // say if a number is divisible by 3
            string divideByThree = "is";
            if (i % 3 == 0)
            {
                divideByThree = "is";
            }
            else
            {
                divideByThree = "is not";
            }

            Console.WriteLine($"{i} {divideByThree} divisible by 3");
        }


        }
    }
}
