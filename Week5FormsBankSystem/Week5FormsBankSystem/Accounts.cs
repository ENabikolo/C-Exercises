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
    public partial class Accounts : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader R;
        private String AccType;
        private String Gender;


        public Accounts()
        {
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='c:\\users\\admin\\documents\\visual studio 2015\\Projects\\Week5FormsBankSystem\\Week5FormsBankSystem\\Database1.mdf';Integrated Security=True";
            con.Open();
            cmd = con.CreateCommand();
        }

        private void CreateAccount_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();

            AccType =  currentRadioButton.Checked ? "C": "S";
            Gender =   maleRadioButton.Checked ? "M" : "F";


            cmd.CommandText = "SELECT Concat('"+ AccType + "','"+ Gender + "',format(ISNULL(MAX(substring(AccountNo,3,3))+1, '001'),'000') AS NewAccNo from accounts WHERE substring(AccountNo,1,1)= '" + AccType + "' ";
           
            SqlDataReader R = cmd.ExecuteReader();
            R.Read();
            String NewAccountNumber = R["NewAccNo"].ToString();
            R.Close();
            cmd.CommandText = "Insert into Accounts values('" + NewAccountNumber + "','" + T2.Text + " ','" + T3.Text + "','A')";
            //MessageBox.Show(cmd.CommandText);
            cmd.ExecuteNonQuery(); 
            T1.Text = NewAccountNumber;  

            }

        private void T1_TextChanged(object sender, EventArgs e)
        {

        }
    }
        }
    
