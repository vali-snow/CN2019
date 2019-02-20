using System;
using static System.Math;
using System.Linq;
using System.Collections.Generic;

namespace Tema1
{
    public class Methods
    {
        public static double GetPrecizie()
        {
            var precizie = 1.0;
            while (1.0 + precizie != 1.0)
            {
                precizie /= 10;
            }
            return precizie;
        }

        public static bool CheckAdunareAsociativa(double x, double y, double z)
        {
            return (x + y) + z == x + (y + z);
        }

        public static bool CheckInmultireAsociativa(double x, double y, double z)
        {
            return (x * y) * z == x * (y * z);
        }

        public static void SinAproximation()
        {
            var randomNumbers = Generate10000RandomNumbers();
            var exact = new double[10000];
            for (int i = 0; i < 10000; i++)
            {
                exact[i] = Math.Sin(randomNumbers[i]);
            }
            var r1 = new double[10000];
            for (int i = 0; i < 10000; i++)
            {
                r1[i] = Math.Abs(exact[i] - CalculatePolinom(1, randomNumbers[i]));
            }
            var r2 = new double[10000];
            for (int i = 0; i < 10000; i++)
            {
                r2[i] = Math.Abs(exact[i] - CalculatePolinom(2, randomNumbers[i]));
            }
            var r3 = new double[10000];
            for (int i = 0; i < 10000; i++)
            {
                r3[i] = Math.Abs(exact[i] - CalculatePolinom(3, randomNumbers[i]));
            }
            var r4 = new double[10000];
            for (int i = 0; i < 10000; i++)
            {
                r4[i] = Math.Abs(exact[i] - CalculatePolinom(4, randomNumbers[i]));
            }
            var r5 = new double[10000];
            for (int i = 0; i < 10000; i++)
            {
                r5[i] = Math.Abs(exact[i] - CalculatePolinom(5, randomNumbers[i]));
            }
            var r6 = new double[10000];
            for (int i = 0; i < 10000; i++)
            {
                r6[i] = Math.Abs(exact[i] - CalculatePolinom(6, randomNumbers[i]));
            }

            var bestAproximation = new int[6];
            for (int i = 0; i < 10000; i++)
            {
                var row = new Dictionary<int, double>() { { 1, r1[i] }, { 2, r2[i] }, { 3, r3[i] }, { 4, r4[i] }, { 5, r5[i] }, { 6, r6[i] } };
                foreach (var item in row.OrderBy(o => o.Value).Take(3))
                {
                    bestAproximation[item.Key-1]++;
                }
            }

        }

        private static double[] Generate10000RandomNumbers()
        {
            var result = new double[10000];
            Random random = new Random();
            int i = 0;
            while (i < 10000)
            {
                result[i] = Math.PI / 2 * (random.NextDouble() * 2 - 1);
                i++;
            }
            return result;
        }

        public static double CalculatePolinom(int i, double x)
        {
            double c1, c2, c3, c4, c5, c6, a1, a2;
            double xx = x * x;
            switch (i)
            {
                case 1:
                    c1 = Double.Parse("0.16666666666666666666666666666667");
                    c2 = Double.Parse("0.00833333333333333333333333333333");
                    return x * (1 + xx * (-c1 + c2 * xx));
                case 2:
                    c1 = Double.Parse("0.16666666666666666666666666666667");
                    c2 = Double.Parse("0.00833333333333333333333333333333");
                    c3 = Double.Parse("1.984126984126984126984126984127E-4");
                    return x * (1 + xx * (-c1 + xx * (c2 - c3 * xx)));
                case 3:
                    c1 = Double.Parse("0.16666666666666666666666666666667");
                    c2 = Double.Parse("0.00833333333333333333333333333333");
                    c3 = Double.Parse("1.984126984126984126984126984127E-4");
                    c4 = Double.Parse("2.7557319223985890652557319223986E-6");
                    return x * (1 - xx * (-c1 + xx * (c2 + xx * (-c3 + c4 * xx))));
                case 4:
                    a1 = 0.166;
                    a2 = 0.00833;
                    c3 = Double.Parse("1.984126984126984126984126984127E-4");
                    c4 = Double.Parse("2.7557319223985890652557319223986E-6");
                    return x * (1 - xx * (-a1 + xx * (a2 + xx * (-c3 + c4 * xx))));
                case 5:
                    c1 = Double.Parse("0.16666666666666666666666666666667");
                    c2 = Double.Parse("0.00833333333333333333333333333333");
                    c3 = Double.Parse("1.984126984126984126984126984127E-4");
                    c4 = Double.Parse("2.7557319223985890652557319223986E-6");
                    c5 = Double.Parse("2.5052108385441718775052108385442E-8");
                    return x * (1 - xx * (-c1 + xx * (c2 + xx * (-c3 + xx * (c4 - c5 * xx)))));
                case 6:
                    c1 = Double.Parse("0.16666666666666666666666666666667");
                    c2 = Double.Parse("0.00833333333333333333333333333333");
                    c3 = Double.Parse("1.984126984126984126984126984127E-4");
                    c4 = Double.Parse("2.7557319223985890652557319223986E-6");
                    c5 = Double.Parse("2.5052108385441718775052108385442E-8");
                    c6 = Double.Parse("1.6059043836821614599392377170155E-10");
                    return x * (1 - xx * (-c1 + xx * (c2 + xx * (-c3 + xx * (c4 + xx * (-c5 + c6 * xx))))));
                default:
                    return 0;
            }
        }
    }
}
