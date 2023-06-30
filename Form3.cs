using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Annual_Budget_Planner
{
  
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Text = Form2.total_income.ToString();
            textBox2.Text = Form2.total_expense.ToString();
            textBox3.Text = Form2.total_savings.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextWriter text = new StreamWriter("E:\\SAVED\\" + Form2.month_name + ".txt");
            text.WriteLine("YOUR INCOME           : " + textBox1.Text + "");
            text.WriteLine("House Expense         : " + Form2.house_expense + "");
            text.WriteLine("Transport Expense     : " + Form2.transportation_expense + "");  
            text.WriteLine( "Billing Expense       : " + Form2.billing_expense + "" );
            text.WriteLine("Food Expense          : " + Form2.food_expense + "");
            text.WriteLine("Entertainment Expense : " + Form2.entertainment_expense + "" );
            text.WriteLine("Education Expense     : " + Form2.education_expense + "");
            text.WriteLine("YOUR TOTAL EXPENSE    : " + textBox2.Text + "\n" + "YOUR SAVINGS          : " + textBox3.Text + "\n");
            text.Close();
           MessageBox.Show("Saved Successfully");

        }
       
    }
}