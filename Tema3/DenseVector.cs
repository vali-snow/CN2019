using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3
{
    public class DenseVector
    {
        public int Count { get; set; } = 0;
        public List<double> Values { get; set; } = new List<double>();

        public void AddValue(double value)
        {
            Count++;
            Values.Add(value);
        }
    }
}