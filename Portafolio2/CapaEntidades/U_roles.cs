using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaEntidades
{
    public class U_roles
    {
        private Usuario fk_Usuario;

        public Usuario Fk_Usuario
        {
            get { return fk_Usuario; }
            set { fk_Usuario = value; }
        }



        private Roles fk_Roles;

        public Roles Fk_Roles
        {
            get { return fk_Roles; }
            set { fk_Roles = value; }
        }

       

        public U_roles()
        {
            

        }


        public U_roles(Usuario fk1, Roles fk2)
        {
            this.fk_Usuario = fk1;
            this.fk_Roles = fk2;
        }
    }
}
