using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LTP2_ControleAcademico.Negocio;

namespace LTP2_ControleAcademico
{
    public partial class CadastrarAluno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            rnAluno A = new rnAluno();

            A.ID_Aluno = Convert.ToInt32(Session["Aluno"]);

            if (!IsPostBack)
            {
                Session["Aluno"] = Convert.ToInt32(A.ID_Aluno);

                if (Session["Aluno"].ToString() != "0")
                {
                    preencherFormulario();
                }
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            rnAluno A = new rnAluno();

            A.RA_Aluno = txtRA.Text;
            A.Nome_Aluno = txtNome.Text;
            A.CPF_Aluno = txtCPF.Text;
            A.Sexo = txtSexo.Text;
            A.Ingresso = txtIngresso.Text;

            if (Session["Aluno"].ToString() == "0")
            {
                A.Inserir();
            }
            else
            {
                A.ID_Aluno = Convert.ToInt32(Session["Aluno"]);
                A.Alterar();
            }

            Response.Redirect("Alunos.aspx");

        }

        public void preencherFormulario()
        {
            rnAluno A = new rnAluno();

            A.ID_Aluno = Convert.ToInt32(Session["Aluno"]);
            A.RecuperarRegistro();

            txtRA.Text = A.RA_Aluno;
            txtNome.Text = A.Nome_Aluno;
            txtCPF.Text = A.CPF_Aluno;
            txtSexo.Text = A.Sexo;
            txtIngresso.Text = A.Ingresso;
        }
    }
}