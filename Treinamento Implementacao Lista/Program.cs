using Treinamento_Implementacao_Lista;

var listaProduto = new ListaProduto();

var computador = new Produto();
computador.Codigo = 1;
computador.Nome = "Computador";
computador.Quantidade = 1;

listaProduto.Adicionar(computador);

var cadeira = new Produto();
cadeira.Codigo = 2;
cadeira.Nome = "Cadeira";
cadeira.Quantidade = 4;

listaProduto.Adicionar(cadeira);


Console.WriteLine(listaProduto.QuantidadeLista());

listaProduto.Remover(computador);

Console.WriteLine(listaProduto.QuantidadeLista());

Console.WriteLine(listaProduto.RetornarPeloIndice(0).Nome);



Console.ReadLine();
