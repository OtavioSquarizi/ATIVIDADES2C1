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
    public partial class FormVertical : Form
    {
        public FormVertical()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            string texto = textBox1.Text;

            for (int i = 0; i < texto.Length; i++)
            {
                listBox1.Items.Add(texto[i]);
            }
        }
    }
}
