using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaEntidades
{
    public class Pabellon
    {
        private int idpabellon;

        public int Idpabellon
        {
            get { return idpabellon; }
            set { idpabellon = value; }
        }
        private String area;

        public String Area
        {
            get { return area; }
            set { area = value; }
        }

        private Especialidad fk_Especialidad;

        public Especialidad Fk_Especialidad
        {
            get { return fk_Especialidad; }
            set { fk_Especialidad = value; }
        }

        private String tamaño;

        public String Tamaño
        {
            get { return tamaño; }
            set { tamaño = value; }
        }

        private String codigo;

        public String Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public Pabellon()
        {

        }

        
    }
}
