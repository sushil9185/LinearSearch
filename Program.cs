namespace LinearSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myarray = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int n = 10;
            Console.WriteLine(FindElementInArray(myarray, n));
        }

        static int FindElementInArray(int[] a, int n)
        {
            for(int i = 0; i < a.Length; i++) 
            {
                if (a[i] == n)
                    return i;
            }

            return -1;
        }
    }
}