using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Tienda.DAO
{
    public class ReservaDeHora
    {
        public static string CadenaConexion
        {
            get { return "Data Source=FSAEZ-PC94;Initial Catalog=test1;Integrated Security=true"; }
        }

        //----------------------------PROCEDIMIENTO BASE DE DATOS RESERVA DE HORA DE CLIENTE----------------------------
        public static bool GetReservarHora(Models.ReservaDeHora reserva)
        {

            var cantidad = 0;


            using (SqlConnection cn = new SqlConnection(CadenaConexion))
            {
                SqlCommand cmd = new SqlCommand("ReservaHora", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Nombre", reserva.Nombre);
                cmd.Parameters.AddWithValue("Correo", reserva.Correo);
                cmd.Parameters.AddWithValue("Fecha", reserva.Fecha);
                cmd.Parameters.AddWithValue("Hora", reserva.Hora);
                cmd.Connection = cn;
                //cmd.Parameters.Add("Registrado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                // cmd.Parameters.Add("MensajeIf", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;


                cn.Open();


                cantidad = cmd.ExecuteNonQuery();


            }

            return cantidad > 0;

        }
    }
}