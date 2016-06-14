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
            Console.WriteLine("Did this food grow from the earth or have a mother?");
            string answer = Console.ReadLine();
            if (answer.ToLower() == "yes")
            {
                Console.WriteLine("Does this food come from a package or have a Label?");
                answer = Console.ReadLine();
            //    if (answer.ToLower() == "yes")
              //  {
                //    Console.WriteLine("Does it have more that 5 indgredients?");
                  //  answer = Console.ReadLine();
                    //if (answer.ToLower() == "yes")
           //         {
           //             Console.WriteLine("Not recommended to eat!");
           //
           //       }
           //         else
           //        {
           //             Console.WriteLine("Bon Appetite!!");
           //         }
           //    else {
           //             Console.WriteLine("Is it raised naturally?");
           //             answer = Console.ReadLine();
           //            if (answer.ToLower() == "yes")
           //             {
           //                 Console.WriteLine("Bon Appetite!");
           //             }
           //             else
           //             {
           //                 Console.WriteLine("Don't eat!!");
           //             }
           //             else{
           //                 Console.WriteLine("Don't eat!!");
           //             }
           //
           //         }
           //         else {

           //         }


           //     }
           // }
           // else
           // {
           //     Console.WriteLine("Do not eat!!");
            }

        }
    }
}
