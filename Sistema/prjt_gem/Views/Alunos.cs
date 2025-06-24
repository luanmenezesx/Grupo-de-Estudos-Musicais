using IgrejaMVC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.IO;


namespace IgrejaMVC.Views
{
    public partial class Alunos : Form
    {
        public Alunos()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public string Professor { get; set; }
        public string Perfil { get; set; }

        private void Alunos_Load(object sender, EventArgs e)
        {
            gridAluno.Font = new Font("Century Gothic", 12, FontStyle.Regular);

            // Estilizar o cabeçalho das colunas
            gridAluno.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 14);
            gridAluno.ReadOnly = true; // Impede a edição das células
            gridAluno.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Seleciona a linha inteira
            gridAluno.MultiSelect = false; // Impede seleção múltipla

            // Adiciona o manipulador para ajustar as colunas assim que os dados forem carregados
            gridAluno.DataBindingComplete += gridAluno_DataBindingComplete;
            CarregarAlunos();
        }

        private void gridAluno_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn coluna in gridAluno.Columns)
            {
                if (coluna.Name == "nome" || coluna.Name == "cpf" ||
                    coluna.Name == "email" || coluna.Name == "telefone")
                {
                    coluna.Visible = true;
                }
                else
                {
                    coluna.Visible = false;
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            BancoDados banco = new BancoDados();  // Instancia a classe de banco
            string nome = txtPesqAlunos.Text;       // Pega o nome digitado no campo de pesquisa

            gridAluno.DataSource = banco.PesquisarAluno(nome);
            // O evento gridAluno.DataBindingComplete será chamado automaticamente após a vinculação
        }

        private void gridAluno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridAluno.SelectedRows.Count > 0) // Verifica se há uma linha selecionada
            {
                // Cria uma nova instância do formulário de informações
                InformacoesAlunos formInfo = new InformacoesAlunos();

                // Obtém a linha selecionada
                var row = gridAluno.SelectedRows[0];

                // Passa os dados da linha para os campos do InformacoesAlunos
                formInfo.txtNome.Text = row.Cells["nome"].Value?.ToString();
                formInfo.txtCPF.Text = row.Cells["cpf"].Value?.ToString();
                formInfo.txtDtCadastro.Text = Convert.ToDateTime(row.Cells["dt_cadastro"].Value).ToString("yyyy-MM-dd");
                formInfo.txtDtNascimento.Text = Convert.ToDateTime(row.Cells["dt_nascimento"].Value).ToString("yyyy-MM-dd");
                formInfo.txtInstrumento.Text = row.Cells["id_instrumento"].Value?.ToString();
                formInfo.txtTelefone.Text = row.Cells["telefone"].Value?.ToString();
                formInfo.txtEmail.Text = row.Cells["email"].Value?.ToString();
                formInfo.txtCEP.Text = row.Cells["cep"].Value?.ToString();
                formInfo.txtEndereco.Text = row.Cells["endereco"].Value?.ToString();
                formInfo.txtNumero.Text = row.Cells["numero"].Value?.ToString();
                formInfo.txtBairro.Text = row.Cells["bairro"].Value?.ToString();
                formInfo.txtCidade.Text = row.Cells["cidade"].Value?.ToString();
                formInfo.txtEstado.Text = row.Cells["estado"].Value?.ToString();
                formInfo.txtEstadoCivil.Text = row.Cells["estado_civil"].Value?.ToString();

                // Configura a foto do perfil, caso exista
                if (row.Cells["foto_perfil"].Value != null && row.Cells["foto_perfil"].Value is byte[] foto)
                {
                    using (var ms = new System.IO.MemoryStream(foto))
                    {
                        formInfo.pictureBox1.Image = System.Drawing.Image.FromStream(ms);
                    }
                }
                else
                {
                    formInfo.pictureBox1.Image = null; // Caso não haja imagem
                }

                // Abre a tela de Informações e fecha esta
                formInfo.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma linha na tabela antes de acessar as informações.",
                                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtPesqAlunos_TextChanged(object sender, EventArgs e)
        {
            // Você pode implementar a atualização do grid aqui, se desejar.
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            // Código adicional, se necessário.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void btnHinos_Click(object sender, EventArgs e)
        {
            if (gridAluno.SelectedRows.Count > 0)
            {
                int idAluno = Convert.ToInt32(gridAluno.SelectedRows[0].Cells[0].Value);

                // Passa o ID do aluno para o formulário Hinos
                Hinos form = new Hinos(idAluno);
                form.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecione um aluno antes de visualizar os hinos.");
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProfessores_Click(object sender, EventArgs e)
        {
            InformacoesProfessores form = new InformacoesProfessores();
            form.Professor = this.Professor;
            form.Perfil = this.Perfil;
            form.Show();
        }

        private void btnExcluirAluno_Click(object sender, EventArgs e)
        {
            if (gridAluno.SelectedRows.Count > 0) // Verifica se há uma linha selecionada
            {
                var row = gridAluno.SelectedRows[0];
                int idAluno = Convert.ToInt32(row.Cells["id"].Value); // Ajuste para "id", conforme sua tabela SQL

                // Verifica se o ID é 0 e, caso seja, interrompe o fluxo
                if (idAluno == 0)
                {
                    return;
                }

                var confirmResult = MessageBox.Show($"Tem certeza que deseja excluir o aluno com ID {idAluno}?",
                                                    "Confirmação de Exclusão",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    // Chama a operação de exclusão no AlunoDAO
                    AlunoDAO alunoDAO = new AlunoDAO();
                    bool sucesso = alunoDAO.ExcluirAluno(idAluno);

                    if (sucesso)
                    {
                        MessageBox.Show("Aluno excluído com sucesso!");
                        CarregarAlunos();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao excluir aluno.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma linha na tabela antes de excluir um aluno.",
                                "Atenção",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnImprimirRel_Click(object sender, EventArgs e)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Relatório de Alunos");

                // Adiciona cabeçalhos
                worksheet.Cell(1, 1).Value = "Nome";
                worksheet.Cell(1, 2).Value = "CPF";
                worksheet.Cell(1, 3).Value = "Email";
                worksheet.Cell(1, 4).Value = "Telefone";

                // Estilo do cabeçalho
                var headerRange = worksheet.Range("A1:D1");
                headerRange.Style.Font.Bold = true;
                headerRange.Style.Fill.BackgroundColor = XLColor.LightGray;
                headerRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                headerRange.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                headerRange.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                headerRange.Style.Border.TopBorder = XLBorderStyleValues.Thin;
                headerRange.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                headerRange.Style.Border.RightBorder = XLBorderStyleValues.Thin;

                int row = 2;

                foreach (DataGridViewRow gridRow in gridAluno.Rows)
                {
                    if (!gridRow.IsNewRow)
                    {
                        worksheet.Cell(row, 1).Value = gridRow.Cells["nome"].Value?.ToString();
                        worksheet.Cell(row, 2).Value = gridRow.Cells["cpf"].Value?.ToString();
                        worksheet.Cell(row, 3).Value = gridRow.Cells["email"].Value?.ToString();
                        worksheet.Cell(row, 4).Value = gridRow.Cells["telefone"].Value?.ToString();

                        // Estilo das células
                        worksheet.Range(row, 1, row, 4).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
                        worksheet.Range(row, 1, row, 4).Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                        worksheet.Range(row, 1, row, 4).Style.Border.BottomBorder = XLBorderStyleValues.Thin;

                        row++;
                    }
                }

                // Ajusta automaticamente as colunas
                worksheet.Columns().AdjustToContents();

                // Define o caminho da pasta Downloads
                string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", "RelatorioAlunos.xlsx");
                workbook.SaveAs(downloadsPath);

                MessageBox.Show($"Relatório salvo com sucesso em {downloadsPath}!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CarregarAlunos()
        {
            BancoDados banco = new BancoDados();
            string nome = txtPesqAlunos.Text;
            gridAluno.DataSource = banco.PesquisarAluno(nome);
        }

    }
}
