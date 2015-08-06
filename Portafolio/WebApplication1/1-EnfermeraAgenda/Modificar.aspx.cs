using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;
using CapaNegocios;
using CapaEntidades;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (!IsPostBack)
            {
                CargarComboboxEspecialidad();
                CargarComboboxPaciente2();
                
            }
            
        }

        private void CargarComboboxEspecialidad()
        {
            cboEspecialista2.DataSource = Vistas.VistaEspecialidada();
            cboEspecialista2.DataTextField = "tipos";
            cboEspecialista2.DataValueField = "idespecialidad";
            cboEspecialista2.DataBind();
            ListItem l = new ListItem("[Seleccione]", "[Seleccione]");
            cboEspecialista2.Items.Insert(0, l);
        }

        private void CargarComboboxPaciente2()
        {
            cboPaciente2.DataSource = Vistas.VistaPacientes().Select(a => new { paciente = a.Nombre + " " + a.Apellido, rut = a.Rut });
            cboPaciente2.DataTextField = "paciente";
            cboPaciente2.DataValueField = "rut";
            cboPaciente2.DataBind();
            ListItem l = new ListItem("[Seleccione]", "[Seleccione]");
            cboPaciente2.Items.Insert(0, l);



        }


            

        protected void cboEspecialista2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEspecialista2.SelectedIndex == 0)
            {

                this.cboPabellon2.Items.Clear();

            }

            if (cboEspecialista2.SelectedIndex == 1)
            {
                this.cboPabellon2.Items.Clear();
                activarCombobox2();
                cboPabellon2.DataSource = Vistas.VistaPabellon().Where(z => z.Fk_Especialidad.Idespecialidad.ToString() == cboEspecialista2.SelectedValue).Select(a => a.Codigo);
                cboPabellon2.DataBind();
                

            }
            if (cboEspecialista2.SelectedIndex == 2)
            {
                this.cboPabellon2.Items.Clear();
                activarCombobox2();
                cboPabellon2.DataSource = Vistas.VistaPabellon().Where(z => z.Fk_Especialidad.Idespecialidad.ToString() == cboEspecialista2.SelectedValue).Select(a => a.Codigo);
                cboPabellon2.DataBind();
                
            }
            if (cboEspecialista2.SelectedIndex == 3)
            {

                this.cboPabellon2.Items.Clear();
                activarCombobox2();
                cboPabellon2.DataSource = Vistas.VistaPabellon().Where(z => z.Fk_Especialidad.Idespecialidad.ToString() == cboEspecialista2.SelectedValue).Select(a => a.Codigo);
                cboPabellon2.DataBind();
                
            }
            if (cboEspecialista2.SelectedIndex == 4)
            {
                this.cboPabellon2.Items.Clear();
                activarCombobox2();
                cboPabellon2.DataSource = Vistas.VistaPabellon().Where(z => z.Fk_Especialidad.Idespecialidad.ToString() == cboEspecialista2.SelectedValue).Select(a => a.Codigo);
                cboPabellon2.DataBind();
              
            }
        }

      

        private void activarCombobox2()
        {
            cboPabellon2.Enabled = true;
            cboPaciente2.Enabled = true;
            btnBuscar.Enabled = true;
        }




        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cboEspecialista2.SelectedIndex == 0)
            {
                Response.Write("<script>alert('Tiene que seleccionar una Especialidad')</script>");

            }
            else
            {

                int indexEspe = int.Parse(cboEspecialista2.SelectedValue);
                int indexPabellon = cboPabellon2.SelectedIndex;
                int indexPaciente = cboPaciente2.SelectedIndex;
                 DateTime fecha = Calendar1.SelectedDate;
                if (indexEspe == 0 && indexPabellon == -1 && indexPaciente == 0 && fecha.Year == 1)
                {
                    Response.Write("<script>alert('Tiene que seleccionar un campo')</script>");
                }
                else
                {
                    GridView1.Visible = true;
                    List<Agenda> agenda = Filtrar(fecha, indexEspe, indexPabellon, indexPaciente);
                    GridView1.DataSource = agenda.Select(a => new { id = a.Idagenda, Fecha = a.Fecha.ToString("dd/MM/yyyy"), nombre = a.Fk_Usuario.Nombre, HoraInicio = a.Horainicio, HoraTermino = a.Horatermino, Aseo = a.Aseo, duracion = a.Duracion, Paciente = a.Fk_Paciente.Nombre, Cirujano = a.Fk_Cirujano.Nombre, Pabellon = a.Fk_Pabellon }).OrderBy(a => a.id);
                    GridView1.DataBind();
                    if (GridView1.Rows.Count == 0)
                    {
                        Response.Write("<script>alert('No se ha encontrado agendamiento')</script>");
                    }
                }

            }
        }
        private List<Agenda> Filtrar(DateTime fecha,int indexEspe, int indexPabellon, int indexPaciente)
        {
            List<Agenda> nuevo = Vistas.VistaAgenda().ToList();
            if (fecha.Year!=1)
            {
                nuevo = Vistas.VistaAgenda().Where(a => a.Fecha == fecha).ToList(); 
            }

            
            if (indexEspe != 0)
            {
               nuevo  = nuevo.Where(a => a.Fk_Especialidad.Idespecialidad.ToString() == cboEspecialista2.SelectedValue).ToList();

            }
           
            if (indexPabellon == -1 ||indexPabellon == 0)
            {

            }
            else
            {
                nuevo = nuevo.Where(a => a.Fk_Pabellon.Codigo == cboPabellon2.SelectedValue).ToList();

            }
            if (indexPaciente != 0)
            {
                nuevo= nuevo.Where(a => a.Fk_Paciente.Rut == cboPaciente2.SelectedValue).ToList();

            }
           

            return nuevo;
        }

      
        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
           

            int index = Convert.ToInt16(GridView1.SelectedDataKey.Value);
            Response.Redirect("Modificar2.aspx?id="+index);
        }

           
        protected void cboPabellon2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void cboPaciente2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void cboCirujano2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void cboUsuario2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}