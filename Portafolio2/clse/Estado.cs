using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clse
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

        public Estado(int idestado, String situacion)
        {
            this.Idestado = idestado;
            this.Situacion = situacion;
        }
    }
}
