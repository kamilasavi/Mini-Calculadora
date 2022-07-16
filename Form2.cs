using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Calculadora
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void txbVisor_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + 1;
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + 2;
        }
    }
}
