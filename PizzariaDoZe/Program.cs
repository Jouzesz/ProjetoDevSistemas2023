using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using MySql.Data.MySqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace PizzariaDoZe
{


    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // No .NET 2.1 ou posterior os provedores n�o s�o mais registrados automaticamente no DbProviderFactories

            // Ap�s instalar os pacotes via NuGet, realizar o registro manualmente no DbProviderFactories

            DbProviderFactories.RegisterFactory("MySql.Data.MySqlClient", MySql.Data.MySqlClient.MySqlClientFactory.Instance);
            //DbProviderFactories.RegisterFactory("System.Data.SqlClient", System.Data.SqlClient.SqlClientFactory.Instance);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Principal());

            

            string connectionString = "Server=localhost;Database=db_pizza;Uid=root;Pwd=123456;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Conex�o estabelecida com sucesso
                    Console.WriteLine("Conex�o bem-sucedida!");

                    // Outras opera��es no banco de dados podem ser realizadas aqui

                    connection.Close();
                }
                Console.WriteLine("Conex�o encerrada com sucesso!");
            }
            catch (Exception ex)
            {
                // Tratar exce��es ou erros de conex�o
                Console.WriteLine("Erro na conex�o: " + ex.Message);
            }


            Console.ReadLine();
        }

    }
}