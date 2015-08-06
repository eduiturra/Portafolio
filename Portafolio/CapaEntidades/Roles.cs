using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaEntidades
{
   public class Roles
    {
        private int idRoles;

        public int IdRoles
        {
            get { return idRoles; }
            set { idRoles = value; }
        }

        private String perfil;

        public String Perfil
        {
            get { return perfil; }
            set { perfil = value; }
        }

        public Roles()
        {

        }

        public Roles(int xid,String xperfil)
        {
            this.IdRoles = xid;
            this.Perfil = xperfil;
        }
    }
}
