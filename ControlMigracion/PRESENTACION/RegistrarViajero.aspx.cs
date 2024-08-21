using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ControlMigracion.Models;
using ControlMigracion.NEGOCIO;

namespace ControlMigracion
{
    public partial class RegistrarViajero : System.Web.UI.Page
    {
        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            Viajero viajero = new Viajero
            {
                CedulaPasaporte = txtCedulaPasaporte.Text,
                Nombre = txtNombre.Text,
                SegundoNombre = txtSegundoNombre.Text,
                Apellido1 = txtApellido1.Text,
                Apellido2 = txtApellido2.Text,
                FechaNacimiento = Convert.ToDateTime(txtFechaNacimiento.Text),
                Nacionalidad = txtNacionalidad.Text,
                Correo = txtCorreo.Text,
                Sexo = ddlSexo.SelectedValue
            };
            ViajeroN viajeroN = new ViajeroN();
            viajeroN.RegistrarViajero(viajero);

            lblMessage.Text = "Viajero registrado correctamente.";
        }
    }
}