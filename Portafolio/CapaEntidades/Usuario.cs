using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaEntidades
{
    public class Usuario
    {
        private String rutusuario;

        public String Rutusuario
        {
            get { return rutusuario; }
            set { rutusuario = value; }
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

        private String pass;

        public String Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        public Usuario()
        {

        }

        public Usuario(String xrut,String xnombre,String xapellido,int xfono,String xemail,String xpass)
        {
            this.Rutusuario = xrut;
            this.Nombre = xnombre;
            this.Apellido = xapellido;
            this.Fono = xfono;
            this.Email = xemail;
            this.Pass = xpass;
        }
    }
}
