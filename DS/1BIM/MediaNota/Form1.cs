using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaNota

{
    public partial class Form1 : Form
    {
        string nome;
        float nota1, nota2, nota3, media;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Nome_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            nome = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
             nota1 = float.Parse(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
             nota2 = float.Parse(textBox3.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            nota3 = float.Parse(textBox4.Text);
        }

         private void button1_Click(object sender, EventArgs e)
        {
            media = (nota1 + nota2 + nota3)/3;
            MessageBox.Show("Seu nome é " + nome + " e a média das notas é " + media);

        }
    }
}
