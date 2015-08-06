using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocios
{
    public class ValidarComboBox
    {
        public static String Validar(int indice0,int indice, int indice2, int indice3, int indice4, int indice5)
        {
            String nuevo = null;
            if (indice0 == 0)
            {
                nuevo = "<script>alert('Tiene que elegir un Paciente')</script>";
            }
            else if (indice==0)
            {
                nuevo = "<script>alert('Tiene que elegir un Cirujano')</script>";
            }
            else if (indice2 == 0)
            {

                nuevo = "<script>alert('Tiene que elegir un Anestesista')</script>";
            }
            else if (indice2 == 0)
            {

                nuevo = "<script>alert('Tiene que elegir un Arsenalero')</script>";
            }
            else if (indice2 == 0)
            {

                nuevo = "<script>alert('Tiene que elegir un Tecnico Anestesista')</script>";
            }
            else if (indice2 == 0)
            {

                nuevo = "<script>alert('Tiene que elegir un Enfermero')</script>";
            }

            return nuevo;
        }
    }
}
