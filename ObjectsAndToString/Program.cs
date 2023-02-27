// dotnet run
using ObjectsAndToString;

Produto produto = new Produto();

Console.WriteLine("Entre com os dados do produto:");
Console.Write("Nome: ");
produto.Nome = Console.ReadLine();
Console.Write("Preço: ");
produto.Preco = double.Parse(Console.ReadLine());
Console.Write("Quantidade: ");
produto.Quantidade = int.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Dados do produto " + produto);

Console.WriteLine();
Console.Write("Digite oa quantidade de produtos a serem adicionados no estoque: ");
int NovaQuantidade = int.Parse(Console.ReadLine());
produto.AdicionarProdutos(NovaQuantidade);

Console.WriteLine();
Console.WriteLine("Dados atualizados: " + produto);

Console.WriteLine();
Console.Write("Digite oa quantidade de produtos a serem removidos do estoque: ");
NovaQuantidade = int.Parse(Console.ReadLine());
produto.RemoverProdutos(NovaQuantidade);

Console.WriteLine();
Console.WriteLine("Dados atualizados: " + produto);
Console.WriteLine();