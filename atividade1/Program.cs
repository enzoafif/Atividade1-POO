using atividade1;

try
{
    Cliente cliente = new Cliente();

    Console.Write("Digite o score do cliente: ");
    cliente.Score = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(cliente.AnalisarScore());

    Produto produto = new Produto();

    Console.Write("Digite a descrição do produto: ");
    produto.Descricao = Console.ReadLine();

    Console.Write("Digite o valor do produto: ");
    produto.Valor = Convert.ToInt32(Console.ReadLine());

    Console.Write("Digite o desconto do produto(em %): ");
    produto.Desconto = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(produto.AnalisarDesconto());
}
catch(Exception ex)

{
    Console.WriteLine("Ocorreu um erro: " + ex.Message);
}


