using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;
using CapaEntidades;
using System.Web.Services;
using Oracle.DataAccess.Client;
using System.Data;
using Oracle.DataAccess.Types;
using System.Globalization;

namespace WebApplication1
{
    public partial class S_Visualizar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarComboboxEspecialidad();
            }
           
        }

        private void CargarComboboxEspecialidad()
        {
            cboEspecialista.DataSource = Vistas.VistaEspecialidada();
            cboEspecialista.DataTextField = "tipos";
            cboEspecialista.DataValueField = "idespecialidad";
            cboEspecialista.DataBind();
            ListItem l = new ListItem("[Seleccione]", "[Seleccione]");
            cboEspecialista.Items.Insert(0, l);
        }

        protected void cboPersonal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEspecialista.SelectedIndex == 0)
            {

                this.cboPabellon.Items.Clear();

            }

            if (cboEspecialista.SelectedIndex == 1)
            {
                cboPabellon.Enabled = true;
                this.cboPabellon.Items.Clear();
                cboPabellon.DataSource = Vistas.VistaPabellon().Where(z => z.Fk_Especialidad.Idespecialidad.ToString() == cboEspecialista.SelectedValue).Select(a => a.Codigo);
                cboPabellon.DataBind();


            }
            if (cboEspecialista.SelectedIndex == 2)
            {
                cboPabellon.Enabled = true;
                this.cboPabellon.Items.Clear();
                cboPabellon.DataSource = Vistas.VistaPabellon().Where(z => z.Fk_Especialidad.Idespecialidad.ToString() == cboEspecialista.SelectedValue).Select(a => a.Codigo);
                cboPabellon.DataBind();

            }
            if (cboEspecialista.SelectedIndex == 3)
            {

                this.cboPabellon.Items.Clear();
                cboPabellon.Enabled = true;
                cboPabellon.DataSource = Vistas.VistaPabellon().Where(z => z.Fk_Especialidad.Idespecialidad.ToString() == cboEspecialista.SelectedValue).Select(a => a.Codigo);
                cboPabellon.DataBind();

            }
            if (cboEspecialista.SelectedIndex == 4)
            {
                this.cboPabellon.Items.Clear();
                cboPabellon.Enabled = true;
                cboPabellon.DataSource = Vistas.VistaPabellon().Where(z => z.Fk_Especialidad.Idespecialidad.ToString() == cboEspecialista.SelectedValue).Select(a => a.Codigo);
                cboPabellon.DataBind();

            }
        }

        protected void cboNombre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cboPabellon.SelectedIndex == -1 || cboEspecialista.SelectedIndex == 0)
            {
                Response.Write("<script>alert('Tiene que seleccionar una Especialidad')</script>");
            }
            else
            {
                GridView1.Visible = true;
                GridView1.DataSource = Vistas.VistaAgenda().Select(a => new { Pabellon = a.Fk_Pabellon.Codigo, Fecha = a.Fecha.ToString("dd/MM/yyyy"), HoraInicio = a.Horainicio, Aseo = a.Aseo, duracion = a.Duracion, Paciente = a.Fk_Paciente.Nombre, Cirujano = a.Fk_Cirujano.Nombre, Enfermero = a.Fk_Enfermero, Anestesista = a.Fk_Anestesista.Nombre + " " + a.Fk_Anestesista.Apellido,TecAnestesista = a.Fk_Tanestesia.Nombre +" "+ a.Fk_Tanestesia.Apellido,Arsenalero = a.Fk_Arsenalero.Nombre + " " + a.Fk_Arsenalero.Apellido, Pabellonero = a.Fk_Pabellonero.Nombre + " " + a.Fk_Pabellonero.Apellido }).ToList();
       
                GridView1.DataBind();
                if (GridView1.Rows.Count == 0)
                {
                    Response.Write("<script>alert('No se ha encontrado agendamiento')</script>");
                }
            }
        }

        [WebMethod]
        public static string HolaMundo()
        {
           String mensaje=String.Empty;
         
           int con = Vistas.VistaHistorial().Where(a => a.Fecha.ToString("d") == DateTime.Now.ToString("d")).Count();
           if (con == 0)
           {
               mensaje = "No han existido cambios en la agenda el día de hoy";
           }
           else
           {
               List<Historial> historial = Vistas.VistaHistorial().Where(a => a.Fecha.ToString("d") == DateTime.Now.ToString("d")).ToList();
               mensaje = "Ha habido " + con + " cambio en el día de hoy";
               foreach (var item in historial)
               {
                   if (item.Tipo=="insertar")
                   { 
                       mensaje = mensaje + "\n- Se ha insertado una agendamiento nuevo en el pabellón " + item.Fk_idAgenda.Fk_Pabellon.Codigo + " de la especialidad " + item.Fk_idAgenda.Fk_Especialidad.Tipos + " tiene cómo fecha el "+item.Fk_idAgenda.Fecha.ToString("d")+ ",el cambio se hiso el " + item.Fecha; 
                   }
                   else if (item.Tipo == "modificar")
                   {
                       mensaje = mensaje + "\n- Se ha modificado el agendamiento del pabellón " + item.Fk_idAgenda.Fk_Pabellon.Codigo + " de la especialidad " + item.Fk_idAgenda.Fk_Especialidad.Tipos + " tiene cómo fecha el " + item.Fk_idAgenda.Fecha.ToString("d") + ",el cambio se hiso el " + item.Fecha; 

                   }
                   else if (item.Tipo == "estado")
                   {
                       mensaje = mensaje + "\n- Se ha modificado el estado del pabellón " + item.Fk_idAgenda.Fk_Pabellon.Codigo + " de la especialidad " + item.Fk_idAgenda.Fk_Especialidad.Tipos + " tiene cómo fecha el " + item.Fk_idAgenda.Fecha.ToString("d") + ",el cambio se hiso el " + item.Fecha; 

                   }
                    
               }
           }
           return mensaje;
        }

        protected void GridView1_PageIndexChanging1(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = Vistas.VistaAgenda().Select(a => new { Pabellon = a.Fk_Pabellon.Codigo, Fecha = a.Fecha.ToString("dd/MM/yyyy"), HoraInicio = a.Horainicio, Aseo = a.Aseo, duracion = a.Duracion, Paciente = a.Fk_Paciente.Nombre, Cirujano = a.Fk_Cirujano.Nombre, Enfermero = a.Fk_Enfermero, Anestesista = a.Fk_Anestesista.Nombre + " " + a.Fk_Anestesista.Apellido, TecAnestesista = a.Fk_Tanestesia.Nombre + " " + a.Fk_Tanestesia.Apellido, Arsenalero = a.Fk_Arsenalero.Nombre + " " + a.Fk_Arsenalero.Apellido, Pabellonero = a.Fk_Pabellonero.Nombre + " " + a.Fk_Pabellonero.Apellido }).ToList();
            GridView1.DataBind();
        } 

       

    }
}