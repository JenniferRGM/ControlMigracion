using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using ControlMigracion.Models;

namespace ControlMigracion.DATOS
{
    public class ViajeroD
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MIGRACION"].ConnectionString;

        public void RegistrarViajero(Viajero viajero)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Viajeros (Cedula_Pasaporte, Nombre, Segundo_Nombre, Apellido1, Apellido2, Fecha_Nacimiento, Nacionalidad, Correo, Sexo) 
                             VALUES (@Cedula_Pasaporte, @Nombre, @Segundo_Nombre, @Apellido1, @Apellido2, @Fecha_Nacimiento, @Nacionalidad, @Correo, @Sexo)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Cedula_Pasaporte", viajero.CedulaPasaporte);
                cmd.Parameters.AddWithValue("@Nombre", viajero.Nombre);
                cmd.Parameters.AddWithValue("@Segundo_Nombre", viajero.SegundoNombre);
                cmd.Parameters.AddWithValue("@Apellido1", viajero.Apellido1);
                cmd.Parameters.AddWithValue("@Apellido2", viajero.Apellido2);
                cmd.Parameters.AddWithValue("@Fecha_Nacimiento", viajero.FechaNacimiento);
                cmd.Parameters.AddWithValue("@Nacionalidad", viajero.Nacionalidad);
                cmd.Parameters.AddWithValue("@Correo", viajero.Correo);
                cmd.Parameters.AddWithValue("@Sexo", viajero.Sexo);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<Viajero> ObtenerViajeros()
        {
            List<Viajero> viajeros = new List<Viajero>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Viajeros";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Viajero viajero = new Viajero
                    {
                        IDViajero = Convert.ToInt32(reader["ID_Viajero"]),
                        CedulaPasaporte = reader["Cedula_Pasaporte"].ToString(),
                        Nombre = reader["Nombre"].ToString(),
                        SegundoNombre = reader["Segundo_Nombre"].ToString(),
                        Apellido1 = reader["Apellido1"].ToString(),
                        Apellido2 = reader["Apellido2"].ToString(),
                        FechaNacimiento = Convert.ToDateTime(reader["Fecha_Nacimiento"]),
                        Nacionalidad = reader["Nacionalidad"].ToString(),
                        Correo = reader["Correo"].ToString(),
                        Sexo = reader["Sexo"].ToString()
                    };
                    viajeros.Add(viajero);
                }
            }
            return viajeros;
        }

        public void ActualizarViajero(Viajero viajero)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Viajeros SET Cedula_Pasaporte=@Cedula_Pasaporte, Nombre=@Nombre, Segundo_Nombre=@Segundo_Nombre, 
                             Apellido1=@Apellido1, Apellido2=@Apellido2, Fecha_Nacimiento=@Fecha_Nacimiento, Nacionalidad=@Nacionalidad, 
                             Correo=@Correo, Sexo=@Sexo WHERE ID_Viajero=@ID_Viajero";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Cedula_Pasaporte", viajero.CedulaPasaporte);
                cmd.Parameters.AddWithValue("@Nombre", viajero.Nombre);
                cmd.Parameters.AddWithValue("@Segundo_Nombre", viajero.SegundoNombre);
                cmd.Parameters.AddWithValue("@Apellido1", viajero.Apellido1);
                cmd.Parameters.AddWithValue("@Apellido2", viajero.Apellido2);
                cmd.Parameters.AddWithValue("@Fecha_Nacimiento", viajero.FechaNacimiento);
                cmd.Parameters.AddWithValue("@Nacionalidad", viajero.Nacionalidad);
                cmd.Parameters.AddWithValue("@Correo", viajero.Correo);
                cmd.Parameters.AddWithValue("@Sexo", viajero.Sexo);
                cmd.Parameters.AddWithValue("@ID_Viajero", viajero.IDViajero);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void BorrarViajero(int idViajero)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Viajeros WHERE ID_Viajero=@ID_Viajero";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID_Viajero", idViajero);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}