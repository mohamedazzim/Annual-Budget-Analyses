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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
            if (File.Exists("E:\\SAVED\\" + Form1.temp + ".txt"))
            {

                // StreamReader read = new StreamReader("E:\\SAVED\\" + Form1.temp + ".txt");
                string[] arr = File.ReadAllLines("E:\\SAVED\\" + Form1.temp + ".txt");

                //string arr =
                for (int i = 0; i < arr.Length; i++)
                {
                    listBox1.Items.Add(arr[i]);

                }

            }
            else
            {
                MessageBox.Show("File Not Found");
                Close();    
            }
            //Console.WriteLine(path + "- Existence : " + Directory.Exists(path));
            //}
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        }
    }
