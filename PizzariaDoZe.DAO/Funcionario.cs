namespace PizzariaDoZe.DAO;
public class Funcionario
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Matricula { get; set; }
    public string Senha { get; set; }
    public char Grupo { get; set; }
    public string Motorista { get; set; }
    public DateTime Validade { get; set; }
    public string Observacao { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }
    public int EnderecoId { get; set; }
    public string Numero { get; set; }
    public string Complemento { get; set; }
    public Funcionario(int id = 0, string nome = "", string cpf = "", string matricula = "", string senha = "", char grupo = default, string
    motorista = "", DateTime validade_motorista = default, string observacao = "", string telefone = "", string email = "", int endereco_id = 0,
    string numero = "", string complemento = "")
    {
        Id = id;
        Nome = nome;
        Cpf = cpf;
        Matricula = matricula;
        Senha = senha;
        Grupo = grupo;
        Motorista = motorista;
        Validade = validade_motorista;
        Observacao = observacao;
        Telefone = telefone;
        Email = email;
        EnderecoId = endereco_id;
        Numero = numero;
        Complemento = complemento;
    }
}