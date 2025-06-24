using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgrejaMVC.Models
{
    internal class InstrumentoDAO
    {
        public static string connectionString = ConfigurationManager.AppSettings["conexao"];

        public bool CadastrarInstrumento(Instrumento instrumento)
        {
            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                try
                {
                    conexao.Open();
                    string query = @"INSERT INTO instrumentos (nome_instrumento, quantidade_maxima) 
                             VALUES (@nomeInstrumento, @quantidadeMaxima)";

                    MySqlCommand cmd = new MySqlCommand(query, conexao);
                    cmd.Parameters.AddWithValue("@nomeInstrumento", instrumento.NomeInstrumento);
                    cmd.Parameters.AddWithValue("@quantidadeMaxima", instrumento.QuantidadeMaxima);

                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao cadastrar instrumentos: " + ex.Message);
                    return false;
                }
            }
        }

    }

}
