using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaEntidades
{
    public class C_usuario
    {
        private Clinica fk_idclinica;

        public Clinica Fk_idclinica
        {
            get { return fk_idclinica; }
            set { fk_idclinica = value; }
        }



        private Usuario fk_Usuario;

        public Usuario Fk_Usuario
        {
            get { return fk_Usuario; }
            set { fk_Usuario = value; }
        }

        

    }
}
