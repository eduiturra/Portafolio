using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaEntidades
{
    public class Historial
    {
        private int idHistorial;

        public int IdHistorial
        {
            get { return idHistorial; }
            set { idHistorial = value; }
        }

        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        private String tipo;

        public String Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        private Agenda fk_idAgenda;

        public Agenda Fk_idAgenda
        {
            get { return fk_idAgenda; }
            set { fk_idAgenda = value; }
        }
    }
}
