using System;                 // Console, STAThread
using System.Text;            // Encoding
using System.Windows.Forms;   // Application

namespace Conexion1_CodigoClase
{
    // Punto de entrada: es lo primero que se ejecuta al iniciar el programa.
    internal static class Program
    {
        [STAThread]   // Obligatorio en Windows Forms (modo de hilos que necesitan las ventanas)
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;                   // Tildes y ñ correctas en la consola
            Console.WriteLine("=== TecnoHogar · Forma 1 · Cadena escrita en una clase ===");       // Primer mensaje en la consola

            Application.EnableVisualStyles();                         // Botones con el estilo actual de Windows
            Application.SetCompatibleTextRenderingDefault(false);     // Forma moderna de dibujar el texto
            Application.Run(new FormPrincipal());                     // Abre el formulario principal
        }
    }
}
