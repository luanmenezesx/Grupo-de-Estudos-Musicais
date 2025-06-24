using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.WinForms;
using System.Collections.ObjectModel;
using IgrejaMVC.Models;
using LiveChartsCore.SkiaSharpView.SKCharts;
using LiveChartsCore.Measure;
using static IgrejaMVC.Views.Home;
using System.Data;
namespace IgrejaMVC.Views


{
    public partial class Home : Form
    {
        //private readonly CartesianChart cartesianChart1;
        public Home()
        {


            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.StartPosition = FormStartPosition.CenterScreen;

            //Acabei de adicionar
            for (int ano = 2020; ano <= 2025; ano++)
            {
                cmbAnos.Items.Add(ano);
            }
            cmbAnos.SelectedItem = 2025;

            var viewModel = new ViewModel();

            cartesianChart1.Series = new ISeries[]
            {
            new LineSeries<double>
            {
                Values = new double[] { 2, 1, 3, 5, 3, 4, 6 },
                Fill = null,

            }
            };

        }

        public void AtualizarHome()
        {
            AtualizarGraficoPorAno(2025);
            AtualizarGraficoAlunos(2025);
            AtualizarGraficoInstrumentos();
        }

        public string Professor { get; set; }
        public string Perfil { get; set; }


        private void Home_Load(object sender, EventArgs e)
        {

            lblPerfil.Text = Perfil;
            lblUsuario.Text = Professor;

            AtualizarGraficoPorAno(2025);

            cmbFiltraGraph.Items.Add("Hinos por Mês");
            cmbFiltraGraph.Items.Add("Hinos por Aluno");
            cmbFiltraGraph.Items.Add("Alunos por Instrumento");

            cmbFiltraGraph.SelectedIndex = 0; 
            FiltrarGrafico();


            ViewModel viewModel = new ViewModel();

            DataTable dados = BancoDados.PesquisarHinosporMes(2025);
            DataTableReader dr = dados.CreateDataReader();

            List<double> db1 = new List<double>();
            List<string> lb1 = new List<string>();

            while (dr.Read())
            {
                db1.Add(double.Parse(dr["Qtde"].ToString()));
                lb1.Add(dr["MES"].ToString());
            }

            ColumnSeries<double> s1 = new ColumnSeries<double>
            {
                Values = db1, 
                Name = "Hinos por Mês"
            };

            viewModel.Series.Add(s1);

            Axis eixo1 = new Axis();
            eixo1.Name = "Meses";
            eixo1.Labels = lb1;

            viewModel.XAxes = new Axis[] { eixo1 };


            cartesianChart1.Series = viewModel.Series;
            cartesianChart1.XAxes = viewModel.XAxes;
            cartesianChart1.YAxes = viewModel.YAxes;

            cartesianChart1.LegendPosition = LiveChartsCore.Measure.LegendPosition.Top;
            cartesianChart1.Size = new System.Drawing.Size(600, 300);


            AtualizarGraficoAlunos(2025);

        }
        // fim hinos por mes.
       

        private void AtualizarGraficoInstrumentos()
        {
            ViewModel viewModel = new ViewModel();

            DataTable dados = BancoDados.PesquisarQuantidadePorInstrumento();
            DataTableReader dr = dados.CreateDataReader();

            List<double> valores = new List<double>();
            List<string> nomes = new List<string>();

            while (dr.Read())
            {
                double quantidade = double.Parse(dr["Quantidade"].ToString());

                if (quantidade >= 1) // ✅ Só adiciona quem tem pelo menos 1
                {
                    valores.Add(quantidade);
                    nomes.Add(dr["Instrumento"].ToString());
                }
            }

            ColumnSeries<double> series = new ColumnSeries<double>
            {
                Values = valores,
                Name = "Alunos por Instrumento"
            };

            viewModel.Series.Add(series);

            Axis eixoX = new Axis
            {
                Name = "Instrumento",
                Labels = nomes,
                LabelsRotation = 0
            };

            Axis eixoY = new Axis
            {
                Name = "Qtde Alunos",
                MinLimit = 0
            };

            viewModel.XAxes = new Axis[] { eixoX };
            viewModel.YAxes = new Axis[] { eixoY };

            cartesianChart3.Series = viewModel.Series;
            cartesianChart3.XAxes = viewModel.XAxes;
            cartesianChart3.YAxes = viewModel.YAxes;
            cartesianChart3.LegendPosition = LiveChartsCore.Measure.LegendPosition.Top;
            cartesianChart3.Size = new System.Drawing.Size(600, 300);
        }



