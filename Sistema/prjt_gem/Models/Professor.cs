using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace IgrejaMVC.Models
{
    internal class Professor
    {
        public int Id { get; set; }
        public string Nome_professor { get; set; }
        public string Senha_professor { get; set; }

    }



}
