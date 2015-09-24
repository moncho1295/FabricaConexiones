using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Necesitamos las diferentes definiciones de las intefaces
// para definir los objetos de conexión
using System.Data;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Data.OleDb;

namespace Fabrica_de_Conexiones
{
    // Un listado de posibles proveedores
    enum DataProvider
    { SqlServer, OleDb, Odbc, None }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Una fábrica de conexiones muy sencilla ****");

            // Obtener una conexión específica
            IDbConnection miCn = GetConnection(DataProvider.Odbc);
            Console.WriteLine("Tu conexión es una {0}", miCn.GetType().Name);

            // Abrir, utilizar y luego cerrar la conexión

            Console.ReadLine();
        }

        static IDbConnection GetConnection(DataProvider dp)
        {
            IDbConnection conn = null;
            switch (dp)
            {
                case DataProvider.SqlServer:
                    conn = new SqlConnection();
                    break;
                case DataProvider.OleDb:
                    conn = new OleDbConnection();
                    break;
                case DataProvider.Odbc:
                    conn = new OdbcConnection();
                    break;
            }
            return conn;
        }
    }
}
