using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Week5FormsBankSystem
{
    public partial class Deposits : Form
    {
        SqlConnection con; 
        SqlCommand cmd;
        SqlDataReader Data;
        public float Balance; 
        //private String AccType;
        //private String Gender;


        public Deposits()
        {
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='c:\\users\\admin\\documents\\visual studio 2015\\Projects\\Week5FormsBankSystem\\Week5FormsBankSystem\\Database1.mdf';Integrated Security=True";
            con.Open();
            cmd = con.CreateCommand(); 
            float DAmount = 0;
           
        }

        private void AccNo_Click(object sender, EventArgs e)
        {
            /*
            cmd.CommandText = "SELECT * FROM Accounts WHERE AccNo = '" + AccNo1 + "'";
            SqlDataReader Data = cmd.ExecuteReader();

            if (!Data.Read())
            {
                MessageBox.Show("Invalid Account Number!");
            } else {
                if (Data["Status"].ToString().Equals("D")) {
                    MessageBox.Show("Account Deactivated");
                } else {
                    cmd.CommandText = "SELECT * FROM Accounts WHERE AccNo = '" + AccNo1 + "'"; 

                   // if(Data["AccType"].ToString().Equals()
                }
            }
            */
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (AccNo1.Text != "")
            {
                cmd.CommandText = "SELECT * FROM Accounts WHERE AccountNo = '" + AccNo1.Text + "'";
                MessageBox.Show(cmd.CommandText);
                SqlDataReader Data = cmd.ExecuteReader();

                if (!Data.Read())
                {
                    MessageBox.Show("Invalid Account Number!");
                }
                else
                {
                    if (Data["Status"].ToString().Equals("D"))
                    {
                        MessageBox.Show("Account Deactivated");
                    }
                    else
                    {

                        this.groupBox1.Visible = true;
                        this.DName.Text = Data["Name"].ToString();
                        this.DAddress.Text = Data["Address"].ToString(); 
                        cmd.CommandText = "SELECT * FROM Accounts WHERE AccNo = '" + AccNo1 + "'";

                        // if(Data["AccType"].ToString().Equals()
                    }
                }


            }
            else
            {
                MessageBox.Show("Invalid Account Number!"); 
            }
            //Deposits.search(AccNo1); 
        }

        private void Deposit_Click(object sender, EventArgs e)
        { 
               
            if (Int32.Parse(DAmount.Text) == 0)
            {

                MessageBox.Show("Please Enter an amount:");

            }
            else {
                MessageBox.Show("Confirm the amount, are you sure?", "Confirmation", MessageBoxButtons.YesNo);
            }
        }

   
        private void Balance_TextChanged(object sender, EventArgs e)
        {

            String NewBalance = Data["New Bal"].ToString();
            //cmd.CommandText = "Insert into Account(" + NewBal + ",'" + DAmount + " '," + T3.Text + ")";
            
            //Int32.Parse(CurrBal.Text) += DAmount; 
            //Confirm();
            /*
            
            

            cmd.ExecuteNonQuery();
            T1.Text = NewRegNo; */

            //AccNo1.Balance = Balance; 
        }
    }
}
