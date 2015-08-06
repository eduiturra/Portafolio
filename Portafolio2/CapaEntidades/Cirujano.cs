using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaEntidades
{
    public class Cirujano
    {
        private String rutcirujano;

        public String RutCirujano
        {
            get { return rutcirujano; }
            set { rutcirujano = value; }
        }

        private Especialidad fk_Especialidad;

        public Especialidad Fk_Especialidad
        {
            get { return fk_Especialidad; }
            set { fk_Especialidad = value; }
        }

        private String especialidad;

        public String Especialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
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

        public Cirujano()
        {

        }

        
    }
}
