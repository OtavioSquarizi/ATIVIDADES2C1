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

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dupla: Otávio Tarallo Squarizi e Pietro Barros dos Santos 2C1");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formTabuada = new FormTabuada();
            formTabuada.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form formFatorial = new FormFatorial();
            formFatorial.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formFibonacci = new FormFibonacci();
            formFibonacci.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form formLimite = new FormLimite();
            formLimite.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formIntervalo = new FormIntervalo();
            formIntervalo.ShowDialog();
        }
    }
}
