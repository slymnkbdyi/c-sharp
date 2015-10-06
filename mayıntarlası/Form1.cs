﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mayıntarlası
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int skor = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MayinDoldur(10,10);
        }
        void MayinDoldur(int mayin,int boyut)
        {
            flowLayoutPanel1.Width = boyut* 30;
            flowLayoutPanel1.Height = boyut*30;
            flowLayoutPanel1.Controls.Clear();
            int[] mayinlar = new int[mayin];
            Random rnd = new Random();
            for (int i = 0; i < mayin; i++)
            {
                int secilen = rnd.Next(0, boyut * boyut);
                if (mayinlar.Contains(secilen))
                {

                    i--;
                    continue;

                }
                mayinlar[i] = secilen;


            }


            for (int i=0; i<boyut*boyut; i++)
            {
                Button btn = new Button();
                btn.Width = 30;
                btn.Height = 30;
                btn.Margin = new Padding(0);
                btn.Tag = mayinlar.Contains(i);
                btn.Click += Btn_Click;
                flowLayoutPanel1.Controls.Add(btn);
            }

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button tiklanan = (Button)sender;
            bool durum = (bool)tiklanan.Tag;
            if (durum == true)
            {
                tiklanan.BackColor = Color.Red;
               
                oyunbitir();
            }
            else
            {
                tiklanan.BackColor = Color.Yellow;
                skor++;
                label1.Text = skor.ToString();

            }
           


                }
        void oyunbitir()
        {
            skor = 0;
            foreach (Button item in flowLayoutPanel1.Controls)
            {
                bool durum = (bool)item.Tag;
               
                if (durum)
                {
                    item.BackColor = Color.Red;

                }
                else
                {

                    item.BackColor = Color.Yellow;

                }
            }
            DialogResult sonuc=MessageBox.Show("Oyun Bitti","istiyonmu",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
                MayinDoldur(10, 10);

            else
            {
                this.Close();

            }






        }
    }


}
