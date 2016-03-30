using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Brachi.Personas.Business.Entity;
using Brachi.Personas.Business;

/// <summary>
/// Descripción breve de WebService
/// </summary>
[WebService(Namespace = "http://leo.mx/")]
public class WebService : System.Web.Services.WebService
{

    public WebService()
    {

        //Eliminar la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld()
    {
        return "Hola a todos";
    }
    [WebMethod]
    public List<EntPersona> Obtener()
    {
        return new BusPersona().Obtener();
    }

    [WebMethod]
    public string Agregar(string Nombre, string Paterno, string Materno, DateTime fechaNacimiento, string Mail,
        double Sueldo, int SexoId, bool Estatus)
    {
        EntPersona ent = new EntPersona();
        ent.Nombre = Nombre;
        ent.Paterno = Paterno;
        ent.Materno = Materno;
        ent.fechaNacimiento = fechaNacimiento;
        ent.Mail = Mail;
        ent.Sueldo = Sueldo;
        ent.SexoId = SexoId;
        ent.Estatus = Estatus;

        return "Agregado Correctamente";
    }

    [WebMethod]
    public List<EntPersona> ObtenerUno(int id)
    {
        List<EntPersona> lst = new List<EntPersona>();
        lst.Add(new BusPersona().Obtener(id));
        return lst;
    }

}
