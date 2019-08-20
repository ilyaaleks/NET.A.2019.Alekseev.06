using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.A._2019.Alekseev._04
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Polynomial polynom1 = new Polynomial(new double[] { 3,-4,5});
            Polynomial polynom2 = new Polynomial(new double[] { 3, -4, 5 });
            int[] a = { 5, 3, 2, 5, 7, 42, 43, 54, 23, 134, 3461, 1324, 12, 23 };
            int[][] aa = new int[3][];
            for(int i=0;i<aa.Length;i++)
            {
                aa[i] = new int[5];
            }
            for(int i=0;i<aa.Length;i++)
            {
                for(int j=0;j<aa[i].Length;j++)
                {
                    aa[i][j] = rand.Next(15);
                   Console.Write(aa[i][j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("//////////");
            Console.WriteLine();
            Console.Write("");
            BubbleSortClass.SortByMinElem(aa);
            for (int i = 0; i < aa.Length; i++)
            {
                for (int j = 0; j < aa[i].Length; j++)
                {
                    Console.Write(aa[i][j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
