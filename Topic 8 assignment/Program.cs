using System.Drawing;

namespace Topic_8_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random Generator = new Random();

            List<string> colours = new List <string> ();

            Console.WriteLine("Please enter 5 colours");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter colour");
                string input = Console.ReadLine();
                colours.Add(input);
            }
            Console.WriteLine(colours[0] + ", " + colours[1] + ", " + colours[2] + ", " + colours[3] + " and " + colours[4]);

            Console.WriteLine();

            Console.WriteLine("I pick the colour, " + colours[Generator.Next(colours.Count)]);
        }



    }
}
