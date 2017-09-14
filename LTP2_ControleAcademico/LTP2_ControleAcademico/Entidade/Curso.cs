using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LTP2_ControleAcademico.Entidade
{
    public class Curso
    {
        public int ID_Curso { get; set; }
        public string Codigo_Curso { get; set; }
        public string Nome_Curso { get; set; }
        public string Periodo_Curso { get; set; }
        public string Duracao_Curso { get; set; }
        public string Enade_Curso { get; set; }
    }
}