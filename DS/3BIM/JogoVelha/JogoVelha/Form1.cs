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
    public partial class FormMenu : Form
    {
        int jogador1 = 0;
        int jogador2 = 0;
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnAzul_Click(object sender, EventArgs e)
        {
            if (jogador1 == 0)
            {
                jogador1 = 1;
                picP1.Image = Properties.Resources.clotilde;
                picP1.SizeMode = PictureBoxSizeMode.Zoom;

                btnAzul.Enabled = false;
            }
            else if (jogador2 == 0)
            {
                jogador2 = 1;
                picP2.Image = Properties.Resources.clotilde;
                picP2.SizeMode = PictureBoxSizeMode.Zoom;

                btnAzul.Enabled = false;
            }
        }

        private void btnVerm_Click(object sender, EventArgs e)
        {
            if (jogador1 == 0)
            {
                jogador1 = 2;
                picP1.Image = Properties.Resources.cleide;
                picP1.SizeMode = PictureBoxSizeMode.Zoom;

                btnVerm.Enabled = false;
            }
            else if (jogador2 == 0)
            {
                jogador2 = 2;
                picP2.Image = Properties.Resources.cleide;
                picP2.SizeMode = PictureBoxSizeMode.Zoom;

                btnVerm.Enabled = false;
            }
        }

        private void btnVerd_Click(object sender, EventArgs e)
        {
            if (jogador1 == 0)
            {
                jogador1 = 3;
                picP1.Image = Properties.Resources.benedita;
                picP1.SizeMode = PictureBoxSizeMode.Zoom;

                btnVerd.Enabled = false;
            }
            else if (jogador2 == 0)
            {
                jogador2 = 3;
                picP2.Image = Properties.Resources.benedita;
                picP2.SizeMode = PictureBoxSizeMode.Zoom;

                btnVerd.Enabled = false;
            }
        }

        private void btnAmar_Click(object sender, EventArgs e)
        {
            if (jogador1 == 0)
            {
                jogador1 = 4;
                picP1.Image = Properties.Resources.matilde;
                picP1.SizeMode = PictureBoxSizeMode.Zoom;

                btnAmar.Enabled = false;
            }
            else if (jogador2 == 0)
            {
                jogador2 = 4;
                picP2.Image = Properties.Resources.matilde;
                picP2.SizeMode = PictureBoxSizeMode.Zoom;

                btnAmar.Enabled = false;
            }
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            if (jogador1 == 0 || jogador2 == 0)
            {
                MessageBox.Show("Os jogadores precisam escolher uma velha!");
            }
            else
            {
                FormJogo jogo = new FormJogo(jogador1, jogador2);
                jogo.Show();
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
