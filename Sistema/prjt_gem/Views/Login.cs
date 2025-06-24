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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string nome = txtNomeProfessor.Text; // Obtém o nome do campo de texto
            string senha = txtSenhaProfessor.Text; // Obtém a senha do campo de texto

            // Verifica se o nome e senha estão corretos

            ProfessorPerfil prof = BancoDados.VerificaProfessorPerfil(nome, senha);

            if (!string.IsNullOrEmpty(prof.Professor))
            {
                // Abre a tela Home e fecha a tela Login
                this.Hide(); // Esconde a tela atual
                Home home = new Home(); // Instancia a tela Home
                home.Professor = prof.Professor;
                home.Perfil = prof.Perfil;
                home.ShowDialog(); // Exibe a tela Home
                this.Close(); // Fecha a tela Login
            }
            else
            {
                // Mensagem de erro
                MessageBox.Show("Nome ou senha incorretos! Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CadastrarProfessor CadastrarProfessor = new CadastrarProfessor(); // Instancia a tela Home
            CadastrarProfessor.ShowDialog(); // Exibe a tela Home

            txtNomeProfessor.Clear();
            txtSenhaProfessor.Clear();
        }
    }
}
