using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LTP2_ControleAcademico.Negocio;

namespace LTP2_ControleAcademico
{
    public partial class CadastarDisciplina : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            rnDisciplina D = new rnDisciplina();

            D.ID_Disciplina = Convert.ToInt32(Session["Disciplina"]);

            if (!IsPostBack)
            {
                Session["Disciplina"] = Convert.ToInt32(D.ID_Disciplina);

                if (Session["Disciplina"].ToString() != "0")
                {
                    preencherFormulario();
                }
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            rnDisciplina D = new rnDisciplina();

            D.Codigo_Disc = txtCodigo.Text;
            D.Nome_Disc = txtDisciplina.Text;
            D.Semestre = txtSemestre.Text;
            D.Ementa = txtEmenta.Text;
            D.Carga_Hora = txtCargaHoraria.Text;

            if (Session["Disciplina"].ToString() == "0")
            {
                D.Inserir();
            }
            else
            {
                D.ID_Disciplina = Convert.ToInt32(Session["Disciplina"]);
                D.Alterar();
            }

            Response.Redirect("Disciplinas.aspx");

        }

        public void preencherFormulario()
        {
            rnDisciplina D = new rnDisciplina();
            D.ID_Disciplina = Convert.ToInt32(Session["Disciplina"]);
            D.RecuperarRegistro();

            txtCodigo.Text = D.Codigo_Disc;
            txtDisciplina.Text = D.Nome_Disc;
            txtEmenta.Text = D.Ementa;
            txtSemestre.Text = D.Semestre;
            txtCargaHoraria.Text = D.Carga_Hora;
        }
    }
}