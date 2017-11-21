using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week5FormsEditor
{
    public partial class Form1 : Form
    {
     

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Resize(object sender, EventArgs e)
        {
            RT.Height = this.Height -20;
            RT.Width = this.Width -20;

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenF.ShowDialog(); 
            if (OpenF.FileName!="")
            {
                MessageBox.Show(OpenF.FileName);

                RT.LoadFile(OpenF.FileName);
               /* TextChanged = false;
                this.Text = FileName; */

            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveF.ShowDialog();
            if (SaveF.FileName != "") {         
                RT.SaveFile(SaveF.FileName);
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Have oprions for Exiting the application. 
            DialogResult Choice;
            Choice=MessageBox.Show("Do You want to save This file?","Warning",MessageBoxButtons.YesNoCancel);

            if (Choice == DialogResult.Yes)
            {
                SaveF.ShowDialog();
                if (SaveF.FileName != "")
                {
                    RT.SaveFile(SaveF.FileName);
                    
                }
            }
            if (Choice == DialogResult.No) 
            {
                Application.Exit();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Choice;
            Choice = MessageBox.Show("Do You want to save this file?", "Warning", MessageBoxButtons.YesNoCancel);

            if (Choice == DialogResult.Yes)
            {
                SaveF.ShowDialog();
                if (SaveF.FileName != "")
                {
                    RT.SaveFile(SaveF.FileName);
                }
            }
            if (Choice == DialogResult.No){

                RT.Text = null; //empties the current form. 
                }

            }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontD.ShowDialog();
            FontD.ShowColor = true; 
            RT.SelectionFont = FontD.Font;
    
           //RT.TextFont = FontD.Font("Monospaced", 11, FontStyle.Regular)

            /*if (FontChanged = true)
            {} */
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorD.ShowDialog();
            RT.SelectionColor = ColorD.Color;
            //RT.ForeColor = ColorD.Color; 

            //if ()


        }
    }
    }

