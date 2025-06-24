using IgrejaMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgrejaMVC.Controllers
{
    internal class LoginController
    {
        public string VerificarUsuario(string nome, string senha)
        {
            if (BancoDados.VerificaProfessor(nome, senha))
            {
                return "Login realizado com sucesso";
            }
            else
            {
                return "CPF ou Senha inválido";
            }

        }
    }
}
