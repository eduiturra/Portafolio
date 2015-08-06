using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clse
{
    public class U_Roles
    {
        private int id_uroles;

        public int Id_uroles
        {
            get { return id_uroles; }
            set { id_uroles = value; }
        }

        public U_Roles()
        { }

        public U_Roles(int idur)
        {
            this.Id_uroles = idur;
        }

        private Roles fk_Roles;

        public Roles Fk_Roles
        {
            get { return fk_Roles; }
            set { fk_Roles = value; }
        }

        private Usuario fk_Usuario;

        public Usuario Fk_Usuario
        {
            get { return fk_Usuario; }
            set { fk_Usuario = value; }
        }
    }
}
