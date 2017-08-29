<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Epic_Spies_Challenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="font-family: Arial, Helvetica, sans-serif">
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" Height="190px" ImageUrl="~/epic-spies-logo.jpg" />
        <h2>Spy New Assignment Form</h2>
        Spy Code Name&nbsp; <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        New Assignment Name&nbsp;
        <asp:TextBox ID="assignmentTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        End Date of Previous Assignment<asp:Calendar ID="oldAssignmentEnd" runat="server"></asp:Calendar>
        <br />
        Start Date of New Assignment<asp:Calendar ID="newAssignmentStart" runat="server"></asp:Calendar>
        <br />
        Projected End Date of New Assignment<asp:Calendar ID="newAssignmentEnd" runat="server" OnSelectionChanged="Calendar3_SelectionChanged"></asp:Calendar>
        <br />
        <asp:Button ID="assignButton" runat="server" OnClick="assignButton_Click" Text="Assign Spy" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
