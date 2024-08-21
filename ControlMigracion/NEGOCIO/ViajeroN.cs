using ControlMigracion.DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ControlMigracion.Models;


namespace ControlMigracion.NEGOCIO
{
    public class ViajeroN
    {
        private ViajeroD viajeroDAL = new ViajeroD();
        public void RegistrarViajero(Viajero viajero)
        {
            viajeroDAL.RegistrarViajero(viajero);
        }

        public List<Viajero> ObtenerViajeros()
        {
            return viajeroDAL.ObtenerViajeros();
        }

        public void ActualizarViajero(Viajero viajero)
        {
            viajeroDAL.ActualizarViajero(viajero);
        }

        public void BorrarViajero(int idViajero)
        {
            viajeroDAL.BorrarViajero(idViajero);
        }
    }
}
