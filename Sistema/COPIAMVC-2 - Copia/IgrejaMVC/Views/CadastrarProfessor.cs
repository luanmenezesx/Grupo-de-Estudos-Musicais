using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace IgrejaMVC.Views
{
    public partial class CadastrarProfessor : Form
    {
        // String de conexão com MySQL (coloque aqui em cima mesmo, se preferir)
        public static string connectionString = ConfigurationManager.AppSettings["conexao"];

        public CadastrarProfessor()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnCadastrarprof_Click(object sender, EventArgs e)
        {
            string nome = txtCadNomeProfessor.Text;
            string senha = txtCadSenhaProfessor.Text;
            string confirmaSenha = textRepitaSenha.Text;
            string perfil = cmbPerfil.Text;
            string senhaChave = txtSenhaChave.Text;

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(senha) || string.IsNullOrWhiteSpace(confirmaSenha))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            if (senha != confirmaSenha)
            {
                MessageBox.Show("As senhas não coincidem. Tente novamente.");
                return;
            }

            // Validação de senha-chave para administrador
            if (perfil == "Administrador")
            {
                if (string.IsNullOrWhiteSpace(senhaChave) || senhaChave != "1234")
                {
                    MessageBox.Show("Você não pode ser administrador.");
                    return;
                }
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // Verifica se já existe um professor com o mesmo nome e senha
                string checkQuery = "SELECT COUNT(*) FROM Professores WHERE Nome_professor = @Nome AND Senha_professor = @Senha";
                using (MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@Nome", nome);
                    checkCommand.Parameters.AddWithValue("@Senha", senha);

                    try
                    {
                        connection.Open();
                        int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Credenciais já cadastradas");
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao verificar duplicidade: " + ex.Message);
                        return;
                    }
                }

                // Agora faz o INSERT
                string query = "INSERT INTO Professores (Nome_professor, Senha_professor, perfil_professor) VALUES (@Nome, @Senha, @Perfil)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nome", nome);
                    command.Parameters.AddWithValue("@Senha", senha);
                    command.Parameters.AddWithValue("@Perfil", perfil);

                    try
                    {
                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            if (perfil == "Administrador")
                            {
                                MessageBox.Show("Seja bem-vindo, Administrador!");
                            }
                            else
                            {
                                MessageBox.Show("Seja bem-vindo, Professor!");
                            }

                            Login loginForm = new Login();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao cadastrar professor.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }
                }
            }
        }



        private void CadastrarProfessor_Load(object sender, EventArgs e)
        {
            txtSenhaChave.Visible = false; // Campo oculto por padrão
            cmbPerfil.SelectedItem = "Professor";

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSenhaChave_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            if (cmbPerfil.SelectedItem != null && cmbPerfil.SelectedItem.ToString() == "Administrador")
            {
                txtSenhaChave.Visible = true;
            }
            else
            {
                txtSenhaChave.Visible = false;
            }
        }
    }
}
