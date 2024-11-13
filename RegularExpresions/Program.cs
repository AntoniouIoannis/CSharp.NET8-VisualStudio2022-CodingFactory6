using System.Text.RegularExpressions;

namespace RegularExpresions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input1 = "hello123";
            string pattern1 = @"[a-z]+\d+";

            OneMatch(input1, pattern1);
        }
        /// <summary>
        /// OneMatch οχι επαναλαμβανομενα
        /// </summary>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        public static void OneMatch(string input, string pattern) 
        {
            Match match = Regex.Match(input, pattern);
            if (match.Success)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
