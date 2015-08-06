using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaEntidades
{
    public class Especialidad
    {
        private int idespecialidad;

        public int Idespecialidad
        {
            get { return idespecialidad; }
            set { idespecialidad = value; }
        }

        private String tipos;

        public String Tipos
        {
            get { return tipos; }
            set { tipos = value; }
        }

        public Especialidad()
        { }

       
    }
}
