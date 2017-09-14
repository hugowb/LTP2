using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LTP2_ControleAcademico.Negocio;


namespace LTP2_ControleAcademico
{
    public partial class Cursos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            rnCurso C = new rnCurso();

            if (!IsPostBack)
            {
                Session["Curso"] = "0";
                Preencher_dados();
            }
        }

        private void Preencher_dados()
        {
            rnCurso C = new rnCurso();

            gdvCursos.DataSource = C.RecuperarCursos("");
            gdvCursos.DataBind();


        }

        protected void gdvCursos_RowCommand(object sender, GridViewCommandEventArgs e)
        {


            if (e.CommandName == "editar")
            {
                Session["Curso"] = e.CommandArgument;
                Response.Redirect("CadastrarCurso.aspx");
            }
            if (e.CommandName == "excluir")
            {
                rnCurso C= new rnCurso();
                C.ID_Curso = Convert.ToInt32(e.CommandArgument);
                C.Excluir();

                Response.Redirect("Cursos.aspx");
            }
        }
    }
}