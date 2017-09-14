using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LTP2_ControleAcademico.Negocio;

namespace LTP2_ControleAcademico
{
    public partial class Disciplinas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            rnDisciplina D = new rnDisciplina();

            if (!IsPostBack)
            {
                Session["Disciplina"] = "0";
                Preencher_dados();
            }
        }

        private void Preencher_dados()
        {
            rnDisciplina D = new rnDisciplina();

            gdvDisciplinas.DataSource = D.RecuperarDisciplinas("");
            gdvDisciplinas.DataBind();


        }

        protected void gdvDisciplinas_RowCommand(object sender, GridViewCommandEventArgs e)
        {


            if (e.CommandName == "editar")
            {
                Session["Disciplina"] = e.CommandArgument;
                Response.Redirect("CadastrarDisciplina.aspx");
            }
            if (e.CommandName == "excluir")
            {
                rnDisciplina D = new rnDisciplina();
                D.ID_Disciplina = Convert.ToInt32(e.CommandArgument);
                D.Excluir();

                Response.Redirect("Disciplinas.aspx");
            }
        }
    }
}