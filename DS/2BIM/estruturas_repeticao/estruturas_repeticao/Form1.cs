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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formTabuada = new FormTabuada();
            formTabuada.ShowDialog();

        }

        private void fatorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formFatorial = new FormFatorial();
            formFatorial.ShowDialog();
        }

        private void fibonacciToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form formFibonacci1 = new FormFibonacci();
            formFibonacci1.ShowDialog();
        }

        private void limiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formLimite = new FormLimite();
            formLimite.ShowDialog();
        }

        private void intervaloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formIntervalo = new FormIntervalo();
            formIntervalo.ShowDialog();
        }

        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DUPLA: Otávio Tarallo Squarizi e Pietro Barros dos Santos 2C1");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
