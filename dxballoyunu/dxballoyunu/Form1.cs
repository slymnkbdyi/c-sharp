using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dxballoyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x = 1;
        int y = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            radioButton1.Left +=x;
            radioButton1.Top +=y;

            if(radioButton1.Left <=0 || radioButton1.Right >=this.ClientSize.Width)
            {
                x *= -1;
            }

            // clientsize formun cerceve haric yükselkigi yada genisligini verir
            if (radioButton1.Top <= 0 || radioButton1.Bottom >= this.ClientSize.Height)
            {
                y *= -1;
            }












        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
