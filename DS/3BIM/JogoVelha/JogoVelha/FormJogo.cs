using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoVelha
{
   
    public partial class FormJogo : Form
    {
        int jogador1;
        int jogador2;
        int jogadorAtual = 1;
        public FormJogo(int p1, int p2)
        {
            InitializeComponent();

            jogador1 = p1;
            jogador2 = p2;

            AtualizarVez();
        }
        void AtualizarVez()
        {
            if (jogadorAtual == 1)
            {
                if (jogador1 == 1)
                    picVez.Image = Properties.Resources.clotildepfp;
                else if (jogador1 == 2)
                    picVez.Image = Properties.Resources.cleidepfp;
                else if (jogador1 == 3)
                    picVez.Image = Properties.Resources.beneditapfp;
                else if (jogador1 == 4)
                    picVez.Image = Properties.Resources.matildepfp;
            }
            else
            {
                if (jogador2 == 1)
                    picVez.Image = Properties.Resources.clotildepfp;
                else if (jogador2 == 2)
                    picVez.Image = Properties.Resources.cleidepfp;
                else if (jogador2 == 3)
                    picVez.Image = Properties.Resources.beneditapfp;
                else if (jogador2 == 4)
                    picVez.Image = Properties.Resources.matildepfp;
            }

            picVez.SizeMode = PictureBoxSizeMode.Zoom;
        }
        void Jogar(Button botao)
        {
            if (jogadorAtual == 1)
            {
                if (jogador1 == 1)
                    botao.BackColor = Color.Blue;
                else if (jogador1 == 2)
                    botao.BackColor = Color.Red;
                else if (jogador1 == 3)
                    botao.BackColor = Color.Green;
                else if (jogador1 == 4)
                    botao.BackColor = Color.Yellow;

                jogadorAtual = 2;
            }
            else
            {
                if (jogador2 == 1)
                    botao.BackColor = Color.Blue;
                else if (jogador2 == 2)
                    botao.BackColor = Color.Red;
                else if (jogador2 == 3)
                    botao.BackColor = Color.Green;
                else if (jogador2 == 4)
                    botao.BackColor = Color.Yellow;

                jogadorAtual = 1;
            }

            botao.Enabled = false;

            AtualizarVez();

            VerificarVitoria();
        }

        void VerificarVitoria()
        {
            // linhaa 1 //
            if (!btn1.Enabled && !btn2.Enabled && !btn3.Enabled)
            {
                if (btn1.BackColor == btn2.BackColor &&
                    btn2.BackColor == btn3.BackColor)
                {
                    MessageBox.Show("Temos um vencedor!");
                }
            }

            // linha 2 //
            if (!btn4.Enabled && !btn5.Enabled && !btn6.Enabled)
            {
                if (btn4.BackColor == btn5.BackColor &&
                    btn5.BackColor == btn6.BackColor)
                {
                    MessageBox.Show("Temos um vencedor!");
                }
            }

            // linha3 //
            if (!btn7.Enabled && !btn8.Enabled && !btn9.Enabled)
            {
                if (btn7.BackColor == btn8.BackColor &&
                    btn8.BackColor == btn9.BackColor)
                {
                    MessageBox.Show("Temos um vencedor!");
                }
            }
            // col 1 //
            if (!btn1.Enabled && !btn4.Enabled && !btn7.Enabled)
            {
                if (btn1.BackColor == btn4.BackColor &&
                    btn4.BackColor == btn7.BackColor)
                {
                    MessageBox.Show("Temos um vencedor!");
                }
            }

            // col 2 //
            if (!btn2.Enabled && !btn5.Enabled && !btn8.Enabled)
            {
                if (btn2.BackColor == btn5.BackColor &&
                    btn5.BackColor == btn8.BackColor)
                {
                    MessageBox.Show("Temos um vencedor!");
                }
            }

            // col 3 //
            if (!btn3.Enabled && !btn6.Enabled && !btn9.Enabled)
            {
                if (btn3.BackColor == btn6.BackColor &&
                    btn6.BackColor == btn9.BackColor)
                {
                    MessageBox.Show("Temos um vencedor!");
                }
            }

            // diag 1 //
            if (!btn1.Enabled && !btn5.Enabled && !btn9.Enabled)
            {
                if (btn1.BackColor == btn5.BackColor &&
                    btn5.BackColor == btn9.BackColor)
                {
                    MessageBox.Show("Temos um vencedor!");
                }
            }

            // diag 2 //
            if (!btn3.Enabled && !btn5.Enabled && !btn7.Enabled)
            {
                if (btn3.BackColor == btn5.BackColor &&
                    btn5.BackColor == btn7.BackColor)
                {
                    MessageBox.Show("Temos um vencedor!");
                }
            }

            //velha//
            if (!btn1.Enabled && !btn2.Enabled && !btn3.Enabled &&
                !btn4.Enabled && !btn5.Enabled && !btn6.Enabled &&
                !btn7.Enabled && !btn8.Enabled && !btn9.Enabled)
            {
                MessageBox.Show("Deu velha!");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Jogar(btn1);
        }

        private void picVez_Click(object sender, EventArgs e)
        {

        }

        private void lblVez_Click(object sender, EventArgs e)
        {
           
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Jogar(btn2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Jogar(btn3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Jogar(btn4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Jogar(btn5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Jogar(btn6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Jogar(btn7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Jogar(btn8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Jogar(btn9);
        }

        private void FormJogo_Load(object sender, EventArgs e)
        {

        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            jogadorAtual = 1;

            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            btn1.BackColor = SystemColors.Control;
            btn2.BackColor = SystemColors.Control;
            btn3.BackColor = SystemColors.Control;
            btn4.BackColor = SystemColors.Control;
            btn5.BackColor = SystemColors.Control;
            btn6.BackColor = SystemColors.Control;
            btn7.BackColor = SystemColors.Control;
            btn8.BackColor = SystemColors.Control;
            btn9.BackColor = SystemColors.Control;

            AtualizarVez();
        }
    }
}
