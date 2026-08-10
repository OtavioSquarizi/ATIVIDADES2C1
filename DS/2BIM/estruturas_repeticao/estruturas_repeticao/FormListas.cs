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
    public partial class FormListas : Form
    {
        public FormListas()
        {
            InitializeComponent();
        }

        private void FormListas_Load(object sender, EventArgs e)
        {
           
            listBox1.Items.Add("Ferrari");
            listBox1.Items.Add("Mclaren");
            listBox1.Items.Add("RedBull");
            listBox1.Items.Add("Williams");
            listBox1.Items.Add("Mercedes");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox2.Items.Add(listBox1.SelectedItem);

                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                listBox1.Items.Add(listBox2.SelectedItem);

                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            while (listBox1.Items.Count > 0)
            {
                listBox2.Items.Add(listBox1.Items[0]);

                listBox1.Items.RemoveAt(0);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            while (listBox2.Items.Count > 0)
            {
                listBox1.Items.Add(listBox2.Items[0]);

                listBox2.Items.RemoveAt(0);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Sorted = true;
            listBox2.Sorted = true;

        }
    }
}
