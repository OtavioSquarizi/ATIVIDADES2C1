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
    public partial class FormFibonacci : Form
    {
        public FormFibonacci()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int n1 = 0;
            int n2 = 1;
            int prox;

            listBox1.Items.Add(n1);
            listBox1.Items.Add(n2);

            for (int i = 0; i < 10; i++)
            {
                prox = n1 + n2;

                listBox1.Items.Add(prox);

                n1 = n2;
                n2 = prox;
            }
        }

        private void FormFibonacci_Load(object sender, EventArgs e)
        {

        }
    }
}
