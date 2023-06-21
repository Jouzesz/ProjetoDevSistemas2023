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

            // No .NET 2.1 ou posterior os provedores não são mais registrados automaticamente no DbProviderFactories

            // Após instalar os pacotes via NuGet, realizar o registro manualmente no DbProviderFactories

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

                    // Conexão estabelecida com sucesso
                    Console.WriteLine("Conexão bem-sucedida!");

                    // Outras operações no banco de dados podem ser realizadas aqui

                    connection.Close();
                }
                Console.WriteLine("Conexão encerrada com sucesso!");
            }
            catch (Exception ex)
            {
                // Tratar exceções ou erros de conexão
                Console.WriteLine("Erro na conexão: " + ex.Message);
            }


            Console.ReadLine();
        }

    }
}