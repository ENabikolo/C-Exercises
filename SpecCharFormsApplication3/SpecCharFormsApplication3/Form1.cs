using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpecCharFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            T2.Text = ""; 
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (T1.Text.Contains("0-9"))
            {
                 
            }
        }

        private void T1_TextChanged(object sender, EventArgs e)
        {
            T1.Text = "I am kind of getting these like $$$"; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
