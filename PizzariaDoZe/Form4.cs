using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PizzariaDoZe.DAO;
using System.Configuration;
using System.Data.SqlClient;


namespace PizzariaDoZe
{
    public partial class PaginaIngredientes : Form
    {
        private readonly IngredienteDAO dao;

        private IngredienteDAO ingredienteDAO;
        // pega os dados do banco de dados
        string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
        string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
        // cria a instancia da classe da model


        private void AtualizarTela()
        {
            ingredienteDAO = new IngredienteDAO(provider, strConnection);
            //Instância e Preenche o objeto com os dados da view
            var ingrediente = new Ingrediente();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = ingredienteDAO.Buscar(ingrediente);
                // seta o datasouce do dataGridView com os dados retornados
                dataGridViewDados.Columns.Clear();
                dataGridViewDados.AutoGenerateColumns = true;
                dataGridViewDados.DataSource = linhas;
                dataGridViewDados.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public PaginaIngredientes()
        {
            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            dao = new IngredienteDAO(provider, strConnection);

            InitializeComponent();
            AtualizarTela();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonCadastro_Click(object? sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textboxNome.Text))
            {
                MessageBox.Show("O nome precisa ser preenchido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Instância e Preenche o objeto com os dados da view
                var ingrediente = new Ingrediente
                {
                    Id = 0,
                    Nome = textboxNome.Text,
                };
                try
                {
                    // chama o método para inserir da camada model
                    dao.Inserir(ingrediente);
                    MessageBox.Show("Dados inseridos com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void textboxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
