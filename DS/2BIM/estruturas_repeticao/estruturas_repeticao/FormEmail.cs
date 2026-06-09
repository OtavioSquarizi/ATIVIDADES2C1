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
    public partial class FormEmail : Form
    {
        public FormEmail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;

            int posicao = email.IndexOf("@");

            if (posicao >= 0)
            {
                string usuario = email.Substring(0, posicao);

                string provedor = email.Substring(posicao + 1);

                MessageBox.Show(
                    "Posição do @: " + posicao +
                    "\nUsuário: " + usuario +
                    "\nCaracteres do usuário: " + usuario.Length +
                    "\nProvedor: " + provedor
                );
            }
            else
            {
                MessageBox.Show("Digite um email válido!");
            }
        }
    }
}
