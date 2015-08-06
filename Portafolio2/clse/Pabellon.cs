using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clse
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

        private String tamaño;

        public String Tamaño
        {
            get { return tamaño; }
            set { tamaño = value; }
        }

        public Pabellon()
        { }

        public Pabellon(int idpabellon, String area, String tamaño)
        {
            this.Idpabellon = idpabellon;
            this.Area = area;
            this.Tamaño = tamaño;
        }
    }
}
