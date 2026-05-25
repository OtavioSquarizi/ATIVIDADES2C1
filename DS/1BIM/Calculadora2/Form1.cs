using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora2
{
    public partial class Form1 : Form
    {

        string nome;

        int anos, meses, semanas, dias, horas;


        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            nome = textBox1.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("Nome: " + nome + "\n" +
            "Anos: " + anos + "\n" +
            "Meses: " + meses + "\n" +
            "Semanas: " + semanas + "\n" +
            "Dias: " + dias + "\n" +
            "Horas: " + horas,
            "Cálculo de Idade");

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            anos = Convert.ToInt32(textBox2.Text);

            meses = anos * 12 ;

            semanas = anos * 52;

            dias = anos * 365;

            horas = dias * 24;

        }
    }
}
