﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace toplayıp_çarptırma_ve_5_ekleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesap_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam;
            sayi1 = Convert.ToInt32(txtS1.Text);
            sayi2 = Convert.ToInt32(txtS2.Text);

            toplam = ((sayi1 + sayi2) * 2) + 5;

            MessageBox.Show("Sonucunuz: " + toplam);
        }
    }
}
