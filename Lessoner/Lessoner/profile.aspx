﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="~/profile.aspx.cs" Inherits="Lessoner.profile" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title id="title">Dein Profil
    </title>
    <link href="Bootstrap/css/bootstrap.css" rel="stylesheet" />
    <link href="Bootstrap/css/bootstrap-theme.css" rel="stylesheet" />
    <link href="CSS/Style.css" rel="stylesheet" />
    <script src="JQuery/jquery-1.10.2.js"></script>
    <script src="Bootstrap/js/bootstrap.js"></script>
    <script src="Javascript/LoginScript.js"></script>
    <script src="Javascript/profile.js"></script>
    <script src="Javascript/Global.js"></script>
</head>
<body onload="getdata(); CheckLoggedin('profile.aspx');">
    <div class="alert alert-danger alert-dismissable" id="ErrorDisplay" style="display: none">
        <button type="button" class="close" aria-hidden="true" onclick="CloseError()">&times;</button>
        <strong>Fehler: </strong>
        <label id="ErrorText"></label>
    </div>
    <div class="navbar navbar-inverse navbar-fixed-top" role="navigation">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
            </div>
            <div class="collapse navbar-collapse">
                <ul class="nav navbar-nav">
                    <li class="active"><a href="#">Hauptseite</a></li>
                    <li><a href="about.aspx">Über den Lessoner</a></li>
                    <li><a href="contact.aspx">Kontakt</a></li>
                </ul>
                <form class="navbar-form navbar-right" role="form" id="LoginForm" runat="server">
                    <asp:UpdatePanel runat="server">
                        <ContentTemplate>
                            <asp:ScriptManager runat="server"></asp:ScriptManager>
                                <asp:Panel runat="server" ID="LoginControlls">
                                <div class="form-group">
                                    <asp:TextBox runat="server" placeholder="Email" class="form-control" id="txtUsername"></asp:TextBox>
                                </div>
                                 <div class="form-group">
                                <asp:TextBox TextMode="Password" placeholder="Passwort" class="form-control" id="txtPasswort" runat="server"></asp:TextBox>
                                </div>
                                <asp:Button class="btn btn-success" Text="Anmelden" onclick="btnLoginSubmit_Click" id="btnLoginSubmit" runat="server" />
                            </asp:Panel>
                        </ContentTemplate>
                        <Triggers>
                            <asp:AsyncPostBackTrigger  ControlID="txtUsername" />
                            <asp:AsyncPostBackTrigger ControlID="txtPasswort" />
                            <asp:AsyncPostBackTrigger ControlID="btnLoginSubmit" />
                        </Triggers>
                    </asp:UpdatePanel>
                </form>
            </div>
        </div>
    </div>

    <div class="container">
        <h1 id="vnname"></h1>

        <div class="row">
            <div class="col-md-4">
                <img src="Data\ProfileImages\0001.jpg" height: 300px;" class="hidden-xs" class="hidden-sm" />
                <!-- TODO: Bild beim Upload bearbeiten auf 300x300 ohne stauchung -->
            </div>
            <div class="col-md-4">
                <table class="table table-striped">
                    <tbody>
                        <tr>
                            <td id="strasseNr"></td>
                        </tr>
                        <tr>
                            <td id="PLZOrt"></td>
                        </tr>
                        <tr>
                            <td id="Klasse">Klasse nicht gegeben!</td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>

    
    <script src="../../dist/js/bootstrap.min.js"></script>

</body>
</html>
