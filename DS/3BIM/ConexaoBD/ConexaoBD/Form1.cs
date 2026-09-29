using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ConexaoBD
{
    public partial class Form1 : Form
    {
        int pos, codigo;

        SqlConnection conecta = new SqlConnection(
            @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Empresa;Integrated Security=True");

        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        DataTable ds = new DataTable("Funcionarios");
        public Form1()
        {
            InitializeComponent();
        }

        private void carrega_dados()
        {
            cmd.CommandText = "select * from Funcionarios";
            dr = cmd.ExecuteReader();
            ds.Clear();
            ds.Load(dr);
            pos = 0;
            dvgFuncionarios.DataSource = ds;
        }

        private void navega()
        {
            txtCodigo.Text = Convert.ToString(ds.Rows[pos]["CodFun"]);
            txtNome.Text = Convert.ToString(ds.Rows[pos]["Nome"]);
            txtSobrenome.Text = Convert.ToString(ds.Rows[pos]["Sobrenome"]);
            txtCargo.Text = Convert.ToString(ds.Rows[pos]["Cargo"]);
            txtCidade.Text = Convert.ToString(ds.Rows[pos]["Cidade"]);
            txtTelefone.Text = Convert.ToString(ds.Rows[pos]["Fone"]);
            txtSalario.Text = Convert.ToString(ds.Rows[pos]["Salario"]);
        }

        private void botoes(Boolean ativar)
        {
            btnPrimeiro.Enabled = ativar;
            btnUltimo.Enabled = ativar;
            btnAnterior.Enabled = ativar;
            btnProximo.Enabled = ativar;

            btnNovo.Enabled = ativar;
            btnGravar.Enabled = !ativar;
            btnEditar.Enabled = ativar;
            btnExcluir.Enabled = ativar;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dvgFuncionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conecta;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "insert into Funcionarios " +
                "(Nome, Sobrenome, Cargo, Cidade, Fone, Salario) " +
                "Values (@Nome, @Sobrenome, @Cargo, @Cidade, @Fone, @Salario)";

            cmd.Parameters.Add(new SqlParameter("@Nome", txtNome.Text));
            cmd.Parameters.Add(new SqlParameter("@Sobrenome", txtSobrenome.Text));
            cmd.Parameters.Add(new SqlParameter("@Cargo", txtCargo.Text));
            cmd.Parameters.Add(new SqlParameter("@Cidade", txtCidade.Text));
            cmd.Parameters.Add(new SqlParameter("@Fone", txtTelefone.Text));
            cmd.Parameters.Add(new SqlParameter("@Salario", txtSalario.Text));

            cmd.ExecuteNonQuery();

            MessageBox.Show("Dados cadastrados com sucesso", "Inclusão");

            carrega_dados();
            navega();
            botoes(true);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            botoes(true);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conecta;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText =
                "update Funcionarios set " +
                "Nome=@Nome, " +
                "Sobrenome=@Sobrenome, " +
                "Cargo=@Cargo, " +
                "Cidade=@Cidade, " +
                "Fone=@Fone, " +
                "Salario=@Salario " +
                "where CodFun=@CodFun";

            cmd.Parameters.AddWithValue("@CodFun", txtCodigo.Text);
            cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@Sobrenome", txtSobrenome.Text);
            cmd.Parameters.AddWithValue("@Cargo", txtCargo.Text);
            cmd.Parameters.AddWithValue("@Cidade", txtCidade.Text);
            cmd.Parameters.AddWithValue("@Fone", txtTelefone.Text);
            cmd.Parameters.AddWithValue("@Salario", txtSalario.Text);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Dados atualizados com sucesso", "Atualização");

            carrega_dados();
            navega();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conecta;
            cmd.CommandType = CommandType.Text;

            if (MessageBox.Show("Tem certeza que deseja excluir este registro?",
                "Exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cmd.CommandText = "delete from Funcionarios where CodFun = @CodFun";

                cmd.Parameters.Add(new SqlParameter("@CodFun", this.txtCodigo.Text));

                cmd.ExecuteNonQuery();

                carrega_dados();
                navega();
                botoes(true);
            }
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            pos = 0;
            navega();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (pos > 0)
            {
                pos--;
                navega();
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (pos < ds.Rows.Count - 1)
            {
                pos++;
                navega();
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            pos = ds.Rows.Count - 1;
            navega();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (ds.Rows.Count <= 0)
            {
                txtCodigo.Text = Convert.ToString("1");
            }
            else
            {
                codigo = Convert.ToInt32(ds.Rows[ds.Rows.Count - 1]["CodFun"]);

                txtNome.Clear();
                txtSobrenome.Clear();
                txtCargo.Clear();
                txtCidade.Clear();
                txtTelefone.Clear();
                txtSalario.Clear();

                txtCodigo.Text = Convert.ToString(codigo + 1);
                txtNome.Focus();
            }

            botoes(false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conecta.Open();

            cmd.Connection = conecta;

            try
            {
                MessageBox.Show("A conexão foi obtida com sucesso.");
            }
            catch
            {
                MessageBox.Show("Não foi possível obter a conexão. Veja o log de erros.");
            }

            cmd.CommandType = CommandType.Text;

            carrega_dados();

            if (ds.Rows.Count <= 0)
            {
                MessageBox.Show("Tabela sem registros, cadastre um ", "Tabela Vazia");
            }
            else
            {
                navega();
                // label4.Text = Convert.ToString(ds.Rows.Count);
            }
        }
    }
}
