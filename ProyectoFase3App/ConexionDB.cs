using System;
using System.Data;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace AppFase3
{
    public class ConexionBD
    {
        private const string NombreConexion = "ConexionFase3";
        private readonly string cadenaConexion;

        public ConexionBD()
        {
            ConnectionStringSettings? configuracion =
                ConfigurationManager.ConnectionStrings[NombreConexion];

            if (configuracion == null || string.IsNullOrWhiteSpace(configuracion.ConnectionString))
            {
                throw new InvalidOperationException(
                    $"No se encontró la cadena de conexión '{NombreConexion}' en App.config.");
            }

            cadenaConexion = configuracion.ConnectionString;
        }

        public void ProbarConexion()
        {
            try
            {
                using SqlConnection conexion = CrearConexion();
                conexion.Open();
            }
            catch (Exception ex)
            {
                throw CrearError("No se pudo conectar a SQL Server. Verifica el servidor, la base de datos y las credenciales configuradas en App.config.", ex);
            }
        }

        public DataTable ObtenerTodosLosRegistros()
        {
            const string consulta = "SELECT * FROM Clientes";

            try
            {
                using SqlConnection conexion = CrearConexion();
                using SqlCommand comando = new(consulta, conexion);
                using SqlDataAdapter adaptador = new(comando);
                DataTable tablaDatos = new();

                conexion.Open();
                adaptador.Fill(tablaDatos);
                return tablaDatos;
            }
            catch (Exception ex)
            {
                throw CrearError("No se pudieron cargar los registros desde SQL Server. Verifica que exista la tabla Clientes y que la conexión sea válida.", ex);
            }
        }

        public DataTable FiltrarRegistros(string valorBusqueda)
        {
            const string consulta = """
                SELECT *
                FROM Clientes
                WHERE Categoria LIKE @filtro
                """;

            try
            {
                using SqlConnection conexion = CrearConexion();
                using SqlCommand comando = new(consulta, conexion);
                using SqlDataAdapter adaptador = new(comando);
                DataTable tablaDatos = new();

                comando.Parameters.Add("@filtro", SqlDbType.NVarChar, 200).Value =
                    $"%{valorBusqueda.Trim()}%";

                conexion.Open();
                adaptador.Fill(tablaDatos);
                return tablaDatos;
            }
            catch (Exception ex)
            {
                throw CrearError("No se pudo aplicar el filtro en SQL Server. Verifica que exista la columna Categoria y que la conexión sea válida.", ex);
            }
        }

        private SqlConnection CrearConexion()
        {
            if (cadenaConexion.Contains("REEMPLAZAR_SERVIDOR", StringComparison.OrdinalIgnoreCase) ||
                cadenaConexion.Contains("REEMPLAZAR_BASE_DATOS", StringComparison.OrdinalIgnoreCase))
            {
                throw new InvalidOperationException(
                    "La conexión aún no está configurada. Edita App.config y reemplaza REEMPLAZAR_SERVIDOR y REEMPLAZAR_BASE_DATOS por los valores de tu SQL Server.");
            }

            return new SqlConnection(cadenaConexion);
        }

        private static DataAccessException CrearError(string mensaje, Exception ex)
        {
            return new DataAccessException(mensaje, ex);
        }
    }

    public sealed class DataAccessException : Exception
    {
        public DataAccessException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}