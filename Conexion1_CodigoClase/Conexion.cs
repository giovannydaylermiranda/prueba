using Microsoft.Data.SqlClient;   // SqlConnection

namespace Conexion1_CodigoClase
{
    // FORMA 1: la cadena de conexión está ESCRITA EN EL CÓDIGO, dentro de esta clase.
    // static = no hace falta crear un objeto Conexion; se usa directo: Conexion.Crear()
    public static class Conexion
    {
        // La cadena de conexión: le dice a SQL Server a dónde y cómo conectarse.
        //   Server=localhost              -> el servidor (cámbialo por el tuyo, ver abajo)
        //   Database=tecnohogar           -> la base de datos
        //   Integrated Security=True      -> Autenticación de Windows (usa tu usuario de Windows)
        //   TrustServerCertificate=True   -> acepta el certificado del servidor local (evita el error de certificado)
        // Si tu servidor es SQL Express, usa: Server=.\\SQLEXPRESS  (en C# la barra se escribe doble)
        // const = valor fijo que no cambia mientras el programa se ejecuta.
        private const string CADENA = "Server=localhost;Database=tecnohogar;Integrated Security=True;TrustServerCertificate=True;";

        // Devuelve una conexión nueva (cerrada). Quien la usa decide cuándo abrirla y cerrarla.
        public static SqlConnection Crear()
        {
            return new SqlConnection(CADENA);
        }
    }
}
