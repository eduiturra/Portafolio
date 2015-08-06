using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;
using CapaNegocios;
using System.Data;
using CapaEntidades;

namespace WebApplication1._4_JefePabellon
{
    public partial class InformePabellon : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                uno.Visible = false;
                Calendar1.SelectedDate = DateTime.Now;
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

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            int especialista =int.Parse(cboEspecialista.SelectedValue);
            int Periodo = cboPeriodo.SelectedIndex;
            if (Periodo==1)
            {
                 DateTime fecha=Calendar1.SelectedDate;
                 GridView1.DataSource = Vistas.VistaReporteFinal(fecha.ToString("d"), especialista).OrderBy(a => a.Pabellon);
                 GridView1.DataBind();
                
                 
            }
            else if (Periodo==2)
            {
               String fecha= cboMes.SelectedValue;
              GridView1.DataSource = Vistas.VistaReporteFinal2(fecha, especialista).OrderBy(a => a.Pabellon);;
               GridView1.DataBind();
               
            }
	   
            
        }

        protected void cboPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
             int Periodo = cboPeriodo.SelectedIndex;
             if (Periodo == 1)
             {
                 uno.Visible = false;
                 Calendar1.Visible = true;
             }
             else if (Periodo == 2)
             {
                 Calendar1.Visible = false;
                 uno.Visible = true;
                 

             }
        }

        protected void cboEspecialista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

       
    }
}