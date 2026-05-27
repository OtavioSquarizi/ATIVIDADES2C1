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
    public partial class FormFatorial : Form
    {
        public FormFatorial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero;
            int fatorial = 1;
            string conta = "";

            numero = Convert.ToInt32(textBox1.Text);

            if (numero == 0)
            {
                MessageBox.Show("0! = 1");
            }
            else
            {
                for (int i = 1; i <= numero; i++)
                {
                    fatorial = fatorial * i;

                    if (i == 1)
                    {
                        conta = i.ToString();
                    }
                    else
                    {
                        conta = conta + " * " + i;
                    }
                }

                MessageBox.Show(numero + "! = " + fatorial + " (" + conta + ")");
            }
        }

        private void FormFatorial_Load(object sender, EventArgs e)
        {

        }
    }
}
