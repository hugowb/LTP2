using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LTP2_ControleAcademico.Entidade
{
    public class Aluno
    {
        public int ID_Aluno { get; set; }
        public string RA_Aluno { get; set; }
        public string Nome_Aluno { get; set; }
        public string CPF_Aluno { get; set; }
        public string Sexo { get; set; }
        public string Ingresso { get; set; }
    }
}