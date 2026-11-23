using Microsoft.Data.SqlClient;   // SqlConnection

namespace Conexion4_Settings
{
    // FORMA 4: la cadena se guarda en la Configuración del proyecto
    // (clic derecho al proyecto -> Propiedades -> Configuración / Settings).
    // Visual Studio genera la clase Properties.Settings con una propiedad por cada valor,
    // así que la cadena se lee como una propiedad normal, con autocompletado.
    public static class Conexion
    {
        public static SqlConnection Crear()
        {
            // Settings.Default = la configuración del proyecto.
            // TecnoHogarConnectionString = el nombre que se le dio en la tabla de Configuración.
            string cadena = Properties.Settings.Default.TecnoHogarConnectionString;

            return new SqlConnection(cadena);
        }
    }
}
