using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracTalepFormu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem satır = new ListViewItem();
            satır.Text = textBox1.Text;
            satır.SubItems.Add(comboBox1.Text);
            satır.SubItems.Add(comboBox2.Text);
            satır.SubItems.Add(textBox4.Text);
            satır.SubItems.Add(textBox5.Text);
            listView1.Items.Add(satır);

            textBox1.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;




        }

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult sonuc = MessageBox.Show("eminmisin", "siliniyor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sonuc == DialogResult.Yes)
            {

                foreach (ListViewItem satir in listView1.SelectedItems)
                {
                    listView1.Items.Remove(satir);


                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListViewItem secili = listView1.SelectedItems[0];
            textBox1.Text = secili.Text;
            comboBox1.Text = secili.SubItems[1].Text;
            comboBox2.Text = secili.SubItems[2].Text;
            textBox4.Text = secili.SubItems[3].Text;
            textBox4.Text = secili.SubItems[4].Text;

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListViewItem secili = listView1.SelectedItems[0];
            secili.Text =  textBox1.Text;
            secili.SubItems[1].Text =  comboBox1.Text;
            secili.SubItems[2].Text =  comboBox2.Text;
            secili.SubItems[3].Text =  textBox4.Text;
            secili.SubItems[4].Text  =   textBox4.Text;

        }
    }
}



