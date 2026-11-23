using System;                                   // AppContext, InvalidOperationException
using Microsoft.Extensions.Configuration;       // ConfigurationBuilder, IConfiguration (paquete ...Configuration.Json)
using Microsoft.Data.SqlClient;                 // SqlConnection

namespace Conexion3_AppSettingsJson
{
    // FORMA 3: la cadena está en el archivo appsettings.json (formato moderno de .NET).
    public static class Conexion
    {
        // Se lee el archivo UNA sola vez, cuando se usa la clase por primera vez.
        private static readonly IConfiguration configuracion = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)          // Carpeta donde está el .exe (bin\Debug\...)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: false)  // Archivo a leer (obligatorio)
            .Build();                                        // Construye la configuración

        public static SqlConnection Crear()
        {
            // Lee "ConnectionStrings" -> "TecnoHogar" del JSON.
            string cadena = configuracion.GetConnectionString("TecnoHogar");

            if (string.IsNullOrWhiteSpace(cadena))
            {
                throw new InvalidOperationException("No se encontró ConnectionStrings:TecnoHogar en appsettings.json.");
            }

            return new SqlConnection(cadena);
        }
    }
}
