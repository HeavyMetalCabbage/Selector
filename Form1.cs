using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Selector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = " Add";
            Spin.Text = "Spin";
        }

        //Create the list to contain objects added
        List<string> list = new List<string>();


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox1.Text) == true)
            {
                MessageBox.Show("Please enter a valid string");
                textBox1.Clear();
            }

            else
            {
                listBox1.Items.Add(textBox1.Text);
                list.Add(textBox1.Text);
                textBox1.Clear();
            }

        }
        //Select from the list
        private void Spin_Click_1(object sender, EventArgs e)
        {
            Random random = new Random();

            int num = random.Next(list.Count());

            MessageBox.Show("You have spun: " + list[num]);
        }
    }
}
