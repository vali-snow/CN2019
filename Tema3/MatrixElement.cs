using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3
{
    public class MatrixElement : IEnumerable, IEquatable<MatrixElement>
    {
        public double Value { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }

        public MatrixElement(double value, int row, int column)
        {
            Value = value;
            Row = row;
            Column = column;
        }

        public IEnumerator GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public bool Equals(MatrixElement other)
        {
            var result = Value == other.Value && Row == other.Row && Column == other.Column;
            return result;
        }

        public int GetHashCode(MatrixElement obj)
        {
            throw new NotImplementedException();
        }
    }
}
