using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem satir = new ListViewItem();
            satir.Text = textBox1.Text;
            satir.SubItems.Add(textBox2.Text);
            satir.SubItems.Add(textBox3.Text);
            listView1.Items.Add(satir);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
            
        }
    }
}
