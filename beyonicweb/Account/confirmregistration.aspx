<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="confirmregistration.aspx.cs" Inherits="beyonicweb.Account.confirmregistration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Please Type The code You Recived"></asp:Label>
    <br />
    <br />
    <asp:TextBox ID="TextBox1" runat="server" Width="211px"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btncodesub" runat="server" onclick="btncodesub_Click" 
        Text="submit" Width="109px" />
</asp:Content>
