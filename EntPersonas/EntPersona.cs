using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Brachi.Personas.Business.Entity
{
    public class EntPersona
    {
        //PERS_ID, PERS_NOMB, PERS_APAT, PERS_AMAT, PERS_FNAC, PERS_MAIL, PERS_SUEL, PERS_SEXO_ID, PERS_STAT

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Paterno { get; set; }
        public string Materno { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string Mail { get; set; }
        public double Sueldo { get; set; }
        public int SexoId { get; set; }
        public bool Estatus { get; set; }

        private EntSexo sexo;
        public EntSexo Sexo
        {
            get
            {
                if (sexo == null)
                    sexo = new EntSexo();
                return sexo;
            }
            set
            {
                if (sexo == null)
                    sexo = new EntSexo();
                sexo = value;
            }
        }
    }
}
