<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfCliente.aspx.cs" Inherits="CapaPresentaci.wfCliente" %>

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
        <asp:GridView ID="GridView1" runat="server" Height="330px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="512px">
        </asp:GridView>
    </form>
</body>
</html>
