using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;


namespace IgrejaMVC.Models
{
    internal class BancoDados
    {
        public static string connectionString = ConfigurationManager.AppSettings["conexao"];
            
        public static bool VerificaProfessor(string nome, string senha)
        {
            string sql = "SELECT COUNT(*) FROM professores WHERE nome_professor = @nome AND senha_professor = @senha;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@senha", senha);

                    try
                    {
                        conn.Open();

                        // Retorna o número de registros que correspondem à consulta
                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        conn.Close();

                        return count > 0; // Retorna true se houver pelo menos um registro encontrado
                    }
                    catch (MySqlException ex)
                    {
                        Console.WriteLine("Erro ao verificar professor: " + ex.Message);
                        return false; // Retorna false em caso de erro
                    }
                }
            }
        }


        public static ProfessorPerfil VerificaProfessorPerfil(string nome, string senha)
        {
            string sql = "SELECT * FROM professores WHERE nome_professor = @nome AND senha_professor = @senha;";

            ProfessorPerfil retorno = new ProfessorPerfil();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@senha", senha);

                    try
                    {
                        conn.Open();

                        MySqlDataReader rdr = cmd.ExecuteReader();

                        while (rdr.Read())
                        {
                            retorno.Professor = rdr[1].ToString();
                            retorno.Perfil = rdr[3].ToString();
                        }
                        conn.Close();
                        return retorno; // Retorna true se houver pelo menos um registro encontrado
                    }
                    catch (MySqlException ex)
                    {
                        Console.WriteLine("Erro ao verificar professor: " + ex.Message);
                        return retorno; // Retorna false em caso de erro
                    }
                }
            }
        }

        public DataTable PesquisarProfessor(string nome)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string sql = @"
            SELECT 
                id_professor AS 'id_professor', 
                nome_professor AS 'Nome',  
                perfil_professor AS 'Perfil' 
            FROM professores 
            WHERE nome_professor LIKE @nome
            ORDER BY 
                CASE 
                    WHEN perfil_professor = 'Administrador' THEN 0 
                    ELSE 1 
                END,
                nome_professor";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                conn.Open();
                adapter.Fill(dt);
                conn.Close();

                return dt;
            }
        }


        public static DataTable PesquisarHinosPorAluno(int ano)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string sql = @"
            SELECT 
                a.nome AS NomeAluno,
                COUNT(ah.id_hino) AS QtdeHinos
            FROM 
                Aluno_Hino ah
            JOIN 
                Alunos a ON ah.id_aluno = a.id
            WHERE 
                YEAR(ah.data_passagem) = @ano
            GROUP BY 
                a.nome
            ORDER BY 
                QtdeHinos DESC";

                using (MySqlCommand comando = new MySqlCommand(sql, conn))
                {
                    comando.Parameters.AddWithValue("@ano", ano);
                    using (MySqlDataAdapter da = new MySqlDataAdapter(comando))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public static int ObterInstrumentoDoAluno(string cpf)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string sql = "SELECT id_instrumento FROM alunos WHERE cpf = @cpf";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@cpf", cpf);

                try
                {
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    conn.Close();

                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        return -1; // Retorna -1 se o aluno não possuir instrumento associado
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Erro ao obter instrumento do aluno: " + ex.Message);
                    return -1; // Indica erro na consulta
                }
            }
        }

        public static DataTable PesquisarInstrumentoComEscolhido(string cpfAluno)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string sql = @"
            -- Instrumentos com vagas, exceto o já escolhido pelo aluno
            SELECT i.id, i.nome_instrumento, i.quantidade_maxima, 
                   COALESCE(t.quantidade, 0) AS quantidade, 
                   (i.quantidade_maxima - COALESCE(t.quantidade, 0)) AS total
            FROM Instrumentos i
            LEFT JOIN (
                SELECT id_instrumento, COUNT(*) AS quantidade
                FROM Alunos
                WHERE id_instrumento IS NOT NULL
                GROUP BY id_instrumento
            ) AS t ON i.id = t.id_instrumento
            WHERE (i.quantidade_maxima - COALESCE(t.quantidade, 0)) > 0
              AND i.id NOT IN (
                  SELECT id_instrumento FROM Alunos WHERE cpf = @cpf
              )

            UNION

            -- Instrumento atualmente escolhido pelo aluno (mesmo se cheio)
            SELECT i.id, i.nome_instrumento, i.quantidade_maxima, 
                   COALESCE(t2.quantidade, 0) AS quantidade, 
                   (i.quantidade_maxima - COALESCE(t2.quantidade, 0)) AS total
            FROM Instrumentos i
            INNER JOIN Alunos a ON a.id_instrumento = i.id
            LEFT JOIN (
                SELECT id_instrumento, COUNT(*) AS quantidade
                FROM Alunos
                GROUP BY id_instrumento
            ) AS t2 ON t2.id_instrumento = i.id
            WHERE a.cpf = @cpf";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@cpf", cpfAluno);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                conn.Open();
                adapter.Fill(dt);
                conn.Close();

                return dt;
            }
        }
       

        public DataTable PesquisarAluno(string nome)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string sql = "SELECT * FROM alunos WHERE nome LIKE @nome";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nome", "%" + nome + "%"); // Busca apenas nomes que começam com a sequência informada

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                conn.Open();
                adapter.Fill(dt);
                conn.Close();
                return dt;
            }
        }

        public DataTable PesquisarHinos(int idAluno, string nome)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string sql = @"  SELECT  h.id AS 'Número',   h.nome_hino AS 'Nome'
                 FROM Hinos h INNER JOIN Aluno_Hino ah ON ah.id_hino = h.id
                 WHERE ah.id_aluno = @idAluno AND h.nome_hino LIKE @nome";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@idAluno", idAluno);
                cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                conn.Open();
                adapter.Fill(dt);
                conn.Close();

                return dt;
            }
        }

        public DataTable PesquisarHinosNumero(int numero)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string sql = "SELECT * FROM hinos WHERE numero_hino = @numero";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@numero", numero ); // Busca apenas hinos que começam com a sequência informada

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                conn.Open();
                adapter.Fill(dt);
                conn.Close();
                return dt;
            }
        }


        public DataTable PesquisarInstrumentoPorNome(string nome)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string sql = @"
            SELECT 
                nome_instrumento AS 'nome instrumento', 
                quantidade_maxima AS 'quantidade máxima'
            FROM instrumentos 
            WHERE nome_instrumento LIKE @nome
            ORDER BY quantidade_maxima DESC"; // Ordena do maior para o menor

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nome", nome + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                conn.Open();
                adapter.Fill(dt);
                conn.Close();

                return dt;
            }
        }


        public static DataTable PesquisarQuantidadePorInstrumento()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string sql = @"
            SELECT 
                i.nome_instrumento AS Instrumento,
                COUNT(a.id) AS Quantidade
            FROM instrumentos i
            LEFT JOIN alunos a ON i.id = a.id_instrumento
            GROUP BY i.nome_instrumento
            ORDER BY Quantidade DESC;";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                conn.Open();
                adapter.Fill(dt);
                conn.Close();

                return dt;
            }
        }



        public static DataTable PesquisarInstrumentoTotal()
        {
            //Outra solução: @"select id,nome_instrumento,quantidade_maxima,quantidade,quantidade_maxima-quantidade total
           // from instrumentos inner
            //                   join (select id_instrumento, count(id_instrumento) quantidade from alunos group by id_instrumento ) t
              //                 on instrumentos.id = t.id_instrumento where quantidade_maxima-quantidade > 0";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string sql = @"SELECT i.id,  i.nome_instrumento,i.quantidade_maxima,  COALESCE(t.quantidade, 0) AS quantidade,
                             i.quantidade_maxima - COALESCE(t.quantidade, 0) AS total FROM Instrumentos i LEFT JOIN (
                             SELECT id_instrumento, COUNT(id_instrumento) AS quantidade  FROM Alunos  WHERE id_instrumento IS NOT NULL
                             GROUP BY id_instrumento) t ON i.id = t.id_instrumento WHERE i.quantidade_maxima - COALESCE(t.quantidade, 0) > 0;";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                conn.Open();
                adapter.Fill(dt);
                conn.Close();

                return dt;
            }
        }

        public static DataTable PesquisarHinosporMes(int ano)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string sql = @"SET lc_time_names = 'pt_BR';
                       SELECT MONTHNAME(data_passagem) AS MES, 
                              MONTH(data_passagem) AS MES_NUM, 
                              COUNT(id_hino) AS Qtde
                       FROM aluno_hino 
                       WHERE YEAR(data_passagem) = @ano
                       GROUP BY MES_NUM, MES
                       ORDER BY MES_NUM;";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ano", ano); // Adiciona parâmetro para prevenir SQL Injection

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                conn.Open();
                adapter.Fill(dt);
                conn.Close();

                return dt;
            }
        }



        public static bool AtualizarAluno(Aluno aluno)
        {
            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                try
                {
                    conexao.Open();
                    string query = @"UPDATE alunos SET 
                nome = @Nome, 
                dt_nascimento = @DataNascimento, 
                id_instrumento = @Instrumento, 
                telefone = @Telefone, 
                email = @Email, 
                cep = @CEP, 
                endereco = @Endereco, 
                numero = @Numero, 
                bairro = @Bairro, 
                cidade = @Cidade, 
                estado = @Estado, 
                estado_civil = @EstadoCivil, 
                foto_perfil = @Foto
                WHERE cpf = @CPF";

                    MySqlCommand cmd = new MySqlCommand(query, conexao);
                    cmd.Parameters.AddWithValue("@Nome", aluno.Nome);
                    cmd.Parameters.AddWithValue("@CPF", aluno.CPF);
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
                    // Log ou trate o erro de acordo com suas necessidades
                    return false;
                }
            }
        }

        public DataTable ObterAlunosPorHinos(int minimo)
        {
            DataTable dt = new DataTable();

            string query = @"
            SELECT a.id, a.nome, COUNT(ah.id_hino) AS total_hinos
            FROM Alunos a
            JOIN Aluno_Hino ah ON a.id = ah.id_aluno
            GROUP BY a.id, a.nome
            HAVING COUNT(ah.id_hino) >= @minimo;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@minimo", minimo);

                    conn.Open();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                // Registre o erro ou trate de acordo com seu projeto
                Console.WriteLine("Erro ao buscar alunos: " + ex.Message);
            }

            return dt;
        }
        public static bool ValidarCPF(string cpf)
        {
            if (string.IsNullOrEmpty(cpf))
                return false;

            cpf = cpf.Replace(".", "").Replace("-", "").Trim();

            if (cpf.Length != 11)
                return false;

            // Verificar se todos os dígitos são iguais (ex: 11111111111)
            if (cpf.All(c => c == cpf[0]))
                return false;

            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf = cpf.Substring(0, 9);
            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            int resto = soma % 11;
            resto = resto < 2 ? 0 : 11 - resto;
            string digito = resto.ToString();

            tempCpf += digito;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            resto = resto < 2 ? 0 : 11 - resto;
            digito += resto.ToString();

            return cpf.EndsWith(digito);
        }
    }

}

