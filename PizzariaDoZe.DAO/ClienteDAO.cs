using System.Data;
using System.Data.Common;
namespace PizzariaDoZe.DAO;
public class ClienteDAO
{
    private readonly DbProviderFactory factory;
    private string Provider { get; set; }
    private string StringConexao { get; set; }
    public ClienteDAO(string provider, string stringConexao)
    {
        Provider = provider;
        StringConexao = stringConexao;
        factory = DbProviderFactories.GetFactory(Provider);
    }
    // MÉTODO INSERIR AQUI
    public int Inserir(Cliente cliente)
    {
        using var conexao = factory.CreateConnection(); //Cria conexão
        conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
        using var comando = factory.CreateCommand(); //Cria comando
        comando!.Connection = conexao; //Atribui conexão
                                       //Adiciona parâmetro (@campo e valor)
        var nome = comando.CreateParameter(); nome.ParameterName = "@nome";
        nome.Value = cliente.Nome; comando.Parameters.Add(nome);
        var cpf = comando.CreateParameter(); cpf.ParameterName = "@cpf";
        cpf.Value = cliente.Cpf; comando.Parameters.Add(cpf);
        var telefone = comando.CreateParameter(); telefone.ParameterName = "@telefone";
        telefone.Value = cliente.Telefone; comando.Parameters.Add(telefone);
        var email = comando.CreateParameter(); email.ParameterName = "@email";
        email.Value = cliente.Email; comando.Parameters.Add(email);
        var endereco_id = comando.CreateParameter(); endereco_id.ParameterName = "@endereco_id";
        endereco_id.Value = cliente.EnderecoId; comando.Parameters.Add(endereco_id);
        var numero = comando.CreateParameter(); numero.ParameterName = "@numero";
        numero.Value = cliente.Numero; comando.Parameters.Add(numero);
        var complemento = comando.CreateParameter(); complemento.ParameterName = "@complemento";
        complemento.Value = cliente.Complemento; comando.Parameters.Add(complemento);
        conexao.Open();
        //ajusta o comando SQL para capturar o ID gerado tanto do MySQL como do SQLServer
        string auxSQL_ID = Provider.Contains("MySql") ? "SELECT LAST_INSERT_ID();" : "SELECT SCOPE_IDENTITY();";
        //realiza o INSERT e retorna o ID gerado, algo que vai ser necessário na sequencia
        comando.CommandText = @"INSERT INTO tb_clientes (nome_cliente, cpf, telefone, email, endereco_id, numero, complemento)
        VALUES(@nome, @cpf, @telefone, @email, @endereco_id, @numero, @complemento);" + auxSQL_ID;
        //executa o comando no banco de dados e captura o ID gerado
        var IdGerado = comando.ExecuteScalar();
        return Convert.ToInt32(IdGerado);
    }

    public DataTable Buscar(Cliente cliente)
    {
        using var conexao = factory.CreateConnection(); //Cria conexão
        conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
        using var comando = factory.CreateCommand(); //Cria comando
        comando!.Connection = conexao; //Atribui conexão
                                       //verifica se tem filtro e personaliza o SQL do filtro
        string auxSqlFiltro = "";
        if (cliente.Id > 0)
        {
            auxSqlFiltro = "WHERE cc.id_cliente = " + cliente.Id + " ";
        }
        else if (cliente.Nome.Length > 0)
        {
            auxSqlFiltro = "WHERE cc.nome_cliente like '%" + cliente.Nome + "%' ";
        }
        conexao.Open();
        comando.CommandText = @" " +
        "SELECT cc.id_cliente AS ID, cc.nome_cliente AS Nome, cc.cpf AS CPF, cc.telefone AS Telefone, cc.email AS 'E-mail', " +
        "e.id_endereco AS ID, e.cep AS CEP, e.logradouro AS Logradouro, e.bairro AS Bairro, " +
        "c.id_cidade AS IDCidade, c.nome_cidade AS Cidade, " +
        "u.id_uf AS IDUF, u.nome_uf AS UF, " +
        "p.id_pais AS IDPais, p.nome_pais AS Pais, " +
        "cc.numero AS Número, cc.complemento AS Complemento " +
        "FROM tb_clientes AS cc " +
        "INNER JOIN tb_enderecos AS e ON e.id_endereco = cc.endereco_id " +
        "INNER JOIN cad_cidades AS c ON c.id_cidade = e.cidade_id " +
        "INNER JOIN cad_uf AS u ON u.id_uf = c.uf_id " +
        "INNER JOIN cad_paises AS p ON p.id_pais = u.pais_id " +
        auxSqlFiltro +
        "ORDER BY cc.nome_cliente;";
        //Executa o script na conexão e retorna as linhas afetadas.
        var sdr = comando.ExecuteReader();
        DataTable linhas = new();
        linhas.Load(sdr);
        return linhas;
    }
}