using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;
using System.Drawing;

namespace WebApplication1
{
    public partial class S_Reportar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblAsunto.Visible = false;
            }

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {


                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("edu.iturra@alumnos.duoc.cl");
                msg.To.Add("edu.iturra@alumnos.duoc.cl");
                if (cboEvento.SelectedValue == "Otros")
                {
                    msg.Subject = txtAsunto.Text;
                    msg.Body = txtDescripcion.InnerText;
                    if (txtAsunto.Text.Length == 0)
                    {
                        
                        Response.Write("<script>alert('Asunto vacio')</script>");
                        cboEvento.BorderColor = Color.Red;
                        
                        

                    }
                    else if (txtDescripcion.InnerText.Length == 0)
                    {
                        Response.Write("<script>alert('Descripción vacia')</script>");
                        cboEvento.BorderColor = Color.White;
                    }
                    else
                    {
                        txtAsunto.BorderColor = Color.White;
                        SmtpClient sc = new SmtpClient("smtp.gmail.com");
                        sc.Port = 25;
                        sc.Credentials = new NetworkCredential("edu.iturra@alumnos.duoc.cl", "guitarra.69");
                        sc.EnableSsl = true;
                        sc.Send(msg);
                        Response.Write("<script>alert('Reporte enviado')</script>");
                    }
                }
                else
                {
                    if (cboEvento.SelectedIndex == 0)
                    {
                        Response.Write("<script>alert('Asunto vacio')</script>");
                        cboEvento.BorderColor = Color.Red;

                    }
                    else if (txtDescripcion.InnerText.Length == 0)
                    {
                        cboEvento.BorderColor = Color.White;
                        Response.Write("<script>alert('Descripción vacia')</script>");
                    }
                    else
                    {
                        cboEvento.BorderColor = Color.White;
                        msg.Subject = cboEvento.SelectedValue;
                        msg.Body = txtDescripcion.InnerText;
                        SmtpClient sc = new SmtpClient("smtp.gmail.com");
                        sc.Port = 25;
                        sc.Credentials = new NetworkCredential("edu.iturra@alumnos.duoc.cl", "guitarra.69");
                        sc.EnableSsl = true;
                        sc.Send(msg);
                        Response.Write("<script>alert('Reporte enviado')</script>");
                    }

                }



            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Insertado" + ex.ToString() + "')</script>");

            }
        }

        protected void cboEvento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEvento.SelectedValue == "Otros")
            {
                lblAsunto.Visible = true;
                txtAsunto.Visible = true;
            }
        }
    }
}