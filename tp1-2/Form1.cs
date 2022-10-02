using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdvalid_Click(object sender, EventArgs e)
        {
            string nom = Convert.ToString(txtnom.Text);
            string pre = Convert.ToString(txtpre.Text);
            string sf = " ";
            if (radcel.Checked)
                sf = "Célibataire";
            if (radmar.Checked)
                sf = "Marié(e)";
            if (raddiv.Checked)
                sf = "Divorcé(e)";
            if (string.IsNullOrEmpty(txtpre.Text) || string.IsNullOrEmpty(txtnom.Text))
                MessageBox.Show("Attention : Zone Vide !!! ");
            else {
                MessageBox.Show("Vous êtes :  " + nom + " " + pre + " Vous êtes nés le : " + date.Value.ToShortDateString() + " vous étes => : " + sf + " " + " " + sexe.Text + " vous avez  " + nbenf.Value.ToString() + " enfants");
            }
            

        }

        private void txtpre_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdquit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdinit_Click(object sender, EventArgs e)
        {
            txtpre.Clear();
            txtnom.Clear();
         
            
        }
    }
}
