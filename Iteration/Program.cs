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
        
        }
    }
}
