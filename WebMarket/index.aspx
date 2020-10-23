<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebMarket.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="StyleSheet1.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="input">
                <asp:Label ID="Label1" runat="server" Text="Purchase"></asp:Label>
            <asp:TextBox ID="tbxPurchase" CssClass="purc" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label2" runat="server" Text="Turnover"></asp:Label>
        <asp:TextBox ID="tbxTurnover" runat="server" CssClass="turn"></asp:TextBox>
                <br />
                <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
                <br />
                <asp:Button CssClass="btnCalc" ID="Button1" runat="server" Text="Calculate" OnClick="Button1_Click" />
            </div>
            <div class="content">
     <div class="bronze">
                    <label>Bronze</label>
        <br />
        <br />
		<label>Purchase:</label> <asp:Label ID="brPV" runat="server" Text=""></asp:Label>
		<br>
		<label>Discount Rate:</label> <asp:Label ID="brDR" runat="server" Text=""></asp:Label>
		<br>
		<label>Discount:</label> <asp:Label ID="brD" runat="server" Text=""></asp:Label>
		<br>
		<label>Total:</label> <asp:Label ID="brT" runat="server" Text=""></asp:Label>
	</div>
	<div class="silver">
        <label>Silver</label>
        <br />
        <br />
		<label>Purchase:</label> <asp:Label ID="svPV" runat="server" Text=""></asp:Label>
		<br>
		<label>Discount Rate:</label> <asp:Label ID="svDR" runat="server" Text=""></asp:Label>
		<br>
		<label>Discount:</label> <asp:Label ID="svD" runat="server" Text=""></asp:Label>
		<br>
		<label>Total:</label> <asp:Label ID="svT" runat="server" Text=""></asp:Label>
	</div>
	<div class="gold">
        <label>Gold</label>
        <br />
        <br />
		<label>Purchase:</label> <asp:Label ID="gPV" runat="server" Text=""></asp:Label>
		<br>
		<label>Discount Rate:</label><asp:Label ID="gDR" runat="server" Text=""></asp:Label> 
		<br>
		<label>Discount:</label> <asp:Label ID="gD" runat="server" Text=""></asp:Label>
		<br>
		<label>Total:</label> <asp:Label ID="gT" runat="server" Text=""></asp:Label>
	</div>
            </div>
        </div>
        
    </form>
</body>
</html>
