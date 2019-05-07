using System;
using System.Linq;
using System.Collections.Generic;
namespace Tema6
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] test = { 3, -4, 2, 1 };
            Polinomial myTest = new Polinomial(test);
            Console.WriteLine(myTest.solveForValue(2));
            double R = (Math.Abs(test[0]) + test.Max())/Math.Abs(test[0]);
            Console.WriteLine(R);
            for(double i = -R; i <= R; i = i + 1)
            {
                double root = myTest.aproximateRoot(i);
                Console.WriteLine(i);
                //Console.WriteLine(root);
            }
        }
    }
    class Polinomial
    {
        public double[] Coeficients { set; get; }
        public Polinomial(double[] coeficienti)
        {
            this.Coeficients = coeficienti;
        }
        public Polinomial derive()
        {
            double[] derivedPolinomial = new double[this.Coeficients.Length - 1];
            for(int i = 0; i < derivedPolinomial.Length; i++)
            {
                derivedPolinomial[i] = this.Coeficients[i] * (this.Coeficients.Length - 1 - i);
            }
            return new Polinomial(derivedPolinomial);
        }
        public double aproximateRoot(double x)
        {
            double p = this.solveForValue(x);
            double pDerived = this.derive().solveForValue(x);
            double pDoubleDerived = this.derive().derive().solveForValue(x);
            double A;
            double delta;
            double root = x;
            int k = 0;
            do
            {
                A = 2 * Math.Pow(pDerived, 2) - p * pDoubleDerived;
                if (Math.Abs(A) < Math.Pow(10, -10))
                {
                    return -1;
                }
                delta = p * pDerived / A;
                root = root - delta;
                k++;
            } while (Math.Abs(delta) >= Math.Pow(10, -10) && k <= 10000 && Math.Abs(delta) <= Math.Pow(10, 8));
            if (Math.Abs(delta) < Math.Pow(10, -10))
                return root;
            else 
                return -1;
        }
        public double solveForValue(double v)
        {
            double[] Q = new double[this.Coeficients.Length-1];
            for(int i = 0; i < Q.Length; i++)
            {
                if( i == 0)
                {
                    Q[i] = this.Coeficients[i];
                }
                else
                {
                    Q[i] = this.Coeficients[i] + (v * Q[i - 1]);
                }
            }
            double[] q = { 1, -v };
            double[] resultPolinomial = new double[Q.Length + 1];
            for(int i = 0; i < Q.Length; i++)
            {
                if(i == 0)
                {
                    resultPolinomial[i] = Q[i];
                }
                else if(i == Q.Length-1)
                {
                    resultPolinomial[Q.Length] = q[1] * Q[i];
                }
                else
                {
                    resultPolinomial[i] = Q[i] + q[1] * Q[i];
                }
            }
            return this.Coeficients[this.Coeficients.Length-1] - resultPolinomial[resultPolinomial.Length-1];
        }
    }
}
