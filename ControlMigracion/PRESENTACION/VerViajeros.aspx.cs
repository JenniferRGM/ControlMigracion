using ControlMigracion.DATOS;
using ControlMigracion.NEGOCIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ControlMigracion.Models;

namespace ControlMigracion.PRESENTACION
{
    public partial class VerViajeros : System.Web.UI.Page
    {
        private ViajeroN viajeroN = new ViajeroN();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarViajeros();
            }
        }

        private void CargarViajeros()
        {
            gvViajeros.DataSource = viajeroN.ObtenerViajeros();
            gvViajeros.DataBind();
        }

        protected void gvViajeros_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvViajeros.EditIndex = e.NewEditIndex;
            CargarViajeros();
        }
        protected void gvViajeros_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = gvViajeros.Rows[e.RowIndex];
            int idViajero = Convert.ToInt32(gvViajeros.DataKeys[e.RowIndex].Values[0]);

            Viajero viajero = new Viajero
            {
                IDViajero = idViajero,
                CedulaPasaporte = (row.FindControl("CedulaPasaporte") as TextBox).Text,
                Nombre = (row.FindControl("Nombre") as TextBox).Text,
                SegundoNombre = (row.FindControl("SegundoNombre") as TextBox).Text,
                Apellido1 = (row.FindControl("Apellido1") as TextBox).Text,
                Apellido2 = (row.FindControl("Apellido2") as TextBox).Text,
                FechaNacimiento = Convert.ToDateTime((row.FindControl("FechaNacimiento") as TextBox).Text),
                Nacionalidad = (row.FindControl("Nacionalidad") as TextBox).Text,
                Correo = (row.FindControl("Correo") as TextBox).Text,
                Sexo = (row.FindControl("Sexo") as TextBox).Text
            };

            viajeroN.ActualizarViajero(viajero);
            gvViajeros.EditIndex = -1;
            CargarViajeros();
        }
        protected void gvViajeros_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int idViajero = Convert.ToInt32(gvViajeros.DataKeys[e.RowIndex].Values[0]);
            viajeroN.BorrarViajero(idViajero);
            CargarViajeros();
        }
        protected void gvViajeros_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvViajeros.EditIndex = -1;
            CargarViajeros();
        }
    }
}