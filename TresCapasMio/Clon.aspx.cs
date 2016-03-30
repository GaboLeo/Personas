using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Brachi.Personas.Business;
using Brachi.Personas.Business.Entity;

public partial class Clon : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            CargarPersonas();
            if (!IsPostBack)
            {
                LlenarDDLSexo();
            }
        }
        catch (Exception ex)
        {
            Title = ex.Message;
        }
    }

    private void LinkButton()
    {
        EntPersona ent = new EntPersona();
        LinkButton lnk = new LinkButton();
        lnk.ID = "lnk" + ent.Id;
        lnk.ToolTip = "Tu id es: " + ent.Id;
        lnk.CommandArgument = ent.Id.ToString();
        lnk.Text = ent.Nombre;
        lnk.Click += new EventHandler(lnk_Click);
        phPersonas.Controls.Add(lnk);
    }

    private void LlenarDDLSexo()
    {
        try
        {
            //List<EntSexo> lst = new BusPersona().CargarCombo();
            ddlSexo.DataSource = new BusPersona().CargarCombo();
            ddlSexo.DataTextField = "Nombre";
            ddlSexo.DataValueField = "Id";
            ddlSexo.DataBind();
            ddlSexo1.DataSource = new BusPersona().CargarCombo();
            ddlSexo1.DataTextField = "Nombre";
            ddlSexo1.DataValueField = "Id";
            ddlSexo1.DataBind();
        }
        catch (Exception ex)
        {

            MostrarMensaje(ex.Message);
        }


    }
    
    private void CargarPersonas()
    {
        List<EntPersona> lst = new BusPersona().Obtener();
        LiteralControl literal = new LiteralControl();
        literal.Text = "";

        foreach (EntPersona ent in lst)
        {
            literal.Text += "<tr>";
            literal.Text += "  <td>";
            literal.Text += ent.Id;
            literal.Text += "  </td>";
            literal.Text += "  <td>";
            phPersonas.Controls.Add(literal);

            LinkButton lnk = new LinkButton();
            lnk.ID = "lnk" + ent.Id;
            lnk.ToolTip = "Tu id es: " + ent.Id;
            lnk.CommandArgument = ent.Id.ToString();
            lnk.Text = ent.Nombre;
            lnk.Click += new EventHandler(lnk_Click);
            phPersonas.Controls.Add(lnk);

            literal = new LiteralControl();
            literal.Text += "  </td>";


            literal.Text += "  <td>";
            literal.Text += ent.fechaNacimiento.ToString("dd/MM/yyyy");
            literal.Text += "  </td>";
            literal.Text += "  <td>";
            literal.Text += ent.Mail;
            literal.Text += "  </td>";
            literal.Text += "  <td>";
            literal.Text += ent.Sueldo.ToString("C");
            literal.Text += "  </td>";
            literal.Text += "  <td>";
            literal.Text += ent.Sexo.Nombre;
            literal.Text += "  </td>";
            literal.Text += "  <td>";
            if (ent.Estatus)
                literal.Text += "      <input ID=\"Labefl343\" type=\"checkbox\" checked disabled></input>";
            else
                literal.Text += "      <input ID=\"Labefl343\" type=\"checkbox\" disabled></input>";
            literal.Text += "  </td>";

            literal.Text += "</tr>";

        }

        phPersonas.Controls.Add(literal);



    }
    protected void btnAgregar_Click(object sender, EventArgs e)
    {
        try
        {
            EntPersona ent = new EntPersona();
            ent.Nombre = txtNomb.Text;
            ent.Paterno = txtPate.Text;
            ent.Materno = txtMate.Text;
            ent.fechaNacimiento = Convert.ToDateTime(txtFech.Text);
            ent.Mail = txtMail.Text;
            ent.Sueldo = Convert.ToDouble(txtSuel.Text);
            ent.SexoId = Convert.ToInt32(ddlSexo.SelectedValue);
            ent.Estatus = chkEstatus.Checked;



            new BusPersona().agregar(ent);
            Response.Redirect(Request.CurrentExecutionFilePath);
        }
        catch (Exception ex)
        {
            MostrarMensaje(ex.Message);
        }
    }

    private void MostrarMensaje(string mensaje)
    {
        mensaje = mensaje.Replace("/n", " ").Replace("/r", " ").Replace("'", " ").Replace("//r", " ").Replace("//n", " ");
        mensaje = "alert('" + mensaje + "');";
        ScriptManager.RegisterStartupScript(this, GetType(), "", mensaje, true);

    }
    protected void btnActualizar_Click(object sender, EventArgs e)
    {
        try
        {
            EntPersona ent = new EntPersona();
            ent.Id = Convert.ToInt32(hfId.Value);
            ent.Nombre = txtNomb.Text;
            ent.Paterno = txtPate.Text;
            ent.Materno = txtMate.Text;
            ent.fechaNacimiento = Convert.ToDateTime(txtFech.Text);
            ent.Mail = txtMail.Text;
            ent.Sueldo = Convert.ToDouble(txtSuel.Text);
            ent.SexoId = Convert.ToInt32(ddlSexo.SelectedValue);
            ent.Estatus = chkEstatus.Checked;

            new BusPersona().Actualizar(ent); //No olvidar siempre planchar ala clase BusPersona con la entidad persona en su metodo agregar
            Response.Redirect(Request.CurrentExecutionFilePath);
        }
        catch (Exception ex)
        {

            Title = ex.Message;
        }
    }
    protected void btnBorrar_Click(object sender, EventArgs e)
    {

        try
        {

            int id = Convert.ToInt32(hfId.Value);
            //hfId.Value = id.ToString();

            new BusPersona().Eliminar(id);  //por que else metodo anterior no regresa nada solo se coloca new
            Response.Redirect(Request.CurrentExecutionFilePath);
        }
        catch (Exception ex)
        {

            Title = ex.Message;
        }
    }
    protected void btnGuardar_Click(object sender, EventArgs e)
    {
    }
    void lnk_Click(object sender, EventArgs e)
    {
        try
        {
            LinkButton lnk = (LinkButton)sender;
            int id = Convert.ToInt32(lnk.CommandArgument);
            hfId.Value = id.ToString();
            EntPersona ent = new BusPersona().Obtener(id);
            txtNomb.Text = ent.Nombre;
            txtPate.Text = ent.Paterno;
            txtMate.Text = ent.Materno;
            txtFech.Text = ent.fechaNacimiento.ToString("dd/MM/yyyy");
            txtMail.Text = ent.Mail;
            txtSuel.Text = ent.Sueldo.ToString();
            ddlSexo.SelectedValue = ent.SexoId.ToString();
            chkEstatus.Checked = ent.Estatus;


        }


        catch (Exception ex)
        {
            Title = ex.Message;

        }

    }

}