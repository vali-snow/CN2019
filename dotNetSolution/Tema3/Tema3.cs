using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema3
{
    public partial class Tema3 : Form
    {
        public Tema3()
        {
            InitializeComponent();
        }

        private void btnStartCS_Click(object sender, EventArgs ev)
        {
            //read from file
            var aResult = new ReadFromFileResult($"..\\..\\db\\a.txt");
            clbInitialization.SetItemCheckState(0, CheckState.Checked);
            clbInitialization.SetItemCheckState(1, CheckState.Checked);
            clbInitialization.SetItemCheckState(2, CheckState.Checked);
            clbInitialization.Refresh();
            var bResult = new ReadFromFileResult($"..\\..\\db\\b.txt");
            clbInitialization.SetItemCheckState(3, CheckState.Checked);
            clbInitialization.SetItemCheckState(4, CheckState.Checked);
            clbInitialization.SetItemCheckState(5, CheckState.Checked);
            clbInitialization.Refresh();
            var aplusbResult = new ReadFromFileResult($"..\\..\\db\\aplusb.txt");
            clbInitialization.SetItemCheckState(6, CheckState.Checked);
            clbInitialization.SetItemCheckState(7, CheckState.Checked);
            clbInitialization.SetItemCheckState(8, CheckState.Checked);
            clbInitialization.Refresh();
            var aoribResult = new ReadFromFileResult($"..\\..\\db\\aorib.txt");
            clbInitialization.SetItemCheckState(9, CheckState.Checked);
            clbInitialization.SetItemCheckState(10, CheckState.Checked);
            clbInitialization.SetItemCheckState(11, CheckState.Checked);
            clbInitialization.Refresh();
            clbStepsCompleted.SetItemCheckState(0, CheckState.Checked);
            clbStepsCompleted.Refresh();

            //check maxim 12 not null per row in Matrix A
            var maxim12a = true;
            foreach (var row in aResult.Matrix.Elements)
            {
                if (row.Value.Count > 12)
                {
                    maxim12a = false;
                    break;
                }
            }
            clbStepsCompleted.SetItemCheckState(1, CheckState.Checked);
            clbStepsCompleted.Refresh();
            txtMatrixA12.Text = maxim12a.ToString();
            txtMatrixA12.Refresh();

            //check maxim 12 not null per row in Matrix B
            var maxim12b = true;
            foreach (var row in bResult.Matrix.Elements)
            {
                if (row.Value.Count > 12)
                {
                    maxim12b = false;
                    break;
                }
            }
            clbStepsCompleted.SetItemCheckState(2, CheckState.Checked);
            clbStepsCompleted.Refresh();
            txtMatrixB12.Text = maxim12b.ToString();
            txtMatrixB12.Refresh();

            //suma matricilor a  b
            var suma = new SparseMatrix();
            foreach (var element in aResult.Matrix.Elements.SelectMany(e => e.Value).ToList())
            {
                suma.AddValue(element.Value, element.Row, element.Column);
            }
            foreach (var element in bResult.Matrix.Elements.SelectMany(e => e.Value).ToList())
            {
                suma.AddValue(element.Value, element.Row, element.Column);
            }
            for (int i = 0; i < suma.Elements.Count; i++)
            {
                suma.Elements[i].Sort((a, b) => a.Column.CompareTo(b.Column));
            }
            clbStepsCompleted.SetItemCheckState(3, CheckState.Checked);
            clbStepsCompleted.Refresh();

            //check maxim 24 not null per row in Matrix A+B
            var maxim24ab = true;
            foreach (var row in suma.Elements)
            {
                if (row.Value.Count > 24)
                {
                    maxim24ab = false;
                    break;
                }
            }
            clbStepsCompleted.SetItemCheckState(4, CheckState.Checked);
            clbStepsCompleted.Refresh();
            txtMatrixAplusB24.Text = maxim24ab.ToString();
            txtMatrixAplusB24.Refresh();

            //check daca rezultatul e la fel ca in aplusb
            var correctAddition = suma.IsEqualTo(aplusbResult.Matrix);
            clbStepsCompleted.SetItemCheckState(5, CheckState.Checked);
            clbStepsCompleted.Refresh();
            txtAplusBCorrect.Text = correctAddition.ToString();
            txtAplusBCorrect.Refresh();

            //inmultirea matricilor a b
            var bPrim = new SparseMatrix();
            foreach (var element in bResult.Matrix.Elements.SelectMany(e => e.Value).ToList())
            {
                bPrim.AddValue(element.Value, element.Column, element.Row);
            }
            for (int i = 0; i < bPrim.Elements.Count; i++)
            {
                bPrim.Elements[i].Sort((a, b) => a.Column.CompareTo(b.Column));
            }
            var produs = new SparseMatrix();
            for (int i = 0; i < aResult.Size; i++)
            {
                for (int j = 0; j < aResult.Size; j++)
                {
                    var celula = 0D;

                    foreach (var element in aResult.Matrix.Elements[i])
                    {
                        var correspondingElement = bPrim.Elements[j].FirstOrDefault(e => element.Column == e.Column);
                        if (correspondingElement != null)
                        {
                            celula += correspondingElement.Value * element.Value;
                        }
                    }
                    if (celula != 0) { produs.AddValue(celula, i, j); }
                }
            }
            clbStepsCompleted.SetItemCheckState(6, CheckState.Checked);
            clbStepsCompleted.Refresh();
            

            //check daca rezultatul e la fel ca in aorib
            var correctMultiplication = produs.IsEqualTo(aoribResult.Matrix);
            clbStepsCompleted.SetItemCheckState(7, CheckState.Checked);
            clbStepsCompleted.Refresh();
            txtAOriBCorrect.Text = correctMultiplication.ToString();
            txtAOriBCorrect.Refresh();

            //calculate A * x
            var x = Enumerable.Range(1, 2019).Reverse().ToList();
            var vectorA = new DenseVector();
            for (int i = 0; i < 2019; i++)
            {
                var celula = 0D;
                foreach (var element in aResult.Matrix.Elements[i])
                {
                    celula += x[element.Column] * element.Value;
                }
                if (celula != 0) { vectorA.AddValue(celula); }
            }
            var correctVectorMultiplicationA = true;
            for (int i = 0; i < 2019; i++)
            {
                if (vectorA.Values[i] != aResult.Vector.Values[i])
                {
                    correctVectorMultiplicationA = false;
                    break;
                }
            }
            clbStepsCompleted.SetItemCheckState(8, CheckState.Checked);
            clbStepsCompleted.Refresh();
            txtAxCorrect.Text = correctVectorMultiplicationA.ToString();
            txtAxCorrect.Refresh();

            //calculate B* x
            var vectorB = new DenseVector();
            for (int i = 0; i < 2019; i++)
            {
                var celula = 0D;
                foreach (var element in bResult.Matrix.Elements[i])
                {
                    celula += x[element.Column] * element.Value;
                }
                if (celula != 0) { vectorB.AddValue(celula); }
            }
            var correctVectorMultiplicationB = true;
            for (int i = 0; i < 2019; i++)
            {
                if (vectorB.Values[i] != bResult.Vector.Values[i])
                {
                    correctVectorMultiplicationB = false;
                    break;
                }
            }
            clbStepsCompleted.SetItemCheckState(9, CheckState.Checked);
            clbStepsCompleted.Refresh();
            txtBxCorrect.Text = correctVectorMultiplicationB.ToString();
            txtBxCorrect.Refresh();

            //calculate AplusB * x
            var vectorAplusB = new DenseVector();
            for (int i = 0; i < 2019; i++)
            {
                var celula = 0D;
                foreach (var element in aplusbResult.Matrix.Elements[i])
                {
                    celula += x[element.Column] * element.Value;
                }
                if (celula != 0) { vectorAplusB.AddValue(celula); }
            }
            var correctVectorMultiplicationAplusB = true;
            for (int i = 0; i < 2019; i++)
            {
                if (vectorAplusB.Values[i] != aplusbResult.Vector.Values[i])
                {
                    correctVectorMultiplicationAplusB = false;
                    break;
                }
            }
            clbStepsCompleted.SetItemCheckState(10, CheckState.Checked);
            clbStepsCompleted.Refresh();
            txtAPlusBxCorrect.Text = correctVectorMultiplicationAplusB.ToString();
            txtAPlusBxCorrect.Refresh();

            //calculate AoriB * x
            var vectorAoriB = new DenseVector();
            for (int i = 0; i < 2019; i++)
            {
                var celula = 0D;
                foreach (var element in aoribResult.Matrix.Elements[i])
                {
                    celula += x[element.Column] * element.Value;
                }
                if (celula != 0) { vectorAoriB.AddValue(celula); }
            }
            var correctVectorMultiplicationAoriB = true;
            for (int i = 0; i < 2019; i++)
            {
                if (vectorAoriB.Values[i] != aoribResult.Vector.Values[i])
                {
                    correctVectorMultiplicationAoriB = false;
                    break;
                }
            }
            clbStepsCompleted.SetItemCheckState(11, CheckState.Checked);
            clbStepsCompleted.Refresh();
            txtAOriBxCorrect.Text = correctVectorMultiplicationAoriB.ToString();
            txtAOriBxCorrect.Refresh();
        }

        private void btnClearResults_Click(object sender, EventArgs e)
        {
            clbInitialization.SetItemCheckState(0, CheckState.Unchecked);
            clbInitialization.SetItemCheckState(1, CheckState.Unchecked);
            clbInitialization.SetItemCheckState(2, CheckState.Unchecked);
            clbInitialization.SetItemCheckState(3, CheckState.Unchecked);
            clbInitialization.SetItemCheckState(4, CheckState.Unchecked);
            clbInitialization.SetItemCheckState(5, CheckState.Unchecked);
            clbInitialization.SetItemCheckState(6, CheckState.Unchecked);
            clbInitialization.SetItemCheckState(7, CheckState.Unchecked);
            clbInitialization.SetItemCheckState(8, CheckState.Unchecked);
            clbInitialization.SetItemCheckState(9, CheckState.Unchecked);
            clbInitialization.SetItemCheckState(10, CheckState.Unchecked);
            clbInitialization.SetItemCheckState(11, CheckState.Unchecked);
            clbStepsCompleted.SetItemCheckState(0, CheckState.Unchecked);
            clbStepsCompleted.SetItemCheckState(1, CheckState.Unchecked);
            clbStepsCompleted.SetItemCheckState(2, CheckState.Unchecked);
            clbStepsCompleted.SetItemCheckState(3, CheckState.Unchecked);
            clbStepsCompleted.SetItemCheckState(4, CheckState.Unchecked);
            clbStepsCompleted.SetItemCheckState(5, CheckState.Unchecked);
            clbStepsCompleted.SetItemCheckState(6, CheckState.Unchecked);
            clbStepsCompleted.SetItemCheckState(7, CheckState.Unchecked);
            clbStepsCompleted.SetItemCheckState(8, CheckState.Unchecked);
            clbStepsCompleted.SetItemCheckState(9, CheckState.Unchecked);
            clbStepsCompleted.SetItemCheckState(10, CheckState.Unchecked);
            clbStepsCompleted.SetItemCheckState(11, CheckState.Unchecked);
            txtMatrixA12.Text = "";
            txtMatrixB12.Text = "";
            txtMatrixAplusB24.Text = "";
            txtAplusBCorrect.Text = "";
            txtAOriBCorrect.Text = "";
            txtAxCorrect.Text = "";
            txtBxCorrect.Text = "";
            txtAPlusBxCorrect.Text = "";
            txtAOriBxCorrect.Text = "";
        }
    }
}
