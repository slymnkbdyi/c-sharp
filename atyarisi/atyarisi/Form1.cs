    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.Media;

    namespace atyarisi
    {
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
            }

            private void button1_Click(object sender, EventArgs e)
            {
                timer1.Start();
                SoundPlayer sesci = new SoundPlayer();
                sesci.SoundLocation = hm.wav;
                sesci.Play();
                AtDurumDegistir(true, pictureBox1);
            }
            Random rnd = new Random();
            private void timer1_Tick(object sender, EventArgs e)
            {
                pictureBox1.Left += rnd.Next(1, 5);
                pictureBox2.Left += rnd.Next(1, 5);
                pictureBox3.Left += rnd.Next(1, 5);

                AtKontrol(pictureBox1);
                AtKontrol(pictureBox2);
                AtKontrol(pictureBox3);

            }
            void AtKontrol(PictureBox at)
            {
                if(at.Right>label1.Left)
                {
                    timer1.Stop();
                    AtDurumDegistir(false, at);
                    MessageBox.Show(at.Name+ "kazandı");

                }

            }

            void AtDurumDegistir(bool durum, PictureBox kazanan)
            {
                pictureBox1.Enabled = pictureBox2.Enabled = pictureBox3.Enabled = durum;
                kazanan.Enabled = true;


            }












        }
    }
