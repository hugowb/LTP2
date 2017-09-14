using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LTP2_ControleAcademico.Entidade;
using System.Data;

namespace LTP2_ControleAcademico.Negocio
{
    public class rnCurso :Curso
    {
        public void Inserir()
        {
            string query = "INSERT INTO curso (Codigo_Curso, Nome_Curso, Periodo_Curso, Duracao_Curso, Enade_Curso) VALUES(";
            query = query + "'" + Codigo_Curso + "',"
                          + "'" + Nome_Curso + "',"
                          + "'" + Periodo_Curso + "',"
                          + "'" + Duracao_Curso + "',"
                          + "'" + Enade_Curso + "')";

            Conexao.modificarTabela(query);
        }

        public void Alterar()
        {
            string query = "UPDATE curso SET ";
            query = query + "Codigo_Curso='" + Codigo_Curso + "',"
                          + "Nome_Curso='" + Nome_Curso + "',"
                          + "Periodo_Curso='" + Periodo_Curso + "',"
                          + "Duracao_Curso='" + Duracao_Curso + "',"
                          + "Enade_Curso='" + Enade_Curso + "' "
                          + "WHERE ID_Curso='" + ID_Curso + "'";

            Conexao.modificarTabela(query);

        }

        public void Excluir()
        {
            string query = "DELETE FROM curso "
                          + "WHERE ID_Curso=" + ID_Curso;

            Conexao.modificarTabela(query);
        }

        public DataTable RecuperarCursos(string filtro)
        {
            string query;
            if (String.IsNullOrEmpty(filtro))
            {
                query = "SELECT * FROM curso";
            }
            else
            {
                query = "SELECT * FROM curso WHERE " + filtro;
            }

            DataTable Dados = new DataTable();
            Dados = Conexao.carregarTabela(query);
            return Dados;
        }

        public void RecuperarRegistro()
        {
            string query = "SELECT * FROM curso WHERE ID_Curso = " + ID_Curso;
            DataTable Dados = new DataTable();
            Dados = Conexao.carregarTabela(query);

            if (Dados != null)
            {
                DataRow dr = Dados.Rows[0];
                Codigo_Curso = dr["Codigo_Curso"].ToString();
                Nome_Curso = dr["Nome_Curso"].ToString();
                Periodo_Curso = dr["Periodo_Curso"].ToString();
                Duracao_Curso = dr["Duracao_Curso"].ToString();
                Enade_Curso = dr["Enade_Curso"].ToString();
            }
        }
    }
}