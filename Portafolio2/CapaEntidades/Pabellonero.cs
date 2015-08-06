using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaEntidades
{
    public class Pabellonero
    {
         private String rutpabellonero;

        public String Rutpabellonero
        {
            get { return rutpabellonero; }
            set { rutpabellonero = value; }
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

        public Pabellonero()
        {

        }

        public Pabellonero(String xrut,String xnombre,String xapeliido,int xfono,String xemail)
        {
            this.Rutpabellonero = xrut;
            this.Nombre = xnombre;
            this.Apellido = xapeliido;
            this.Fono = xfono;
            this.Email = xemail;
        }

    }
}
