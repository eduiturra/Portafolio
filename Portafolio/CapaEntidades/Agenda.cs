using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaEntidades
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

       
        private Usuario fk_Usuario;

        public Usuario Fk_Usuario
        {
            get { return fk_Usuario; }
            set { fk_Usuario = value; }
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

        private Enfermero fk_Enfermero;

        public Enfermero Fk_Enfermero
        {
            get { return fk_Enfermero; }
            set { fk_Enfermero = value; }
        }


        private Cirujano fk_Cirujano;

        public Cirujano Fk_Cirujano
        {
            get { return fk_Cirujano; }
            set { fk_Cirujano = value; }
        }

        private Pabellonero fk_Pabellonero;

        public Pabellonero Fk_Pabellonero
        {
            get { return fk_Pabellonero; }
            set { fk_Pabellonero = value; }
        }

        private Anestesista fk_Anestesista;

        public Anestesista Fk_Anestesista
        {
            get { return fk_Anestesista; }
            set { fk_Anestesista = value; }
        }

        private Tanestesista fk_Tanestesia;

        public Tanestesista Fk_Tanestesia
        {
            get { return fk_Tanestesia; }
            set { fk_Tanestesia = value; }
        }


        private Arsenalero fk_Arsenalero;

        public Arsenalero Fk_Arsenalero
        {
            get { return fk_Arsenalero; }
            set { fk_Arsenalero = value; }
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
