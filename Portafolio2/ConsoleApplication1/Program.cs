using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidades;
using CapaDatos;
using System.Data;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* DateTime tiempo=new DateTime(2008,11,10);
             Console.WriteLine(tiempo.ToString("dd/MM/yyyy"));
             Console.ReadLine();
             TimeSpan hora = new TimeSpan(10,10,00);
             Console.WriteLine(hora.ToString("hh\\:mm"));
             Console.ReadLine();
             try
             {
                 //Insertar.InsertarAgenda(2, "31:12", "31:12", 232, "02/02/2015", "dasd", "dasd", "dasd", "dasd", "170812506", "1170812506", 1, "170812506", "890800", "170812506", "170812506", "170812506", "170812506");
                 Console.ReadLine();
             }
             catch (Exception ex)
             {
                 Console.WriteLine(ex);
                 Console.ReadLine();
             }
            */
            List<Ocupado> ocupado = new List<Ocupado>();
            DateTime nuevo = Vistas.VistaAgenda().Select(a => a.Fecha).Min();
            DateTime nuevo4 = Vistas.VistaAgenda().Select(a => a.Fecha).Max();
            DateTime sumar = new DateTime();
            String[] horas = { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00" };

            while (nuevo <= nuevo4)
            {

                for (int x = 0; x < horas.Length; x++)
                {

                    int das = Vistas.VistaAgenda().Where(a => a.Horainicio == horas[x]).Where(b => b.Fecha == nuevo).Count();

                    if (das == 0)
                    {
                        Ocupado oc = new Ocupado();
                        oc.Hora = horas[x];
                        oc.Estado = "Libre";
                        oc.Fecha = nuevo;
                        ocupado.Add(oc);


                    }
                    else
                    {
                        int duracion = Vistas.VistaAgenda().Where(a => a.Horainicio == horas[x]).Where(b => b.Fecha == nuevo).Select(a => a.Duracion).First();
                        for (int i = 0; i < duracion; i++)
                        {

                            if (x >= 24)
                            {
                                if (x == 24)
                                {
                                    sumar = nuevo.AddDays(1);
                                    nuevo = sumar;
                                    x = 0;
                                }
                                Ocupado oc = new Ocupado();
                                oc.Hora = horas[x];
                                oc.Estado = "Ocupado";
                                oc.Fecha = nuevo;
                                ocupado.Add(oc);
                                x++;
                            }

                            else
                            {
                                Ocupado oc = new Ocupado();
                                oc.Hora = horas[x];
                                oc.Estado = "Ocupado";
                                oc.Fecha = nuevo;
                                ocupado.Add(oc);



                                if (duracion != i + 1)    //Para que no hayan dos dt.Rows.Add seguidos
                                {
                                    x++;
                                }

                            }

                        }
                    }

                }

                sumar = nuevo.AddDays(1);
                nuevo = sumar;
            }
            Console.WriteLine(ocupado.Count);
            Console.ReadKey();
        }
    }
}
