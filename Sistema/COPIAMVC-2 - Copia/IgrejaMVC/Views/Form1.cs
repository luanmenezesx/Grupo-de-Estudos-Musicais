using System.Data;
using System.Text.Json;
using IgrejaMVC.Models;
using IgrejaMVC.Views;
using Org.BouncyCastle.Asn1.Crmf;
using RestSharp;


namespace IgrejaMVC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private string caminhoFoto;

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!BancoDados.ValidarCPF(txtCPF.Text))
                {
                    MessageBox.Show("CPF inválido. Verifique e tente novamente.", "CPF Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(caminhoFoto))
                {
                    MessageBox.Show("Por favor, preencha todos os campos antes de salvar.", "Campos Obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Aluno novoAluno = new Aluno
                {
                    Nome = txtNome.Text,
                    CPF = txtCPF.Text,
                    DtNascimento = txtDtNascimento.Value,
                    Instrumento = int.Parse(txtInstrumento.SelectedValue.ToString()),
                    Telefone = txtTelefone.Text,
                    Email = txtEmail.Text,
                    CEP = txtCEP.Text,
                    Endereco = txtEndereco.Text,
                    Numero = txtNumero.Text,
                    Bairro = txtBairroA.Text,
                    Cidade = txtCidade.Text,
                    Estado = txtEstado.Text,
                    EstadoCivil = txtEstadoCivil.Text,
                    FotoPerfil = ObterFotoComoByteArray(caminhoFoto)
                };

                // Inserir no banco de dados
                AlunoDAO alunoDAO = new AlunoDAO();
                bool sucesso = alunoDAO.CadastrarAluno(novoAluno);

                if (sucesso)
                {
                    MessageBox.Show("Aluno cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();

                    // **Atualiza a Home**
                    Home home = Application.OpenForms.OfType<Home>().FirstOrDefault();
                    if (home != null)
                    {
                        home.AtualizarHome();
                    }
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar o aluno.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LimparCampos()
        {
            txtNome.Text = string.Empty;
            txtCPF.Text = string.Empty;
            txtDtNascimento.Value = DateTime.Now;
            txtInstrumento.SelectedIndex = -1;
            txtTelefone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtCEP.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtNumero.Text = string.Empty;
            txtBairroA.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtEstado.Text = string.Empty;
            txtEstadoCivil.Text = string.Empty;
            pictureBox1.Image = null;

            // Resetar o caminho da foto
            caminhoFoto = null;
        }

        private byte[] ObterFotoComoByteArray(string caminho)
        {
            if (!File.Exists(caminho))
            {
                MessageBox.Show("Arquivo de foto não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return File.ReadAllBytes(caminho); // Lê todo o arquivo e retorna como array de bytes
        }



        private void btnFoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Filtrar para exibir apenas arquivos de imagem
                openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp";

                // Abrir a janela para selecionar um arquivo
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obter o caminho do arquivo escolhido
                    string caminhoArquivo = openFileDialog.FileName;

                    // Exibir a imagem no PictureBox
                    pictureBox1.Image = Image.FromFile(caminhoArquivo);

                    // (Opcional) Armazene o caminho para uso futuro, se necessário
                    caminhoFoto = caminhoArquivo;
                }
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            txtCPF.MaxLength = 11; // Define o limite máximo de 14 caractere
        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {
            txtTelefone.MaxLength = 11; // Define o limite máximo de 14 caracteres
        }

        private void txtCEP_TextChanged(object sender, EventArgs e)
        {
            if (txtCEP.Text.Length == 8) // Sem traço, só números
            {
                BuscarCep(txtCEP.Text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Alunos form = new Alunos();
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = BancoDados.PesquisarInstrumentoTotal();

            txtInstrumento.DataSource = dt;
            txtInstrumento.DisplayMember = "nome_instrumento";
            txtInstrumento.ValueMember = "id";

            txtDtInicio.Enabled = false;
            txtDtInicio.TabStop = false;
            txtDtInicio.Cursor = Cursors.Default;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnInstrumento_Click(object sender, EventArgs e)
        {
            CadastrarInstrumentos form = new CadastrarInstrumentos();
            form.Show();
            this.Close();
        }

        private void txtInstrumento_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void button6_Click(object sender, EventArgs e)
        {
            Home form = new Home();
            this.Close();
        }

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
                    txtBairroA.Text = endereco.bairro;
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

        private void txtDtInicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtDtInicio_ValueChanged_1(object sender, EventArgs e)
        {

        }
    }
}
          