using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3
{
    public class SparseMatrix
    {
        public Dictionary<int, List<MatrixElement>> Elements { get; set; } = new Dictionary<int, List<MatrixElement>>();

        public void AddValue(double value, int row, int column)
        {
            if (Elements.ContainsKey(row))
            {
                var rowList = Elements[row];
                var sameCoordonateElement = rowList.Where(e => e.Column == column).FirstOrDefault();
                if (sameCoordonateElement != null)
                {
                    sameCoordonateElement.Value += value;
                }
                else
                {
                    rowList.Add(new MatrixElement(value, row, column));
                }
            }
            else
            {
                Elements.Add(row, new List<MatrixElement>() { new MatrixElement(value, row, column) });
            }
        }

        internal bool IsEqualTo(SparseMatrix matrix)
        {
            if (matrix == null)
            {
                return false;
            }
            else if (this.Elements.Count != matrix.Elements.Count)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < this.Elements.Count; i++)
                {
                    if (!this.Elements[i].SequenceEqual(matrix.Elements[i]))
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
