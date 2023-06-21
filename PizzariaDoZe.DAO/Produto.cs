namespace PizzariaDoZe.DAO;
public class Produto
{
    public int Id { get; set; }
    public string Descricao { get; set; }
    public decimal Valor { get; set; }
    public char Tipo { get; set; }
    public string ML { get; set; }

    public Produto(int id = 0, string descricao = ""

    , decimal valor = 0, char

    tipo = ' ', string ml = "")
    {
        Id = id;
        Descricao = descricao;
        Valor = valor;
        Tipo = tipo;
        ML = ml;
    }

    public override string ToString()
    {
        return Descricao;
    }
}