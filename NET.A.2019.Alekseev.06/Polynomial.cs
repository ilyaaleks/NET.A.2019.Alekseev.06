using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.A._2019.Alekseev._04
{
    public sealed class Polynomial
    {
        private double[] coeffs;
        public double this[int a]
        {
            get
            {
                return coeffs[a];
            }
            set
            {
                coeffs[a] = value;
            }
        }
        public Polynomial(params double[] coeffs)
        {
            CheckInputArguments(coeffs);
            this.coeffs = coeffs;
        }
        public static Polynomial Mult(Polynomial a, Polynomial b)
        {
            double[] coeffs = new double[a.coeffs.Length + b.coeffs.Length - 1];
            for(int i=0;i<a.coeffs.Length;i++)
            {
                for(int j=0;j<b.coeffs.Length;j++)
                {
                    coeffs[i + j] += a[i] * b[j];
                }
            }
            return new Polynomial(coeffs);
        }
        public static Polynomial Sum(Polynomial a,Polynomial b)
        {
            double[] longest,shortest;
            if (a.coeffs.Length > b.coeffs.Length)
            {
                longest = a.coeffs;
                shortest = b.coeffs;
            }
            else
            {
                longest = b.coeffs;
                shortest = a.coeffs;
            }
            double[] result = new double[longest.Length];
            Array.Copy(longest, 0, result, 0, longest.Length);
            for (int i=0;i<shortest.Length;i++)
            {
                result[i] += shortest[i];
            }
            return new Polynomial(result);
        }
        public static Polynomial Subtr(Polynomial a,Polynomial b)
        {
            double[] longest, shortest;
            if (a.coeffs.Length > b.coeffs.Length)
            {
                longest = a.coeffs;
                shortest = b.coeffs;
            }
            else
            {
                longest = b.coeffs;
                shortest = a.coeffs;
            }
            double[] result = new double[longest.Length];
            Array.Copy(longest, 0, result, 0, longest.Length);
            for(int i=0;i<shortest.Length;i++)
            {
                result[i] -= shortest[i];
            }
            return new Polynomial(result);
        }
        private void CheckInputArguments(double[] coeffs)
        {
            if (coeffs is null)
                throw new ArgumentException();
        }
        #region override methods
        public override string ToString()
        {
            string resultString="";
            foreach (double a in coeffs)
                resultString += a.ToString() + " ";
            return resultString;
        }
        public static Polynomial operator +(Polynomial a,Polynomial b)
        {
            return Sum(a, b);
        }
        public static Polynomial operator *(Polynomial a, Polynomial b)
        {
            return Mult(a, b);
        }
        public static Polynomial operator -(Polynomial a, Polynomial b)
        {
            return Subtr(a,b);
        }
        public override bool Equals(object obj)
        {
            if(obj is null)
            {
                return false;
            }
            Polynomial polynom= (Polynomial)obj;
            return polynom==this;
        }
        public override int GetHashCode()
        {
            double result=0;
            for(int i=0;i<this.coeffs.Length;i++)
            {
                result += coeffs[i] * i * 10000;
            }
            return (int) result;
        }
        public static bool operator ==(Polynomial a, Polynomial b)
        {
            return a.GetHashCode() == b.GetHashCode();
        }
        public static bool operator !=(Polynomial a, Polynomial b)
        {
            return !(a.GetHashCode() == b.GetHashCode());
        }
        #endregion
    }
}

