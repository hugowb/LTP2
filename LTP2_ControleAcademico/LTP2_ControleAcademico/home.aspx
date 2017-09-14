<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="LTP2_ProjetoWeb_001.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link type="text/css" rel="stylesheet" href="Content/customize.css" />
    <link type="text/css" rel="stylesheet" href="Content/bootstrap.css" />
    <script src="Scripts/jquery-1.9.1.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>

    <title></title>
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
            &nbsp;
            
            <div class="col-sm-12">
                <div id="carousel" class="carousel slide" data-ride="carousel">
                    <!-- Indicators -->
                    <ol class="carousel-indicators">
                        <li data-target="#carousel-example-generic" data-slide-to="0" class="active"></li>
                        <li data-target="#carousel-example-generic" data-slide-to="1"></li>
                        <li data-target="#carousel-example-generic" data-slide-to="2"></li>
                    </ol>

                    <!-- Wrapper for slides -->
                    <div class="carousel-inner">
                        <div class="item active">
                            <img src="image/banner-vestibular2014.jpg" alt="..." />
                            <div class="carousel-caption">
                                <h2>Heading</h2>
                            </div>
                        </div>
                        <div class="item">
                            <img src="image/ENEM-01.png" alt="..." />
                            <div class="carousel-caption">
                                <h2>Heading</h2>
                            </div>
                        </div>
                        <div class="item">
                            <img src="image/volta_as_aulas.jpg" alt="..." />
                            <div class="carousel-caption">
                                <h2>Heading</h2>
                            </div>
                        </div>
                    </div>

                    <!-- Controls -->
                    <a class="left carousel-control" href="#carousel-example-generic" data-slide="prev">
                        <span class="glyphicon glyphicon-chevron-left"></span>
                    </a>
                    <a class="right carousel-control" href="#carousel-example-generic" data-slide="next">
                        <span class="glyphicon glyphicon-chevron-right"></span>
                    </a>
                </div>
            </div>
        </div>
        <footer>
            <p>&copy; Hugo Wellington Pereira da Silva Borges</p>
        </footer>
    </form>
</body>
</html>
