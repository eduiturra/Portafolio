using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class modificarUsuario1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GVUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = Convert.ToInt16(GVUsuarios.SelectedDataKey.Value);
            Response.Redirect("modificarUsuario.aspx?id=" + index);
        }
    }
}