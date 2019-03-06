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
      //sm.printLU();
      sm.solveForX();
      Console.WriteLine(sm.getNorma());

      Matrix<double> libraryMatrix;
      
      
    }
  }
}
