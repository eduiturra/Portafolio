using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CapaDatos;
using CapaNegocios;
using CapaEntidades;

namespace WebApplication1
{
    public partial class BuscarAgenda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Calendar1.SelectedDate = DateTime.Now;
                CargarComboboxEspecialidad();
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

        private void Filtro()
        {
            GridView1.Visible = true;

            GridView1.DataSource = Vistas.VistaOcupado(cboEspecialista2.SelectedValue, cboPabellon2.SelectedValue, Calendar1.SelectedDate).Where(a => a.Fecha == Calendar1.SelectedDate).Select(a=>new{Fecha=a.Fecha.ToString("dd/MM/yyyy"),Hora=a.Hora,Estado=a.Estado});
           
            GridView1.DataBind();
           
            
            
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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
                activarCombobox();
                cboPabellon2.DataSource = Vistas.VistaPabellon().Where(z => z.Fk_Especialidad.Idespecialidad.ToString() == cboEspecialista2.SelectedValue).Select(a => a.Codigo);
                cboPabellon2.DataBind();


            }
            if (cboEspecialista2.SelectedIndex == 2)
            {
                this.cboPabellon2.Items.Clear();
                activarCombobox();
                cboPabellon2.DataSource = Vistas.VistaPabellon().Where(z => z.Fk_Especialidad.Idespecialidad.ToString() == cboEspecialista2.SelectedValue).Select(a => a.Codigo);
                cboPabellon2.DataBind();

            }
            if (cboEspecialista2.SelectedIndex == 3)
            {

                this.cboPabellon2.Items.Clear();
                activarCombobox();
                cboPabellon2.DataSource = Vistas.VistaPabellon().Where(z => z.Fk_Especialidad.Idespecialidad.ToString() == cboEspecialista2.SelectedValue).Select(a => a.Codigo);
                cboPabellon2.DataBind();

            }
            if (cboEspecialista2.SelectedIndex == 4)
            {
                this.cboPabellon2.Items.Clear();
                activarCombobox();
                cboPabellon2.DataSource = Vistas.VistaPabellon().Where(z => z.Fk_Especialidad.Idespecialidad.ToString() == cboEspecialista2.SelectedValue).Select(a => a.Codigo);
                cboPabellon2.DataBind();

            }
        }

        protected void cboPabellon2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void activarCombobox()
        {
            btnBuscar.Enabled = true;
            Calendar1.Enabled = true;
            cboPabellon2.Enabled = true;
           
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {

            Filtro();
        }
    }
}