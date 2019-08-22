using NUnit.Framework;
using NET.A._2019.Alekseev._04;
namespace Tests
{
    public class Tests
    {
        Polynomial polynom1;
        Polynomial polynom2;
        static string result;
        static string expResult;
        

        [Test]
        public void Test1(string result)
        {
            Polynomial polynom1 = new Polynomial(3, 4, 1, 2, 1);
            Polynomial polynom2 = new Polynomial(2, 1, 1, 3, 4, 8, 5, 4.6, 17.35);
            result = (polynom1 + polynom2).ToString();
            expResult = new Polynomial(5, 5, 2, 5, 5, 8, 5, 4.6, 17.35).ToString();
            Assert.AreEqual(result, expResult);
        }
    }
}