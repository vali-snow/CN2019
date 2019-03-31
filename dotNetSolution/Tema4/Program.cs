using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema3;
namespace Tema4
{
  class Program
  {
    static void Main(string[] args)
    {
      ReadFromFileResult m1 = new ReadFromFileResult("C:\\Users\\TudorIacobuta\\Desktop\\CN2019\\dotNetSolution\\Tema4\\db\\matrice1.txt");
      ReadFromFileResult m2 = new ReadFromFileResult("C:\\Users\\TudorIacobuta\\Desktop\\CN2019\\dotNetSolution\\Tema4\\db\\matrice2.txt");
      ReadFromFileResult m3 = new ReadFromFileResult("C:\\Users\\TudorIacobuta\\Desktop\\CN2019\\dotNetSolution\\Tema4\\db\\matrice3.txt");
      ReadFromFileResult m4 = new ReadFromFileResult("C:\\Users\\TudorIacobuta\\Desktop\\CN2019\\dotNetSolution\\Tema4\\db\\matrice4.txt");
      ReadFromFileResult m5 = new ReadFromFileResult("C:\\Users\\TudorIacobuta\\Desktop\\CN2019\\dotNetSolution\\Tema4\\db\\matrice5.txt");


            DenseVector xm1 = getSolution(m1.Matrix, m1.Vector, 0.8, Math.Pow(10, -7));
            if (xm1 != null)
            {
                DenseVector AxOmega = scalarMultiplication(m1.Matrix, xm1);
                double testNorma = calculNorma(AxOmega, m1.Vector);

                //xm1.Values.ForEach(em => Console.WriteLine(Math.Round(em)));
                bool correct = true;
                for (int i = 0; i < xm1.Count; i++)
                {
                    if (5 != Math.Round(xm1.Values[i]))
                    {
                        correct = false;
                        break;
                    }
                }
                if (correct)
                {
                    Console.WriteLine("x1 Solution found");
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
            else
            {
                Console.WriteLine("Didnt work");
            }
            DenseVector xm2 = getSolution(m2.Matrix, m2.Vector, 1.2, Math.Pow(10, -7));
            if (xm2 != null)
            {
                DenseVector AxOmega = scalarMultiplication(m2.Matrix, xm2);
                double testNorma = calculNorma(AxOmega, m2.Vector);
                
                bool correct = true;
                for (int i = 0; i < xm2.Count;i++)
                {
                    if(i != Math.Round(xm2.Values[i] * 6.0 / 10.0))
                    {
                        correct = false;
                        break;
                    }
                }
                if(correct)
                {
                    Console.WriteLine("x2 Solution found");
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
            else
            {
                Console.WriteLine("Didnt work");
            }

            DenseVector xm3 = getSolution(m3.Matrix, m3.Vector, 0.8, Math.Pow(10, -7));
            if (xm3 != null)
            {
                DenseVector AxOmega = scalarMultiplication(m3.Matrix, xm3);
                double testNorma = calculNorma(AxOmega, m3.Vector);

                bool correct = true;
                for (int i = 0; i < xm3.Count; i++)
                {
                    if (i != Math.Round(xm3.Values[i] * 4.0))
                    {
                        correct = false;
                        break;
                    }
                }
                if (correct)
                {
                    Console.WriteLine("x3 Solution found");
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
            else
            {
                Console.WriteLine("Didnt work");
            }

            DenseVector xm4 = getSolution(m4.Matrix, m4.Vector, 0.8, Math.Pow(10, -7));
            if (xm4 != null)
            {
              DenseVector AxOmega = scalarMultiplication(m4.Matrix, xm4);
              double testNorma = calculNorma(AxOmega, m4.Vector);
             
                bool correct = true;
                for (int i = 0; i < xm4.Count; i++)
                {
                    if (i != Math.Round(xm4.Values[i] / 0.321))
                    {
                        correct = false;
                        break;
                    }
                }
                if (correct)
                {
                    Console.WriteLine("x4 Solution found");
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
            else
            {
              Console.WriteLine("Didnt work");
            }
            DenseVector xm5 = getSolution(m5.Matrix, m5.Vector, 0.8, Math.Pow(10, -1));
            if (xm5 != null)
            {
                DenseVector AxOmega = scalarMultiplication(m5.Matrix, xm5);
                double testNorma = calculNorma(AxOmega, m5.Vector);
                Console.WriteLine(testNorma);
            }
            else
            {
                Console.WriteLine("Didnt work");
            }
           


        }
        static DenseVector calculateNextVector(DenseVector oldVector, SparseMatrix matrixA, DenseVector vectorB, double omega)
    {
      DenseVector newVector = new DenseVector();
      int n = matrixA.Elements.Count;
      int i = 0;
      while (i != n)
      {
        double sum1 = 0;
        double sum2 = 0;
        var aii = matrixA.Elements[i].FirstOrDefault(e => e.Column == i);
        double oldXki = oldVector.Values[i];
        double bi = vectorB.Values[i];

        matrixA.Elements[i].ForEach(melem =>
        {
          if (melem.Column < i)
          {
            sum1 += newVector.Values[melem.Column] * melem.Value;
          }
          else
          {
            sum2 += oldVector.Values[melem.Column] * melem.Value;
          }
        });
        newVector.AddValue(oldXki + omega / aii.Value * (bi - sum1 - sum2));
        i++;
      }
      return newVector;
    }
    static double calculNorma(DenseVector v1, DenseVector v2)
    {
      double sum = 0;
      int n = v1.Count;
      for (int i = 0; i < n; i++)
      {
        sum += Math.Pow(v1.Values[i] - v2.Values[i], 2);
      }

      return Math.Sqrt(sum);
    }
    static DenseVector scalarMultiplication(SparseMatrix matrix, DenseVector vector)
    {
      DenseVector resultVector = new DenseVector();
      for (int i = 0; i < vector.Count; i++)
      {
        var celula = 0D;
        foreach (var element in matrix.Elements[i])
        {
          celula += vector.Values[element.Column] * element.Value;
        }
        if (celula != 0) { resultVector.AddValue(celula); }
      }
      return resultVector;
    }

    static DenseVector getSolution(
        SparseMatrix matrixA,
        DenseVector vectorB,
        double omega,
        double epsilon
    )
    {

      DenseVector xc = new DenseVector();
      DenseVector xp;

      for (double i = 0; i < vectorB.Count; i++)
      {
        xc.AddValue(i);
      }

      int k = 0;
      double deltaX = 0;
      do
      { 
        xp = xc;
        xc = calculateNextVector(xp, matrixA, vectorB, omega);
        deltaX = calculNorma(xc, xp);
        k++;
      } while (deltaX >= epsilon && k <= 10000 && deltaX < Math.Pow(10, 8));

      if (deltaX < epsilon)
      {
        return xc;
      }
      else
      {
        return null;
      }
    }

  }
}
