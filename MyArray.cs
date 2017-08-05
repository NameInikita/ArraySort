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

            //заполнение  и печать
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
                    arrayDouble[i, j] = rnd.Next(1,5);
                    Console.Write("{0} ",arrayDouble[i,j]);
                }
                Console.WriteLine();
            }
        }
        public void SortSimple()
        {
            for (int i = 0; i < arraySimple.Length-1; i++)
            {
                for (int j = i + 1; j < arraySimple.Length; j++)
                {
                    if (arraySimple[i] > arraySimple[j])
                    {
                        int tmp = arraySimple[j];
                        arraySimple[j] = arraySimple[i];
                        arraySimple[i] = tmp;
                    }
                }
            }
            foreach(int elem in arraySimple)
                Console.Write(elem+ " ");
        }
        //public void BubleSort(int[] a)
        //{
        //    for (int i = 0; i < a.Length; i++)
        //    {
        //        for (int j = 0; j < a.Length - i - 1; j++)
        //        {
        //            if (a[j] > a[j + 1])
        //            {
        //                int tmp = a[j];
        //                a[j] = a[j + 1];
        //                a[j + 1] = tmp;
        //            }
        //        }
        //    }
        //    foreach (int elem in a)
        //        Console.Write(elem + " ");
        //}

        //поиск всех минимальных значений в двумерном массиве
        public int MinDoub()
        {
            int min = arrayDouble[0, 0];

            for (int i=0; i<arrayDouble.GetLength(0);i++)
            {
                for (int j=0;j<arrayDouble.GetLength(1);j++)
                {
                    if (arrayDouble[i,j]<min)
                    {
                        min = arrayDouble[i, j];
                    }
                }
            }
            return min;
        }

        //увеличиваю все минимальные элементы в 100 раз
        public void Change(int min)
        {
            for (int i=0;i<arrayDouble.GetLength(0);i++)
            {
                for (int j=0;j<arrayDouble.GetLength(1);j++)
                {
                    if (arrayDouble[i,j]==min)
                    {
                        arrayDouble[i, j] *= 100;
                    }
                }
            }
        }
        public void PrintDouble()
        {
            for (int i = 0; i < arrayDouble.GetLength(0); i++)
            {
                for (int j = 0; j < arrayDouble.GetLength(1); j++)
                {
                    Console.Write(arrayDouble[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }





    }
}
