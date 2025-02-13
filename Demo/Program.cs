namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 5,31,35,13 };
            CompareNum<int,int,bool> Func1 = SortMethods.SortASC;

            SortingArray<int>.SortingArrayFunc(ints , Func1);

            foreach (int i in ints) 
            {
                Console.WriteLine(i);
            }
        }

        public static bool CompareNumbers(int a, int b) 
        {
            return a < b;
        }
    }

    
}
 