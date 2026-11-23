using System;                     // Console
using Microsoft.Data.SqlClient;   // SqlConnection, SqlConnectionStringBuilder

namespace Conexion5_StringBuilder
{
    // FORMA 5: la cadena no se escribe a mano: se ARMA por partes con SqlConnectionStringBuilder.
    // Cada dato es una propiedad con nombre, así es difícil equivocarse con ; o =.
    public static class Conexion
    {
        public static SqlConnection Crear()
        {
            SqlConnectionStringBuilder constructor = new SqlConnectionStringBuilder();  // Constructor vacío

            constructor.DataSource = "localhost";        // Servidor (para SQL Express: @".\SQLEXPRESS")
            constructor.InitialCatalog = "tecnohogar";   // Base de datos
            constructor.IntegratedSecurity = true;       // Autenticación de Windows
            constructor.TrustServerCertificate = true;   // Acepta el certificado del servidor local

            // ConnectionString devuelve la cadena ya armada; la imprimimos para ver cómo quedó.
            Console.WriteLine("Cadena generada: " + constructor.ConnectionString);

            return new SqlConnection(constructor.ConnectionString);
        }
    }
}
