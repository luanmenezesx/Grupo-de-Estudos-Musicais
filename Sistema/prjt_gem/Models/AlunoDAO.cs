using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace IgrejaMVC.Models
{
    internal class AlunoDAO
    {
        // String de conexão com o banco (altere com seus dados)

        public static string connectionString = ConfigurationManager.AppSettings["conexao"];

        // Método para cadastrar um aluno no banco
        public bool CadastrarAluno(Aluno aluno)
        {
            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                try
                {
                    conexao.Open();
                    string query = @"INSERT INTO alunos (nome, cpf, dt_cadastro, dt_nascimento, id_instrumento, telefone, email, cep, endereco, numero, bairro, cidade, estado, estado_civil, foto_perfil) 
                      VALUES (@Nome, @CPF, @DtCadastro, @DataNascimento, @Instrumento, @Telefone, @Email, @CEP, @Endereco, @Numero, @Bairro, @Cidade, @Estado, @EstadoCivil, @Foto)";


                    MySqlCommand cmd = new MySqlCommand(query, conexao);
                    cmd.Parameters.AddWithValue("@Nome", aluno.Nome);
                    cmd.Parameters.AddWithValue("@CPF", aluno.CPF);
                    cmd.Parameters.AddWithValue("@DtCadastro", DateTime.Now.ToString("yyyy-MM-dd")); // Define a data atual
                    cmd.Parameters.AddWithValue("@DataNascimento", aluno.DtNascimento);
                    cmd.Parameters.AddWithValue("@Instrumento", aluno.Instrumento);
                    cmd.Parameters.AddWithValue("@Telefone", aluno.Telefone);
                    cmd.Parameters.AddWithValue("@Email", aluno.Email);
                    cmd.Parameters.AddWithValue("@CEP", aluno.CEP);
                    cmd.Parameters.AddWithValue("@Endereco", aluno.Endereco);
                    cmd.Parameters.AddWithValue("@Numero", aluno.Numero);
                    cmd.Parameters.AddWithValue("@Bairro", aluno.Bairro);
                    cmd.Parameters.AddWithValue("@Cidade", aluno.Cidade);
                    cmd.Parameters.AddWithValue("@Estado", aluno.Estado);
                    cmd.Parameters.AddWithValue("@EstadoCivil", aluno.EstadoCivil);
                    cmd.Parameters.AddWithValue("@Foto", aluno.FotoPerfil ?? new byte[0]); // Evita erro se estiver vazio

                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao cadastrar aluno: " + ex.Message);
                    return false;
                }
            }
        }
        public bool ExcluirAluno(int idAluno)
      
        {
            string deleteDependentes = "DELETE FROM aluno_hino WHERE id_aluno = @IdAluno";
            string deleteAluno = "DELETE FROM Alunos WHERE id = @IdAluno";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Exclui os registros relacionados na tabela aluno_hino
                        using (MySqlCommand command = new MySqlCommand(deleteDependentes, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@IdAluno", idAluno);
                            command.ExecuteNonQuery();
                        }

                        // Exclui o aluno da tabela alunos
                        using (MySqlCommand command = new MySqlCommand(deleteAluno, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@IdAluno", idAluno);
                            command.ExecuteNonQuery();
                        }

                        // Confirma a transação
                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        // Reverte a transação em caso de erro
                        transaction.Rollback();
                        throw new Exception("Erro ao excluir aluno e dependentes: " + ex.Message);
                    }
                }
            }
        }


    }
}
