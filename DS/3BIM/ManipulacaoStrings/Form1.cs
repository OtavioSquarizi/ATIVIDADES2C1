using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipulacaoStrings
{
    public partial class ManipulacaoStrings : Form
    {
        public ManipulacaoStrings()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnInverter_Click(object sender, EventArgs e)
        {
            string frase = txtFrase.Text;

            string invertida = "";

            for (int i = frase.Length - 1; i >= 0; i--)
            {
                invertida = invertida + frase[i];
            }

            lblInvertido.Text = invertida;
        }

        private void btnPalindromo_Click(object sender, EventArgs e)
        {
            string frase = txtFrase.Text;

            frase = frase.Replace(" ", "");
            frase = frase.ToLower();

            string invertida = "";

            for (int i = frase.Length - 1; i >= 0; i--)
            {
                invertida = invertida + frase[i];
            }

            if (frase == invertida)
            {
                MessageBox.Show("É um palíndromo!");
            }
            else
            {
                MessageBox.Show("Não é um palíndromo!");
            }
        }

        private void btnLetra_Click(object sender, EventArgs e)
        {
            string frase = txtFrase.Text;

            lstLetras.Items.Clear();

            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] != ' ')
                {
                    lstLetras.Items.Add(frase[i]);
                }
            }
        }

        private void btnFrases_Click(object sender, EventArgs e)
        {
            string frase = txtFrase.Text;

            lstFrases.Items.Clear();

            int inicio = 0;

            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == ' ')
                {
                    string palavra = frase.Substring(inicio, i - inicio);

                    lstFrases.Items.Add(palavra);

                    inicio = i + 1;
                }
            }

            if (inicio < frase.Length)
            {
                string palavra = frase.Substring(inicio);

                lstFrases.Items.Add(palavra);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtFrase.Clear();

            lblInvertido.Text = "";

            lstLetras.Items.Clear();

            lstFrases.Items.Clear();

            txtFrase.Focus();
        }

        private void btnTamanho_Click(object sender, EventArgs e)
        {
            int tamanho = txtFrase.Text.Length;

            MessageBox.Show("caracteres: " + tamanho);
        }

        private void btnVogais_Click(object sender, EventArgs e)
        {
            string frase = txtFrase.Text.ToLower();

            int a = 0;
            int e1 = 0;
            int i1 = 0;
            int o = 0;
            int u = 0;

            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == 'a')
                {
                    a++;
                }

                if (frase[i] == 'e')
                {
                    e1++;
                }

                if (frase[i] == 'i')
                {
                    i1++;
                }

                if (frase[i] == 'o')
                {
                    o++;
                }

                if (frase[i] == 'u')
                {
                    u++;
                }
            }

            lblA.Text = a.ToString();
            lblE.Text = e1.ToString();
            lblI.Text = i1.ToString();
            lblO.Text = o.ToString();
            lblU.Text = u.ToString();
        }

        private void btnEspacos_Click(object sender, EventArgs e)
        {
            string frase = txtFrase.Text;

            string semEspacos = frase.Replace(" ", "");

            lblEspaco.Text = semEspacos;
        }
    }
}
