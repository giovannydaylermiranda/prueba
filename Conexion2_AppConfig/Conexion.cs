using System;                      // InvalidOperationException
using System.Configuration;        // ConfigurationManager (paquete System.Configuration.ConfigurationManager)
using Microsoft.Data.SqlClient;    // SqlConnection

namespace Conexion2_AppConfig
{
    // FORMA 2: la cadena está en el archivo App.config, sección <connectionStrings>.
    // Para cambiar de servidor se edita el archivo de configuración, sin tocar el código.
    public static class Conexion
    {
        public static SqlConnection Crear()
        {
            // Busca en App.config la cadena llamada "TecnoHogar" (el atributo name).
            ConnectionStringSettings config = ConfigurationManager.ConnectionStrings["TecnoHogar"];

            // Si no la encuentra (nombre mal escrito o falta App.config), avisa con un error claro.
            if (config == null)
            {
                throw new InvalidOperationException("No se encontró la cadena 'TecnoHogar' en App.config.");
            }

            // config.ConnectionString es el texto de la cadena (atributo connectionString).
            return new SqlConnection(config.ConnectionString);
        }
    }
}
