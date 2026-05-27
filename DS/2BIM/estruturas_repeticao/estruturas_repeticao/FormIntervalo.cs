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
    public partial class FormIntervalo : Form
    {
        public FormIntervalo()
        {
            InitializeComponent();
        }

        private void FormIntervalo_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int inicio;
            int fim;
            int incremento;

            inicio = Convert.ToInt32(textBox1.Text);
            fim = Convert.ToInt32(textBox2.Text);
            incremento = Convert.ToInt32(textBox3.Text);

            for (int i = inicio; i <= fim; i = i + incremento)
            {
                listBox1.Items.Add(i);
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
