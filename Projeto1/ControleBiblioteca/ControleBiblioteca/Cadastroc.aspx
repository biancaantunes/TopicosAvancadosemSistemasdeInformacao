<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastroc.aspx.cs" Inherits="ControleBiblioteca.Cadastroc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

        .auto-style1 {
            width: 100%;
            height: 333px;
        }
        .auto-style2 {
            width: 124px;
        }
        .auto-style3 {
            width: 220px;
        }
        .auto-style7 {
            width: 179px;
        }
        .auto-style4 {
            width: 124px;
            height: 43px;
        }
        .auto-style5 {
            width: 220px;
            height: 43px;
        }
        .auto-style8 {
            height: 43px;
            width: 179px;
        }
        .auto-style6 {
            height: 43px;
        }
        .auto-style9 {
            width: 124px;
            height: 45px;
        }
        .auto-style10 {
            width: 220px;
            height: 45px;
        }
        .auto-style11 {
            width: 179px;
            height: 45px;
        }
        .auto-style12 {
            height: 45px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <div>
            Cadastrar Cliente:</div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Nome:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style4">Telefone:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtTelefone" runat="server" Width="175px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Pais:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtPais" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style2">Cidade: </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtCidade" runat="server" Width="173px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Endereço:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtEndereco" runat="server" Width="173px"></asp:TextBox>
                </td>
                <td class="auto-style2">CEP:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtCep" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">Número do Cartão:</td>
                <td>
                    <asp:TextBox ID="txtCartao" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style8">Data de Validade:</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtValidade" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">Código de Segurança:</td>
                <td>
                    <asp:TextBox ID="txtcodigo" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:Button ID="btn_Voltar" runat="server" Text="Voltar" PostBackUrl="~/TelaCliente.aspx" />
                </td>
                <td class="auto-style10">
                    <asp:Label ID="LblMsg" runat="server"></asp:Label>
                </td>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style12">
                    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
                </td>
            </tr>
        </table>
        <asp:GridView ID="GVCliente" runat="server" Width="727px">
        </asp:GridView>
    </form>
</body>
</html>
