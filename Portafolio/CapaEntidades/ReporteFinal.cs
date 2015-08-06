using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaEntidades
{
    public class ReporteFinal
    {
        private String pabellon;

        public String Pabellon
        {
            get { return pabellon; }
            set { pabellon = value; }
        }

        private String especialidad;

        public String Especialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
        }

        

        private String enproceso;

        public String Enproceso
        {
            get { return enproceso; }
            set { enproceso = value; }
        }

        private String finalizado;

        public String Finalizado
        {
            get { return finalizado; }
            set { finalizado = value; }
        }

        private String suspendido;

        public String Suspendido
        {
            get { return suspendido; }
            set { suspendido = value; }
        }

        private String fecha;

        public String Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
    }
}
