<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.master" AutoEventWireup="true" CodeFile="Recetario.aspx.cs" Inherits="Recetario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Button Text="Llenar" runat="server" ID="btn" onclick="btn_Click" />
    <br />
    <br />  
    <asp:Button Text="Buscar" runat="server" ID="btnBuscar" 
        onclick="btnBuscar_Click" /> &nbsp &nbsp
    <asp:TextBox runat="server" placeholder="Introduce id" ID="txt"/>
    <br />
    
    <asp:GridView ID="gvRecetario" runat="server">
    </asp:GridView>
</asp:Content>