        private void AtualizarGraficoAlunos(int ano)
        {
            ViewModel viewModel2 = new ViewModel();

            DataTable dados = BancoDados.PesquisarHinosPorAluno(ano);
            DataTableReader dr = dados.CreateDataReader();

            List<double> db2 = new List<double>();
            List<string> lb2 = new List<string>();

            while (dr.Read())
            {
                db2.Add(double.Parse(dr["QtdeHinos"].ToString()));
                lb2.Add(dr["NomeAluno"].ToString());
            }

            ColumnSeries<double> s2 = new ColumnSeries<double>
            {
                Values = db2,
                Name = $"Hinos por Aluno ({ano})"
            };

            viewModel2.Series.Add(s2);

            Axis eixoX = new Axis
            {
                Name = "Nome",
                Labels = lb2,
                LabelsRotation = 0 // reto
            };

            Axis eixoY = new Axis
            {
                Name = "Hinos por Aluno",
                MinLimit = 0
            };

            viewModel2.XAxes = new Axis[] { eixoX };
            viewModel2.YAxes = new Axis[] { eixoY };

            cartesianChart2.Series = viewModel2.Series;
            cartesianChart2.XAxes = viewModel2.XAxes;
            cartesianChart2.YAxes = viewModel2.YAxes;
            cartesianChart2.LegendPosition = LegendPosition.Top;
            cartesianChart2.Size = new System.Drawing.Size(600, 300);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Alunos form = new Alunos();
            form.Show();
        }

        private void btnInstrumento_Click(object sender, EventArgs e)
        {
            CadastrarInstrumentos form = new CadastrarInstrumentos();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            InformacoesProfessores form = new InformacoesProfessores();
            form.Professor = this.Professor;
            form.Perfil = this.Perfil;
            form.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void txtQuantInstrumentos_Click(object sender, EventArgs e)
        {

        }

        public class ViewModel
        {


            public ObservableCollection<ISeries> Series { get; set; } = new ObservableCollection<ISeries>();

            public Axis[] XAxes { get; set; }


            public Axis[] YAxes { get; set; } = new Axis[]
            {
              new Axis
              {
              Name = "Hinos por Mês",
              MinLimit = 0
              }
            };


        }

        private void cartesianChart1_Load(object sender, EventArgs e)
        {

        }

        private void cmbAnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAnos.SelectedItem != null && int.TryParse(cmbAnos.SelectedItem.ToString(), out int anoSelecionado))
            {
                AtualizarGraficoPorAno(anoSelecionado);
            }
        }


        private void AtualizarGraficoPorAno(int ano)
        {
            ViewModel viewModel = new ViewModel();

            DataTable dados = BancoDados.PesquisarHinosporMes(ano);
            DataTableReader dr = dados.CreateDataReader();

            List<double> db1 = new List<double>();
            List<string> lb1 = new List<string>();

            while (dr.Read())
            {
                db1.Add(double.Parse(dr["Qtde"].ToString()));
                lb1.Add(dr["MES"].ToString());
            }

            ColumnSeries<double> s1 = new ColumnSeries<double>
            {
                Values = db1,
                Name = $"Hinos por Mês ({ano})"
            };

            viewModel.Series.Add(s1);

            Axis eixo1 = new Axis
            {
                Name = "Meses",
                Labels = lb1
            };

            viewModel.XAxes = new Axis[] { eixo1 };

            cartesianChart1.Series = viewModel.Series;
            cartesianChart1.XAxes = viewModel.XAxes;
            cartesianChart1.YAxes = viewModel.YAxes;
            cartesianChart1.LegendPosition = LegendPosition.Top;
            cartesianChart1.Size = new System.Drawing.Size(600, 300);
        }



        private void cartesianChart2_Load(object sender, EventArgs e)
        {


        }

        private void cmbFiltraGraph_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarGrafico();
        }

        private void FiltrarGrafico()
        {
            string selecionado = cmbFiltraGraph.SelectedItem.ToString();

            if (selecionado == "Hinos por Mês")
            {
                cartesianChart1.Visible = true;
                cartesianChart2.Visible = false;
                cartesianChart3.Visible = false;
            }
            else if (selecionado == "Hinos por Aluno")
            {
                cartesianChart1.Visible = false;
                cartesianChart2.Visible = true;
                cartesianChart3.Visible = false;
            }
            else if (selecionado == "Alunos por Instrumento")
            {
                cartesianChart1.Visible = false;
                cartesianChart2.Visible = false;
                cartesianChart3.Visible = true;

                AtualizarGraficoInstrumentos(); // Atualiza o gráfico quando selecionado
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            AlunosAptos alunosAptos = new AlunosAptos();
            alunosAptos.Show();
        }
    }
}

