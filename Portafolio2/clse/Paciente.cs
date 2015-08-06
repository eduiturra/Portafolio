using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clse
{
    public class Paciente
    {
        private String rutpaciente;

        public String Rutpaciente
        {
            get { return rutpaciente; }
            set { rutpaciente = value; }
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

        private int edad;

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
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

        public Paciente()
        { }

        public Paciente(String rutp, String nombre, String apellido, int edad, int fono, String email)
        {
            this.Rutpaciente = rutp;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
            this.Fono = fono;
            this.Email = email;
        }
    }
}
