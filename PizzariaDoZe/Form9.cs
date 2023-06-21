using System.Data;
using PizzariaDoZe.DAO;
using System.Configuration;
namespace PizzariaDoZe


{
    public partial class PaginaPedidos : Form
    {
        private IngredienteDAO ingredienteDAO;

        private SaborDAO saborDAO;

        private ProdutoDAO produtoDAO;

        // pega os dados do banco de dados
        string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
        string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
        public PaginaPedidos()
        {
            InitializeComponent();

            // cria a instância da classe da model
            ingredienteDAO = new IngredienteDAO(provider, strConnection);

            // cria a instancia da classe da model
            saborDAO = new SaborDAO(provider, strConnection);

            // cria a instancia da classe da model
            produtoDAO = new ProdutoDAO(provider, strConnection);

            AtualizaSabores();
            AtualizaProdutos();
        }

        private void AtualizaSabores()
        {
            // Instância e Preenche o objeto com os dados da view
            var sabor = new Sabor();

            DataTable linhas = saborDAO.Buscar(sabor);
            // carrega os dados, como objeto, no checkedListBox
            checkedListBoxSabores.Items.Clear();
            foreach (DataRow row in linhas.Rows)
            {
                checkedListBoxSabores.Items.Add(new Sabor(int.Parse(row["ID"].ToString()), row["Nome"].ToString()));
            }
        }

        private void AtualizaProdutos()
        {
            // Instância e Preenche o objeto com os dados da view
            var produto = new Produto();

            DataTable linhas = produtoDAO.Buscar(produto);
            // carrega os dados, como objeto, no checkedListBox
            checkedListBoxProduto.Items.Clear();
            foreach (DataRow row in linhas.Rows)
            {
                checkedListBoxProduto.Items.Add(new Sabor(int.Parse(row["ID"].ToString()), row["Descrição"].ToString()));
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
