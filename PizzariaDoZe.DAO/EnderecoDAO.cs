using System.Data;
using System.Data.Common;
using System.IO;

namespace PizzariaDoZe.DAO;
public class EnderecoDAO
{
    private readonly DbProviderFactory factory;
    private string Provider { get; set; }
    private string StringConexao { get; set; }
    public EnderecoDAO(string provider, string stringConexao)
    {
        Provider = provider;
        StringConexao = stringConexao;
        factory = DbProviderFactories.GetFactory(Provider);
    }
    // MÉTODO BUSCAR AQUI
    public DataTable Buscar(Endereco endereco)
    {
        using var conexao = factory.CreateConnection(); //Cria conexão
        conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
        using var comando = factory.CreateCommand(); //Cria comando
        comando!.Connection = conexao; //Atribui conexão
                                       //verifica se tem filtro e personaliza o SQL do filtro
        string auxSqlFiltro = "";
        if (endereco.Id > 0)
        {
            auxSqlFiltro = "WHERE e.id = " + endereco.Id + " ";
        }
        else if (endereco.Cep.Length > 0)
        {
            auxSqlFiltro = "WHERE e.cep = '" + endereco.Cep + "' ";
        }
        conexao.Open();
        comando.CommandText = @" " +
        "SELECT e.id_endereco AS ID, e.cep AS CEP, e.logradouro AS Logradouro, e.bairro AS Bairro, " +
        "c.id_cidade AS IDCidade, c.nome_cidade AS Cidade, " +
        "u.id_uf AS IDUF, u.nome_uf AS UF, " +
        "p.id_pais AS IDPais, p.nome_pais AS Pais " +
        "FROM tb_enderecos AS e " +
        "INNER JOIN cad_cidades AS c ON c.id_cidade = e.cidade_id " +
        "INNER JOIN cad_uf AS u ON u.id_uf = c.uf_id " +
        "INNER JOIN cad_paises AS p ON p.id_pais = u.pais_id " +
        auxSqlFiltro +
        "ORDER BY e.cep;";
        //Executa o script na conexão e retorna as linhas afetadas.
        var sdr = comando.ExecuteReader();
        DataTable linhas = new();
        linhas.Load(sdr);
        return linhas;
    }
}