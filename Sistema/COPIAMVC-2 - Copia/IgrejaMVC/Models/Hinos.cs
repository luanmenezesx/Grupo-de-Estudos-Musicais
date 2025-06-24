using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgrejaMVC.Models
{
    internal class Hinos
    {
        public static string connectionString = ConfigurationManager.AppSettings["conexao"];

        public DataTable MostrarHinos(int idaluno)
        {
            DataTable dt = new DataTable();


            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                try
                {
                    conexao.Open();
                    string query = @"
            SELECT 
                h.numero_hino AS 'Número', 
                h.nome_hino AS 'Nome', 
                ah.data_passagem AS 'Data de passagem'
            FROM Aluno_Hino ah
            INNER JOIN Hinos h ON ah.id_hino = h.id
            WHERE ah.id_aluno = @idAluno";

                    MySqlCommand cmd = new MySqlCommand(query, conexao);
                    cmd.Parameters.AddWithValue("@idAluno", idaluno);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao carregar hinos: " + ex.Message);
                }

                return dt;
            }
         }
            public string SalvarHinoParaAluno(int alunoId, int numeroHino) {

            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                try
                {
                    conexao.Open();

                    // Verifica se o hino existe e obtém seu ID
                    string selectHino = "SELECT id FROM Hinos WHERE numero_hino = @numero";
                    MySqlCommand cmdSelect = new MySqlCommand(selectHino, conexao);
                    cmdSelect.Parameters.AddWithValue("@numero", numeroHino);
                    object result = cmdSelect.ExecuteScalar();

                    if (result == null)
                        return "Hino não encontrado.";

                    int hinoId = Convert.ToInt32(result);

                    // Verifica se o hino já está cadastrado para esse aluno
                    string check = "SELECT COUNT(*) FROM Aluno_Hino WHERE id_aluno = @idAluno AND id_hino = @idHino";
                    MySqlCommand cmdCheck = new MySqlCommand(check, conexao);
                    cmdCheck.Parameters.AddWithValue("@idAluno", alunoId);
                    cmdCheck.Parameters.AddWithValue("@idHino", hinoId);
                    long existe = Convert.ToInt64(cmdCheck.ExecuteScalar());

                    if (existe > 0)
                        return "Hino já está cadastrado para este aluno.";

                    // Se não estiver cadastrado, insere o hino para o aluno
                    string insert = "INSERT INTO Aluno_Hino (id_aluno, id_hino, data_passagem) VALUES (@idAluno, @idHino, @data)";
                    MySqlCommand cmdInsert = new MySqlCommand(insert, conexao);
                    cmdInsert.Parameters.AddWithValue("@idAluno", alunoId);
                    cmdInsert.Parameters.AddWithValue("@idHino", hinoId);
                    cmdInsert.Parameters.AddWithValue("@data", DateTime.Now);
                    cmdInsert.ExecuteNonQuery();

                    return "Hino cadastrado com sucesso!";
                }
                catch (Exception ex)
                {
                    return "Erro ao salvar hino: " + ex.Message;
                }
            }
       

        }
    }
}
