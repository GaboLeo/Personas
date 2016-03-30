using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Brachi.Personas.Business.Entity;
using Brachi.Personas.Business;

public partial class PruebaGV : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
                CargarGVPersonas();
        }
        catch (Exception ex)
        {
            Title = ex.Message;
            
        }
    }

    private void CargarGVPersonas()
    {
        gvPersonas.DataSource = new BusPersona().Obtener(); //Forma Rapida de llenar GridView directo desde la base de datos
        gvPersonas.DataBind();
        gvPersonas.FooterRow.Cells[9].ColumnSpan = 2;
        gvPersonas.FooterRow.Cells[10].Visible = false;
        DropDownList ddlSexoFT = (DropDownList)gvPersonas.FooterRow.FindControl("ddlSexoFT");
        ddlSexoFT.DataSource = new BusPersona().CargarCombo();
        ddlSexoFT.DataTextField = "Nombre";
        ddlSexoFT.DataValueField = "Id";
        ddlSexoFT.DataBind();
    }
    protected void gvPersonas_RowEditing(object sender, GridViewEditEventArgs e)
    {
        try
        {
            gvPersonas.EditIndex = e.NewEditIndex;
            CargarGVPersonas();
            DropDownList ddlSexoEIT = (DropDownList)gvPersonas.Rows[e.NewEditIndex].FindControl("ddlSexoEIT");
            ddlSexoEIT.DataSource = new BusPersona().CargarCombo();
            ddlSexoEIT.DataTextField = "Nombre";
            ddlSexoEIT.DataValueField = "Id";
            ddlSexoEIT.DataBind();
            ddlSexoEIT.SelectedValue=gvPersonas.DataKeys[e.NewEditIndex].Values["SexoId"].ToString();
        }
        catch (Exception ex)
        {

            string cadena = "Error";
            MostrarMensaje(cadena + " " + ex);
        }
    }
    protected void gvPersonas_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        try
        {
            gvPersonas.EditIndex=-1;
            CargarGVPersonas();

        }
        catch (Exception ex)
        {
            string cadena = "Error";
            MostrarMensaje(cadena+" "+ex);
            
        }
    }
    protected void gvPersonas_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        try
        {
            EntPersona per= new EntPersona();
            per.Id=Convert.ToInt32(gvPersonas.DataKeys[e.RowIndex].Values["Id"]);
            per.Nombre = ((TextBox)gvPersonas.Rows[e.RowIndex].FindControl("txtNombreEIT")).Text;
            per.Paterno = ((TextBox)gvPersonas.Rows[e.RowIndex].FindControl("txtPaternoEIT")).Text;
            per.Materno = ((TextBox)gvPersonas.Rows[e.RowIndex].FindControl("txtMaternoEIT")).Text;
            per.fechaNacimiento = Convert.ToDateTime(((TextBox)(gvPersonas.Rows[e.RowIndex].FindControl("txtFechaNacimientoEIT"))).Text);
            per.Mail = ((TextBox)gvPersonas.Rows[e.RowIndex].FindControl("txtMailEIT")).Text;
            per.Sueldo = Convert.ToDouble(((TextBox)gvPersonas.Rows[e.RowIndex].FindControl("txtSueldoEIT")).Text);
            per.SexoId = Convert.ToInt32(((DropDownList)gvPersonas.Rows[e.RowIndex].FindControl("ddlSexoEIT")).SelectedValue);
            per.Estatus = Convert.ToBoolean(((CheckBox)gvPersonas.Rows[e.RowIndex].FindControl("chkEstatusEIT")).Checked);

            new BusPersona().Actualizar(per);
            Response.Redirect(Request.CurrentExecutionFilePath);

        }
        catch (Exception ex)
        {

            string cadena = "Error";
            MostrarMensaje(cadena+" "+ex);
        }
    }
    protected void gvPersonas_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        try
        {
            EntPersona per = new EntPersona();
            per.Id =Convert.ToInt32(gvPersonas.DataKeys[e.RowIndex].Values["Id"]);
            new BusPersona().Eliminar(per.Id);
            Response.Redirect(Request.CurrentExecutionFilePath);
        }
        catch (Exception ex)
        {

            string cadena = "Error";
            MostrarMensaje(cadena+" "+ ex);
        }
    }
    private void MostrarMensaje(string mensaje)
    {
        mensaje = mensaje.Replace("\n", "").Replace("\r", "").Replace("'", "");
        mensaje = "alert('" + mensaje + "');";
        ScriptManager.RegisterStartupScript(this, GetType(), "", mensaje, true);
    }
    protected void btnAgregarFT_Click(object sender, EventArgs e)
    {
        try
        {
            EntPersona per = new EntPersona();
            per.Nombre = ((TextBox)gvPersonas.FooterRow.FindControl("txtNombreFT")).Text;
            per.Paterno = ((TextBox)gvPersonas.FooterRow.FindControl("txtPaternoFT")).Text;
            per.Materno = ((TextBox)gvPersonas.FooterRow.FindControl("txtMaternoFT")).Text;
            per.fechaNacimiento = Convert.ToDateTime(((TextBox)(gvPersonas.FooterRow.FindControl("txtFechaNacimientoFT"))).Text);
            per.Mail = ((TextBox)gvPersonas.FooterRow.FindControl("txtMailFT")).Text;
            per.Sueldo = Convert.ToDouble(((TextBox)gvPersonas.FooterRow.FindControl("txtSueldoFT")).Text);
            per.SexoId = Convert.ToInt32(((DropDownList)gvPersonas.FooterRow.FindControl("ddlSexoFT")).SelectedValue);
            per.Estatus = Convert.ToBoolean(((CheckBox)gvPersonas.FooterRow.FindControl("chkEstatusFT")).Checked);

            new BusPersona().agregar(per);
            Response.Redirect(Request.CurrentExecutionFilePath);

        }
        catch (Exception ex)
        {

            string cadena = "Error";
            MostrarMensaje(cadena + " " + ex);
        }
    }
}