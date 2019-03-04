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
      if (sm.descompunere())
      {
        sm.printLU();
        Console.WriteLine(sm.getDeterminant());
      }
      else
      {
        Console.WriteLine("Nu are matrice patratica");
      }
      
    }
  }
}
