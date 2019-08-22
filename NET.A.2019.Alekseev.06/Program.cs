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
            Polynomial polynom1 = new Polynomial(3, 4, 1, 2, 1);
            Polynomial polynom2 = new Polynomial(2, 1, 1, 3, 4, 8, 5, 4.6, 17.35);
            Polynomial result = polynom1 + polynom2;
            Console.WriteLine(result.Equals(new Polynomial(5, 5, 2, 5, 5, 8, 5, 4.6, 17.35)));
        }
    }
}
