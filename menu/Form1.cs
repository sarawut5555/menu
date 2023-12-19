using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int CalculateTotal()
        {
            int Banana = 30;
            int Apple = 50;
            int total = 0;

            if(checkBox1.Checked)
            {
                total += Banana;
            }
            if (checkBox2.Checked)
            {
                total += Apple;
            }
            return total;
        }
        private string GetSelectedFoods()
        {
            List<string> selectedfoods = new List<string>();

            if (checkBox1.Checked)
            {
                selectedfoods.Add(checkBox1.Text);
            }
            if (checkBox2.Checked)
            {
                selectedfoods.Add(checkBox2.Text);
            }
            return string.Join(",", selectedfoods);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int total = CalculateTotal();
            string selectfoods = GetSelectedFoods();
            textBox1.Text = selectfoods;
            textBox2.Text = total.ToString();
        }
    }
}
