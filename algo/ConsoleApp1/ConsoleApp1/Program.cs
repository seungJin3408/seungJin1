using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] insertion = { 99,0, 3, 4, 2, 5, 6, 7, 9,33,11,52 };
            Program x = new();
            //int[] result = x.Insertion_Sort(insertion, insertion.Length);
            int[] result = x.Bubble_Sort(insertion, insertion.Length);
            foreach (int xx in result)
            {
                Console.WriteLine(xx);
            }
        }


        public int[] Insertion_Sort(int[] a, int aLenght)
        {
            for(int i = 1; i < aLenght; i++)
            {
                int v = a[i];
                int j = i - 1;
                while( j >=0 && a[j] > v)
                {
                    a[j + 1] = a[j];
                    j--;                    
                }
                a[j + 1] = v;
            }
            return a;
        }

        public int[] Bubble_Sort(int[] A,int N)
        {
            bool x = true;
            int sw = 0;
            while (x)
            {
                x = false;
                for (int j = N -1; j >= 1; --j)
                {
                    if (A[j] < A[j - 1])
                    {
                        int y = A[j - 1];
                        A[j - 1] = A[j];
                        A[j] = y;
                        x = true;
                        sw++;
                    }
                }
            }
            Console.WriteLine("{0}번 스왑", sw);
            return A;
        }
    }
}
