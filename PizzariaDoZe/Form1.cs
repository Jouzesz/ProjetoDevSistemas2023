using System.Configuration;
using System.Data.Common;

namespace PizzariaDoZe
{
    public partial class Principal : Form
    {

        public static void ValidaConexaoDB()
        {
            DbProviderFactory factory;
            try
            {
                factory = DbProviderFactories.GetFactory(ConfigurationManager.ConnectionStrings["BD"].ProviderName);
                using var conexao = factory.CreateConnection();
                conexao!.ConnectionString = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
                using var comando = factory.CreateCommand();
                comando!.Connection = conexao;
                conexao.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                new FormConfig().ShowDialog();
                ValidaConexaoDB();
            }
        }
        public Principal()
        {
            InitializeComponent();
            ValidaConexaoDB();
        }

        private void Funcionarios_Click(object sender, EventArgs e)
        {
            PaginaFuncionarios cli = new PaginaFuncionarios();
            cli.StartPosition = FormStartPosition.CenterParent;
            cli.Show();
        }

        private void Clientes_Click(object sender, EventArgs e)
        {
            PaginaClientes cli = new PaginaClientes();
            cli.StartPosition = FormStartPosition.CenterParent;
            cli.Show();
        }

        private void Ingredientes_Click(object sender, EventArgs e)
        {
            PaginaIngredientes cli = new PaginaIngredientes();
            cli.StartPosition = FormStartPosition.CenterParent;
            cli.Show();
        }

        private void Sabores_Click(object sender, EventArgs e)
        {
            PaginaSabores cli = new PaginaSabores();
            cli.StartPosition = FormStartPosition.CenterParent;
            cli.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void buttonConfig_Click(object sender, EventArgs e)
        {
            FormConfig cli = new FormConfig();
            cli.StartPosition = FormStartPosition.CenterParent;
            cli.Show();

        }

        private void buttonValores_Click(object sender, EventArgs e)
        {
            PaginaValores cli = new PaginaValores();
            cli.StartPosition = FormStartPosition.CenterParent;
            cli.Show();
        }

        private void buttonProdutos_Click(object sender, EventArgs e)
        {
            PaginaProdutos cli = new PaginaProdutos();
            cli.StartPosition = FormStartPosition.CenterParent;
            cli.Show();
        }

        private void buttonPedidos_Click(object sender, EventArgs e)
        {
            PaginaPedidos cli = new PaginaPedidos();
            cli.StartPosition = FormStartPosition.CenterParent;
            cli.Show();
        }
    }
}