using System;

namespace IgnoreNegatives
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ignore Negatives");
            int num = 0;
            int negativesCount = 0;
            /// apo mesa προς τα εξω το φτιαχνουμε!!!
            /// δινουμε το Console.WriteLine("Please insert a number (integer):  ");
            /// num = int.Parse(Console.ReadLine());
            /// το βαζουμε σε "do - while" για να προχωρησει οταν θα ειναι σωστο (true)
            /// KAI EAN DEN DVUEI ακεραιος το βαζουμε στην "try - catch" για να βγαλει το σφαλμα!!!
            /// ΣΕ ΓΕΝΙΚΕΣ ΓΡΑΜΜΕΣ ΠΑΜΕ ΝΑ ΠΙΑΣΟΥΜΕ ΠΡΩΤΑ ΤΙΣ ΠΕΡΙΠΤΩΣΕΙΣ ΠΟΥ Ο ΧΡΗΣΤΗΣ ΔΕΝ ΔΙΝΕΙ ΤΑ
            /// ΠΡΟΒΛΕΠΩΜΕΝΑ ΣΤΟΙΧΕΙΑ οποτε "φτιαχνουμε" περιπτωσει λαθους του και εμφγανιζουμε το σφαλμα.
            try
            {
                do
                {
                    Console.Write("Please insert a number (integer):  ");
                    num = int.Parse(Console.ReadLine()!);
                    if (num > 0) continue;
                    if (num == 0) break;
                    negativesCount++;

                } while (true);
                Console.WriteLine("Negatives count: " + negativesCount);
            } catch (FormatException e) 
            {
                Console.WriteLine(e.Message);
            }
            
            
        }
    }
}
