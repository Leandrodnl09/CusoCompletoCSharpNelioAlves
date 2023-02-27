using ContaBancaria;

Conta conta;

Console.Write("Digite o número da sua conta: ");
int num = int.Parse(Console.ReadLine());
Console.Write("Digite o nome do titular da conta: ");
string titular = Console.ReadLine();
Console.Write("Haverá depósito inicial (S/N)? ");
char x = char.Parse(Console.ReadLine());

if (x == 's' || x == 'S')
{
    Console.Write("Digite o valor do depósito inicial: ");
    double depositoInicial = double.Parse(Console.ReadLine());
    conta = new Conta(num, titular, depositoInicial);
}
else
{
    conta = new Conta(num, titular);
}
Console.WriteLine();
Console.WriteLine("Dados da conta:");
Console.WriteLine(conta);
Console.WriteLine();
Console.Write("Entre com o valor para depósito: ");
double deposito = double.Parse(Console.ReadLine());
conta.Deposito(deposito);
Console.WriteLine();
Console.WriteLine("Dados da conta atualizados:");
Console.WriteLine(conta);
Console.Write("Entre com o valor para saque: ");
double saque = double.Parse(Console.ReadLine());
conta.Saque(saque);
Console.WriteLine();
Console.WriteLine("Dados da conta atualizados:");
Console.WriteLine(conta);