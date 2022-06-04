using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;

namespace Tienda.DAO
{
    public class Productos
    {
        //----------------------------OBTENER EL LISTADO DE LOS PRODUCTOS IGRESADOS----------------------------
        public static List<Models.Productos> GetAll()
        {
            

            List<Models.Productos> lstProductos = new List<Models.Productos>();

            string connectionString =
                                    "Data Source=(local);Initial Catalog=test1;"
                                    + "Integrated Security=true";

            
            // Provide the query string with a parameter placeholder.
            string queryString = "select ProductoId, Nombre,Precio, Imagen from productos";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);
                //command.Parameters.AddWithValue("@pricePoint", paramValue);

                // Open the connection in a try/catch block.
                // Create and execute the DataReader, writing the result
                // set to the console window.
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();


                    while (reader.Read())
                    {
                        
                        lstProductos.Add(new Models.Productos()
                        {
                            ProductoId = int.Parse(reader[0].ToString()),
                            Nombre = reader[1].ToString(),
                            Precio = int.Parse(reader[2].ToString()),

                            
                            Imagen = Convert.ToBase64String((byte[])reader[3])






                    });

                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return lstProductos;
        }
    }
}