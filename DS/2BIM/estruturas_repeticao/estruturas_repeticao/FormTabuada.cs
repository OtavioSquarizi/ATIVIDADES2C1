using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estruturas_repeticao
{
    public partial class FormTabuada : Form
    {
        public FormTabuada()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int numero;

            numero = Convert.ToInt32(textBox1.Text);

            for (int i = 0; i <= 10; i++)
            {
                listBox1.Items.Add(numero + " x " + i + " = " + (numero * i));
            }
        }

        private void FormTabuada_Load(object sender, EventArgs e)
        {

        }
    }

}

