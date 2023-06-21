using System.Data;
using System.Data.Common;
using System.Drawing;
namespace PizzariaDoZe.DAO;
public class ProdutoDAO
{
    private readonly DbProviderFactory factory;
    private string Provider { get; set; }
    private string StringConexao { get; set; }
    public ProdutoDAO(string provider, string stringConexao)
    {
        Provider = provider;
        StringConexao = stringConexao;
        factory = DbProviderFactories.GetFactory(Provider);
    }

    public int Inserir(Produto produto)
    {
        using var conexao = factory.CreateConnection(); //Cria conexão
        conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
        using var comando = factory.CreateCommand(); //Cria comando
        comando!.Connection = conexao; //Atribui conexão
                                       //Adiciona parâmetro (@campo e valor)
        var descricao = comando.CreateParameter(); descricao.ParameterName = "@descricao";
        descricao.Value = produto.Descricao; comando.Parameters.Add(descricao);
        var valorProduto = comando.CreateParameter(); valorProduto.ParameterName = "@valorProduto";
        valorProduto.Value = produto.Valor; comando.Parameters.Add(valorProduto);
        var tipo = comando.CreateParameter(); tipo.ParameterName = "@tipo";
        tipo.Value = produto.Tipo; comando.Parameters.Add(tipo);
        var ml = comando.CreateParameter(); ml.ParameterName = "@ml";
        ml.Value = produto.ML; comando.Parameters.Add(ml);
        conexao.Open();
        //ajusta o comando SQL para capturar o ID gerado tanto do MySQL como do SQLServer
        string auxSQL_ID = Provider.Contains("MySql") ? "SELECT LAST_INSERT_ID();" : "SELECT SCOPE_IDENTITY();";
        //realiza o INSERT e retorna o ID gerado, algo que vai ser necessário na sequencia
        comando.CommandText = @"" +
        "INSERT INTO cad_produtos (descricao_produto, valor, tipo, medida_unitaria) " +
        "VALUES (@descricao, @valorProduto, @tipo, @ml);" +
        auxSQL_ID;
        //executa o comando no banco de dados e captura o ID gerado
        var IdSaborGerado = comando.ExecuteScalar();
        return Convert.ToInt32(IdSaborGerado);
    }

    public DataTable Buscar(Produto produto)
    {

        using var conexao = factory.CreateConnection(); //Cria conexão
        conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
        using var comando = factory.CreateCommand(); //Cria comando
        comando!.Connection = conexao; //Atribui conexão
                                       //verifica se tem filtro e personaliza o SQL do filtro
        string auxSqlFiltro = "";
        if (produto.Id > 0)
        {
            auxSqlFiltro = "WHERE p.id_produto = " + produto.Id + " ";
        }
        conexao.Open();
        comando.CommandText = @" " +
        "SELECT id_produto AS ID, descricao_produto AS Descrição, valor AS Valor, tipo AS 'Tipo Produto',medida_unitaria AS ML " +
        "FROM cad_produtos AS p " +
        auxSqlFiltro +
        "ORDER BY p.descricao_produto;";
        //Executa o script na conexão e retorna as linhas afetadas.
        var sdr = comando.ExecuteReader();
        DataTable linhas = new();
        linhas.Load(sdr);
        return linhas;

    }
}