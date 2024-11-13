using System.Security.Cryptography.X509Certificates;

namespace NullableStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nullable Strings!");
            string s1;
            string? s2;

            Console.WriteLine("Please insert two numbers: ");
            s1 = Console.ReadLine();
            s2 = Console.ReadLine();

            if (s2 != null) 
            {
                if ((s1.Equals("Coding")) && (s2.Equals("Factory"))) 
                {

                }
            }

            ///δινει την δυνατοτητα του nullable το ? δλδ string?
        public static string? GetUppercaseString() 
        {
            string? s1;

            Console.WriteLine("Enter a string: ");
            s1 = Console.ReadLine();

            return s1?.ToUpper();
        }    
        }
    }
}
