<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.master" AutoEventWireup="true" CodeFile="ClonGitHubPruebaGV.aspx.cs" Inherits="ClonGitHubPruebaGV" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="css/bootstrap.css" rel="stylesheet" />
    <link href="css/bootstrap-datepicker.css" rel="stylesheet" />
    <link href="css/bootstrap-datepicker.standalone.css" rel="stylesheet" />
    <link href="css/bootstrap-datepicker3.css" rel="stylesheet" />
    <link href="css/bootstrap-datepicker3.standalone.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <div class="panel panel-primary">
            <div class="panel-heading">
            </div>
            <div class="panel-body">
                <div style="overflow: scroll; height: 300px;">
                    <asp:GridView ID="gvPersonas" runat="server" AutoGenerateColumns="False" ShowFooter="True"
                        DataKeyNames="Id,SexoId" OnRowCancelingEdit="gvPersonas_RowCancelingEdit" OnRowDeleting="gvPersonas_RowDeleting"
                        OnRowEditing="gvPersonas_RowEditing" OnRowUpdating="gvPersonas_RowUpdating">
                        <Columns>
                            <asp:TemplateField HeaderText="ID">
                                <EditItemTemplate>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("Id") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="NOMBRE">
                                <EditItemTemplate>
                                    <asp:TextBox ID="txtNombreEIT" runat="server" Text='<%# Bind("Nombre") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("Nombre") %>'></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox runat="server" ID="txtNombreFT" />
                                </FooterTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="APELLIDO PATERNO">
                                <EditItemTemplate>
                                    <asp:TextBox ID="txtPaternoEIT" runat="server" Text='<%# Bind("Paterno") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("Paterno") %>'></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox runat="server" ID="txtPaternoFT" />
                                </FooterTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="APELLIDO MATERNO">
                                <EditItemTemplate>
                                    <asp:TextBox ID="txtMaternoEIT" runat="server" Text='<%# Bind("Materno") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("Materno") %>'></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox runat="server" ID="txtMaternoFT" />
                                </FooterTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="FECHA DE NACIMIENTO">
                                <EditItemTemplate>
                                    <asp:TextBox ID="txtFechaNacimientoEIT" runat="server" Text='<%# Bind("fechaNacimiento") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label5" runat="server" Text='<%# Bind("fechaNacimiento", "{0:dd/MM/yyyy}") %>'></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox runat="server" ID="txtFechaNacimientoFT" />
                                </FooterTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="CORREO ELECTRÓNICO">
                                <EditItemTemplate>
                                    <asp:TextBox ID="txtMailEIT" runat="server" Text='<%# Bind("Mail") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label6" runat="server" Text='<%# Bind("Mail") %>'></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox runat="server" ID="txtMailFT" />
                                </FooterTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="SUELDO">
                                <EditItemTemplate>
                                    <asp:TextBox ID="txtSueldoEIT" runat="server" Text='<%# Bind("Sueldo") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label7" runat="server" Text='<%# Bind("Sueldo", "{0:c}") %>'></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox runat="server" ID="txtSueldoFT" />
                                </FooterTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="SEXO">
                                <EditItemTemplate>
                                    <asp:DropDownList runat="server" ID="ddlSexoEIT" AppendDataBoundItems="true">
                                        <asp:ListItem Text="Elige Sexo" Value="0" />
                                    </asp:DropDownList>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label8" runat="server" Text='<%# Bind("Sexo.Nombre") %>'></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <asp:DropDownList runat="server" ID="ddlSexoFT" AppendDataBoundItems="true">
                                        <asp:ListItem Text="Elige Sexo" Value="0" />
                                    </asp:DropDownList>
                                </FooterTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="ESTATUS">
                                <EditItemTemplate>
                                    <asp:CheckBox runat="server" ID="chkEstatusEIT" Checked='<%# Bind("Estatus") %>' />
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:CheckBox ID="chkEstatus" runat="server" Enabled="false" Checked='<%# Bind("Estatus") %>'>
                                    </asp:CheckBox>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <asp:CheckBox runat="server" ID="chkEstatusFT" Checked="true" />
                                </FooterTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="EDICIÓN" ShowHeader="False">
                                <EditItemTemplate>
                                    <asp:LinkButton ID="Actualizar" runat="server" CausesValidation="True" CommandName="Update"
                                        Text="Actualizar"></asp:LinkButton>
                                    &nbsp;<asp:LinkButton ID="Cancelar" runat="server" CausesValidation="False" CommandName="Cancel"
                                        Text="Cancelar"></asp:LinkButton>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:LinkButton ID="Editar" runat="server" CausesValidation="False" CommandName="Edit"
                                        Text="Editar"></asp:LinkButton>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <div style="text-align: center;">
                                        <asp:Button Text="Agregar" runat="server" ID="btnAgregarFT" 
                                            CssClass="btn btn-primary btn-sm" onclick="btnAgregarFT_Click" />
                                        </div>
                                </FooterTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="ELIMINAR" ShowHeader="False">
                                <ItemTemplate>
                                    <asp:LinkButton ID="Eliminar" runat="server" CausesValidation="False" CommandName="Delete"
                                        Text="Eliminar"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    <script src="js/jquery-2.1.4.js"></script>
    <script src="js/bootstrap.js"></script>
    <script src="js/bootstrap-datepicker.js"></script>
    <script src="js/moment-with-locales.js"></script>
</asp:Content>

