using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;

namespace Fabrica_de_Conexiones
{
    class MyConnectionOleDb
    {
        public MyConnectionOleDb()
        {
            // Crear conexión
            OleDbConnection conn = new OleDbConnection(@"provider = sqloledb;
                data source = .\sqlexpress; integrated security = sspi;");

            try
            {
                // Abrir conexión
                conn.Open();
                Console.WriteLine("Conexión establecida.");

                // Detalles de la conexión
                Console.WriteLine("Conexión establecida.");
                Console.WriteLine("\tConnection string: {0}", conn.ConnectionString);
                Console.WriteLine("\tBase de datos: {0}", conn.Database);
                Console.WriteLine("\tFuentes de datos: {0}", conn.DataSource);
                Console.WriteLine("\tVersión del servidor: {0}", conn.ServerVersion);
                Console.WriteLine("\tEstado: {0}", conn.State);
            }
            catch (OleDbException ex)
            {
                // Desplegar excepción o error
                Console.WriteLine("Error: " + ex.Message + ex.StackTrace);
            }
            finally
            {
                //Cerrar la conexión
                conn.Close();
            }
        }
    }
}
