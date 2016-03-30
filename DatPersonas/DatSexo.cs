using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Brachi.Personas.Data
{
    public class DatSexo : DatAbstracta
    {
        public DataTable CargarComboSexo()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT SEXO_ID, SEXO_NOMB FROM SEXO", con);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
    }
}
