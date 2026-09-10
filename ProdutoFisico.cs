public class ProdutoFisico : Produto
{
    private double _peso = 0;
    private double _valorFrete = 0;

    public ProdutoFisico(string nome, decimal preco, double peso, double valorFrete) : base(nome, preco)
    {
        Peso = peso;
        ValorFrete = valorFrete;
    }

    public double Peso { get { return _peso; } set { _peso = value; } }
    public double ValorFrete { get { return _valorFrete; } set { _valorFrete = value; } }

    public decimal CalcularFrete(double peso)
    {
        decimal valorFrete = (decimal)peso * 10.00m;
        return valorFrete;
    }
}