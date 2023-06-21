using System.Data;
using System.Data.Common;
namespace PizzariaDoZe.DAO;
public class ValorDAO
{
    private readonly DbProviderFactory factory;
    private string Provider { get; set; }
    private string StringConexao { get; set; }
    public ValorDAO(string provider, string stringConexao)
    {
        Provider = provider;
        StringConexao = stringConexao;
        factory = DbProviderFactories.GetFactory(Provider);
    }
    public int Inserir(Valor valor)
    {
        using var conexao = factory.CreateConnection(); //Cria conexão
        conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
        using var comando = factory.CreateCommand(); //Cria comando
        comando!.Connection = conexao; //Atribui conexão
                                       //Adiciona parâmetro (@campo e valor)
        var tamanho = comando.CreateParameter(); tamanho.ParameterName = "@tamanho";
        tamanho.Value = valor.Tamanho; comando.Parameters.Add(tamanho);
        var categoria = comando.CreateParameter(); categoria.ParameterName = "@categoria";
        categoria.Value = valor.Categoria; comando.Parameters.Add(categoria);
        var valorPizza = comando.CreateParameter(); valorPizza.ParameterName = "@valorPizza";
        valorPizza.Value = valor.ValorPizza; comando.Parameters.Add(valorPizza);
        var valorBorda = comando.CreateParameter(); valorBorda.ParameterName = "@valorBorda";
        valorBorda.Value = valor.ValorBorda; comando.Parameters.Add(valorBorda);
        conexao.Open();
        //ajusta o comando SQL para capturar o ID gerado tanto do MySQL como do SQLServer
        string auxSQL_ID = Provider.Contains("MySql") ? "SELECT LAST_INSERT_ID();" : "SELECT SCOPE_IDENTITY();";
        //realiza o INSERT e retorna o ID gerado, algo que vai ser necessário na sequencia
        comando.CommandText = @"" +
        "INSERT INTO tb_valor (tamanho, categoria, valor, valor_borda) " +
        "VALUES (@tamanho, @categoria, @valorPizza, @valorBorda);" +
        auxSQL_ID;
        //executa o comando no banco de dados e captura o ID gerado
        var IdSaborGerado = comando.ExecuteScalar();
        return Convert.ToInt32(IdSaborGerado);
    }

    public DataTable Buscar(Valor valor)
    {

        using var conexao = factory.CreateConnection(); //Cria conexão
        conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
        using var comando = factory.CreateCommand(); //Cria comando
        comando!.Connection = conexao; //Atribui conexão
                                       //verifica se tem filtro e personaliza o SQL do filtro
        string auxSqlFiltro = "";
        if (valor.Id > 0)
        {
            auxSqlFiltro = "WHERE s.id_valor = " + valor.Id + " ";
        }
        conexao.Open();
        comando.CommandText = @" " +
        "SELECT id_valor AS ID, tamanho AS Tamanho, categoria AS Categoria, valor AS Valor, valor_borda AS 'ValorBorda' " +
        "FROM tb_valor AS v " +
        auxSqlFiltro +
        ";";
        //Executa o script na conexão e retorna as linhas afetadas.
        var sdr = comando.ExecuteReader();
        DataTable linhas = new();
        linhas.Load(sdr);
        return linhas;

    }

}