using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaEntidades
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
        {

        }

        public Clinica(int id,String nom,String direc,int fon)
        {
            this.Idclinica = id;
            this.Nombre = nom;
            this.Direccion = direc;
            this.Fono = fon;
        }

    }
}
