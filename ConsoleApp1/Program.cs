using System;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;
namespace Tema2Logic
{
  class Program
  {
    static void Main(string[] args)
    {
      SmartMatrix sm = new SmartMatrix();
      sm.descompunere();
      sm.printLU();
      sm.solveForX();
      Console.WriteLine();
      Console.WriteLine($"Norma solutiei {sm.getNorma()}");
      Console.WriteLine();
      sm.librariesNorms_1();
      Console.WriteLine();
      sm.librariesNorms_2();

      Matrix<double> libraryMatrix;
      
      
    }
  }
}
