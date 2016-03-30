<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.master" AutoEventWireup="true" CodeFile="RecuperaObtener.aspx.cs" Inherits="RecuperaObtener" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container">
Apellidos
    <br />
    <asp:Label Text="Lista de apellidos" runat="server" ID="lbl" />
    <br />
    <asp:Button Text="Buscar" runat="server" ID="btn" onclick="btn_Click"/>

</div>
</asp:Content>

