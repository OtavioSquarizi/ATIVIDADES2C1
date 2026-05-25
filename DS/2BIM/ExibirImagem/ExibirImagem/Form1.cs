using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExibirImagem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                pictureBox1.Image = null;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = checkBox1.Checked;
        }

        private void radioaImagem2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioaImagem2.Checked)
            {
                pictureBox1.ImageLocation = "imagens/logo2.png";
            }
        }

        private void radioImagem1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioImagem1.Checked)
            {
                pictureBox1.ImageLocation = "imagens/Logo_C_sharp.png";
            }
        }

        private void radioSemborda_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSemborda.Checked)
            {
                pictureBox1.BorderStyle = BorderStyle.None;
            }
        }

        private void radioFixa_CheckedChanged(object sender, EventArgs e)
        {
            if (radioFixa.Checked)
            {
                pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void radio3D_CheckedChanged(object sender, EventArgs e)
        {
            if (radio3D.Checked)
            {
                pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            }
        }

        private void sair_Click(object sender, EventArgs e)
        {

        }
    }
}
