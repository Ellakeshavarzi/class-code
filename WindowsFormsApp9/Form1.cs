using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Calculate cal = new Calculate();
            string[] s = { textBox1.Text, textBox2.Text };
            label3.Text = cal.sum(s).ToString();
            


            //label3.Text = cal.sum(textBox1.Text, textBox2.Text).ToString();
            /*
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            label3.Text = cal.sum(num1, num2).ToString();
            */
        }
    }
}
