using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LTP2_ControleAcademico.Entidade
{
    public class Disciplina
    {
        public int ID_Disciplina { get; set; }
        public string Codigo_Disc { get; set; }
        public string Nome_Disc { get; set; }
        public string Ementa { get; set; }
        public string Semestre { get; set; }
        public string Carga_Hora { get; set; }
    }
}