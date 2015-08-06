using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaEntidades
{
    public class TotalPabellones
    {
        private int idpabellon;

        public int Idpabellon
        {
            get { return idpabellon; }
            set { idpabellon = value; }
        }

        private int total;

        public int Total
        {
            get { return total; }
            set { total = value; }
        }

        private String fecha;

        public String Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
    }
}
