using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using wsNSGeorge;

public partial class RecuperaObtener : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    private void MostrarMensaje(string mensaje)
    {
        mensaje = mensaje.Replace("\n", "").Replace("\r", "").Replace("'", "");
        mensaje = "alert('" + mensaje + "');";
        ScriptManager.RegisterStartupScript(this, GetType(), "", mensaje, true);
    }
    protected void btn_Click(object sender, EventArgs e)
    {
        try
        {
            wsPersonas objproxy = new wsPersonas();
            string[] cadenas = objproxy.Obtener2();
            foreach (string cadena in cadenas)
            {
                lbl.Text += cadena + "<br />"; 
            }
        }
        catch (Exception ex)
        {

            MostrarMensaje("Error" + ex);
        }
    }
}