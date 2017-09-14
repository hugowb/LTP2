<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Disciplinas.aspx.cs" Inherits="LTP2_ControleAcademico.Disciplinas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Disciplinas</title>
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
                    <h3>Disciplinas cadastradas</h3>
                    &nbsp;
                    
            <asp:GridView class="tabela" ID="gdvDisciplinas" align="center" runat="server" AutoGenerateColumns="false" EmptyDataText="Não há disciplinas Cadastrados" OnRowCommand="gdvDisciplinas_RowCommand">
                <Columns>
                    <asp:TemplateField HeaderText="Ações">
                        <ItemTemplate>
                            <asp:LinkButton Text="<span class='glyphicon glyphicon-edit'</span>" ID="Editar" runat="server" CommandName="editar" CommandArgument='<%# Eval("ID_Disciplina") %>' ToolTip="Editar">
                            </asp:LinkButton>
                            <asp:LinkButton ID="Excluir" runat="server" CommandName="excluir" CommandArgument='<%# Eval("ID_Disciplina") %>' ToolTip="Excluir">
                                <span class="glyphicon glyphicon-trash"></span>
                            </asp:LinkButton>
                            &nbsp
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField HeaderText="Código" DataField="Codigo_Disc" />
                    <asp:BoundField HeaderText="Disciplina" DataField="Nome_Disc" />
                    <asp:BoundField HeaderText="Ementa" DataField="Ementa" />
                    <asp:BoundField HeaderText="Semestre" DataField="Semestre" />
                    <asp:BoundField HeaderText="Carga Horaria" DataField="Carga_Hora" />
                </Columns>
            </asp:GridView>
                </div>
            </div>
        </div>

        <footer>
            <p>&copy; Hugo Wellington Pereira da Silva Borges</p>
        </footer>

    </form>
</body>
</html>
