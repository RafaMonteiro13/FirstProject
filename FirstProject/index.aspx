<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="FirstProject.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HiddenField ID ="idproduto" runat="server" />
            <table>
                <tr>
                    <td>
                        <asp:Label Text ="Produto" runat = "server" />
                    </td>

                    <td colspan="2">
                        <asp:TextBox id ="txtnome" runat = "server" />
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label Text ="Descrição" runat = "server" />
                    </td>

                    <td colspan="2">
                        <asp:TextBox id ="txtdescricao" runat = "server" />
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label Text ="Valor" runat = "server" />
                    </td>

                    <td colspan="2">
                        <asp:TextBox id ="txtvalor" runat = "server" />
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label Text ="Quantidade" runat = "server" />
                    </td>

                    <td colspan="2">
                        <asp:TextBox id ="txtquantidade" runat = "server" />
                    </td>
                </tr>

                <tr>
                    <td colspan ="3">
                        <asp:Button text ="Salvar" ID="btnSalvar" runat = "server" OnClick="btnSalvar_Click" />
                        <asp:Button text ="Editar" ID="btnEditar" runat = "server" />
                        <asp:Button text ="Deletar" ID="btnDeletar" runat = "server" />
                    </td>

                </tr>
               <tr>

                <td colspan="3">
                       <asp:Label Text ="" ID="lblMensagemOk"   runat = "server" ForeColor="Green" />
                </td>
               </tr>
                <tr>

                <td colspan="3">
                       <asp:Label Text ="" ID="lblMensagemErro" runat = "server" ForeColor="Red" />
                </td>
                    </tr>

            </table>
        </div>
    </form>
</body>
</html>
