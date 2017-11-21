using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week5FormsCalcApplication3
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        void clicked(object B, EventArgs e)
        {
            Button Btn = (Button)B; 
            D1.Text = D1.Text + Btn.Text;
        }

        void execute(object B, EventArgs e)
        {
            Button Btn = (Button)B;
            D1.Text = D1.Text + Btn.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            D1.Text = D1.Text + "3";
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            D1.Text = D1.Text + "0";
        }

        private void Screen_TextChanged(object sender, EventArgs e)
        {

            if (D1.Text == " ")
            {
                this.Text = ("Press a button!");
            }

        }
        private void Power_Click(object sender, EventArgs e)
        {

           //Application.Current.Shutdown(); 


        }
    

    private void One_Click(object sender, EventArgs e)
    {
        D1.Text = D1.Text + "1";
    }

        private void Two_Click(object sender, EventArgs e)
        {
            D1.Text = D1.Text + "2";
        }

        private void Four_Click(object sender, EventArgs e)
        {
            D1.Text = D1.Text + "4";

        }

        private void Five_Click(object sender, EventArgs e)
        {
            D1.Text = D1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            D1.Text = D1.Text + "6";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            D1.Text = D1.Text + "7";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            D1.Text = D1.Text + "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            D1.Text = "9";
        }

        private void Add_Click(object sender, EventArgs e)
        {
            int A, B, C;
            A = Int32.Parse(D1.Text);
            B = Int32.Parse(D1.Text);
            C = A + B;
            D1.Text = C.ToString();
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            int A, B, C;
            A = Int32.Parse(D1.Text);
            B = Int32.Parse(D1.Text);
            C = A - B;
            D1.Text = C.ToString();
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            int A, B, C;
            A = Int32.Parse(D1.Text);
            B = Int32.Parse(D1.Text);
            C = A * B;
            D1.Text = C.ToString();
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            int A, B, C;
            A = Int32.Parse(D1.Text);
            B = Int32.Parse(D1.Text);
            C = A/B;
            D1.Text = C.ToString();
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            //D1.Text = Btn.Text.toString(); 

            //D1.Text =Int32.Parse(D1.Text);
        }

        private void C_Click(object sender, EventArgs e)
        {
        
            D1.Text=" ";
            //D1.Text.Focus(); 
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
 
}