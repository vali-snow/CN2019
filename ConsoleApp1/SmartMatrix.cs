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
    private Matrix<double> A;

    private Matrix<double> L;
    private Matrix<double> U;
    private int n;
    private int precizie;
    public SmartMatrix()
    {
      this.n = 3;
      L = DenseMatrix.OfArray(new double[n, n]);
      U = DenseMatrix.OfArray(new double[n, n]);

      this.A = DenseMatrix.OfArray(new double[,] {
        {1.5,3,3},
        {2,6.5,14},
        {1,3,8}});
      this.Ainit = new double[3,3];
      
      this.precizie = 5;
    }
    public void printLU()
    {
      for (int i = 0; i < n; i++)
      {
        for (int j = 0; j < n; j++)
        {
          Console.Write(string.Format("{0} ", L[i, j]));
        }
        Console.Write(Environment.NewLine + Environment.NewLine);
      }

      for (int i = 0; i < n; i++)
      {
        for (int j = 0; j < n; j++)
        {
          Console.Write(string.Format("{0} ", U[i, j]));
        }
        Console.Write(Environment.NewLine + Environment.NewLine);
      }
    }
    public double getDeterminant()
    {
      double det = 1;
      for(int i =0; i < n; i++)
      {
        det *= L[i, i];
      }
      return det;
    }
    public bool descompunere()
    {
      //calculam descompunerea LU
      for (int p = 0; p < n; p++)
      {
        //unde p este un pas din descompunere
        for (int i = 0; i <= p - 1; i++)
        {
          //double sumOfK_l = 0;
          double sumOfK_u = 0;
          for (int k = 0; k < i; k++)
          {
            //sumOfK_l += L[p, k] * U[k, i];
            sumOfK_u += L[i, k] * U[k, p];
          }
          //L[p, i] = A[p, i] - sumOfK_l;

          if (L[i, i] != 0)
          {
            U[i, p] = (A[i, p] - sumOfK_u) / L[i, i];
          }
          else
          {
            return false;
          }
        }//End i for

        for (int i = 0; i <= p;i++)
        {
          if (i == p)
          {
            U[i, p] = 1;
          }
          double sumOfK_l = 0;
          //double sumOfK_u = 0;
          for (int k = 0; k < i; k++)
          {
            sumOfK_l += L[p, k] * U[k, i];
            //sumOfK_u += L[i, k] * U[k, p];
          }
          L[p, i] = A[p, i] - sumOfK_l;
          
        }//End i for 
        
      }//End p for
      return true;
      
    }
  }
}
