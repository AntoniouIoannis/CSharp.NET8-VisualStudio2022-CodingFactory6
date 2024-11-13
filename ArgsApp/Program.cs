using System;

namespace ArgsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Error!   Parameters count must be three:  ");
                Environment.Exit(1);
            }
            Console.WriteLine($"{args[0]}, {args[1]}, {args[2]}");
            /// εφοσον του κανουμε build "csc .\Program.cs" μετα το "τρεχουμε" με ".\Program Hello Giannis Antoniou"
            /// οπου αυτο ειναι οι τρεις παραμετροι!!! δλδ τα "Hello", "Giannis", "Antoniou".
            /// Αν δωσουμε δυο ή τεσσερεις θα βγαλει μνμ λαθους.
        }
    }
}

