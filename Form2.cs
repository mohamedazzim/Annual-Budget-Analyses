using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Annual_Budget_Planner
{
    public partial class Form2 : Form
    {
        Form3 frm1 = new Form3();

        public static string month_name;
        public static string new_expense_name;
        public static string new_expense_name_2;
        public static int total_income;
        public static int total_expense;
        public static int total_savings;
        public static int house_expense;
        public static int transportation_expense;
        public static int billing_expense;
        public static int food_expense;
        public static int entertainment_expense;
        public static int education_expense;
        public static int live_total;
        public static int new_expense_1;
        public static int new_expense_2;
        
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";

            
           month_name = Form1.month;
           textBox8.Text = live_total.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            total_income = int.Parse(textBox1.Text);
            house_expense = int.Parse(textBox2.Text);
            transportation_expense = int.Parse(textBox3.Text);
            billing_expense = int.Parse(textBox4.Text);
            food_expense = int.Parse(textBox5.Text);
            entertainment_expense = int.Parse(textBox6.Text);
            education_expense = int.Parse(textBox7.Text);
            total_expense = house_expense + transportation_expense + billing_expense + food_expense + entertainment_expense + education_expense + new_expense_1 + new_expense_2;

            total_savings = total_income - total_expense;


           // listBox1.Items.Add("Total Income Is : " + total_income);
           // listBox1.Items.Add("Total Expense Is : " +total_expense);
           // listBox1.Items.Add("Total Savings Is : " + total_savings);
            frm1.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(textBox8.Text) < int.Parse(textBox1.Text))
            {
                textBox8.ForeColor = Color.Black;
            }
            else if (int.Parse(textBox8.Text) == int.Parse(textBox1.Text) )
            {
                textBox8.ForeColor = Color.Green;
            }
            else if (int.Parse(textBox8.Text) > int.Parse(textBox1.Text))
            {
                textBox8.ForeColor = Color.Red;
            }



            if (int.Parse(textBox8.Text) > int.Parse(textBox1.Text) )
            {
                BackColor = Color.Red;
            }
            else if (int.Parse(textBox8.Text) < int.Parse(textBox1.Text) || int.Parse(textBox8.Text) == int.Parse(textBox1.Text))
            {
                BackColor = Color.White;
            }


        }


        #region comments
        //private void textBox2_TextChanged(object sender, EventArgs e)
        //{
        //    live_total += Convert.ToInt32(textBox2.Text);
        //    textBox8.Text = live_total.ToString();

        //if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
        //textBox3.Text = (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text)).ToString();
        //      }
        #endregion


        #region Live_Total_Code

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrEmpty(textBox5.Text) && !string.IsNullOrEmpty(textBox6.Text) && !string.IsNullOrEmpty(textBox7.Text))
                textBox8.Text = (Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox6.Text) + Convert.ToInt32(textBox7.Text)).ToString();
        }



        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrEmpty(textBox5.Text) && !string.IsNullOrEmpty(textBox6.Text) && !string.IsNullOrEmpty(textBox7.Text))
                textBox8.Text = (Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox6.Text) + Convert.ToInt32(textBox7.Text)).ToString();


        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrEmpty(textBox5.Text) && !string.IsNullOrEmpty(textBox6.Text) && !string.IsNullOrEmpty(textBox7.Text))
                textBox8.Text = (Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox6.Text) + Convert.ToInt32(textBox7.Text)).ToString();

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrEmpty(textBox5.Text) && !string.IsNullOrEmpty(textBox6.Text) && !string.IsNullOrEmpty(textBox7.Text))
                textBox8.Text = (Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox6.Text) + Convert.ToInt32(textBox7.Text)).ToString();


        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrEmpty(textBox5.Text) && !string.IsNullOrEmpty(textBox6.Text) && !string.IsNullOrEmpty(textBox7.Text))
                textBox8.Text = (Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox6.Text) + Convert.ToInt32(textBox7.Text)).ToString();

        }


        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrEmpty(textBox5.Text) && !string.IsNullOrEmpty(textBox6.Text) && !string.IsNullOrEmpty(textBox7.Text))
                textBox8.Text = (Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox6.Text) + Convert.ToInt32(textBox7.Text)).ToString();
        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrEmpty(textBox5.Text) && !string.IsNullOrEmpty(textBox6.Text) && !string.IsNullOrEmpty(textBox7.Text))
                textBox8.Text = (Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox6.Text) + Convert.ToInt32(textBox7.Text)).ToString();
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrEmpty(textBox5.Text) && !string.IsNullOrEmpty(textBox6.Text) && !string.IsNullOrEmpty(textBox7.Text))
                textBox8.Text = (Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox6.Text) + Convert.ToInt32(textBox7.Text)).ToString();
        }

        #endregion


        #region Defualt Value
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.Text = "30000";
                textBox2.Text = "5000";
                textBox3.Text = "3000";
                textBox4.Text = "2000";
                textBox5.Text = "4000";
                textBox6.Text = "1000";
                textBox7.Text = "1000";
            }
        }
        #endregion
        
    }
}
