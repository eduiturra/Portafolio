using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clse
{
    public class Clinica
    {
        private int idclinica;

        public int Idclinica
        {
            get { return idclinica; }
            set { idclinica = value; }
        }

        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private String direccion;

        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        private int fono;

        public int Fono
        {
            get { return fono; }
            set { fono = value; }
        }

        public Clinica()
        { }

        public Clinica(int id, String nombre, String direccion, int fono)
        {
            this.Idclinica = id;
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Fono = fono;
        }
    }
}
