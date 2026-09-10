// ProdutoDigital produtoDigital = new ProdutoDigital(
//     "Curso de C#",
//     50,
//     "www.exemplo.com/download"
// );

// produtoDigital.ExibirDados();
// produtoDigital.LiberarDownload();

ProdutoFisico produto = new ProdutoFisico("Caderno", 30, 2, 1);

decimal frete = produto.CalcularFrete(produto.Peso);

Console.WriteLine($"Frete: R$ {frete:F2}");