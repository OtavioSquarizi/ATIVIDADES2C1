using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Selecione
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vermelho = 0;
            double verde = 0;
            double amarelo = 0;
            double azul = 0;

            // -------------------------
            // Parte 1 (RadioButtons)
            // -------------------------

            // Pergunta 1
            if (rbP1_A.Checked) vermelho++;
            if (rbP1_B.Checked) verde++;
            if (rbP1_C.Checked) amarelo++;
            if (rbP1_D.Checked) azul++;

            // Pergunta 2
            if (rbP2_A.Checked) vermelho++;
            if (rbP2_B.Checked) verde++;
            if (rbP2_C.Checked) amarelo++;
            if (rbP2_D.Checked) azul++;

            // Pergunta 3
            if (rbP3_A.Checked) vermelho++;
            if (rbP3_B.Checked) verde++;
            if (rbP3_C.Checked) amarelo++;
            if (rbP3_D.Checked) azul++;

            // -------------------------
            // Parte 2 (CheckBox - peso 0.5)
            // -------------------------

            // Pergunta 4
            if (cbP4_A.Checked) vermelho += 0.5;
            if (cbP4_B.Checked) verde += 0.5;
            if (cbP4_C.Checked) amarelo += 0.5;
            if (cbP4_D.Checked) azul += 0.5;

            // Pergunta 5
            if (cbP5_A.Checked) vermelho += 0.5;
            if (cbP5_B.Checked) verde += 0.5;
            if (cbP5_C.Checked) amarelo += 0.5;
            if (cbP5_D.Checked) azul += 0.5;

            // Pergunta 6
            if (cbP6_A.Checked) vermelho += 0.5;
            if (cbP6_B.Checked) verde += 0.5;
            if (cbP6_C.Checked) amarelo += 0.5;
            if (cbP6_D.Checked) azul += 0.5;

            // -------------------------
            // Resultado
            // -------------------------

            double max = Math.Max(Math.Max(vermelho, verde), Math.Max(amarelo, azul));

            string resultado = "";

            if (vermelho == max)
            {
                resultado += "🔴 Vermelho\nPerfil dominante, competitivo, direto e focado em resultados.\n\n";
            }

            if (verde == max)
            {
                resultado += "🟢 Verde\nPerfil calmo, paciente, cooperativo e confiável.\n\n";
            }

            if (amarelo == max)
            {
                resultado += "🟡 Amarelo\nPerfil comunicativo, criativo, entusiasmado e sociável.\n\n";
            }

            if (azul == max)
            {
                resultado += "🔵 Azul\nPerfil analítico, detalhista, organizado e orientado a dados.\n\n";
            }

            // -------------------------
            // Exibir MessageBox
            // -------------------------

            MessageBox.Show(
                "Resultado do Quiz:\n\n" + resultado,
                "Seu Perfil",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
