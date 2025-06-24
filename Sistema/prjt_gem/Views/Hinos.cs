using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IgrejaMVC.Models;


namespace IgrejaMVC.Views
{
    public partial class Hinos : Form
    {
        private int idAluno; 

        public Hinos(int idAlunoRecebido)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.idAluno = idAlunoRecebido;
            gridHinos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
        public void AtualizarGrids()
        {
            Models.Hinos hinoModel = new Models.Hinos();
            gridHinos.DataSource = hinoModel.MostrarHinos(idAluno);
        }

        private void Hinos_Load(object sender, EventArgs e)
        {
            Models.Hinos hino = new Models.Hinos();
            gridHinos.DataSource = hino.MostrarHinos(idAluno);
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

        private void btnInstrumento_Click(object sender, EventArgs e)
        {
            CadastrarInstrumentos form = new CadastrarInstrumentos();
            form.Show();
            this.Close();
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNumeroHino.Text.Trim(), out int numeroHino))
            {
                MessageBox.Show("Número do hino inválido.");
                return;
            }

            Models.Hinos hinoModel = new Models.Hinos();
            string resultado = hinoModel.SalvarHinoParaAluno(idAluno, numeroHino);

            MessageBox.Show(resultado);

            gridHinos.DataSource = hinoModel.MostrarHinos(idAluno);

            txtNumeroHino.Clear();
            txtNomeHino.Clear();

            // **Atualiza os dados da página Home**
            Home home = Application.OpenForms.OfType<Home>().FirstOrDefault();
            if (home != null)
            {
                home.AtualizarHome();
            }
        }

        private void gridAluno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPesquisarHino_Click(object sender, EventArgs e)
        {

            BancoDados banco = new BancoDados(); 
            string nome = txtPesquisarHino.Text;       

            gridHinos.DataSource = banco.PesquisarHinos(idAluno, nome);
        }

        private void txtNumeroHino_Leave(object sender, EventArgs e)
        {


        }

        private void txtNomeHino_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumeroHino_TextChanged(object sender, EventArgs e)
        {
            txtNomeHino.Clear();

            if (!string.IsNullOrEmpty(txtNumeroHino.Text))
            {
                BancoDados banco = new BancoDados();

                DataTable dt = banco.PesquisarHinosNumero(int.Parse(txtNumeroHino.Text));

                DataTableReader dr = dt.CreateDataReader();

                while (dr.Read())
                {
                    txtNomeHino.Text = dr.GetValue(2).ToString();
                }
            }
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

        private void pictureBox6_Click_1(object sender, EventArgs e)
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
                var worksheet = workbook.Worksheets.Add("Hinos do Aluno");

                worksheet.Cell(1, 1).Value = "Número";
                worksheet.Cell(1, 2).Value = "Nome";
                worksheet.Cell(1, 3).Value = "Data de Passagem";

                var header = worksheet.Range("A1:C1");
                header.Style.Font.Bold = true;
                header.Style.Fill.BackgroundColor = ClosedXML.Excel.XLColor.LightSteelBlue;
                header.Style.Alignment.Horizontal = ClosedXML.Excel.XLAlignmentHorizontalValues.Center;
                header.Style.Border.OutsideBorder = ClosedXML.Excel.XLBorderStyleValues.Thin;

                int linha = 2;

                foreach (DataGridViewRow row in gridHinos.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        worksheet.Cell(linha, 1).Value = row.Cells["Número"].Value?.ToString();
                        worksheet.Cell(linha, 2).Value = row.Cells["nome"].Value?.ToString();
                        worksheet.Cell(linha, 3).Value = row.Cells["Data de Passagem"].Value?.ToString();
                        linha++;
                    }
                }

                worksheet.Columns().AdjustToContents();

                string caminho = System.IO.Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                    "Downloads",
                    $"Hinos_Aluno_{idAluno}.xlsx"
                );

                workbook.SaveAs(caminho);

                MessageBox.Show($"Relatório salvo com sucesso em:\n{caminho}", "Relatório Gerado",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
