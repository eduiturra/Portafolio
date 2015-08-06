using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidades;
using CapaDatos;
namespace CapaNegocios
{
    public class ValidarAgenda
    {

        public static bool Validar(int Cirugia, String pabellon, String horaInicio, DateTime tiempo, int durar)
        {
            String[] horas = { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00", "00:00" };

            bool valido = true;
            List<Ocupado> ocupado = new List<Ocupado>();
            int validar = Vistas.VistaAgenda().Where(a => a.Fk_Especialidad.Idespecialidad == Cirugia).Where(a => a.Fk_Pabellon.Codigo == pabellon).Where(a => a.Fecha == tiempo || a.Fecha == tiempo.AddDays(-1)).Count();
            if (validar > 0)
            {
                
                DateTime prueba = tiempo.AddDays(-1);
                DateTime sumar = new DateTime();

                while (prueba <= tiempo)
                {

                    for (int x = 0; x < horas.Length - 1; x++)
                    {

                        int das = Vistas.VistaAgenda().Where(a => a.Horainicio == horas[x]).Where(b => b.Fecha == prueba).Count();

                        if (das != 0)
                        {
                            int duracion = Vistas.VistaAgenda().Where(a => a.Horainicio == horas[x]).Where(b => b.Fecha == prueba).Select(a => a.Duracion).First();
                            for (int i = 0; i < duracion; i++)
                            {

                                if (x >= 24)
                                {
                                    if (x == 24)
                                    {
                                        sumar = prueba.AddDays(1);
                                        prueba = sumar;
                                        x = 0;
                                    }
                                    if (horas[x] == horaInicio)
                                    {
                                        valido = false;
                                    }
                                }

                                else
                                {
                                    if (horas[x] == horaInicio)
                                    {
                                        valido = false;
                                    }

                                    if (duracion != i + 1)    //Para que no hayan dos dt.Rows.Add seguidos
                                    {
                                        x++;
                                    }

                                }

                            }
                        }

                    }

                    sumar = prueba.AddDays(1);
                    prueba = sumar;
                }
            }
            else
            {

                for (int x = 0; x < horas.Length - 1; x++)
                {


                    Ocupado oc = new Ocupado();
                    oc.Hora = horas[x] + "-" + horas[x + 1]; ;
                    oc.Estado = "Libre";
                    oc.Fecha = tiempo;
                    ocupado.Add(oc);



                }
            }

            return valido;
        }

    }
}
