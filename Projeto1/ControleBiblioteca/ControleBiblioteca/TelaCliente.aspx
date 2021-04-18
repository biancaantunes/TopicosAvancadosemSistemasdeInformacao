<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TelaCliente.aspx.cs" Inherits="ControleBiblioteca.Controle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 335px;
        }
        .auto-style2 {
            width: 211px;
        }
        .auto-style7 {
            width: 211px;
            height: 34px;
        }
        .auto-style9 {
            height: 34px;
        }
        .auto-style10 {
            width: 223px;
        }
        .auto-style11 {
            width: 223px;
            height: 34px;
        }
        .auto-style13 {
            width: 164px;
        }
        .auto-style14 {
            width: 164px;
            height: 34px;
        }
        .auto-style15 {
            width: 211px;
            height: 30px;
        }
        .auto-style16 {
            width: 164px;
            height: 30px;
        }
        .auto-style17 {
            width: 223px;
            height: 30px;
        }
        .auto-style18 {
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Conta</td>
                <td class="auto-style13">Livros</td>
                <td class="auto-style10">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7"></td>
                <td class="auto-style14"></td>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style9"></td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="Button7" runat="server" Text="Cadastrar" PostBackUrl="~/Cadastroc.aspx" />
                </td>
                <td class="auto-style13">
                    <asp:Button ID="Button10" runat="server" Text="Consultar" PostBackUrl="~/ConsultarLivro.aspx" />
                </td>
                <td class="auto-style10">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    &nbsp;</td>
                <td class="auto-style13">
                    <asp:Button ID="Button6" runat="server" Text="Comprar" PostBackUrl="~/ComprarLivro.aspx" />
                </td>
                <td class="auto-style10">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7"></td>
                <td class="auto-style14"></td>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style9"></td>
            </tr>
            <tr>
                <td class="auto-style15"></td>
                <td class="auto-style16"></td>
                <td class="auto-style17"></td>
                <td class="auto-style18"></td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
