using System;
using System.Collections.Generic;
using System.Text;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

namespace Tema2Logic
{
  public class SmartMatrix
  {
    private double[,] Ainit;
    private double[,] A;
    

    private double[] Binit;
    private double[] Y;

    private double[] X;
    private double norma;
    double[] e;
    private int n;
    private int precizie;
    public SmartMatrix()
    {
      this.n = 3;

      this.X = new double[n];
      this.Y = new double[n];
      this.A = new double[n, n];
      this.e = new double[n];
      this.Binit = new double[] { 1, 2, 3 };
      this.Ainit = new double[,] {
        {1.5,3,3},
        {2,6.5,14},
        {1,3,8}};


      this.precizie = 5;
    }
    private void solveForY()
    {
      
      for (int i = 0; i <n; i++)
      {
        double sum = 0;
        for(int j = 0; j < i;j++)
        {
          sum += A[i,j]*Y[j];
        }
        Y[i] = (Binit[i] - sum) / A[i, i];
      }
    }
    public void solveForX()
    {
      solveForY();
      for (int i = n-1; i >=0 ; i--)
      {
        double sum = 0;
        for (int j = i+1; j < n; j++)
        {
          sum += A[i, j] * X[j];
          
        }
        X[i] = (Y[i] - sum);
      }

      Console.WriteLine("Solutia X: ");
      for (int i = 0; i < n; i++)
      {
        Console.WriteLine(X[i]);
      }
    }
    
    public void printLU()
    {
      Console.WriteLine("Matricea LU: ");
      for (int i = 0; i < n; i++)
      {
        for (int j = 0; j < n; j++)
        {
          Console.Write(string.Format("{0} ", A[i, j]));
        }
        Console.Write(Environment.NewLine + Environment.NewLine);
      }
    }
    public double getDeterminant()
    {
      double det = 1;
      for(int i =0; i < n; i++)
      {
        det *= A[i, i];
      }
      return det;
    }
    public double getNorma()
    {
      for (int i = 0; i < n; i++)
      {
         
        double sumProd = 0;
        for (int j = 0; j < n; j++)
          sumProd += Ainit[i,j] * X[j];
        e[i] += Math.Pow((sumProd - Binit[i]), 2);
      }

      for (int i = 0; i < n; i++)
        norma += e[i];
      norma = Math.Sqrt(norma);

      return norma;
    }
    public bool descompunere()
    {
      //calculam descompunerea LU
      for (int p = 0; p < n; p++)
      {

        
        for (int i = 0; i <= p - 1; i++)
        {
         
          double sumOfK_u = 0;
          for (int k = 0; k < i; k++)
          {
            
            sumOfK_u += A[i, k] * A[k, p];
          }
          if (A[i, i] != 0)
          {
            A[i, p] = (Ainit[i, p] - sumOfK_u) / A[i, i];
          }
          else
          {
            return false;
          }
        }//End i for

        for (int i = 0; i <= p; i++)
        {
          double sumOfK_l = 0;
          for (int k = 0; k < i; k++)
          {
            sumOfK_l += A[p, k] * A[k, i];

          }
          A[p, i] = Ainit[p, i] - sumOfK_l;

        }//End i for 

      }//End p for
      return true;
      
    }
    public void librariesNorms_1()
    {
      Matrix<double> libAinit = DenseMatrix.OfArray(Ainit);
      Vector<double> libBinit = DenseVector.OfArray(Binit);
      Vector<double> libX = libAinit.Solve(libBinit);
      double[] e = new double[libX.Count];
      for (int i = 0; i < n; i++)
      {
        e[i] += Math.Pow((X[i] - libX[i]), 2);
      }
      double norma = 0;
      for (int i = 0; i < n; i++)
        norma += e[i];
      norma = Math.Sqrt(norma);
      Console.WriteLine("Norma ||X - Xlib||: "+norma);
      
    }
    public void librariesNorms_2()
    {
      Matrix<double> libAinit = DenseMatrix.OfArray(Ainit);
      Matrix<double> libAinverse = libAinit.Inverse(); 
      
      
      double[] e = new double[n];
      for (int i = 0; i < n; i++)
      {
        double sumProd = 0;
        for (int j = 0; j < n; j++)
          sumProd += libAinverse[i, j] * Binit[j];

        e[i] += Math.Pow((X[i] - sumProd), 2);
      }
      double norma = 0;
      for (int i = 0; i < n; i++)
        norma += e[i];
      norma = Math.Sqrt(norma);
      Console.WriteLine("Norma ||X - Ainverse*Binit||: " + norma);
    }
  }
}
