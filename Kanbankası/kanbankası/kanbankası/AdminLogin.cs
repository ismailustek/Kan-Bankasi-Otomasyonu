using System;
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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (AdminSifreTb.Text == "") 
            {
                MessageBox.Show("Admin Şifreni Giriniz");
            }else if (AdminSifreTb.Text == "1234")
            {
                Calisan cal=new Calisan();
                cal.Show();
                this.Hide();

            }
            else 
            {
                MessageBox.Show("Yanlış şifre");
                AdminSifreTb.Text = "";
            }
               
        }
    }
}
