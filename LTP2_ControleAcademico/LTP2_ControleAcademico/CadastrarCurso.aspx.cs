using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LTP2_ControleAcademico.Negocio;

namespace LTP2_ControleAcademico
{
    public partial class CadastrarCurso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            rnCurso C = new rnCurso();

            C.ID_Curso = Convert.ToInt32(Session["Curso"]);

            if (!IsPostBack)
            {
                Session["Curso"] = Convert.ToInt32(C.ID_Curso);

                if (Session["Curso"].ToString() != "0")
                {
                    preencherFormulario();
                }
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
       {
            rnCurso C = new rnCurso();

            C.Codigo_Curso = txtCodido.Text;
            C.Nome_Curso = txtCurso.Text;
            C.Periodo_Curso = txtPeriodo.Text;
            C.Duracao_Curso = txtDuracao.Text;
            C.Enade_Curso = txtEnade.Text;

            if (Session["Curso"].ToString() == "0")
            {
                C.Inserir();
            }
            else
            {
                C.ID_Curso = Convert.ToInt32(Session["Curso"]);
                C.Alterar();
            }

            Response.Redirect("Cursos.aspx");

        }

        public void preencherFormulario()
        {
            rnCurso C = new rnCurso();

            C.ID_Curso = Convert.ToInt32(Session["Curso"]);
            C.RecuperarRegistro();

            txtCodido.Text = C.Codigo_Curso;
            txtCurso.Text = C.Nome_Curso ;
            txtPeriodo.Text = C.Periodo_Curso;
            txtDuracao.Text = C.Duracao_Curso;
            txtEnade.Text = C.Enade_Curso;
        }
    }
}