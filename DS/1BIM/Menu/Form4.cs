using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int A = int.Parse(textBox1.Text);
            int B = int.Parse(textBox2.Text);
            int C = int.Parse(textBox3.Text);

            if (A < B + C && B < A + C && C < A + B)
            {
                if (A == B && B == C)
                {
                    lblResultado.Text = "TRIÂNGULO EQUILÁTERO";
                    picImagem.ImageLocation = "imagens/equilatero.png";
                }
                else if (A != B && B != C && A != C)
                {
                    lblResultado.Text = "TRIÂNGULO ESCALENO";
                    picImagem.ImageLocation = "imagens/escaleno.jpeg";
                }
                else
                {
                    lblResultado.Text = "TRIÂNGULO ISÓSCELES";
                    picImagem.ImageLocation = "imagens/isosceles.png";
                }
            }
            else
            {
                lblResultado.Text = "NÃO É TRIÂNGULO";
                picImagem.Image = null;
            }
        }

        private void picImagem_Click(object sender, EventArgs e)
        {

        }
    }
}
