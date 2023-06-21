namespace PizzariaDoZe.DAO;
public class Valor
{
    public int Id { get; set; }
    public char Tamanho { get; set; }
    public char Categoria { get; set; }
    public decimal ValorPizza { get; set; }
    public decimal ValorBorda { get; set; }

    public Valor(int id = 0, char tamanho = ' ', char categoria = ' ', decimal valorPizza = 0,
    decimal valorBorda = 0)
    {
        Id = id;
        Tamanho = tamanho;
        Categoria = categoria;
        ValorPizza = valorPizza;
        ValorBorda = valorBorda;
    }
}