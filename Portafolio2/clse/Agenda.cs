using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clse
{
    public class Agenda
    {
        private int idagenda;

        public int Idagenda
        {
            get { return idagenda; }
            set { idagenda = value; }
        }

        private String horainicio;

        public String Horainicio
        {
            get { return horainicio; }
            set { horainicio = value; }
        }

        private String horatermino;

        public String Horatermino
        {
            get { return horatermino; }
            set { horatermino = value; }
        }

        private int duracion;

        public int Duracion
        {
            get { return duracion; }
            set { duracion = value; }
        }

        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        private String aseo;

        public String Aseo
        {
            get { return aseo; }
            set { aseo = value; }
        }

        private String retrasado;

        public String Retrasado
        {
            get { return retrasado; }
            set { retrasado = value; }
        }

        private Paciente fk_Paciente;

        public Paciente Fk_Paciente
        {
            get { return fk_Paciente; }
            set { fk_Paciente = value; }
        }

        private Pabellon fk_Pabellon;

        public Pabellon Fk_Pabellon
        {
            get { return fk_Pabellon; }
            set { fk_Pabellon = value; }
        }

        private Especialidad fk_Especialidad;

        public Especialidad Fk_Especialidad
        {
            get { return fk_Especialidad; }
            set { fk_Especialidad = value; }
        }

        private Estado fk_Estado;

        public Estado Fk_Estado
        {
            get { return fk_Estado; }
            set { fk_Estado = value; }
        }


    }
}
