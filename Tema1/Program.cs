using System;
//using System.Math;

namespace Tema1
{
    class Program
    {
        static void Main(string[] args)
        {
            /// 1.Precizia Masina
            var precizieMasina = Methods.GetPrecizie();
            Console.WriteLine($"Precizia masina pentru limbajul C# este: {precizieMasina}");

            /// 2.Neasociativitate a operatiei de adunare efectuate de calculator cu y,z = precizia masina
            Console.WriteLine($"Operatia de adunare mai este asociativa cand y si z sunt egale cu precizia masina? {(Methods.CheckAdunareAsociativa(1.0,precizieMasina,precizieMasina)?"Adevarat":"Fals")}");

            /// 2.Neasociativiate a operatiei de inmultire efectuate de calculator - verificare exemplu
            var (x, y, z) = (1+Double.Parse("1E-15"), Double.Parse("1.0E-10"), Double.Parse("1.0E-10"));
            Console.WriteLine($"Daca x= {x}, y = {y}, z= {z}, operatia de inmultire mai este asociativa? {(Methods.CheckInmultireAsociativa(x,y,z)?"Adevarat":"Fals")}");

            /// 3.Aproximări polinomiale ale funcţiei sin
            Methods.SinAproximation();
        }
    }
}
