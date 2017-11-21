using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week5MultiFormsApplication
{
    public partial class Form1 : Form
    {
        Form2 F2;
        public Form1()
        {
             F2 = new Form2(); 
            InitializeComponent();
        }

        void clicked(object B, EventArgs e)
        {
            Button Btn = (Button)B;
            T1.Text = T1.Text + Btn.Text;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            F2.Show();

        }

        private void T1_TextChanged(object sender, EventArgs e)
        {
        T1.textBox
        }
    }
}

