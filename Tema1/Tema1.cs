using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema1
{
    public partial class Tema1 : Form
    {
        public Tema1()
        {
            InitializeComponent();
        }

        private void btnCalculate1_Click(object sender, EventArgs e)
        {
            var precizie = 1.0;
            while (1.0 + precizie != 1.0)
            {
                precizie /= 10;
            }
            txtMachinePrecision.Text =  precizie.ToString();
            btnCalculate1.Enabled = false;
        }

        private void btnCheckAdditivity_Click(object sender, EventArgs e)
        {
            var x = Double.Parse(txtXA.Text);
            var y = Double.Parse(txtYA.Text);
            var z = Double.Parse(txtZA.Text);
            var check = (x + y) + z == x + (y + z);
            MessageBox.Show($"Operatia de adunare este asociativa cand y si z sunt egale cu precizia masina? {(check ? "Adevarat" : "Fals")}");
        }

        private void btnCheckMultiplication_Click(object sender, EventArgs e)
        {
            var x = 1+ Double.Parse("1E-15");
            var y = Double.Parse(txtYM.Text);
            var z = Double.Parse(txtZM.Text);
            var check = (x * y) * z == x * (y * z);
            MessageBox.Show($"Operatia de inmultire este asociativa in acest caz? {(check ? "Adevarat" : "Fals")}");
        }

        private void btnStartSession_Click(object sender, EventArgs e)
        {
            // Generate 100000 random numbers
            var randomNumbers = new double[100000];
            Random random = new Random();
            for (int i = 0; i < 100000; i++)
            {
                randomNumbers[i] = Math.PI / 2 * (random.NextDouble() * 2 - 1);
            }
            cbxGenerateRandom.Checked = true;

            Stopwatch stopwatch = new Stopwatch();

            // Calculate exact sin value for numbers
            var sinExact = new double[100000];
            stopwatch.Start();
            for (int i = 0; i < 100000; i++)
            {
                sinExact[i] = Math.Sin(randomNumbers[i]);
            }
            stopwatch.Stop();
            cbxCalculateSinValueWithMath.Checked = true;
            txtCalcWithMath.Text = $"ET in ms: {stopwatch.ElapsedMilliseconds}";

            // Calculate sin value with P1
            var sinP1 = new double[100000];
            stopwatch.Restart();
            for (int i = 0; i < 100000; i++)
            {
                sinP1[i] = CalculatePolinom(1, randomNumbers[i]);
            }
            stopwatch.Stop();
            cbxCalculateSinValueWithP1.Checked = true;
            txtCalcWithP1.Text = $"ET in ms: {stopwatch.ElapsedMilliseconds}";

            // Calculate sin value with P2
            var sinP2 = new double[100000];
            stopwatch.Restart();
            for (int i = 0; i < 100000; i++)
            {
                sinP2[i] = CalculatePolinom(2, randomNumbers[i]);
            }
            stopwatch.Stop();
            cbxCalculateSinValueWithP2.Checked = true;
            txtCalcWithP2.Text = $"ET in ms: {stopwatch.ElapsedMilliseconds}";

            // Calculate sin value with P3
            var sinP3 = new double[100000];
            stopwatch.Restart();
            for (int i = 0; i < 100000; i++)
            {
                sinP3[i] = CalculatePolinom(3, randomNumbers[i]);
            }
            stopwatch.Stop();
            cbxCalculateSinValueWithP3.Checked = true;
            txtCalcWithP3.Text = $"ET in ms: {stopwatch.ElapsedMilliseconds}";

            // Calculate sin value with P4
            var sinP4 = new double[100000];
            stopwatch.Restart();
            for (int i = 0; i < 100000; i++)
            {
                sinP4[i] = CalculatePolinom(4, randomNumbers[i]);
            }
            stopwatch.Stop();
            cbxCalculateSinValueWithP4.Checked = true;
            txtCalcWithP4.Text = $"ET in ms: {stopwatch.ElapsedMilliseconds}";

            // Calculate sin value with P5
            var sinP5 = new double[100000];
            stopwatch.Restart();
            for (int i = 0; i < 100000; i++)
            {
                sinP5[i] = CalculatePolinom(5, randomNumbers[i]);
            }
            stopwatch.Stop();
            cbxCalculateSinValueWithP5.Checked = true;
            txtCalcWithP5.Text = $"ET in ms: {stopwatch.ElapsedMilliseconds}";

            // Calculate sin value with P6
            var sinP6 = new double[100000];
            stopwatch.Restart();
            for (int i = 0; i < 100000; i++)
            {
                sinP6[i] = CalculatePolinom(6, randomNumbers[i]);
            }
            stopwatch.Stop();
            cbxCalculateSinValueWithP6.Checked = true;
            txtCalcWithP6.Text = $"ET in ms: {stopwatch.ElapsedMilliseconds}";

            // Calculate best approximation between P1-P6
            var bestAproximation = new Dictionary<int, int> { { 1,0}, { 2,0}, {3,0 }, { 4,0}, { 5,0}, { 6,0} };
            for (int i = 0; i < 100000; i++)
            {
                var row = new Dictionary<int, double>() { { 1, sinP1[i] }, { 2, sinP2[i] }, { 3, sinP3[i] }, { 4, sinP4[i] }, { 5, sinP5[i] }, { 6, sinP6[i] } };
                foreach (var item in row.OrderBy(o => Math.Abs(sinExact[i] - o.Value)).Take(3))
                {
                    bestAproximation[item.Key]++;
                }
            }
            foreach (var item in bestAproximation.OrderByDescending(o => o.Value).Take(3))
            {
                switch (item.Key)
                {
                    case 1:
                        cbxP1.Checked = true;
                        break;
                    case 2:
                        cbxP2.Checked = true;
                        break;
                    case 3:
                        cbxP3.Checked = true;
                        break;
                    case 4:
                        cbxP4.Checked = true;
                        break;
                    case 5:
                        cbxP5.Checked = true;
                        break;
                    case 6:
                        cbxP6.Checked = true;
                        break;
                }
            }
        }

        private double CalculatePolinom(int i, double x)
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
