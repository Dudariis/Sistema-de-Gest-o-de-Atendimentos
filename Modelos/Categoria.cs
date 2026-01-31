namespace HelpDesk;

public class Categoria
{
    public int id { get, set; }
    public string Nome { get, set; }

    public Categoria(int id, string nome)
    {
        Id = id;
        Nome = nome;
    }
}