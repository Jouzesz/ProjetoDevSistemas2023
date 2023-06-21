namespace PizzariaDoZe.DAO;
public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }
    public int EnderecoId { get; set; }
    public string Numero { get; set; }
    public string Complemento { get; set; }

    public Cliente(int id = 0, string nome = "", string cpf = "", string telefone = "", string email = "",
    int endereco_id = 0, string numero = "", string complemento = "")
    {
        Id = id;
        Nome = nome;
        Cpf = cpf;
        Telefone = telefone;
        Email = email;
        EnderecoId = endereco_id;
        Numero = numero;
        Complemento = complemento;
    }
}