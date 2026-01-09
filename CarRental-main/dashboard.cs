using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental_main
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PelangganForm pelanggan = new PelangganForm();

            // Menampilkan Form2
            pelanggan.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PelangganForm pelanggan = new PelangganForm();

            // Menampilkan Form2
            pelanggan.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            RentalForm rental = new RentalForm();

            // Menampilkan Form2
            rental.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MobilForm Mobil = new MobilForm();

            // Menampilkan Form2
            Mobil.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            KaryawanForm karyawan = new KaryawanForm();

            // Menampilkan Form2
            karyawan.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            
        }
    }
}
