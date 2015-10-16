<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="registerconfermation.aspx.cs" Inherits="beyonicweb.Account.registerconfermation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        Enter The Code You Received:&nbsp;&nbsp;
        <asp:Label ID="lblusername" runat="server"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="txtphonecode" runat="server" Width="251px"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnsub" runat="server" Text="Submit" Width="100px" />
    </p>
</asp:Content>
