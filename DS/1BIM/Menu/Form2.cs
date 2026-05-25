using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = int.Parse(textBox3.Text);

            int d;

            if (a < b)
            {
                d = a;
                a = b;
                b = d;
            }

            if (a < c)
            {
                d = a;
                a = c;
                c = d;
            }

            if (b < c)
            {
                d = b;
                b = c;
                c = d;
            }
            MessageBox.Show(a + " , " + b + " , " + c);
        }
    }
}
