<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ejercicio03.aspx.cs" Inherits="Ejercicio03.ejercicio03" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label>Ingrese su edad:</label><br />
            <asp:TextBox ID="TextEdad" runat="server" TextMode="Number"></asp:TextBox><br />

            <label>Ingrese su promdio:</label><br />
            <asp:TextBox ID="TextPromedio" runat="server" TextMode="Number"></asp:TextBox><br />

            <asp:Button ID="btnEvaluar" runat="server" OnClick="btnEvaluar_Click" Text="Evaluar"/>

            <label>Beca que tendra:</label><br />
            <asp:TextBox ID="TextBeca" runat="server" TextMode="Number"></asp:TextBox><br />
        </div>
    </form>
</body>
</html>
