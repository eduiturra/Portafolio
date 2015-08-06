using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaEntidades
{
    public class Anestesista
    {
         private String rutanestesista;

         public String Rutanestesista
        {
            get { return rutanestesista; }
            set { rutanestesista = value; }
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

        public Anestesista()
        {

        }

        public Anestesista(String xrut,String xnombre,String xapeliido,int xfono,String xemail)
        {
            this.Rutanestesista = xrut;
            this.Nombre = xnombre;
            this.Apellido = xapeliido;
            this.Fono = xfono;
            this.Email = xemail;
        }
    }
}
