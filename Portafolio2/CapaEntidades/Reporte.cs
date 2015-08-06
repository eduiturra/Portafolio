using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaEntidades
{
    public class Reporte
    {
        private Pabellon fk_pabellon;

        public Pabellon Fk_pabellon
        {
            get { return fk_pabellon; }
            set { fk_pabellon = value; }
        }

        private Especialidad fk_especialidad;

        public Especialidad Fk_especialidad
        {
            get { return fk_especialidad; }
            set { fk_especialidad = value; }
        }

        private Double total;

        public Double Total
        {
            get { return total; }
            set { total = value; }
        }

        private Estado fk_estado;

        public Estado Fk_estado
        {
            get { return fk_estado; }
            set { fk_estado = value; }
        }

        private String fecha;

        public String Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
    }
}
