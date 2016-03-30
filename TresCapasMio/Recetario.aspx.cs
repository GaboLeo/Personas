using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using wsGabo;

public partial class Recetario : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_Click(object sender, EventArgs e)
    {
        try
        {
            wsRecetario objProxi = new wsRecetario();
            gvRecetario.DataSource = objProxi.ObtenerRecetas();
            gvRecetario.DataBind();
        }
        catch (Exception ex)
        {

            MostrarMensaje("Error" + ex);
        }

    }
    private void MostrarMensaje(string mensaje)
    {
        mensaje = mensaje.Replace("\n", "").Replace("\r", "").Replace("'", "");
        mensaje = "alert('" + mensaje + "');";
        ScriptManager.RegisterStartupScript(this, GetType(), "", mensaje, true);
    }
    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        try
        {
            int id = Convert.ToInt32(txt.Text);
            gvRecetario.DataSource=new wsRecetario().ObtenerRecetaID(id);
            
            gvRecetario.DataBind();

        }
        catch (Exception ex)
        {

            MostrarMensaje("Error"+ex);
        }
    }
   
}
 public class EntReceta
    {
     public int Id { get; set; }
     public string Nombre { get; set; }
     public string Ingredientes { get; set; }
     public string Descripcion { get; set; }
     public int MyProperty { get; set; }

    }