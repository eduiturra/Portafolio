using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clse
{
    public class C_Usuario
    {
        private Clinica fk_Clinica;

        public Clinica Fk_Clinica
        {
            get { return fk_Clinica; }
            set { fk_Clinica = value; }
        }

        private Datocontacto fk_Datocontacto;

        public Datocontacto Fk_Datocontacto
        {
            get { return fk_Datocontacto; }
            set { fk_Datocontacto = value; }
        }
    }
}
