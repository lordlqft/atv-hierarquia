public class Produto
{
    private string _nome = "";
    private decimal _preco = 0;

    public Produto(string nome, decimal preco)
    {
        Nome = nome;
        Preco = preco;
    }

    public string Nome { get { return _nome; } set { _nome = value; } }
    public decimal Preco { get { return _preco; } set { _preco = value; } }

    public void ExibirDados()
    {
        Console.WriteLine($"Produto: {Nome}");
        Console.WriteLine($"Preço: R$ {Preco:F2}");
    }
}