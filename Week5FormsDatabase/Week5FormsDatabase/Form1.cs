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
namespace Week5FormsDatabase
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader Data;
        SqlDataReader R; 
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='c:\\users\\admin\\documents\\visual studio 2015\\Projects\\Week5FormsDatabase\\Week5FormsDatabase\\Database1.mdf';Integrated Security=True";
            con.Open();
            cmd = con.CreateCommand(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Query ="insert into School values("+T1.Text+",'" +T2.Text+" ',"+T3.Text+")";
            cmd.CommandText = Query;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "SELECT NVL(Max(RegNo), 0)+1 AS New R FROM School";
            SqlDataReader R = cmd.ExecuteReader();
            if (R.Read())
            {
                String NewRegNo = R["New R"].ToString();
                cmd.CommandText = "Insert into School values(" + NewRegNo + ",'" + T2.Text + " '," + T3.Text + ")";
                cmd.ExecuteNonQuery();
                T1.Text = NewRegNo;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "SELECT * FROM School";
            Data = cmd.ExecuteReader();
            if (Data.Read())
            {
                T1.Text = Data["RegNo"].ToString();
                T2.Text = Data["Name"].ToString();
                T3.Text = Data["Marks"].ToString();
            }
        }

        
    }
}
