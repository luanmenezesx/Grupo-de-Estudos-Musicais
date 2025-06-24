using ClosedXML.Excel;
using IgrejaMVC.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IgrejaMVC.Views
{
    public partial class AlunosAptos : Form
    {
        public AlunosAptos()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void cmbFiltraGraph_SelectedIndexChanged(object sender, EventArgs e)
        {

            string filtro = cmbFiltraAptos.SelectedItem.ToString();

            // Oculta todos primeiro
            gridCultoJovens.Visible = false;
            gridCultoficial.Visible = false;
            gridOficializacao.Visible = false;



            switch (filtro)
            {
                case "Culto de Jovens":
                    gridCultoJovens.Visible = true;
                    break;
                case "Culto Oficial":
                    gridCultoficial.Visible = true;
                    break;
                case "Oficialização":
                    gridOficializacao.Visible = true;
                    break;
            }
        }

        private void AlunosAptos_Load(object sender, EventArgs e)
        {
            gridCultoficial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridCultoJovens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridOficializacao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            gridCultoficial.ReadOnly = true;
            gridCultoJovens.ReadOnly = true;
            gridOficializacao.ReadOnly = true;

            // Define a fonte somente para os grids
            Font gridFont = new Font("Century Gothic", 12);

            gridCultoficial.DefaultCellStyle.Font = gridFont;
            gridCultoJovens.DefaultCellStyle.Font = gridFont;
            gridOficializacao.DefaultCellStyle.Font = gridFont;

            cmbFiltraAptos.Items.Add("Culto de Jovens");
            cmbFiltraAptos.Items.Add("Culto Oficial");
            cmbFiltraAptos.Items.Add("Oficialização");

            CarregarDataGrids();
            cmbFiltraAptos.SelectedIndex = 0; // Mostra o primeiro por padrão
        }

        private void CarregarDataGrids()
        {
            BancoDados banco = new BancoDados();

            // Alunos com 25 hinos ou mais → Culto de Jovens
            gridCultoJovens.DataSource = banco.ObterAlunosPorHinos(25);

            // Alunos com 50 hinos ou mais → Culto Oficial
            gridCultoficial.DataSource = banco.ObterAlunosPorHinos(50);

            // Alunos com 100 hinos ou mais → Oficialização
            gridOficializacao.DataSource = banco.ObterAlunosPorHinos(100);
        }

        private void gridOficializacao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridView grid = (DataGridView)sender;

                // Supondo que a coluna "ID" esteja na posição 0 (ajuste se necessário)
                int idAluno = Convert.ToInt32(grid.Rows[e.RowIndex].Cells[0].Value);

                // Abre a tela de hinos do aluno
                Hinos telaHinos = new Hinos(idAluno);
                telaHinos.Show();
                this.Close();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gridCultoJovens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridView grid = (DataGridView)sender;

                // Supondo que a coluna "ID" esteja na posição 0 (ajuste se necessário)
                int idAluno = Convert.ToInt32(grid.Rows[e.RowIndex].Cells[0].Value);

                // Abre a tela de hinos do aluno
                Hinos telaHinos = new Hinos(idAluno);
                telaHinos.ShowDialog();
                this.Close();   
            }
        }

        private void gridCultoficial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridView grid = (DataGridView)sender;

                // Supondo que a coluna "ID" esteja na posição 0 (ajuste se necessário)
                int idAluno = Convert.ToInt32(grid.Rows[e.RowIndex].Cells[0].Value);

                // Abre a tela de hinos do aluno
                Hinos telaHinos = new Hinos(idAluno);
                telaHinos.ShowDialog();
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Alunos form1 = new Alunos();
            form1.Show();
            this.Hide();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void btnInstrumento_Click(object sender, EventArgs e)
        {
            CadastrarInstrumentos cadastrarInstrumentos = new CadastrarInstrumentos();
            cadastrarInstrumentos.Show();
            this.Close();
        }

        private void btnProfessores_Click(object sender, EventArgs e)
        {
            InformacoesProfessores informacoesProfessores = new InformacoesProfessores();
            informacoesProfessores.Show();
            this.Close();
        }

        private void btnImprimirRel_Click(object sender, EventArgs e)
        {
            DataGridView gridAtual = null;
            string nomePlanilha = "";

            switch (cmbFiltraAptos.SelectedItem.ToString())
            {
                case "Culto de Jovens":
                    gridAtual = gridCultoJovens;
                    nomePlanilha = "Culto de Jovens";
                    break;
                case "Culto Oficial":
                    gridAtual = gridCultoficial;
                    nomePlanilha = "Culto Oficial";
                    break;
                case "Oficialização":
                    gridAtual = gridOficializacao;
                    nomePlanilha = "Oficialização";
                    break;
            }

            if (gridAtual == null) return;

            using (var workbook = new ClosedXML.Excel.XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add(nomePlanilha);

                // Cabeçalhos
                worksheet.Cell(1, 1).Value = "ID";
                worksheet.Cell(1, 2).Value = "Nome";
                worksheet.Cell(1, 3).Value = "Total de Hinos";

                // Estilo cabeçalho
                var header = worksheet.Range("A1:C1");
                header.Style.Font.Bold = true;
                header.Style.Fill.BackgroundColor = XLColor.LightSteelBlue;
                header.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                header.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                int linha = 2;

                foreach (DataGridViewRow row in gridAtual.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        worksheet.Cell(linha, 1).Value = row.Cells["id"].Value?.ToString();
                        worksheet.Cell(linha, 2).Value = row.Cells["nome"].Value?.ToString();
                        worksheet.Cell(linha, 3).Value = row.Cells["total_hinos"].Value?.ToString();

                        linha++;
                    }
                }

                worksheet.Columns().AdjustToContents();

                // Caminho do arquivo
                string caminhoArquivo = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                    "Downloads",
                    $"Relatorio_{nomePlanilha.Replace(" ", "_")}.xlsx"
                );

                workbook.SaveAs(caminhoArquivo);

                MessageBox.Show($"Relatório '{nomePlanilha}' salvo com sucesso em:\n{caminhoArquivo}",
                                "Relatório Gerado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
