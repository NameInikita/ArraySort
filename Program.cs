using System;


namespace SimpleArray
{
    class Program
    {
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





            Console.ReadKey();
        }
    }
}
