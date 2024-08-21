using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlMigracion.PRESENTACION
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // Este es el manejador de eventos para el botón btnSubmit
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // Aquí se realiza la lógica de autenticación
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Supongamos que tienes una clase UsuarioDAL para validar usuarios
            Usuarios usuarios = new Usuarios();
            bool isValidUser = usuarios.ValidarUsuario(username, password);

            if (isValidUser)
            {
                // Redirigir a la página principal si el usuario es válido
                Response.Redirect("~/Home.aspx");
            }
            else
            {
                // Mostrar un mensaje de error si las credenciales son incorrectas
                Response.Write("<script>alert('Invalid username or password');</script>");
            }
        }
    }
}