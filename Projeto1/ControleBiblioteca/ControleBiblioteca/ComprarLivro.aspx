<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ComprarLivro.aspx.cs" Inherits="ControleBiblioteca.ComprarLivro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 276px;
        }
        .auto-style2 {
            width: 160px;
        }
        .auto-style3 {
            width: 160px;
            height: 40px;
        }
        .auto-style4 {
            height: 40px;
        }
        .auto-style5 {
            width: 212px;
        }
        .auto-style6 {
            height: 40px;
            width: 212px;
        }
        .auto-style7 {
            height: 299px;
        }
        .auto-style8 {
            width: 160px;
            height: 30px;
        }
        .auto-style9 {
            width: 212px;
            height: 30px;
        }
        .auto-style10 {
            height: 30px;
        }
        .auto-style11 {
            width: 160px;
            height: 26px;
        }
        .auto-style12 {
            width: 212px;
            height: 26px;
        }
        .auto-style13 {
            height: 26px;
        }
        .auto-style14 {
            width: 160px;
            height: 29px;
        }
        .auto-style15 {
            width: 212px;
            height: 29px;
        }
        .auto-style16 {
            height: 29px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style7">
        <div>
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Carrinho de Compras:</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style6"></td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style2">Id_Cliente:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtcliente" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Nome:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style14">Id_Livro:</td>
                <td class="auto-style15">
                    <asp:TextBox ID="txtlivro" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style16"></td>
            </tr>
            <tr>
                <td class="auto-style8">
                    Titulo:</td>
                <td class="auto-style9">
                    <asp:TextBox ID="txtTitulo" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style10">
                </td>
            </tr>
            <tr>
                <td class="auto-style11">
                </td>
                <td class="auto-style12">
                    <asp:Label ID="LblMsg" runat="server"></asp:Label>
                </td>
                <td class="auto-style13">
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    &nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="Button2" runat="server" PostBackUrl="~/TelaCliente.aspx" Text="Voltar" />
                </td>
                <td class="auto-style5">&nbsp;</td>
                <td>
                    <asp:Button ID="btnSalvar" runat="server" Text="Comprar" OnClick="btnSalvar_Click" />
                </td>
            </tr>
            </table>
        <asp:GridView ID="GVCarrinho" runat="server" Width="728px">
        </asp:GridView>
    </form>
</body>
</html>
