using System;

namespace SimpleArray
{
    class MyArray
    {
        int[] arraySimple;
        int[,] arrayDouble;
        Random rnd = new Random();

        public MyArray(int a)
        {
            arraySimple = new int[Math.Abs(a)];//абсолютное значение. ограничение на отриц знач

            //заполнение 
             for (int i=0;i<arraySimple.Length;i++)
            {
                arraySimple[i]=rnd.Next(0,40);
                Console.Write("{0} ",arraySimple[i]);
            }
        }

        public MyArray(int a, int b)
        {
            arrayDouble = new int[Math.Abs(a), Math.Abs(b)];

            //заполнение
            for (int i=0;i<arrayDouble.GetLength(0);i++)
            {
                for (int j = 0; j < arrayDouble.GetLength(1); j++)
                {
                    arrayDouble[i, j] = rnd.Next(0, 15);
                    Console.Write("{0} ",arrayDouble[i,j]);
                }
                Console.WriteLine();
            }
        }


    }
}
