﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kanbankası
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            KanBagısı dn = new KanBagısı();
            dn.Show();
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            Donor dn = new Donor();
            dn.Show();
            this.Hide();


        }

        private void label3_Click(object sender, EventArgs e)
        {
          DonorListesi dn = new DonorListesi();
            dn.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Hasta dn = new Hasta();
            dn.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            HastaListesi dn = new HastaListesi();
            dn.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            KanStoğu dn = new KanStoğu();
            dn.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
           KanTransferi dn = new KanTransferi();
            dn.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            KontrolPaneli dn = new KontrolPaneli();
            dn.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();

        }
    }
}
