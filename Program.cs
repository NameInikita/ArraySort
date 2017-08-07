using System;


namespace SimpleArray
{
    class Program
    {
        public static void BubbleSort(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length - i - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int tmp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = tmp;
                    }
                }
            }
            foreach (int elem in a)
                Console.Write(elem + " ");
        }
        static void Main(string[] args)
        {
            MyArray mySimple = new MyArray(8);
            Console.WriteLine();
            mySimple.SortSimple();
            Console.WriteLine();

            Console.WriteLine();

            MyArray myDooble = new MyArray(5,-5);
            Console.WriteLine("\n"+myDooble.MinDoub());
            Console.WriteLine();
            myDooble.Change(myDooble.MinDoub());
            myDooble.PrintDouble();

            Console.WriteLine();
            int[] arr = { 2, 7, 5, 3, 8, 1, 5, 8, 7 };
            foreach(int elem in arr)
                Console.Write(elem + " ");
            Console.WriteLine();
            BubbleSort(arr);

            Console.ReadKey();
        }
    }
}
