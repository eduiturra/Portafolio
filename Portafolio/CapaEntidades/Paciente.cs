using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaEntidades
{
    public class Paciente
    {
        private String rut;
        private String nombre;
        private String apellido;
        private int edad;
        private int fono;
        private String email;
       

        public String Rut
        {
            get { return rut; }
            set { rut = value; }
        }


        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public String Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
       

        public int Fono
        {
            get { return fono; }
            set { fono = value; }
        }


        public String Email
        {
            get { return email; }
            set { email = value; }
        }


        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public Paciente()
        {

        }

        public Paciente(String rut,String nombre,String apellido,int edad,int fono,String email)
        {
            this.Rut = rut;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
            this.Fono = fono;
            this.Email = email;
        }

        
        
    }
}
