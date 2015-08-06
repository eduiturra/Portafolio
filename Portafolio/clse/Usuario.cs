using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clse
{
    public class Usuario
    {
        private int idusuario;

        public int Idusuario
        {
            get { return idusuario; }
            set { idusuario = value; }
        }

        private String pass;

        public String Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        public Usuario()
        { }

        public Usuario(int idU, String pass)
        {
            this.Idusuario = idU;
            this.Pass = pass;
        }

        
    }
}
