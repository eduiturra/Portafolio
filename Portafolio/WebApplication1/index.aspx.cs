using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;
using System.Data.OleDb;
using System.Data;
using CapaEntidades;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            {
      
                GridView1.DataSource = Vistas.VistaPacientes();
                GridView1.DataBind();
            }
        }
    }
}