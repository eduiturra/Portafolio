using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaEntidades
{
    public class Estado
    {

        private int idestado;

        public int Idestado
        {
            get { return idestado; }
            set { idestado = value; }
        }

        private String situacion;

        public String Situacion
        {
            get { return situacion; }
            set { situacion = value; }
        }

        public Estado()
        { }

       
    }
}

