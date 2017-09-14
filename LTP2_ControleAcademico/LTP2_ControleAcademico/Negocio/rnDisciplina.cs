using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LTP2_ControleAcademico.Entidade;
using System.Data;

namespace LTP2_ControleAcademico.Negocio
{
    public class rnDisciplina : Disciplina
    {
        public void Inserir()
        {
            string query = "INSERT INTO disciplina (Codigo_Disc, Nome_Disc, Ementa, Semestre, Carga_Hora) VALUES(";
            query = query + "'" + Codigo_Disc + "',"
                          + "'" + Nome_Disc + "',"
                          + "'" + Ementa + "',"
                          + "'" + Semestre + "',"
                          + "'" + Carga_Hora + "')";

            Conexao.modificarTabela(query);
        }

        public void Alterar()
        {
            string query = "UPDATE disciplina SET ";
            query = query + "Codigo_Disc='" + Codigo_Disc + "',"
                          + "Nome_Disc='" + Nome_Disc + "',"
                          + "Ementa='" + Ementa + "',"
                          + "Semestre='" + Semestre + "',"
                          + "Carga_Hora='" + Carga_Hora + "'"
                          + "WHERE ID_Disciplina='" + ID_Disciplina + "'";

            Conexao.modificarTabela(query);

        }

        public void Excluir()
        {
            string query = "DELETE FROM disciplina "
                          + "WHERE ID_Disciplina=" + ID_Disciplina;

            Conexao.modificarTabela(query);
        }

        public DataTable RecuperarDisciplinas(string filtro)
        {
            string query;
            if (String.IsNullOrEmpty(filtro))
            {
                query = "SELECT * FROM disciplina";
            }
            else
            {
                query = "SELECT * FROM disciplina WHERE " + filtro;
            }

            DataTable Dados = new DataTable();
            Dados = Conexao.carregarTabela(query);
            return Dados;
        }

        public void RecuperarRegistro()
        {
            string query = "SELECT * FROM disciplina WHERE ID_Disciplina = " + ID_Disciplina;
            DataTable Dados = new DataTable();
            Dados = Conexao.carregarTabela(query);

            if (Dados != null)
            {
                DataRow dr = Dados.Rows[0];
                Codigo_Disc = dr["Codigo_Disc"].ToString();
                Nome_Disc = dr["Nome_Disc"].ToString();
                Ementa = dr["Ementa"].ToString();
                Semestre= dr["Semestre"].ToString();
                Carga_Hora = dr["Carga_Hora"].ToString();
            }
        }

    }
}