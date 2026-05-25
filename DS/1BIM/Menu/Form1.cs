namespace Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 tela = new Form2();
            tela.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 tela = new Form3();
            tela.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 tela = new Form4();
            tela.Show();
        }
    }
}
