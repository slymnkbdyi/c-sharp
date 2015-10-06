using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizzasiparis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Siparis SiparisHesapla()
        {
            Siparis s = new Siparis();
            s.Adet = (int)numericUpDown1.Value;
            Pizza p = new Pizza();
            p.Ebat = (PizzaEbat)comboBox1.SelectedItem;
            p.Tur = (PizzaTur)listBox1.SelectedItem;
            p.Kenar = (radioButton2.Checked) ? (KenarTur)radioButton2.Tag : (KenarTur)radioButton1.Tag;
            foreach (CheckBox item in groupBox1.Controls)
            {
                if (item.Checked)
                    p.Malzemeler.Add((PizzaMalzeme)item.Tag);
            }
            s.Pizza = p;
            peturn s;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Siparis s = SiparisHesapla();
            textBox1.Text = s.Fiyat.Tostring("C");

        }
    }
}
