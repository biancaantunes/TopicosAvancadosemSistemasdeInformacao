<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultarLivro.aspx.cs" Inherits="ControleBiblioteca.ConsultarLivro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GVLivro" runat="server" Width="731px">
        </asp:GridView>
        <asp:Button ID="Button1" runat="server" PostBackUrl="~/TelaCliente.aspx" Text="Voltar" />
    </form>
</body>
</html>
