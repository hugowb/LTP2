using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LTP2_ControleAcademico.Entidade;
using System.Data;

namespace LTP2_ControleAcademico.Negocio
{
    public class rnAluno: Aluno
    {
        public void Inserir()
        {
            string query = "INSERT INTO ltp2.aluno (RA_Aluno, Nome_Aluno, CPF_Aluno, Sexo, Ingresso) VALUES(";
            query = query + "'" + RA_Aluno + "',"
                          + "'" + Nome_Aluno + "',"
                          + "'" + CPF_Aluno + "',"
                          + "'" + Sexo + "',"
                          + "'" + Ingresso + "')";

            Conexao.modificarTabela(query);
        }

        public void Alterar()
        {
            string query = "UPDATE ltp2.aluno SET ";
            query = query + "RA_Aluno='" + RA_Aluno + "',"
                          + "Nome_Aluno='" + Nome_Aluno + "',"
                          + "CPF_Aluno='" + CPF_Aluno + "',"
                          + "Sexo='" + Sexo + "',"
                          + "Ingresso='" + Ingresso + "' "
                          + "WHERE ID_Aluno='" + ID_Aluno + "'";

            Conexao.modificarTabela(query);

        }

        public void Excluir()
        {
            string query = "DELETE FROM aluno "
                          + "WHERE ID_Aluno=" + ID_Aluno;

            Conexao.modificarTabela(query);
        }

        public DataTable RecuperarAlunos(string filtro)
        {
            string query;
            if (String.IsNullOrEmpty(filtro))
            {
                query = "SELECT * FROM aluno";
            }
            else
            {
                query = "SELECT * FROM aluno WHERE " + filtro;
            }

            DataTable Dados = new DataTable();
            Dados = Conexao.carregarTabela(query);
            return Dados;
        }

        public void RecuperarRegistro()
        {
            string query = "SELECT * FROM aluno WHERE ID_Aluno = " + ID_Aluno;
            DataTable Dados = new DataTable();
            Dados = Conexao.carregarTabela(query);

            if (Dados != null)
            {
                DataRow dr = Dados.Rows[0];
                RA_Aluno = dr["RA_Aluno"].ToString();
                Nome_Aluno = dr["Nome_Aluno"].ToString();
                CPF_Aluno = dr["CPF_Aluno"].ToString();
                Sexo = dr["Sexo"].ToString();
                Ingresso = dr["Ingresso"].ToString();
            }
        }
    }
}