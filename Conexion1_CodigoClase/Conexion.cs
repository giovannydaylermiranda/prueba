using Microsoft.Data.SqlClient;   // SqlConnection

namespace Conexion1_CodigoClase
{
    // FORMA 1: la cadena de conexión está ESCRITA EN EL CÓDIGO, dentro de esta clase.
    // static = no hace falta crear un objeto Conexion; se usa directo: Conexion.Crear()
    public static class Conexion
    {
        
        private const string CADENA = "Server=localhost;Database=tecnohogar;Integrated Security=True;TrustServerCertificate=True;";

        // Devuelve una conexión nueva (cerrada). Quien la usa decide cuándo abrirla y cerrarla.
        public static SqlConnection Crear()
        {
            return new SqlConnection(CADENA);
        }
    }
}
