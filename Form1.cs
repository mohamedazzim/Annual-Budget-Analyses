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
    public partial class Form1 : Form
    {
        Form2 frm = new Form2();
        public static string temp = "";


        Form4  save = new Form4();

        public static string month = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            month = button4.Text;
            frm.ShowDialog();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             month = button1.Text;
            frm.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            month = button2.Text;
            frm.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            month = button3.Text;
            frm.ShowDialog();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            month = button5.Text;
            frm.ShowDialog();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            month = button6.Text;
            frm.ShowDialog();
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            month = button7.Text;
            frm.ShowDialog();
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            month = button8.Text;
            frm.ShowDialog();
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            month = button9.Text;
            frm.ShowDialog();
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            month = button10.Text;
            frm.ShowDialog();
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            month = button11.Text;
            frm.ShowDialog();
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            month = button12.Text;
            frm.ShowDialog();
            
        }

        private void button24_Click(object sender, EventArgs e)
        {
            temp = button24.Text;
            save.ShowDialog();


           
            //string[] file_name = File.ReadAllLines("E:\\SAVED\\JANUARY.txt");


        }

        private void button23_Click(object sender, EventArgs e)
        {
            temp = button23.Text;
            save.ShowDialog();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            temp = button22.Text;
            save.ShowDialog();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            temp = button21.Text;
            save.ShowDialog();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            temp = button20.Text;
            save.ShowDialog();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            temp = button19.Text;
            save.ShowDialog();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            temp = button18.Text;
            save.ShowDialog();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            temp = button17.Text;
            save.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            temp = button16.Text;
            save.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            temp = button15.Text;
            save.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            temp = button14.Text;
            save.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            temp = button13.Text;
            save.ShowDialog();
        }
    }
}
