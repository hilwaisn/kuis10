using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kuis10
{
    public partial class KuisPertemuan10 : Form
    {
        public KuisPertemuan10()
        {
            InitializeComponent();
        }
        double temp1;
        double temp2;
        char oper;
        bool oper1;
        private void Form1_Load(object sender, EventArgs e)
        {
            fokus();
        }
        private void fokus()
        {
            txtHasil.Focus();
            txtHasil.Select(txtHasil.Text.Length, 1);
        }

        private void txtAngka1_TextChanged(object sender, EventArgs e)
        {
            Button btnAng = (Button)sender;
            if (txtHasil.Text == "0")
            {
                txtHasil.Clear();
            }
            if (oper == '=')
            {
                oper = ' ';
                oper1 = false;
                temp1 = 0;
            }
            txtHasil.Text = txtHasil.Text + btnAng.Text;
            fokus();
        }

        private void btnKurang_Click(object sender, EventArgs e)
        {
            temp1 = temp1 - Convert.ToDouble(temp2);
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            temp1 = temp1 + Convert.ToDouble(temp2);
        }

        private void btnBagi_Click(object sender, EventArgs e)
        {
            temp1 = temp1 / Convert.ToDouble(temp2);
        }

        private void btnKali_Click(object sender, EventArgs e)
        {
            temp1 = temp1 * Convert.ToDouble(temp2);
        }
    }
}