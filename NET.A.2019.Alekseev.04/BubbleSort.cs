using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.A._2019.Alekseev._04
{
    static class BubbleSortClass
    {
        private static void BubbleSortForInt(int[] mas)
        {
            int flag;
            int buffer;
            for (int j = 0; j < mas.Length - 1; j++)
            {
                flag = 0;
                for (int i = 0; i < mas.Length - 1; i++)
                {
                    if (mas[i] > mas[i + 1])
                    {
                        buffer = mas[i];
                        mas[i] = mas[i + 1];
                        mas[i + 1] = buffer;
                        flag = 1;
                    }
                }
                if (flag == 0)
                {
                    break;
                }
            }
        }
        
        public static void SortBySum(int[][] array)
        {
            
            for(int j=0;j<array.Length-1;j++)
            {
                for(int i=0;i<array.Length-1;i++)
                {
                    if(array[i].Sum()>array[i+1].Sum())
                    {
                        Swap(ref array[i], ref array[i + 1]);
                    }
                }
            }
        }
        public static void SortByMaxElem(int[][] array)
        {
            for(int i=0;i<array.Length;i++)
            {
                BubbleSortForInt(array[i]);
            }
            for (int j = 0; j < array.Length - 1; j++)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i][array[i].Length-1] > array[i + 1][array[i+1].Length-1])
                    {
                        Swap(ref array[i], ref array[i + 1]);
                    }
                }
            }
        }
        public static void SortByMinElem(int[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                BubbleSortForInt(array[i]);
            }
            for (int j = 0; j < array.Length - 1; j++)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i][array[i].Length - 1] < array[i + 1][array[i + 1].Length - 1])
                    {
                        Swap(ref array[i], ref array[i + 1]);
                    }
                }
            }
        }
        private static void Swap(ref int[] a, ref int[] b)
        {
            int[] buf;
            buf = a;
            a = b;
            b = buf;
        }
    }
}
