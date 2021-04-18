<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroL.aspx.cs" Inherits="ControleBiblioteca.CadastroL" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

        .auto-style2 {
            width: 100%;
            height: 330px;
        }
        .auto-style3 {
            width: 170px;
        }
        .auto-style7 {
            width: 477px;
        }
        .auto-style4 {
            height: 23px;
            width: 170px;
        }
        .auto-style8 {
            width: 170px;
            height: 36px;
        }
        .auto-style6 {
            height: 23px;
            width: 477px;
        }
        .auto-style9 {
            width: 477px;
            height: 36px;
        }
        .auto-style10 {
            width: 170px;
            height: 31px;
        }
        .auto-style11 {
            width: 477px;
            height: 31px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table class="auto-style2">
            <tr>
                <td class="auto-style10">Cadastrar Livro:</td>
                <td class="auto-style11"></td>
                <td class="auto-style11"></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Título:</td>
                <td class="auto-style7">
                    <asp:TextBox ID="txtTitulo" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Nome do Autor:</td>
                <td class="auto-style7">
                    <asp:TextBox ID="txtAutor" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Editora:</td>
                <td class="auto-style7">
                    <asp:TextBox ID="txtEditora" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Data de Lançamento:</td>
                <td class="auto-style7">
                    <asp:TextBox ID="txtDatadeLancamento" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">Preço:</td>
                <td class="auto-style9">
                    <asp:TextBox ID="txtPreco" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style9">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Button ID="Button1" runat="server" Text="Voltar" PostBackUrl="~/TelaAdm.aspx" />
                </td>
                <td class="auto-style7">
                    <asp:Label ID="LblMsg" runat="server"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4"></td>
                <td class="auto-style6"></td>
                <td class="auto-style6">&nbsp;</td>
            </tr>
        </table>
        <asp:GridView ID="GVLivro" runat="server" Width="724px">
        </asp:GridView>
    </form>
</body>
</html>
