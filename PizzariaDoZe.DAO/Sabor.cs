namespace PizzariaDoZe.DAO;
public class Sabor
{
    public int Id { get; set; }
    public string Descricao { get; set; }
    public byte[] Foto { get; set; }
    public char Categoria { get; set; }
    public char Tipo { get; set; }
    public List<Ingrediente> SaborIngredientes { get; set; }
    public Sabor(int id = 0, string descricao = ""

    , byte[] foto = null, char
    categoria = ' ', char tipo = ' ', List<Ingrediente> saborIngredientes = null)
    {
        Id = id;
        Descricao = descricao;
        Foto = foto;
        Categoria = categoria;
        Tipo = tipo;
        this.SaborIngredientes = saborIngredientes;
    }

    public override string ToString()
    {
        return Descricao;
    }
}