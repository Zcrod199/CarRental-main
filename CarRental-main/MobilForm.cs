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
    public partial class MobilForm : Form
    {
        public MobilForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                // Jika kontrol adalah TextBox, kosongkan teksnya
                if (control is TextBox)
                {
                    (control as TextBox).Text = string.Empty;
                }
            }
        }
    }
    }
