using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Fabrica_de_Conexiones
{
    class ConnectionSql
    {
        // Connection string (cadena de conexión, key = value)
        // puede ser diferente basada en el entorno de ejecución
        private string _connString = @"server = .\sqlexpress; integrated security = true;";

        public ConnectionSql()
        {
            SqlConnection conn = new SqlConnection(_connString);

            try
            {
                // Abrir la conexión
                conn.Open();

                // Detalles de la conexión
                Console.WriteLine("Conexión establecida.");
                Console.WriteLine("\tConnection string: {0}", conn.ConnectionString);
                Console.WriteLine("\tBase de datos: {0}", conn.Database);
                Console.WriteLine("\tFuentes de datos: {0}", conn.DataSource);
                Console.WriteLine("\tVersión del servidor: {0}", conn.ServerVersion);
                Console.WriteLine("\tEstado: {0}", conn.State);
                Console.WriteLine("\tId estación de trabajo: {0}", conn.WorkstationId);
            }
            catch (SqlException ex)
            {
                // Desplegar la excepción e el error
                Console.WriteLine("Error: " + ex.Message + ex.StackTrace);
            }
            finally
            {
                // Cerrar la conexión
                conn.Close();
                Console.WriteLine("Conexión cerrada.");
            }
        }
    }
}
