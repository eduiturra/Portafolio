using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clse
{
    public class Datocontacto
    {
        private String rutsalud;

        public String Rutsalud
        {
            get { return rutsalud; }
            set { rutsalud = value; }
        }

        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private String apellido;

        public String Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        private int fono;

        public int Fono
        {
            get { return fono; }
            set { fono = value; }
        }

        private String email;

        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        public Datocontacto()
        {}

        public Datocontacto(String rutsalud, String nombre, String apellido, int fono, String email)
        {
            this.Rutsalud = rutsalud;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Fono = fono;
            this.Email = email;
        }

        private U_Roles fk_U_Roles;

        public U_Roles Fk_U_Roles
        {
            get { return fk_U_Roles; }
            set { fk_U_Roles = value; }
        }
    }
}
