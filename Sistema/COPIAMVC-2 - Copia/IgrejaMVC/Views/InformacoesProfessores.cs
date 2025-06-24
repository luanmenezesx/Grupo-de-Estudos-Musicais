using ClosedXML.Excel;
using IgrejaMVC.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IgrejaMVC.Views
{
    public partial class InformacoesProfessores : Form
    {
        public static string connectionString = ConfigurationManager.AppSettings["conexao"];

        public InformacoesProfessores()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            gridProfessores.ReadOnly = true; // Impede a edição das células
            gridProfessores.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Seleciona a linha inteira
            gridProfessores.MultiSelect = false; // Impede seleção múltipla
        }

        public string Professor { get; set; }
        public string Perfil { get; set; }

        private void btnPesquisarProfessores_Click(object sender, EventArgs e)
        {
            BancoDados banco = new BancoDados();  
            string nome = txtPesqProfessores.Text;
            CarregarProfessores();

            gridProfessores.DataSource = banco.PesquisarProfessor(nome);
        }

        private void InformacoesProfessores_Load(object sender, EventArgs e)
        {
            gridProfessores.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Seleciona a linha inteira

            lblPerfil.Text = Perfil;
            lblUsuario.Text = Professor;

            if (Perfil == "Administrador")
                btnExcluirProfessor.Visible = true;
            else
                btnExcluirProfessor.Visible = false;

        }

        private void gridProfessores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridProfessores.SelectedRows.Count > 0) // Verifica se há uma linha selecionada
            {
                // Obtém a linha selecionada
                var row = gridProfessores.SelectedRows[0];

                // Captura o ID do professor
                int idProfessor = Convert.ToInt32(row.Cells["id_professor"].Value);

            }
            else
            {
                MessageBox.Show("Por favor, selecione uma linha na tabela antes de acessar as informações.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcluirProfessor_Click(object sender, EventArgs e)
        {
            if (gridProfessores.SelectedRows.Count > 0) // Verifica se há uma linha selecionada
            {
                var row = gridProfessores.SelectedRows[0];
                int idProfessor = Convert.ToInt32(row.Cells["id_professor"].Value);

                string nomeSelecionado = row.Cells["nome"].Value.ToString();
                string perfilSelecionado = row.Cells["perfil"].Value.ToString();

                string nomeLogado = lblUsuario.Text;
                string perfilLogado = lblPerfil.Text;

                // Impede que o usuário exclua ele mesmo com o mesmo perfil
                if (nomeSelecionado.Equals(nomeLogado) && perfilSelecionado.Equals(perfilLogado))
                {
                    MessageBox.Show("Operação Inválida! Você não pode excluir seu próprio usuário com o mesmo perfil.",
                                    "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                var confirmResult = MessageBox.Show($"Tem certeza que deseja excluir o professor com ID {idProfessor}?",
                                                    "Confirmação de Exclusão",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    string query = "DELETE FROM Professores WHERE id_professor = @Id";

                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Id", idProfessor);

                            try
                            {
                                connection.Open();
                                int result = command.ExecuteNonQuery();

                                if (result > 0)
                                {
                                    MessageBox.Show("Professor excluído com sucesso!");
                                    CarregarProfessores();
                                }
                                else
                                {
                                    MessageBox.Show("Erro ao excluir professor.");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Erro: " + ex.Message);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma linha na tabela antes de excluir um professor.",
                                "Atenção",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }


        private void btnInstrumento_Click(object sender, EventArgs e)
        {
            CadastrarInstrumentos cadastrarInstrumentos = new CadastrarInstrumentos();
            cadastrarInstrumentos.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Alunos alunos = new Alunos();
            alunos.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Close();
        }


        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnImprimirRel_Click(object sender, EventArgs e)
        {
            using (var workbook = new ClosedXML.Excel.XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Relatório de Professores");

                // Cabeçalhos
                worksheet.Cell(1, 1).Value = "ID";
                worksheet.Cell(1, 2).Value = "Nome";
                worksheet.Cell(1, 3).Value = "Perfil";

                // Estilo do cabeçalho
                var headerRange = worksheet.Range("A1:C1");
                headerRange.Style.Font.Bold = true;
                headerRange.Style.Fill.BackgroundColor = XLColor.LightGray;
                headerRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                headerRange.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                headerRange.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                headerRange.Style.Border.TopBorder = XLBorderStyleValues.Thin;
                headerRange.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                headerRange.Style.Border.RightBorder = XLBorderStyleValues.Thin;

                int linha = 2;

                foreach (DataGridViewRow row in gridProfessores.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        worksheet.Cell(linha, 1).Value = row.Cells["id_professor"].Value?.ToString();
                        worksheet.Cell(linha, 2).Value = row.Cells["nome"].Value?.ToString();
                        worksheet.Cell(linha, 3).Value = row.Cells["perfil"].Value?.ToString();

                        // Estilo das células
                        worksheet.Range(linha, 1, linha, 3).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
                        worksheet.Range(linha, 1, linha, 3).Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                        worksheet.Range(linha, 1, linha, 3).Style.Border.BottomBorder = XLBorderStyleValues.Thin;

                        linha++;
                    }
                }

                // Ajusta automaticamente as colunas
                worksheet.Columns().AdjustToContents();

                // Define o caminho da pasta Downloads
                string caminhoArquivo = System.IO.Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                    "Downloads",
                    "RelatorioProfessores.xlsx"
                );

                workbook.SaveAs(caminhoArquivo);

                MessageBox.Show($"Relatório salvo com sucesso em:\n{caminhoArquivo}",
                    "Relatório Gerado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CarregarProfessores()
        {
            BancoDados banco = new BancoDados();
            string nome = txtPesqProfessores.Text; // Pesquisa atual
            gridProfessores.DataSource = banco.PesquisarProfessor(nome);
        }

    }
  

}
