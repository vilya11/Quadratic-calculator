using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quadratic_Calculator_gui

{
    public partial class calculate : Form
    {
        public calculate()
        {
            InitializeComponent();
        }

        //automatically generate method to display gui element: The name is also auto generated. I change only the name of important element. 
        private void label1_Click(object sender, EventArgs e)
        {

        }
        //automatically generate method to display gui element: The name is also auto generated. I change only the name of important element. 
        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        //automatically generate method to display gui element: The name is also auto generated. I change only the name of important element. 
        private void label3_Click(object sender, EventArgs e)
        {

        }
        //automatically generate method to display gui element: The name is also auto generated. I change only the name of important element. 
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //this is the clear button. I tried to change the name. But, it's still display as button1. So, I just ignore it.
        private void button1_Click(object sender, EventArgs e)
        {
            aInputText.Clear();
            bInputText.Clear();
            cInputText.Clear();
            x1InputText.Clear();
            x2InputText.Clear();
            aInputText.Focus();

        }
        //this is the calculate button. I put the main calculation here.
        private void calculate1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(aInputText.Text);
            double b = Convert.ToDouble(bInputText.Text);
            double c = Convert.ToDouble(cInputText.Text);


         
            double x1= ((-b + (Math.Sqrt((b * b) - (4 * a * c)))) / (2*a));
            x1InputText.Text = x1.ToString();
            double x2 = ((-b - (Math.Sqrt((b * b) - (4 * a * c)))) / (2*a));
            x2InputText.Text =x2.ToString();
        }
        //automatically generate method to display gui element: The name is also auto generated. I change only the name of important element. 
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
