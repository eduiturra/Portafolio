using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clse
{
    public class C_Cirujano
    {
        private Especialidad fk_Especialidad;

        public Especialidad Fk_Especialidad
        {
            get { return fk_Especialidad; }
            set { fk_Especialidad = value; }
        }

        private Datocontacto fk_Datocontacto;

        public Datocontacto Fk_Datocontacto
        {
            get { return fk_Datocontacto; }
            set { fk_Datocontacto = value; }
        }
    }
}
