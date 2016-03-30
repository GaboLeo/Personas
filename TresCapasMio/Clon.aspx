<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.master" AutoEventWireup="true"
    MaintainScrollPositionOnPostback="True" CodeFile="Clon.aspx.cs" Inherits="Clon" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="css/bootstrap-datepicker.css" rel="stylesheet" type="text/css" />
    <link href="css/bootstrap-datepicker3.css" rel="stylesheet" type="text/css" />
    <link href="css/bootstrap-datetimepicker.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <script src="js/bootstrap-datepicker.js" type="text/javascript"></script>
    <script src="locales/bootstrap-datepicker.es.min.js" type="text/javascript"></script>
    <script src="js/moment-with-locales.js" type="text/javascript"></script>
    <script src="js/bootstrap-datetimepicker.js" type="text/javascript"></script>
    
    <div class="row">
        <div class="col-xs-1">
        </div>
        <div class="col-xs-10">
            <div class="panel panel-primary">
                <div class="panel-heading">
                    <h1 style="text-align: center;">
                        Personas
                    </h1>
                </div>
                <div class="panel-body">
                    <table class="table table-hover ">
                        <tr>
                            <td>
                                <asp:Label runat="server" ID="Label1" Text="ID" />
                            </td>
                            <td>
                                <asp:Label runat="server" ID="lblNombre" Text="NOMBRE COMPLETO" />
                            </td>
                            <td>
                                <asp:Label runat="server" ID="lblFechaNaci" Text="FECHA DE NACIMIENTO" />
                            </td>
                            <td>
                                <asp:Label runat="server" ID="lblCorreo" Text="CORREO" />
                            </td>
                            <td>
                                <asp:Label runat="server" ID="lblSueldo" Text="SUELDO" />
                            </td>
                            <td>
                                <asp:Label runat="server" ID="lblSexo2" Text="SEXO" />
                            </td>
                            <td>
                                <asp:Label runat="server" ID="lblStatus" Text="ESTATUS" />
                            </td>
                        </tr>
                        <asp:PlaceHolder runat="server" ID="phPersonas" />
                    </table>
                </div>
                <div class="panel-footer">
                    <h6 style="text-align: center" />
                    <span class="label label-primary">Fin de la tabla.</span>
                </div>
            </div>
        </div>
        <div class="col-xs-1">
        </div>
    </div>
    <div class="row">
        <div class="col-xs-1">
        </div>
        <div class="col-xs-10">
            <div class="panel panel-primary">
                <div class="panel-heading">
                    <h3 class="panel-title">
                        ABC Personas</h3>
                </div>
                <div class="panel-body">
                    <div class="row">
                        <div class="col-xs-4">
                            <div class="form-group">
                                <label for="lblNomb">
                                    Nombre</label>
                                <asp:TextBox runat="server" class="form-control" ID="txtNomb" placeholder="Introduce Nombre" />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Nombre Requerido"
                                    ControlToValidate="txtNomb" Text="******" ValidationGroup="Form" ForeColor="#DF013A"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ValidationExpression="[\S\s]{3,15}"
                                    ControlToValidate="txtNomb" Text="******" ErrorMessage="Mïnimo 3 caracteres, Máximo 15 caracteres"
                                    ValidationGroup="Form" ForeColor="#DF013A"></asp:RegularExpressionValidator>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Debe ingresar solo letras."
                                    ControlToValidate="txtNomb" ValidationExpression="^[a-zA-Z]*$" ValidationGroup="Form"
                                    Text="*******" ForeColor="#DF013A"></asp:RegularExpressionValidator>
                            </div>
                        </div>
                        <div class="col-xs-4">
                            <div class="form-group">
                                <label for="lblAPat">
                                    Apellido Paterno</label>
                                <asp:TextBox runat="server" class="form-control" ID="txtPate" placeholder="Apellido Paterno" />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="A. Paterno Requerido"
                                    ControlToValidate="txtPate" Text="******" ValidationGroup="Form" ForeColor="#DF013A"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ValidationExpression="[\S\s]{3,15}"
                                    ControlToValidate="txtPate" Text="******" ErrorMessage="Mïnimo 3 caracteres, Máximo 15 caracteres"
                                    ValidationGroup="Form" ForeColor="#DF013A"></asp:RegularExpressionValidator>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ErrorMessage="Debe ingresar solo letras."
                                    ControlToValidate="txtPate" ValidationExpression="^[a-zA-Z]*$" ValidationGroup="Form"
                                    Text="*******" ForeColor="#DF013A"></asp:RegularExpressionValidator>
                            </div>
                        </div>
                        <div class="col-xs-4">
                            <div class="form-group">
                                <label for="lblAmat">
                                    Apellido Materno</label>
                                <asp:TextBox runat="server" class="form-control" ID="txtMate" placeholder="Apellido Materno" />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="A. Materno Requerido"
                                    ControlToValidate="txtMate" Text="******" ValidationGroup="Form" ForeColor="#DF013A"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ValidationExpression="[\S\s]{3,15}"
                                    ControlToValidate="txtMate" Text="******" ErrorMessage="Mïnimo 3 caracteres, Máximo 15 caracteres"
                                    ValidationGroup="Form" ForeColor="#DF013A"></asp:RegularExpressionValidator>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ErrorMessage="Debe ingresar solo letras."
                                    ControlToValidate="txtMate" ValidationExpression="^[a-zA-Z]*$" ValidationGroup="Form"
                                    Text="*******" ForeColor="#DF013A"></asp:RegularExpressionValidator>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-xs-4">
                            <div class="form-group">
                                <label for="lblFnac">
                                    Fecha de nacimiento</label>
                                <asp:TextBox runat="server" class="form-control" ID="txtFech" placeholder="Fecha de Nacimiento" />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Fecha de Nacimiento Requerida"
                                    ControlToValidate="txtFech" Text="******" ValidationGroup="Form" ForeColor="#DF013A"></asp:RequiredFieldValidator>
                                <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Fecha debe ser mayor a 01/01/1970 y menor a 01/01/2014"
                                    ControlToValidate="txtFech" Text="********" ForeColor="#DF013A" MaximumValue="01/01/2014"
                                    MinimumValue="01/01/1970" Type="Date" ValidationGroup="Form"></asp:RangeValidator>
                            </div>
                        </div>
                        <div class="col-xs-4">
                            <div class="form-group">
                                <label for="lblFnac">
                                    Correo electrónico</label>
                                <asp:TextBox runat="server" type="email" class="form-control" ID="txtMail" placeholder="Correo electrónico" />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Correo Requerido"
                                    ControlToValidate="txtMail" Text="******" ValidationGroup="Form" ForeColor="#DF013A"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" ValidationExpression="^[_a-z0-9-]+(.[_a-z0-9-]+)*@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$"
                                    ControlToValidate="txtMail" Text="******" ErrorMessage="Correo Inválido" ValidationGroup="Form"
                                    ForeColor="#DF013A"></asp:RegularExpressionValidator>
                            </div>
                        </div>
                        <div class="col-xs-4">
                            <div class="form-group">
                                <label for="lblFnac">
                                    Sueldo</label>
                                <asp:TextBox runat="server" class="form-control" ID="txtSuel" placeholder="Sueldo" />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Sueldo Requerido"
                                    ControlToValidate="txtSuel" Text="******" ValidationGroup="Form" ForeColor="#DF013A"></asp:RequiredFieldValidator>
                                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Solo numeros representando Dinero"
                                    ControlToValidate="txtSuel" Text="******" ValidationGroup="Form" ForeColor="#DF013A"
                                    Operator="DataTypeCheck" Type="Currency"></asp:CompareValidator>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-xs-6">
                            <div class="text-center">
                                <div class="dropdown">
                                    <asp:DropDownList runat="server" ID="ddlSexo" ValidationGroup="Form" class="btn btn-default dropdown-toggle"
                                        AppendDataBoundItems="true">
                                        <asp:ListItem Text="[Seleccione Sexo]" Value="-1" />
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="ddlSexo"
                                        InitialValue="-1" ErrorMessage="Selecciona un campo válido" ValidationGroup="Form"
                                        ForeColor="#DF013A" Text="*********"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                        </div>
                        <div class="col-xs-6">
                            <div class="text-center">
                                <div class="checkbox">
                                    <label>
                                        <asp:CheckBox Text="Estatus" ID="chkEstatus" runat="server" />
                                    </label>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="panel-footer">
                        <div class="row">
                            <div class="col-xs-4">
                                <div class="text-center">
                                    <asp:Button Text="Agregar" CssClass=" btn btn-primary" runat="server" ID="btnAgregar"
                                        OnClick="btnAgregar_Click" ValidationGroup="Form" />
                                </div>
                            </div>
                            <div class="col-xs-4">
                                <div class="text-center">
                                    <asp:Button Text="Borrar" CssClass=" btn btn-danger" runat="server" ID="btnBorrar"
                                        OnClick="btnBorrar_Click" OnClientClick="return confirm('¿Estás seguro de eliminar el registro?')" />
                                </div>
                            </div>
                            <div class="col-xs-4 text-center">
                                <asp:Button Text="Actualizar" CssClass="btn btn-warning" runat="server" ID="btnActualizar"
                                    OnClick="btnActualizar_Click" />
                                <div class="text-center">
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-xs-12">
                    <div class="panel panel-danger">
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="Form"
                            ForeColor="#FF0040" />
                    </div>
                </div>
            </div>
        </div>
        <div class="col-xs-1">
        </div>
    </div>
    <!-- Modal -->
    <div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span></button>
                    <h4 class="modal-title" id="myModalLabel">
                        Agregar Persona</h4>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-xs-4">
                            <div class="form-group">
                                <label for="lblNomb">
                                    Nombre</label>
                                <asp:TextBox runat="server" class="form-control" ID="txtNomb1" placeholder="Introduce Nombre" />
                            </div>
                            <div class="form-group">
                                <label for="lblFnac">
                                    Fecha de nacimiento</label>
                                <asp:TextBox runat="server" class="form-control" ID="txtFnac1" placeholder="Fecha de Nacimiento" />
                            </div>
                        </div>
                        <div class="col-xs-4">
                            <div class="form-group">
                                <label for="lblAPat">
                                    Apellido Paterno</label>
                                <asp:TextBox runat="server" class="form-control" ID="txtPate1" placeholder="Apellido Paterno" />
                            </div>
                            <div class="form-group">
                                <label for="lblFnac">
                                    Correo electrónico</label>
                                <asp:TextBox runat="server" type="email" class="form-control" ID="txtMail1" placeholder="Correo electrónico" />
                            </div>
                        </div>
                        <div class="col-xs-4">
                            <div class="form-group">
                                <label for="lblAmat">
                                    Apellido Materno</label>
                                <asp:TextBox runat="server" class="form-control" ID="txtMate1" placeholder="Apellido Materno" />
                            </div>
                            <div class="form-group">
                                <label for="lblFnac">
                                    Sueldo</label>
                                <asp:TextBox runat="server" class="form-control" ID="txtSuel1" placeholder="Sueldo" />
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-xs-6">
                            <div class="text-center">
                                <div class="dropdown">
                                    <asp:DropDownList runat="server" ID="ddlSexo1" class="btn btn-default dropdown-toggle"
                                        AppendDataBoundItems="true">
                                        <asp:ListItem Text="[Seleccione Sexo]" Value="0" />
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </div>
                        <div class="col-xs-6">
                            <div class="text-center">
                                <div class="checkbox">
                                    <label>
                                        <asp:CheckBox Text="Estatus" ID="chkEstatus1" runat="server" />
                                    </label>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" data-dismiss="modal">
                        Cerrar</button>
                    <asp:Button Text="Guardar" ID="btnGuardar" runat="server" OnClick="btnGuardar_Click"
                        class="btn btn-primary" />
                </div>
            </div>
        </div>
    </div>
    <asp:HiddenField runat="server" ID="hfId" />
    <script>
        $(document).ready(function () {
            $('#ContentPlaceHolder1_txtFech').datepicker({
                format: 'dd/mm/yyyy',
                weekStart: 1,
                startDate: "01/02/2010",
                todayBtn: "linked",
                clearBtn: true,
                language: "es",
                multidate: true,
                calendarWeeks: true,
                autoclose: true,
                todayHighlight: true,
                beforeShowYear: function (date) {
                    if (date.getFullYear() == 2007) {
                        return false;
                    }
                },
                datesDisabled: ['06/02/2016', '21/02/2016']
            });//Fin del datepicker
        }); // fin del ready
    </script>
        <script type="text/javascript">
            $(function () {
                $('#ContentPlaceHolder1_txtFnac1').datetimepicker({
                    format: 'DD/MM/YYYY HH:mm:ss',
                    locale: 'es'
                });

            });
        </script>
</asp:Content>
