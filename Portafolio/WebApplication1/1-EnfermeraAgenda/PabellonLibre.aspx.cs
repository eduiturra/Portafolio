using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;
using CapaNegocios;
using CapaEntidades;
using System.Drawing;

namespace WebApplication1
{
    public partial class PabellonLibre : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                Calendar1.SelectedDate = DateTime.Now;
            }
        }



        protected void cboPersonal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPersonal.SelectedIndex == 0)
            {

                this.cboNombre.Items.Clear();
                btnBuscar.Enabled = false;
                Calendar1.Enabled = false;
                cboNombre.Enabled = false;
            }

            if (cboPersonal.SelectedIndex == 1)
            {
                this.cboNombre.Items.Clear();
                activarCombobox();
                cboNombre.DataSource = Vistas.VistaCirujano().Select(a => new { nombre = a.Nombre + " " + a.Apellido, rut = a.RutCirujano });
                cboNombre.DataTextField = "nombre";
                cboNombre.DataValueField = "rut";
                cboNombre.DataBind();
                ListItem l = new ListItem("[Seleccione]", "[Seleccione]");
                cboNombre.Items.Insert(0, l);

            }
            if (cboPersonal.SelectedIndex == 2)
            {
                this.cboNombre.Items.Clear();
                activarCombobox();
                cboNombre.DataSource = Vistas.VistanAnestesista().Select(a => new { nombre = a.Nombre + " " + a.Apellido, rut = a.Rutanestesista });
                cboNombre.DataTextField = "nombre";
                cboNombre.DataValueField = "rut";
                cboNombre.DataBind();
                ListItem l = new ListItem("[Seleccione]", "[Seleccione]");
                cboNombre.Items.Insert(0, l);

            }
            if (cboPersonal.SelectedIndex == 3)
            {

                this.cboNombre.Items.Clear();
                activarCombobox();
                cboNombre.DataSource = Vistas.VistanEnfermero().Select(a => new { nombre = a.Nombre + " " + a.Apellido, rut = a.Rutenfermero });
                cboNombre.DataTextField = "nombre";
                cboNombre.DataValueField = "rut";
                cboNombre.DataBind();
                ListItem l = new ListItem("[Seleccione]", "[Seleccione]");
                cboNombre.Items.Insert(0, l);
            }
            if (cboPersonal.SelectedIndex == 4)
            {

                this.cboNombre.Items.Clear();
                activarCombobox();
                cboNombre.DataSource = Vistas.VistanArsenalero().Select(a => new { nombre = a.Nombre + " " + a.Apellido, rut = a.Rutarsenalero });
                cboNombre.DataTextField = "nombre";
                cboNombre.DataValueField = "rut";
                cboNombre.DataBind();
                ListItem l = new ListItem("[Seleccione]", "[Seleccione]");
                cboNombre.Items.Insert(0, l);
            }
            if (cboPersonal.SelectedIndex == 5)
            {

                this.cboNombre.Items.Clear();
                activarCombobox();
                cboNombre.DataSource = Vistas.VistanTanestesista().Select(a => new { nombre = a.Nombre + " " + a.Apellido, rut = a.Ruttanestesista });
                cboNombre.DataTextField = "nombre";
                cboNombre.DataValueField = "rut";
                cboNombre.DataBind();
                ListItem l = new ListItem("[Seleccione]", "[Seleccione]");
                cboNombre.Items.Insert(0, l);
            }
        }

        protected void cboNombre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cboPersonal.SelectedIndex == 0)
            {
                Response.Write("<script>alert('Debe seleccionar Personal')</script>");
                cboNombre.BorderColor = Color.White;
                cboPersonal.BorderColor = Color.Red;
            }
            else if (cboNombre.SelectedIndex == 0)
            {
                Response.Write("<script>alert('Debe seleccionar el nombre del Personal')</script>");
                cboNombre.BorderColor = Color.Red;
                cboPersonal.BorderColor = Color.White;
            }
            else
            {
                if (cboPersonal.SelectedIndex == 1)
                {
                    cboNombre.BorderColor = Color.White;
                    cboPersonal.BorderColor = Color.White;
                    GridView1.Visible = true;

                    GridView1.DataSource = Vistas.VistaOcupadoCirujano(cboNombre.SelectedValue, Calendar1.SelectedDate).Where(a => a.Fecha == Calendar1.SelectedDate).Select(a => new { Fecha = a.Fecha.ToString("dd/MM/yyyy"), Hora = a.Hora, Estado = a.Estado });

                    GridView1.DataBind();
                }
                if (cboPersonal.SelectedIndex == 2)
                {
                    GridView1.Visible = true;

                    GridView1.DataSource = Vistas.VistaOcupadoAnestesista(cboNombre.SelectedValue, Calendar1.SelectedDate).Where(a => a.Fecha == Calendar1.SelectedDate).Select(a => new { Fecha = a.Fecha.ToString("dd/MM/yyyy"), Hora = a.Hora, Estado = a.Estado });

                    GridView1.DataBind();
                }
                if (cboPersonal.SelectedIndex == 3)
                {
                    GridView1.Visible = true;

                    GridView1.DataSource = Vistas.VistaOcupadoEnfermero(cboNombre.SelectedValue, Calendar1.SelectedDate).Where(a => a.Fecha == Calendar1.SelectedDate).Select(a => new { Fecha = a.Fecha.ToString("dd/MM/yyyy"), Hora = a.Hora, Estado = a.Estado, });

                    GridView1.DataBind();
                }
                if (cboPersonal.SelectedIndex == 4)
                {
                    GridView1.Visible = true;

                    GridView1.DataSource = Vistas.VistaOcupadoArsenalero(cboNombre.SelectedValue, Calendar1.SelectedDate).Where(a => a.Fecha == Calendar1.SelectedDate).Select(a => new { Fecha = a.Fecha.ToString("dd/MM/yyyy"), Hora = a.Hora, Estado = a.Estado, });

                    GridView1.DataBind();
                }
                if (cboPersonal.SelectedIndex == 5)
                {
                    GridView1.Visible = true;

                    GridView1.DataSource = Vistas.VistaOcupadoT_Anestesista(cboNombre.SelectedValue, Calendar1.SelectedDate).Where(a => a.Fecha == Calendar1.SelectedDate).Select(a => new { Fecha = a.Fecha.ToString("dd/MM/yyyy"), Hora = a.Hora, Estado = a.Estado, });

                    GridView1.DataBind();
                }
            }
        }
        private void activarCombobox()
        {
            btnBuscar.Enabled = true;
            Calendar1.Enabled = true;
            cboNombre.Enabled = true;

        }



    }
}