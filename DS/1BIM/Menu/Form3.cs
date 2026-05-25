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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int lados = int.Parse(textBox1.Text);
            float medida = float.Parse(textBox2.Text);

            if (lados < 3)
            {
                lblResultado.Text = "NÃO É POLÍGONO";
            }
            else if (lados == 3)
            {
                float area = (medida * medida) / 2;
                lblResultado.Text = "TRIÂNGULO - Área: " + area;
            }
            else if (lados == 4)
            {
                float area = medida * medida;
                lblResultado.Text = "QUADRADO - Área: " + area;
            }
            else if (lados == 5)
            {
                lblResultado.Text = "PENTÁGONO";
            }
            else
            {
                lblResultado.Text = "POLÍGONO NÃO IDENTIFICADO";
            }
        }
    }
}
