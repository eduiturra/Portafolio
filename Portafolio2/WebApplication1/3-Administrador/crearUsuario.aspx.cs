using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class crearUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            String rut = txtRut.Text;
            String nombre = txtNombre.Text;
            String apellido = txtApellido.Text;
            String fono = txtFono.Text;
            String email = txtEmail.Text;
            String pass = txtPass.Text;
            Validar(rut, nombre, apellido, fono, email, pass);
        }

        private void Validar(String rut, String nombre, String apellido, String fono, String email, String pass)
        {
            throw new NotImplementedException();
        }
    }
}