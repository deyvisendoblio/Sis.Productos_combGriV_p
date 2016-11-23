<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmProductosXcategoria.aspx.cs" Inherits="AppWeb_Productos.frmProductosXcategoria" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            position: absolute;
            top: 45px;
            left: 87px;
        }
        .style6
        {
            width: 608px;
        }
        .style8
        {
            width: 340px;
        }
        .style9
        {
            width: 608px;
            height: 23px;
        }
        .style10
        {
            width: 340px;
            height: 23px;
        }
        .style11
        {
            width: 608px;
            height: 62px;
        }
        .style12
        {
            width: 340px;
            position: absolute;
            height: 62px;
        }
    </style>
</head>
<body style="background-color: #FFFFCC">
    <form id="form1" runat="server">
    <div style="height: 332px">
    
        <table class="style1" style="position: relative; height: 261px; width: 376px;">
            <caption>
                Productos Por Categoria</caption>
            <tr>
                <td class="style11">
                    seleccione categoria</td>
                <td class="style12">
                    &nbsp;&nbsp;<asp:DropDownList 
                        ID="ddlCategoria" runat="server" Height="31px" 
                        style="margin-bottom: 13px; margin-top: 0px;" Width="193px" 
                        AutoPostBack="True" onselectedindexchanged="ddlCategoria_SelectedIndexChanged">
                    </asp:DropDownList>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style6">
                    Productos</td>
                <td class="style8">
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:GridView ID="dgvProductos" runat="server" 
                        onselectedindexchanged="dgvProductos_SelectedIndexChanged">
                        <Columns>
                            <asp:CommandField ShowSelectButton="True" />
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td class="style6">
                    stock</td>
                <td class="style8">
                    <asp:TextBox ID="txtStock" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style6">
                    &nbsp;</td>
                <td class="style8">
                    <asp:Button ID="Button2" runat="server" Text="Button" onclick="Button2_Click" />
                </td>
            </tr>
            <tr>
                <td class="style9">
                    </td>
                <td class="style10">
                    </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
