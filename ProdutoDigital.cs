public class ProdutoDigital : Produto
{
    private string _linkDownload = "";

    public ProdutoDigital(string nome, decimal preco, string linkDownload) : base(nome, preco)
    {
        LinkDownload = linkDownload;
    }

    public string LinkDownload { get { return _linkDownload; } set { _linkDownload = value; } }

    public void LiberarDownload()
    {
        Console.WriteLine("Download liberado para o cliente.");
    }
}