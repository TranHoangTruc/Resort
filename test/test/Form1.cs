using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = a + b;
            label1.Text = c.ToString();
=======
            int so1 = int.Parse(textBox1.Text);
            int so2 = int.Parse(textBox2.Text);
            int d = so1 + so2;
            label1.Text = d.ToString();
>>>>>>> feature-cal
        }
    }
}
