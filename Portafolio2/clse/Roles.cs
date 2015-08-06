using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clse
{
    public class Roles
    {
        private int idroles;

        public int Idroles
        {
            get { return idroles; }
            set { idroles = value; }
        }

        private String perfil;

        public String Perfil
        {
            get { return perfil; }
            set { perfil = value; }
        }

        public Roles()
        { }

        public Roles(int idr, String perfil)
        {
            this.Idroles = idr;
            this.Perfil = perfil;
        }
    }
}
