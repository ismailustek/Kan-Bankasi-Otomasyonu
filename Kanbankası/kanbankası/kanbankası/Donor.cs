using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace kanbankası
{
    public partial class Donor : Form
    {
        public Donor()
        {
            InitializeComponent();
        }
        SqlConnection baglanti= new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer\Documents\KanBankasiDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void Reset()
        {
            DAdSoyadTb.Text = "";
            DYasTb.Text = "";
            DCinsCb.SelectedIndex = -1;
            DTelefonTb.Text = "";
            DAdresTb.Text = "";
            DKGrupCb.SelectedIndex = -1;
        }
        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (DAdSoyadTb.Text == "" || DYasTb.Text == "" || DCinsCb.SelectedIndex == -1 || DTelefonTb.Text == "" || DKGrupCb.SelectedIndex == -1 || DAdresTb.Text == "") 
            {
                MessageBox.Show("Eksik Bilgi");

            }
            else
            {
                try 
                { 
                    string query="insert into DonorTbl values('"+DAdSoyadTb.Text+"',"+DYasTb.Text+",'" +DCinsCb.SelectedItem.ToString() + "','" +DTelefonTb.Text + "','" + DAdresTb.Text + "','" + DKGrupCb.SelectedItem.ToString() + "')";
                    baglanti.Open();
                    SqlCommand komut =new SqlCommand(query,baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Donor Başarıyla Kaydedildi ");
                    baglanti.Close();
                    Reset();
                }
                catch(Exception ex) 
                {
                    MessageBox.Show("Ex.Message");
                }


            }
        }

        private void Donor_Load(object sender, EventArgs e)
        {

        }

        private void DAdSoyadTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void DYasTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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

        private void label17_Click(object sender, EventArgs e)
        {
            KanBagısı dn = new KanBagısı();
            dn.Show();
            this.Hide();
        }
    }
}
