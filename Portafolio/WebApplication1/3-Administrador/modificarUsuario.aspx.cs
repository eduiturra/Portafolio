using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class modificarUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cboPaciente2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            String nrut = txtNRut.Text;
            String nnombre = txtNNombre.Text;
            String napellido = txtNApellido.Text;
            String nfono = txtNFono.Text;
            String nemail = txtNEmail.Text;
            String npass = txtNPass.Text;
        }
    }
}