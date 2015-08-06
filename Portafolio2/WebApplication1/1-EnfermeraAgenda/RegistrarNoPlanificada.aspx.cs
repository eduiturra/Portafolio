using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;
using CapaNegocios;
using System.Drawing;


namespace WebApplication1
{
    public partial class RegistrarNoPlanificada : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                Calendar1.SelectedDate = DateTime.Now;
                CargarComboboxEspecialidad();
                CargarComboboxPaciente();
                CargarComboboxAnestesista();
                CargarComboboxArsenalero();
                CargarComboboxEnfermero();
                CargarComboboxTanestesista();



                if (Session["user"] == null)
                {
                    Response.Redirect("WebForm1.aspx");


                }
                else
                {

                }



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

        //Carga los números de pabellones segun la especialidad elegida.
        protected void ComboBoxEspecialista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEspecialista.SelectedIndex == 0)
            {

                this.cboPabellon.Items.Clear();

            }

            if (cboEspecialista.SelectedIndex == 1)
            {
                this.cboPabellon.Items.Clear();
                activarCombobox();
                cboPabellon.DataSource = Vistas.VistaPabellon().Where(z => z.Fk_Especialidad.Idespecialidad.ToString() == cboEspecialista.SelectedValue).Select(a => a.Codigo);
                cboPabellon.DataBind();
                CargarComboboxCirujano();

            }
            if (cboEspecialista.SelectedIndex == 2)
            {
                this.cboPabellon.Items.Clear();
                activarCombobox();
                cboPabellon.DataSource = Vistas.VistaPabellon().Where(z => z.Fk_Especialidad.Idespecialidad.ToString() == cboEspecialista.SelectedValue).Select(a => a.Codigo);
                cboPabellon.DataBind();
                CargarComboboxCirujano();
            }
            if (cboEspecialista.SelectedIndex == 3)
            {

                this.cboPabellon.Items.Clear();
                activarCombobox();
                cboPabellon.DataSource = Vistas.VistaPabellon().Where(z => z.Fk_Especialidad.Idespecialidad.ToString() == cboEspecialista.SelectedValue).Select(a => a.Codigo);
                cboPabellon.DataBind();
                CargarComboboxCirujano();
            }
            if (cboEspecialista.SelectedIndex == 4)
            {
                this.cboPabellon.Items.Clear();
                activarCombobox();
                cboPabellon.DataSource = Vistas.VistaPabellon().Where(z => z.Fk_Especialidad.Idespecialidad.ToString() == cboEspecialista.SelectedValue).Select(a => a.Codigo);
                cboPabellon.DataBind();
                CargarComboboxCirujano();
            }
        }

        //activa los combobox desactivados
        private void activarCombobox()
        {
            btnGuardar.Enabled = true;
            cboCirujano.Enabled = true;
            cboPaciente.Enabled = true;
            cboHora.Enabled = true;
            cboDuracion.Enabled = true;
            cboEnfermero.Enabled = true;
            cboTarnestesia.Enabled = true;
            Calendar1.Enabled = true;
            cboPabellon.Enabled = true;
            cboArsenalero.Enabled = true;
            cboAnestesista.Enabled = true;
            cboAseo.Enabled = true;
        }

        //Carga ComboBox de los Pacientes.
        private void CargarComboboxPaciente()
        {
            cboPaciente.DataSource = Vistas.VistaPacientes().Select(a => new { paciente = a.Nombre + " " + a.Apellido, rut = a.Rut });
            cboPaciente.DataTextField = "paciente";
            cboPaciente.DataValueField = "rut";
            cboPaciente.DataBind();
            ListItem l = new ListItem("[Seleccione]", "[Seleccione]");
            cboPaciente.Items.Insert(0, l);



        }

        private void CargarComboboxCirujano()
        {
            cboCirujano.DataSource = Vistas.VistaCirujano().Where(a => a.Fk_Especialidad.Idespecialidad.ToString() == cboEspecialista.SelectedValue).Select(a => new { cirujano = a.Nombre + " " + a.Apellido, rut = a.RutCirujano });
            cboCirujano.DataTextField = "cirujano";
            cboCirujano.DataValueField = "rut";
            cboCirujano.DataBind();
            ListItem l = new ListItem("[Seleccione]", "[Seleccione]");
            cboCirujano.Items.Insert(0, l);
        }

        private void CargarComboboxEnfermero()
        {
            cboEnfermero.DataSource = Vistas.VistanEnfermero().Select(a => new { enfermero = a.Nombre + " " + a.Apellido, rut = a.Rutenfermero });
            cboEnfermero.DataTextField = "enfermero";
            cboEnfermero.DataValueField = "rut";
            cboEnfermero.DataBind();
            ListItem l = new ListItem("[Seleccione]", "[Seleccione]");
            cboEnfermero.Items.Insert(0, l);
        }

        private void CargarComboboxAnestesista()
        {
            cboAnestesista.DataSource = Vistas.VistanAnestesista().Select(a => new { anestesista = a.Nombre + " " + a.Apellido, rut = a.Rutanestesista });
            cboAnestesista.DataTextField = "anestesista";
            cboAnestesista.DataValueField = "rut";
            cboAnestesista.DataBind();
            ListItem l = new ListItem("[Seleccione]", "[Seleccione]");
            cboAnestesista.Items.Insert(0, l);
        }

        private void CargarComboboxArsenalero()
        {
            cboArsenalero.DataSource = Vistas.VistanArsenalero().Select(a => new { arsenalero = a.Nombre + " " + a.Apellido, rut = a.Rutarsenalero });
            cboArsenalero.DataTextField = "arsenalero";
            cboArsenalero.DataValueField = "rut";
            cboArsenalero.DataBind();
            ListItem l = new ListItem("[Seleccione]", "[Seleccione]");
            cboArsenalero.Items.Insert(0, l);
        }

        private void CargarComboboxTanestesista()
        {
            cboTarnestesia.DataSource = Vistas.VistanTanestesista().Select(a => new { tanestesista = a.Nombre + " " + a.Apellido, rut = a.Ruttanestesista });
            cboTarnestesia.DataTextField = "tanestesista";
            cboTarnestesia.DataValueField = "rut";
            cboTarnestesia.DataBind();
            ListItem l = new ListItem("[Seleccione]", "[Seleccione]");
            cboTarnestesia.Items.Insert(0, l);
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            String usuario = Session["rut"].ToString();
            String aseo = "NO";

            String horainicio = cboHora.SelectedValue;

            int duracion = 0;

            int tipo = int.Parse(cboEspecialista.SelectedValue);
            String pabellon = cboPabellon.SelectedValue;
            String paciente = cboPaciente.SelectedValue;
            String inCirujano = cboCirujano.SelectedValue;
            String inAnestesista = cboAnestesista.SelectedValue;
            String inArsenalero = cboArsenalero.SelectedValue;
            String inEnfermero = cboEnfermero.SelectedValue;
            String inTanestesista = cboTarnestesia.SelectedValue;
            String pabellonero = "18213925-4";
            int especialidad = int.Parse(cboEspecialista.SelectedValue);


            if (cboAseo.SelectedIndex != 0)
            {
                aseo = cboAseo.SelectedValue;
            }

            DateTime calendario = Calendar1.SelectedDate;

            if (cboHora.SelectedIndex != 0)
            {
                horainicio = cboHora.SelectedValue;
            }


            String horatermino = string.Empty;
            if (cboDuracion.SelectedIndex != 0)
            {

                bool parse = int.TryParse(cboDuracion.SelectedValue.ToString(), out duracion);
            }


            if (cboEspecialista.SelectedIndex != 0)
            {
                tipo = int.Parse(cboEspecialista.SelectedValue);

            }


            pabellon = cboPabellon.SelectedValue;




            if (cboPaciente.SelectedIndex != 0)
            {
                paciente = cboPaciente.SelectedValue;

            }

            if (cboCirujano.SelectedIndex != 0)
            {
                inCirujano = cboCirujano.SelectedValue;

            }

            if (cboAnestesista.SelectedIndex != 0)
            {
                inAnestesista = cboAnestesista.SelectedValue;

            }


            if (cboArsenalero.SelectedIndex != 0)
            {
                inArsenalero = cboArsenalero.SelectedValue;

            }

            if (cboEnfermero.SelectedIndex != 0)
            {
                inEnfermero = cboEnfermero.SelectedValue;

            }

            if (cboTarnestesia.SelectedIndex != 0)
            {
                inTanestesista = cboTarnestesia.SelectedValue;

            }

            if (cboTarnestesia.SelectedIndex != 0)
            {
                pabellonero = cboTarnestesia.SelectedValue;

            }



            String validar = Validar(cboPaciente.SelectedIndex, cboCirujano.SelectedIndex,duracion,cboHora.SelectedIndex);
            if (validar != null)
            {
                Response.Write(validar);
            }
            else
            {
                if (ValidarAgenda.Validar(tipo, cboPabellon.SelectedValue, horainicio, calendario, duracion))
                {
                    Insertar.InsertarAgenda(horainicio, horatermino, duracion, calendario, aseo,
                    usuario, paciente, pabellon, inEnfermero, inCirujano, pabellonero, inAnestesista, inTanestesista, inArsenalero, especialidad, 1);
                    Response.Write("<script>alert('El agendamiento ha sido guardado exitosamente!!!');window.location='RegistrarNoPlanificada.aspx';</script>");

                }
                else
                {
                    Response.Write("<script>alert('La hora ya está tomada, porfavor cambiar horario')</script>");

                }
            }

        }

        private String Validar(int indice0, int indice,int duracion,int hora)
        {
            String nuevo = null;
            if (indice0 == 0)
            {
                nuevo = "<script>alert('Tiene que seleccionar un Paciente')</script>";
                cboCirujano.BorderColor = Color.White;
                cboAnestesista.BorderColor = Color.White;
                cboArsenalero.BorderColor = Color.White;
                cboTarnestesia.BorderColor = Color.White;
                cboHora.BorderColor = Color.White;
                cboDuracion.BorderColor = Color.White;
                cboEnfermero.BorderColor = Color.White;
                cboPaciente.BorderColor = Color.Red;
            }
            else if (indice == 0)
            {
                nuevo = "<script>alert('Tiene que seleccionar un Cirujano')</script>";

                cboAnestesista.BorderColor = Color.White;
                cboArsenalero.BorderColor = Color.White;
                cboTarnestesia.BorderColor = Color.White;
                cboHora.BorderColor = Color.White;
                cboDuracion.BorderColor = Color.White;
                cboEnfermero.BorderColor = Color.White;
                cboPaciente.BorderColor = Color.White;
                cboCirujano.BorderColor = Color.Red;
            }
            else if (duracion== 0)
            {

                nuevo = "<script>alert('Tiene que seleccionar la Duración de la cirugía')</script>";
                cboArsenalero.BorderColor = Color.White;
                cboTarnestesia.BorderColor = Color.White;
                cboHora.BorderColor = Color.White;
                cboEnfermero.BorderColor = Color.White;
                cboPaciente.BorderColor = Color.White;
                cboCirujano.BorderColor = Color.White;
                cboAnestesista.BorderColor = Color.White;
                cboDuracion.BorderColor = Color.Red;
            }
            else if (hora == 0)
            {

                nuevo = "<script>alert('Tiene que seleccionar una Hora')</script>";
                cboArsenalero.BorderColor = Color.White;
                cboTarnestesia.BorderColor = Color.White;
                cboDuracion.BorderColor = Color.White;
                cboEnfermero.BorderColor = Color.White;
                cboPaciente.BorderColor = Color.White;
                cboCirujano.BorderColor = Color.White;
                cboAnestesista.BorderColor = Color.White;
                cboHora.BorderColor = Color.Red;
            }


            return nuevo;
        }

        protected void DropDownList5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        protected void DropDownList11_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList10_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        protected void cboAseo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
