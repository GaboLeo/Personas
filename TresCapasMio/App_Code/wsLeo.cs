using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Descripción breve de wsLeo
/// </summary>
[WebService(Namespace = "http://leo.mx/")]

public class wsLeo : System.Web.Services.WebService {

    public wsLeo () {

        //Eliminar la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld() {
        return "Hola a todos";
    }
    
}
