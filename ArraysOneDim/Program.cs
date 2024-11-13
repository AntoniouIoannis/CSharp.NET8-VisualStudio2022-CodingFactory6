namespace ArraysOneDim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arrays in One Dimension!");
            /// 1ος τροπος δημιουργιας 
            Console.WriteLine("1ος τροπος δημιουργιας  // new");
            int[] arr1 = new int[2];   // new
            arr1[0] = 1;
            arr1[1] = 2;

            for (int i = 0; i < arr1.Length; i++) 
            {
                Console.WriteLine($"{arr1[i]}");
            }

            /// 2ος τροπος δημιουργιας
            Console.WriteLine("2ος τροπος δημιουργιας   // unsized initialization");
            int[] arr2 = { 1, 2, 3 };   // unsized initialization

            foreach (int el in arr2) 
            {
                Console.WriteLine(el);
            }

            /// 3ος τροπος δημιουργιας
            Console.WriteLine("3ος τροπος δημιουργιας  // array initialization");
            int[] arr3 = new int[] { 1, 2, 3 };  // array initialization

            /// 4ος τροπος δημιουργιας
            Console.WriteLine("4ος τροπος δημιουργιας   // .NET8, Collection init.");
            int[] arr4 = [1, 2, 3, 4];  // .NET8, Collection init.
        }

        public static bool IsSymetric(int[] arr)
        {
            bool symetric = true;

            for (int i = 0, j = arr.Length - 1; i < j; i++, j--)
            {
                if (arr[i] != arr[j]) symetric = false;
            }
            return symetric;
        }
    }
}
