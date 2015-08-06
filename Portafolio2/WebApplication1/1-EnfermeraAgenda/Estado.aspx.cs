using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidades;
using CapaDatos;

namespace WebApplication1._1_EnfermeraAgenda
{
    public partial class Estado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {


                GridView1.Visible = true;
                GridView1.DataSource = Vistas.VistaAgenda().Select(a => new { id = a.Idagenda, Fecha = a.Fecha.ToString("dd/MM/yyyy"), nombre = a.Fk_Usuario.Nombre, HoraInicio = a.Horainicio, HoraTermino = a.Horatermino, Aseo = a.Aseo, duracion = a.Duracion, Paciente = a.Fk_Paciente.Nombre, Cirujano = a.Fk_Cirujano.Nombre, Pabellon = a.Fk_Pabellon }).OrderBy(a => a.id).ToList();
                GridView1.DataBind();
            }
        }

        protected void cboEspecialista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void cboPabellon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void cboPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void cboUsuario2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void cboCirujano_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //Determine the RowIndex of the Row whose Button was clicked.
          

           
            
            if (e.CommandName == "Finalizar")
            {
                int index = Convert.ToInt32(GridView1.DataKeys[1].Values[0]);
                Actualizar.ActualizarEstado(index, 3);
                Response.Write("<script>alert('Operación Exitosa!!!')</script>");
            }
            else if (e.CommandName == "Suspender")
            {
                int index = Convert.ToInt32(GridView1.DataKeys[1].Values[0]);
                Actualizar.ActualizarEstado(index, 2);
                Response.Write("<script>alert('Operación Exitosa!!!')</script>");
            }
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = Vistas.VistaAgenda().Select(a => new { id = a.Idagenda, Fecha = a.Fecha.ToString("dd/MM/yyyy"), nombre = a.Fk_Usuario.Nombre, HoraInicio = a.Horainicio, HoraTermino = a.Horatermino, Aseo = a.Aseo, duracion = a.Duracion, Paciente = a.Fk_Paciente.Nombre, Cirujano = a.Fk_Cirujano.Nombre, Pabellon = a.Fk_Pabellon }).OrderBy(a => a.id).ToList();
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {

        }
    }
}