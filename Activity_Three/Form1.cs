using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                label3.Visible = true;
                textBox1.Visible = true;
            }
            else
            {
                label3.Visible = false;
                textBox1.Visible = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
             string str = " ";

            //checkBox1 = Switzerland
             if (checkBox1.Checked == true)
             {
                 str = str + checkBox1.Text;
                 str += " ";
             }

             //checkBox2 = South Korea
             if (checkBox2.Checked == true)
             {
                 str = str + checkBox2.Text;
                 str += " ";
             }

             //checkBox3 = California
             if (checkBox3.Checked == true)
             {
                 str = str + checkBox3.Text;
                 str += " ";
             }

             //checkBox4 = China
             if (checkBox4.Checked == true)
             {
                 str = str + checkBox4.Text;
                 str += " ";
             }

             //checkBox5 = Others
             if (checkBox5.Checked == true)
             {
                 str = str + textBox1.Text;
                 str += " ";
             }

             if (str != null)
             {
                 MessageBox.Show("You Selected: \n" + str + "\n Thank You!", "Survey", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
