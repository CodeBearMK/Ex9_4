using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex9_4
{
    public partial class Form1 : Form
    {
        double amount;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(10000);
            numericUpDown1.Value = 1;
            numericUpDown2.Value = 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            amount = Convert.ToInt32(textBox1.Text) * Math.Pow((double)(1 + numericUpDown1.Value / 100), (double)numericUpDown2.Value);
            label6.Text = Math.Round(amount, 2).ToString("N2") + "元";
        }
    }
}
