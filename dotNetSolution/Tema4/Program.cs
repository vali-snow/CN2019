using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema3;
namespace Tema4
{
    public class Solver
    {

        private ReadFromFileResult m1 = new ReadFromFileResult("C:\\Users\\TudorIacobuta\\Desktop\\CN2019\\dotNetSolution\\Tema4\\db\\matrice1.txt");
        private ReadFromFileResult m2 = new ReadFromFileResult("C:\\Users\\TudorIacobuta\\Desktop\\CN2019\\dotNetSolution\\Tema4\\db\\matrice2.txt");
        private ReadFromFileResult m3 = new ReadFromFileResult("C:\\Users\\TudorIacobuta\\Desktop\\CN2019\\dotNetSolution\\Tema4\\db\\matrice3.txt");
        private ReadFromFileResult m4 = new ReadFromFileResult("C:\\Users\\TudorIacobuta\\Desktop\\CN2019\\dotNetSolution\\Tema4\\db\\matrice4.txt");
        private ReadFromFileResult m5 = new ReadFromFileResult("C:\\Users\\TudorIacobuta\\Desktop\\CN2019\\dotNetSolution\\Tema4\\db\\matrice5.txt");
        public double norma1 { private set; get; }
        public double norma2 { private set; get; }
        public double norma3 { private set; get; }
        public double norma4 { private set; get; }
        public double norma5 { private set; get; }
        public double omega { set; get; }

        public Solver()
        {
            omega = 0.8;
        }
        public bool solveM1()
        {
            DenseVector xm1 = Program.getSolution(m1.Matrix, m1.Vector, omega, Math.Pow(10, -7));
            if (xm1 != null)
            {
                DenseVector AxOmega = Program.scalarMultiplication(m1.Matrix, xm1);
                norma1 = Program.calculNorma(AxOmega, m1.Vector);

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
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }
        public bool solveM2()
        {
            DenseVector xm2 = Program.getSolution(m2.Matrix, m2.Vector, omega, Math.Pow(10, -7));
            if (xm2 != null)
            {
                DenseVector AxOmega = Program.scalarMultiplication(m2.Matrix, xm2);
                norma2  = Program.calculNorma(AxOmega, m2.Vector);

                bool correct = true;
                for (int i = 0; i < xm2.Count; i++)
                {
                    if (i != Math.Round(xm2.Values[i] * 6.0 / 10.0))
                    {
                        correct = false;
                        break;
                    }
                }
                if (correct)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }
        public bool solveM3()
        {
            DenseVector xm3 = Program.getSolution(m3.Matrix, m3.Vector, omega, Math.Pow(10, -7));
            if (xm3 != null)
            {
                DenseVector AxOmega = Program.scalarMultiplication(m3.Matrix, xm3);
                norma3 = Program.calculNorma(AxOmega, m3.Vector);

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
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }
        public bool solveM4()
        {
            DenseVector xm4 = Program.getSolution(m4.Matrix, m4.Vector, omega, Math.Pow(10, -7));
            if (xm4 != null)
            {
                DenseVector AxOmega = Program.scalarMultiplication(m4.Matrix, xm4);
                norma4 = Program.calculNorma(AxOmega, m4.Vector);

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
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }
        public bool solveM5()
        {
            DenseVector xm5 = Program.getSolution(m5.Matrix, m5.Vector, omega, Math.Pow(10, -1));
            if (xm5 != null)
            {
                DenseVector AxOmega = Program.scalarMultiplication(m5.Matrix, xm5);
                norma5 = Program.calculNorma(AxOmega, m5.Vector);
                bool correct = true;
                for (int i = 0; i < xm5.Count; i++)
                {
                    if (2 != Math.Round(xm5.Values[i]))
                    {
                        correct = false;
                        break;
                    }
                }
                if (correct)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }


        }
        public class Program
        {

            public static DenseVector calculateNextVector(DenseVector oldVector, SparseMatrix matrixA, DenseVector vectorB, double omega)
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
            public static double calculNorma(DenseVector v1, DenseVector v2)
            {
                double sum = 0;
                int n = v1.Count;
                for (int i = 0; i < n; i++)
                {
                    sum += Math.Pow(v1.Values[i] - v2.Values[i], 2);
                }

                return Math.Sqrt(sum);
            }
            public static DenseVector scalarMultiplication(SparseMatrix matrix, DenseVector vector)
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

            public static DenseVector getSolution(
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
}

  

