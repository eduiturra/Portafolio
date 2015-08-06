using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clse
{
    public class Agenda_Dato
    {
        private Agenda fk_Agenda;

        public Agenda Fk_Agenda
        {
            get { return fk_Agenda; }
            set { fk_Agenda = value; }
        }

        private Datocontacto fk_Datocontacto;

        public Datocontacto Fk_Datocontacto
        {
            get { return fk_Datocontacto; }
            set { fk_Datocontacto = value; }
        }
    }
}
