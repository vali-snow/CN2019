using System;
using System.Collections.Generic;
using System.Text;

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
                    return 
                case 4:
                    a1 = 0.166;
                    a2 = 0.00833;
                    c3 = Double.Parse("1.984126984126984126984126984127E-4");
                    c4 = Double.Parse("2.7557319223985890652557319223986E-6");
                    break;
                case 5:
                    c1 = Double.Parse("0.16666666666666666666666666666667");
                    c2 = Double.Parse("0.00833333333333333333333333333333");
                    c3 = Double.Parse("1.984126984126984126984126984127E-4");
                    c4 = Double.Parse("2.7557319223985890652557319223986E-6");
                    c5 = Double.Parse("2.5052108385441718775052108385442E-8");
                    break;
                case 6:
                    c1 = Double.Parse("0.16666666666666666666666666666667");
                    c2 = Double.Parse("0.00833333333333333333333333333333");
                    c3 = Double.Parse("1.984126984126984126984126984127E-4");
                    c4 = Double.Parse("2.7557319223985890652557319223986E-6");
                    c5 = Double.Parse("2.5052108385441718775052108385442E-8");
                    c6 = Double.Parse("1.6059043836821614599392377170155E-10");
                    break;
                default:
                    break;
            }
        }
    }
}
