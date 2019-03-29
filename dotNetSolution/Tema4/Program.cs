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

      DenseVector x = getSolution(m1.Matrix, m1.Vector, 0.8, Math.Pow(10, -16));
      DenseVector AxOmega = scalarMultiplication(m1.Matrix, x);
      double testNorma = calculNorma(AxOmega, m1.Vector);
      Console.WriteLine(testNorma);
    }
    static DenseVector calculateNextVector(DenseVector  oldVector, SparseMatrix matrixA, DenseVector vectorB, double omega)
    {
      DenseVector newVector = new DenseVector();
      int n = matrixA.Elements.Count;
      int i = 0;
      while(i != n)
      {
        double sum1 = 0;
        double sum2 = 0;
        var aii = matrixA.Elements[i].FirstOrDefault(e => e.Column == i);
        double oldXki = oldVector.Values[i];
        double bi = vectorB.Values[i];
        //Ma gandesc ca aici ar merge un linq pentru fiecare matrixA.Elements[i].foreach(melem => { si aici facult calculele din for})
        /*
        for(int j = 0; j < n; j++)
        {
          var aij = matrixA.Elements[i].FirstOrDefault(e => e.Column == j);
          double oldXkj = oldVector.Values[j];
          if(j < i)
          {
            double newXkj = newVector.Values[j];
            if(aij != null)
            {
              sum1 += newXkj * aij.Value;
            }
          }
          else
          {
            if(aij != null)
            {
              sum2 += oldXkj * aij.Value;
            }
          }
        }
        */
        double diff = bi - sum1 - sum2;
        double raport = omega * diff / aii.Value;
        newVector.AddValue(oldXki + raport);
        i++;
      }
      return newVector;
    }
    static double calculNorma(DenseVector v1,DenseVector v2)
    {
      double sum = 0;
      int n = v1.Count;
      for(int i = 0; i<n;i++)
      {
        sum += Math.Pow(v1.Values[i] - v2.Values[i], 2);
      }
      return Math.Sqrt(sum);
    }
    static DenseVector scalarMultiplication(SparseMatrix matrix,DenseVector vector)
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
    static DenseVector getSolution(SparseMatrix matrixA,
      DenseVector vectorB,
      double omega,
      double epsilon)
    {
      DenseVector xc = new DenseVector();
      DenseVector xp = new DenseVector();
      for (double i = 0; i < vectorB.Count;i++)
      {
        xc.AddValue(i);
      }
      int k = 0;
      double deltaX;

      do
      {
        xp = xc;
        xc = calculateNextVector(xp, matrixA, vectorB, omega);
        deltaX = calculNorma(xc,xp);
        k++;
      } while (deltaX <= epsilon && k <= 10000 && deltaX < Math.Pow(10,8));

      if(deltaX < epsilon)
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
