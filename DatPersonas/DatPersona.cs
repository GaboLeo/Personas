using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Brachi.Personas.Data
{
    public class DatPersona : DatAbstracta
    {
        public DataTable Obtener()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT 	PERS_ID, PERS_NOMB, PERS_APAT, PERS_AMAT, PERS_FNAC, PERS_MAIL, PERS_SUEL, PERS_SEXO_ID, PERS_STAT,  SEXO_ID, SEXO_NOMB, SEXO_DESC FROM PERSONA INNER JOIN SEXO ON PERS_SEXO_ID = SEXO_ID", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable Obtener(int id)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT 	PERS_ID, PERS_NOMB, PERS_APAT, PERS_AMAT, PERS_FNAC, PERS_MAIL, PERS_SUEL, PERS_SEXO_ID, PERS_STAT,  SEXO_ID, SEXO_NOMB, SEXO_DESC FROM PERSONA INNER JOIN SEXO ON PERS_SEXO_ID = SEXO_ID WHERE PERS_ID=" + id, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int Agregar(string nombre, string paterno, string materno, string fechaNacimiento, string correo, double sueldo, int sexoId, bool estatus)
        {
            SqlCommand com = new SqlCommand(string.Format("INSERT INTO PERSONA (PERS_ID, PERS_NOMB, PERS_APAT, PERS_AMAT, PERS_FNAC, PERS_MAIL, PERS_SUEL, PERS_SEXO_ID, PERS_STAT) VALUES((SELECT ISNULL(MAX(PERS_ID) + 1, 1) FROM PERSONA), '{0}', '{1}', '{2}', '{3}', '{4}', {5}, {6}, '{7}')", nombre, paterno, materno, fechaNacimiento, correo, sueldo, sexoId, estatus), con);

            try
            {
                con.Open();
                int filas = com.ExecuteNonQuery(); //respuesta de ejecucion del query en la BD
                con.Close();
                return filas;
            }
            catch (Exception ex)
            {
                con.Close();
                throw new ApplicationException("Error en la capa de datos, " + ex.Message);
            }
        }

        public int Eliminar(int id)
        {
            SqlCommand com = new SqlCommand(string.Format("DELETE FROM Persona Where PERS_ID = {0}", id), con);
            try
            {
                con.Open();
                int filas = com.ExecuteNonQuery();
                con.Close();
                return filas;
            }
            catch (Exception ex)
            {
                con.Close();
                throw new ApplicationException("Error en la capa de datos, " + ex.Message);
            }
        }
        public int Actualizar(string nombre, string paterno, string materno, string fechaNacimiento, string correo, double sueldo, int sexoId, bool estatus, int id)
        {
            SqlCommand com = new SqlCommand(string.Format("UPDATE PERSONA SET PERS_NOMB = '{0}', PERS_APAT = '{1}', PERS_AMAT = '{2}', PERS_FNAC = '{3}', PERS_MAIL ='{4}', PERS_SUEL = {5}, PERS_SEXO_ID = {6}, PERS_STAT ='{7}' WHERE PERS_ID = {8}", nombre, paterno, materno, fechaNacimiento, correo, sueldo, sexoId, estatus, id), con);
            try
            {
                con.Open();
                int filas = com.ExecuteNonQuery();
                con.Close();
                return filas;

            }
            catch (Exception ex)
            {
                con.Close();
                throw new ApplicationException("Error en la capa de datos, " + ex.Message);
            }
        }

    }
}
