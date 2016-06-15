using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace go_with_the_flow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How to decide what to eat");
            Console.WriteLine("Please enter yes or no");

            // first question
            Console.WriteLine("Did this food grow from the earth or have a mother?");
            string answer = Console.ReadLine();

            // if yes to first question
            if (answer.ToLower() == "yes")
            {

                // second question
                Console.WriteLine("Does this food come from a package or have a Label?");
                answer = Console.ReadLine();

                // if yes to second question
                if (answer.ToLower() == "yes")
                {

                    // third question
                    Console.WriteLine("Does it have more that 5 indgredients?");
                    answer = Console.ReadLine();

                    // if yes to third question
                    if (answer.ToLower() == "yes")
                    {
                        Console.WriteLine("Not recommended to eat!");

                    }

                    // if no to third question
                    else
                    {
                        Console.WriteLine("Bon Appetite!!");
                    }
                }

                // if no to second question
                else {

                    // forth question
                    Console.WriteLine("Is it raised naturally?");
                    answer = Console.ReadLine();

                    //if yes to forth question
                    if (answer.ToLower() == "yes")
                    {
                        Console.WriteLine("Bon Appetite!");
                    }

                    // if no to forth question
                    else
                    {
                        Console.WriteLine("Don't eat!!");
                    }

                }


            // if no to first question
            else
            {
                Console.WriteLine("Do not eat!!");
            }

            // end program with a keystroke
            Console.WriteLine("Press any key to end");
            Console.ReadLine();
            //last comment  added later
            //creating my last comment
        }
    }
}
