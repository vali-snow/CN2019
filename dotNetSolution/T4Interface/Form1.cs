using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tema4;
namespace T4Interface
{
    public partial class Form1 : Form
    {
        Solver problemSover = new Solver();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void m1Btn_Click(object sender, EventArgs e)
        {
            if(problemSover.solveM1())
            {
                m1Check.Checked = true;
                textBox1.Text = problemSover.norma1.ToString();
            }
            else
            {
                textBox1.Text = "-1";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void m2Btn_Click(object sender, EventArgs e)
        {
            if (problemSover.solveM2())
            {
                m2Check.Checked = true;
                textBox2.Text = problemSover.norma2.ToString();
            }
            else
            {
                textBox2.Text = "-1";
            }
        }

        private void m3Btn_Click(object sender, EventArgs e)
        {
            if (problemSover.solveM3())
            {
                m3Check.Checked = true;
                textBox3.Text = problemSover.norma3.ToString();
            }
            else
            {
                textBox3.Text = "-1";
            }
        }

        private void m4Btn_Click(object sender, EventArgs e)
        {
            if (problemSover.solveM4())
            {
                m4Check.Checked = true;
                textBox4.Text = problemSover.norma4.ToString();
            }
            else
            {
                textBox4.Text = "-1";
            }
        }

        private void m5Btn_Click(object sender, EventArgs e)
        {
            if (problemSover.solveM5())
            {
                m5Check.Checked = true;
                textBox5.Text = problemSover.norma5.ToString();
            }
            else
            {
                textBox5.Text = "-1";
            }
        }
    }
}
