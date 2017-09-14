<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastrarDisciplina.aspx.cs" Inherits="LTP2_ControleAcademico.CadastarDisciplina" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cadastro de Aluno</title>
    <link type="text/css" rel="stylesheet" href="Content/bootstrap.css" />
    <link type="text/css" rel="stylesheet" href="Content/customize.css" />
    <script src="Scripts/jquery-1.9.1.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <nav id="bar" class="navbar navbar-inverse navbar-fixed-top">
            <div class="container-fluid">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#home">
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" href="home.aspx">UNIFIC <span class="glyphicon glyphicon-home"></span></a>
                </div>
                <div>
                    <div class="collapse navbar-collapse" id="home">
                        <ul class="nav navbar-nav">
                            <li class="dropdown"><a class="dropdown-toggle" data-toggle="dropdown" href="#">Curso <span class="caret"></span></a>
                                <ul class="dropdown-menu">
                                    <li><a href="CadastrarCurso.aspx">Cadastrar</a></li>
                                    <li><a href="Cursos.aspx">Visualizar</a></li>
                                </ul>
                            </li>

                            <li class="dropdown"><a class="dropdown-toggle" data-toggle="dropdown" href="#">Disciplina <span class="caret"></span></a>
                                <ul class="dropdown-menu">
                                    <li><a href="CadastrarDisciplina.aspx">Cadastrar</a></li>
                                    <li><a href="Disciplinas.aspx">Visualizar</a></li>
                                </ul>
                            </li>

                            <li class="dropdown"><a class="dropdown-toggle" data-toggle="dropdown" href="#">Aluno <span class="caret"></span></a>
                                <ul class="dropdown-menu">
                                    <li><a href="CadastrarAluno.aspx">Cadastrar</a></li>
                                    <li><a href="Alunos.aspx">Visualizar</a></li>
                                </ul>
                            </li>

                        </ul>

                        <ul class="nav navbar-nav navbar-right">
                            <li><a href="#"><span class="glyphicon glyphicon-user"></span>Cadastre-se</a></li>
                            <li><a href="#"><span class="glyphicon glyphicon-log-in"></span>Entrar</a></li>
                        </ul>
                    </div>
                </div>
            </div>
        </nav>

        <div class="container">
            <div class="row">
                <div class="jumbotron" id="jbt01">
                    &nbsp;
                    <h3>Cadastro de Disciplina</h3>
                    &nbsp;
                    <label>Código</label>
                    <asp:TextBox ID="txtCodigo" runat="server" class="form-control"></asp:TextBox>
                    <label>Disciplina</label>
                    <asp:TextBox ID="txtDisciplina" runat="server" class="form-control"></asp:TextBox>
                    <label>Ementa</label>
                    <asp:TextBox ID="txtEmenta" runat="server" class="form-control"></asp:TextBox>
                    <label>Semestre</label>
                    <asp:TextBox ID="txtSemestre" runat="server" class="form-control"></asp:TextBox>
                    <label>Carga Horaria</label>
                    <asp:TextBox ID="txtCargaHoraria" runat="server" class="form-control"></asp:TextBox><br />
                    <br />
                    <asp:Button ID="btnSalvar" class="btn btn-primary" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
                </div>
            </div>
        </div>
        
        <footer>
            <p>&copy; Hugo Wellington Pereira da Silva Borges</p>
        </footer>
    </form>
</body>
</html>
