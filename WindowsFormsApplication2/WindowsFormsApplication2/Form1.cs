using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (T.Text == " ")
            {
                MessageBox.Show("First Number is missing");
                T.Focus();
            }
            else if (T1.Text == " ")
            {
                MessageBox.Show("Second Number is Missing");
                T1.Focus();
            }
            else
            {

                int A, B, C;
                A = Int32.Parse(T.Text);
                B = Int32.Parse(T1.Text);
                C = A + B;
                T2.Text = C.ToString();


            }

        }

        private void T_TextChanged(object sender, EventArgs e)
        {
            T.Text = " ";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (T3.Width > (this.Width - 100))
            {
                this.Text = "max width reached";
            }
            T3.Width = T3.Width + 10;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (T4.Width > (this.Width - 100))
            {
                T4.Width = T4.Width + 10;
            }
            if (T4.Width < (this.Width - 100)) //Check this code. 
            {
                T4.Width = T4.Width - 10;
            }
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            if (T.Text == " ")
            {
                MessageBox.Show("First Number is missing");
                T.Focus();
            }
            else if (T1.Text == " ")
            {
                MessageBox.Show("Second Number is Missing");
                T1.Focus();
            }
            else
            {

                int A, B, C;
                A = Int32.Parse(T.Text);
                B = Int32.Parse(T1.Text);
                C = A - B;
                T2.Text = C.ToString();

            }

        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            if (T.Text == " ")
            {
                MessageBox.Show("First Number is missing");
                T.Focus();
            }
            else if (T1.Text == " ")
            {
                MessageBox.Show("Second Number is Missing");
                T1.Focus();
            }
            else
            {

                int A, B, C;
                A = Int32.Parse(T.Text);
                B = Int32.Parse(T1.Text);
                C = A * B;
                T2.Text = C.ToString();
            }
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            if (T.Text == " ")
            {
                MessageBox.Show("First Number is missing");
                T.Focus();
            }
            else if (T1.Text == " ")
            {
                MessageBox.Show("Second Number is Missing");
                T1.Focus();
            }
            else
            {

                int A, B, C;
                A = Int32.Parse(T.Text);
                B = Int32.Parse(T1.Text);
                C = A / B;
                T2.Text = C.ToString();
            }
        }
    }

}
   
