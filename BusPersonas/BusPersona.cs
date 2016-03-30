using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Brachi.Personas.Data;
using Brachi.Personas.Business.Entity;

namespace Brachi.Personas.Business
{
    public class BusPersona
    {
        public BusPersona() { }
        public List<EntPersona> Obtener()
        {
            DataTable dt = new DatPersona().Obtener();
            List<EntPersona> lst = new List<EntPersona>();
            foreach (DataRow dr in dt.Rows)
            {
                EntPersona ent = new EntPersona();
                ent.Id = Convert.ToInt32(dr["PERS_ID"]);
                //ent.Nombre = string.Format("{0} {1} {2}", dr["PERS_NOMB"].ToString(), dr["PERS_APAT"].ToString(), dr["PERS_AMAT"].ToString());
                ent.Nombre=dr["PERS_NOMB"].ToString();
                ent.Paterno=dr["PERS_APAT"].ToString();
                ent.Materno=dr["PERS_AMAT"].ToString();
                ent.fechaNacimiento = Convert.ToDateTime(dr["PERS_FNAC"]);
                ent.Mail = dr["PERS_MAIL"].ToString();
                ent.Sueldo = Convert.ToDouble(dr["PERS_SUEL"]);
                ent.SexoId = Convert.ToInt32(dr["PERS_SEXO_ID"]);
                ent.Sexo.Nombre = dr["SEXO_NOMB"].ToString();
                ent.Estatus = Convert.ToBoolean(dr["PERS_STAT"]);
                lst.Add(ent);
            }
            return lst;
        }

        public void agregar(EntPersona ent)
        {
            int filas = new DatPersona().Agregar(ent.Nombre, ent.Paterno, ent.Materno, ent.fechaNacimiento.ToString("MM/dd/yyyy"), ent.Mail, ent.Sueldo, ent.SexoId, ent.Estatus);
            if (filas != 1)
                throw new ApplicationException(string.Format("Error al insertar a {0} {1}", ent.Nombre, ent.Paterno));
        }

        public List<EntSexo> CargarCombo()
        {
            DataTable dt = new DatSexo().CargarComboSexo();
            List<EntSexo> lst = new List<EntSexo>();
            foreach (DataRow dr in dt.Rows)
            {
                EntSexo ent = new EntSexo();
                ent.Id = Convert.ToInt32(dr["SEXO_ID"]);
                ent.Nombre = dr["SEXO_NOMB"].ToString();
                lst.Add(ent);
            }
            return lst;
        }
        public EntPersona Obtener(int id)
        {
            DataTable dt = new DatPersona().Obtener(id);

            EntPersona ent = new EntPersona();
            ent.Id = Convert.ToInt32(dt.Rows[0]["PERS_ID"]);
            ent.Nombre = dt.Rows[0]["PERS_NOMB"].ToString();
            ent.Paterno = dt.Rows[0]["PERS_APAT"].ToString();
            ent.Materno = dt.Rows[0]["PERS_AMAT"].ToString();
            ent.fechaNacimiento = Convert.ToDateTime(dt.Rows[0]["PERS_FNAC"]);
            ent.Mail = dt.Rows[0]["PERS_MAIL"].ToString();
            ent.Sueldo = Convert.ToDouble(dt.Rows[0]["PERS_SUEL"]);
            ent.SexoId = Convert.ToInt32(dt.Rows[0]["PERS_SEXO_ID"]);
            ent.Sexo.Nombre = dt.Rows[0]["SEXO_NOMB"].ToString();
            ent.Estatus = Convert.ToBoolean(dt.Rows[0]["PERS_STAT"]);
            return ent;
        }

        public void Eliminar(int id)
        {
            int filas = new DatPersona().Eliminar(id);
            if (filas != 1)
                throw new ApplicationException(string.Format("Error al eliminar a {0}", id));
        }

        public void Actualizar(EntPersona ent)
        {
            int filas = new DatPersona().Actualizar(ent.Nombre, ent.Paterno, ent.Materno, ent.fechaNacimiento.ToString("MM/dd/yyyy"), ent.Mail, ent.Sueldo, ent.SexoId, ent.Estatus, ent.Id);

            if (filas != 1)
                throw new ApplicationException(string.Format("Error al insertar a {0} {1}", ent.Nombre, ent.Paterno));
        }

    }


}
