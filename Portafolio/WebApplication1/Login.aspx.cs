using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data;
using CapaDatos;
using CapaNegocios;
using System.Drawing;

namespace WebApplication1
{
    public partial class Login : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            using (OracleConnection conn = Conexion.conectar())
            {
                conn.Open();
                String entrar =ValidarLogin.validarLogin(usuario.Text, contrasenia.Text);

                if (entrar=="Enfermera")
                {
                    Session["user"] = ValidarLogin.nuevaSesion(usuario.Text, contrasenia.Text);
                    Session["rut"] = usuario.Text;
                    
                    Response.Redirect("1-EnfermeraAgenda/Inicio.aspx");
                }
                else if (entrar=="Salud")
                {
                    Session["user"] = ValidarLogin.nuevaSesion(usuario.Text, contrasenia.Text);
                    Session["rut"] = usuario.Text;

                    Response.Redirect("2-TrabajadorSalud/S_Inicio.aspx");
                }
                else if (entrar == "Jefe de Pabellon")
                {
                    Session["user"] = ValidarLogin.nuevaSesion(usuario.Text, contrasenia.Text);
                    Session["rut"] = usuario.Text;
                    Response.Redirect("4-JefePabellon/Inicio.aspx");
                }
                else if (entrar == "Salud")
                {
                    /* Session["user"] = ValidarLogin.nuevaSesion(usuario.Text, contrasenia.Text);
                     Session["rut"] = usuario.Text;
                     Response.Redirect("3-Administrador/Inicio.aspx");*/
                }
                else if (entrar=="rut")
                {
                    Label2.Text = "";
                    contrasenia.BorderColor = Color.White;
                    usuario.BorderColor = Color.Red;
                    Label1.Text="Rut Incorrecto";
                    Label1.ForeColor = Color.Red;
                }
                else if (entrar == "pass")
                {
                    Label1.Text = "";
                    usuario.BorderColor = Color.White;
                    contrasenia.BorderColor = Color.Red;
                    Label2.Text = "Contraseña Incorrecta";
                    Label2.ForeColor= Color.Red;
                    
                        
                }
                

                conn.Close();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            using (OracleConnection conn = Conexion.conectar())
            {
                conn.Open();
                OracleCommand cd = new OracleCommand("proLOGEAR", conn);
                cd.CommandType = CommandType.StoredProcedure;
                cd.Parameters.Add("pRut","17081250-6");
                cd.Parameters.Add("pClave", "123");
                OracleDataReader rd = cd.ExecuteReader();
                while (rd.Read())
                {
                    Label1.Text = rd["numero"].ToString();
                }
                
                conn.Close();
            }
        }



    }
}