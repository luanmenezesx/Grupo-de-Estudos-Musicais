using IgrejaMVC.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IgrejaMVC.Views
{
    public partial class InformacoesAlunos : Form
    {
        public InformacoesAlunos()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            txtCPF.ReadOnly = true;
            txtCPF.TabStop = false;
            txtCPF.Cursor = Cursors.No;
        }

        DataGridView gridAluno = new DataGridView();
        private string caminhoFoto;

        private void InformacoesAlunos_Load(object sender, EventArgs e)
        {
            string cpfAluno = txtCPF.Text;

            DataTable dt = BancoDados.PesquisarInstrumentoComEscolhido(cpfAluno);
            txtInstrumento.DataSource = dt;
            txtInstrumento.DisplayMember = "nome_instrumento";
            txtInstrumento.ValueMember = "id";
            txtDtCadastro.Enabled = false;
            txtDtCadastro.TabStop = false;
            txtDtCadastro.Cursor = Cursors.Default;

            int instrumentoSelecionado = BancoDados.ObterInstrumentoDoAluno(cpfAluno);
            if (instrumentoSelecionado != -1)
            {
                txtInstrumento.SelectedValue = instrumentoSelecionado;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close(); 
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            aluno.Nome = txtNome.Text;
            aluno.CPF = txtCPF.Text;
            aluno.DtNascimento = DateTime.Parse(txtDtNascimento.Text);
            aluno.Instrumento = int.Parse(txtInstrumento.SelectedValue.ToString());
            aluno.Telefone = txtTelefone.Text;
            aluno.Email = txtEmail.Text;
            aluno.CEP = txtCEP.Text;
            aluno.Endereco = txtEndereco.Text;
            aluno.Numero = txtNumero.Text;
            aluno.Bairro = txtBairro.Text;
            aluno.Cidade = txtCidade.Text;
            aluno.Estado = txtEstado.Text;
            aluno.EstadoCivil = txtEstadoCivil.Text;
            aluno.FotoPerfil = pictureBox1.Image != null ? ImageToByteArray(pictureBox1.Image) : new byte[0];

            bool success = BancoDados.AtualizarAluno(aluno);
            if (success)
            {
                MessageBox.Show("Aluno atualizado com sucesso.");

                // **Atualiza a Home**
                Home home = Application.OpenForms.OfType<Home>().FirstOrDefault();
                if (home != null)
                {
                    home.AtualizarHome();
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Ocorreu um erro ao atualizar o aluno.");
            }
        }

        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string caminhoArquivo = openFileDialog.FileName;
                    pictureBox1.Image = Image.FromFile(caminhoArquivo);
                    caminhoFoto = caminhoArquivo;
                }
            }
        }

        private void txtCEP_TextChanged(object sender, EventArgs e)
        {
            if (txtCEP.Text.Length == 8) // Sem traço, só números
            {
                BuscarCep(txtCEP.Text);
            }
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            txtCPF.MaxLength = 11;
        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {
            txtTelefone.MaxLength = 11;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Home form = new Home();
            this.Close();
        }

        private void btnInstrumento_Click(object sender, EventArgs e)
        {
            CadastrarInstrumentos form = new CadastrarInstrumentos();
            form.Show();
            this.Close();
        }

        public string Professor { get; set; }
        public string Perfil { get; set; }

        private void btnProfessores_Click(object sender, EventArgs e)
        {
            InformacoesProfessores form = new InformacoesProfessores();
            form.Professor = this.Professor;
            form.Perfil = this.Perfil;
            form.Show();
            this.Close(); 
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void txtInstrumento_SelectedIndexChanged(object sender, EventArgs e) { }
        private void txtDtCadastro_ValueChanged(object sender, EventArgs e) { }


        private void BuscarCep(string cep)
        {
            try
            {
                string url = $"https://viacep.com.br/ws/{cep}/json/";

                var client = new RestSharp.RestClient(url);
                var request = new RestSharp.RestRequest("", Method.Get);
                var response = client.Execute(request);

                if (!response.IsSuccessful)
                {
                    MessageBox.Show("Erro ao consultar o CEP.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var endereco = System.Text.Json.JsonSerializer.Deserialize<CepEndereco>(response.Content);

                if (endereco != null && endereco.cep != null)
                {
                    txtEndereco.Text = endereco.logradouro;
                    txtBairro.Text = endereco.bairro;
                    txtCidade.Text = endereco.localidade;
                    txtEstado.Text = endereco.uf;
                }
                else
                {
                    MessageBox.Show("CEP não encontrado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
