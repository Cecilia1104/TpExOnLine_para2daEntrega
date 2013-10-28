using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;


namespace TP_ExamenesEnLinea
{
    public partial class LoginUsuario : System.Web.UI.Page
    {
        ServProfesor elServicio = new ServProfesor();
        ServConfiguracion miServicio = new ServConfiguracion();
       
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String mailUsuario = txtmail.Text;
            String passUsuario = txtpass.Text;

            bool valido = miServicio.validarUsuario(mailUsuario, passUsuario);
            if (valido == true) {
                abrirSesionProfesor(passUsuario,mailUsuario);
            }
            else
            {
                erroLogueo();
            }
        }

        private void erroLogueo()
        {
            string mensaje = "Usuario y/o contraseña incorrecta.Reingrese";
            lblmensaje.Text = mensaje;
            //RequiredFieldValidator2.ErrorMessage = "Contraseña Incorrecta";
            //Response.Redirect("LoginUsuario.aspx?msj=" + mensaje);
        }

        private void abrirSesionProfesor(string mailu, string passu)
        {
            try
            {
                    int id = elServicio.RecuperarIdLogueado(passu);
                    string nombre = elServicio.RecuperaNombreLogueado(mailu);
                 
                    Session["Id"] = id;
                    Session["Logueado"] = nombre;
                    Session["Email"] = mailu;
                    Response.Redirect("~/AdminProfesor.aspx");  
            }
            catch (Exception ex)
            {
                string mensaje = "Error de Inicio de Sesion";

                ClientException.LogException(ex, mensaje); Server.Transfer("ErrorGeneral.aspx");
            }
        }

       
      
    }
}