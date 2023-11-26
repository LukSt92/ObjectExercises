using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };
            Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };

            Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap");
            while (true)
            {
                string line = Console.ReadLine();
                if (int.TryParse(line, out int result))
                {
                    if (result == 1)
                    {
                        Console.WriteLine("You pressed " + line);
                        lloyd.WhoAmI();
                    }
                    else if (result == 2)
                    {
                        Console.WriteLine("You pressed " + line);
                        lucinda.WhoAmI();
                    }
                    else if (result == 3)
                    {
                        Elephant changer;
                        changer = lloyd;
                        lloyd = lucinda;
                        lucinda = changer;
                        Console.WriteLine("References have been swapped.");
                    }
                }
                else return;
                Console.WriteLine();
            }
        }
    }
}
