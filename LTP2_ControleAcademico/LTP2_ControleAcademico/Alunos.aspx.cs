using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LTP2_ControleAcademico.Negocio;

namespace LTP2_ControleAcademico
{
    public partial class Alunos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                Session["Aluno"] = "0";
                Preencher_dados();
            }
        }

        private void Preencher_dados()
        {
            rnAluno A = new rnAluno();

            gdvAlunos.DataSource = A.RecuperarAlunos("");
            gdvAlunos.DataBind();


        }

        protected void gdvAlunos_RowCommand(object sender, GridViewCommandEventArgs e)
        {


            if (e.CommandName == "editar")
            {
                Session["Aluno"] = e.CommandArgument;
                Response.Redirect("CadastrarAluno.aspx");
            }
            if (e.CommandName == "excluir")
            {
                rnAluno A = new rnAluno();
                A.ID_Aluno = Convert.ToInt32(e.CommandArgument);
                A.Excluir();

                Response.Redirect("Alunos.aspx");
            }
        }
    }
}