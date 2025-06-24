using IgrejaMVC.Models;
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
    public partial class CadastrarInstrumentos : Form
    {
        public CadastrarInstrumentos()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public string Professor { get; set; }
        public string Perfil { get; set; }

        private void CadastrarInstrumentos_Load(object sender, EventArgs e)
        {
            gridInstrumento.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Seleciona a linha inteira
            gridInstrumento.ReadOnly = true; // Impede a edição das células

            lblPerfil.Text = Perfil;
            lblUsuario.Text = Professor;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home form = new Home();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Alunos form = new Alunos();
            form.Show();
            this.Close();
        }

        private void btnSalvarInstrumento_Click(object sender, EventArgs e)
        {
            try
            {
                // Criação do novo instrumento com os valores dos campos
                Instrumento novoInstrumento = new Instrumento
                {
                    NomeInstrumento = txtNomeInstrumento.Text,
                    QuantidadeMaxima = int.Parse(txtQuantidadeOrq.Text)
                };

                // Inserir no banco de dados
                InstrumentoDAO instrumentoDAO = new InstrumentoDAO();
                bool sucesso = instrumentoDAO.CadastrarInstrumento(novoInstrumento);

                // Verificar o resultado
                if (sucesso)
                {
                    MessageBox.Show("Instrumento cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar o instrumento.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void LimparCampos()
        {
            txtNomeInstrumento.Text = string.Empty;
            txtQuantidadeOrq.Text = string.Empty;
        }

        private void btnPesquisarInstrumento_Click(object sender, EventArgs e)
        {
            BancoDados banco = new BancoDados();  // Instancia a classe de banco
            string instrumento = txtPesqInstrumentos.Text; // Pega o nome digitado no campo de pesquisa

            gridInstrumento.DataSource = banco.PesquisarInstrumentoPorNome(instrumento);
        }

        private void gridInstrumento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // preencher o combobox do instrumento pegando da base
            //txtInstrumento.DataSource = BancoDados.PesquisarInstrumento();
            //txtInstrumento.DisplayMember = "nome";
            // txtInstrumento.ValueMember = "id";
            // buscar os instrumentos agrupado no cadastro de aluno 
            // busca instrumentos cadastrados 
            // loop verificar as quantidades, se for maior ou igual /
            // /txtInstrumento.Items.Remove(tbls.Nome); }
        }

        private void txtNomeInstrumento_TextChanged(object sender, EventArgs e)
        {

        }



        private void btnProfessores_Click(object sender, EventArgs e)
        {
            InformacoesProfessores form = new InformacoesProfessores();
            form.Professor = this.Professor;
            form.Perfil = this.Perfil;
            form.Show();
            this.Close();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnImprimirRel_Click(object sender, EventArgs e)
        {
            using (var workbook = new ClosedXML.Excel.XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Instrumentos");

                // Cabeçalhos
                worksheet.Cell(1, 1).Value = "Nome do Instrumento";
                worksheet.Cell(1, 2).Value = "Quantidade Máxima";

                // Estilizando cabeçalhos
                var header = worksheet.Range("A1:B1");
                header.Style.Font.Bold = true;
                header.Style.Fill.BackgroundColor = ClosedXML.Excel.XLColor.LightSteelBlue;
                header.Style.Alignment.Horizontal = ClosedXML.Excel.XLAlignmentHorizontalValues.Center;
                header.Style.Border.OutsideBorder = ClosedXML.Excel.XLBorderStyleValues.Thin;

                int linha = 2;

                foreach (DataGridViewRow row in gridInstrumento.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        worksheet.Cell(linha, 1).Value = row.Cells["nome instrumento"].Value?.ToString();
                        worksheet.Cell(linha, 2).Value = row.Cells["quantidade máxima"].Value?.ToString();
                        linha++;
                    }
                }

                worksheet.Columns().AdjustToContents();

                // Caminho do arquivo
                string caminhoArquivo = System.IO.Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                    "Downloads",
                    "Relatorio_Instrumentos.xlsx"
                );

                workbook.SaveAs(caminhoArquivo);

                MessageBox.Show($"Relatório salvo com sucesso em:\n{caminhoArquivo}",
                    "Relatório Gerado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
