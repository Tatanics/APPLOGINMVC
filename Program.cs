using AppLoginMVC.Modelo;

namespace AppLoginMVC
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            if (!ConexionDB.ProbarConexion())
            {
                MessageBox.Show("No se puedo onectar a la base de datos en MySql. \n" +
                    "Verifica que MySql este activo y que los datos \n" +
                    "de conexion en ConexionDB.cs sean correctos.",
                    "Error de conexion",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            Application.Run(new FrmLogin());
        }
    }
}