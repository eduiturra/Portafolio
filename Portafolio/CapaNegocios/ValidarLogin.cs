using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;
using CapaEntidades;
namespace CapaNegocios
{
    public class ValidarLogin
    {
        public static String validarLogin(String user, String con)
        {
            String entrar=String.Empty;
            int validar=Vistas.VistaUsuario().Where(a => a.Rutusuario == user && a.Pass == con).Count();
            int validar2 = Vistas.VistaUsuario().Where(a => a.Rutusuario == user && a.Pass != con).Count();

            if (validar==1)
            {
                entrar = Vistas.VistaUroles().Where(a => a.Fk_Usuario.Rutusuario == user).Select(a => a.Fk_Roles.Perfil).First();
            }
            else if (validar2 == 1)
            {
                entrar = "pass";
            }
            else
            {
                entrar = "rut";
            }
            

            return entrar;
        }

        public static string nuevaSesion(String user, String con)
        {
           
                string sesion = null;
                List<Usuario> nuevo = Vistas.VistaUsuario();
                for (int i = 0; i < nuevo.Count; i++)
                {
                    String rut = nuevo[i].Rutusuario;
                    String pass = nuevo[i].Pass;
                    String nombre = nuevo[i].Nombre;
                    String apellido = nuevo[i].Apellido;

                    if (user == rut && con == pass)
                    {

                        sesion = nombre+" "+apellido;
                    }



                }
         
                return sesion;
            }


        }
    }



