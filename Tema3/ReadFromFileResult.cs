using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3
{
    public class ReadFromFileResult
    {
        public int Size { get; set; } = 0;
        public SparseMatrix Matrix { get; set; } = new SparseMatrix();
        public DenseVector Vector { get; set; } = new DenseVector();

        public ReadFromFileResult(string path)
        {
            string[] lines = File.ReadAllLines(path, Encoding.UTF8);
            Size = Convert.ToInt32(lines[0]);

            var i = 2;
            while (lines[i] != "")
            {
                var position = lines[i].Split(new string[] { ", " }, StringSplitOptions.None);
                var value = Convert.ToDouble(position[0]);
                var row = Convert.ToInt32(position[1]);
                var col = Convert.ToInt32(position[2]);
                Matrix.AddValue(value, row, col);
                i++;
            }
            i++;
            while (lines[i] != "")
            {
                var value = Convert.ToDouble(lines[i]);
                Vector.AddValue(value);
                i++;
            }

            for (int j = 0; j < Matrix.Elements.Count; j++)
            {
                Matrix.Elements[j].Sort((a, b) => a.Column.CompareTo(b.Column));
            }
        }
    }
}
