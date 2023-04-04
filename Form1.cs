using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace tema1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set up label1
            label1.Text = "Enter a string and a regex pattern:";
            label1.Location = new System.Drawing.Point(12, 9);
            label1.AutoSize = true;
            this.Controls.Add(label1);

            // Set up textBox1
            textBox1.Location = new System.Drawing.Point(15, 35);
            textBox1.Size = new System.Drawing.Size(250, 20);
            this.Controls.Add(textBox1);

            // Set up textBox2
            textBox2.Location = new System.Drawing.Point(15, 61);
            textBox2.Size = new System.Drawing.Size(250, 20);
            this.Controls.Add(textBox2);

            // Set up button1
            button1.Text = "Check";
            button1.Location = new System.Drawing.Point(15, 87);
            button1.Size = new System.Drawing.Size(75, 23);
            button1.Click += new System.EventHandler(this.Button1_Click);
            this.Controls.Add(button1);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            string pattern = textBox2.Text;
            Regex regex = new Regex(pattern);

            if (regex.IsMatch(input))
            {
                label1.Text = "The string matches the pattern.";
            }
            else
            {
                label1.Text = "The string does not match the pattern.";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
