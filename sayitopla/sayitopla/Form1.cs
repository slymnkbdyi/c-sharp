using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayitopla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(textBox1.Text);
            int s2 = Convert.ToInt32(textBox2.Text);
           
            decimal sonuc=0;
            switch (comboBox1.Text)
            {
                case "-": sonuc = s1 - s2;  break;  
                case "+": sonuc = s1 + s2; break;
                case "/": sonuc = s1 / s2; break;
                case "*": sonuc = s1 * s2; break;

            }
            textBox1.Text = sonuc.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
