// See https://aka.ms/new-console-template for more information
Console.Write("Digite a quantidade de linhas e colunas de uma matriz: ");
string[] num = Console.ReadLine().Split(' ');
int n = int.Parse(num[0]);
int m = int.Parse(num[1]);

int[,] mat = new int[n, m];
for (int i = 0; i < n; i++)
{
    string[] value = (Console.ReadLine().Split(' '));
    for (int j = 0; j < m; j++)
        mat[i, j] = int.Parse(value[j]);
}

for (int i = 0; i < n; i++)
{
    Console.WriteLine();
    for (int j = 0; j < m; j++)
        Console.Write(mat[i, j] + " ");
}
Console.WriteLine();
Console.Write("Digite o número da matriz que deseja pesquisar: ");
int x = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        if (mat[i, j] == x)
        {
            Console.WriteLine("Position " + i + "," + j + ":");
            if (j > 0)
            {
                Console.WriteLine("Left: " + mat[i, j - 1]);
            }
            if (i > 0)
            {
                Console.WriteLine("Up: " + mat[i - 1, j]);
            }
            if (j < n - 1)
            {
                Console.WriteLine("Right: " + mat[i, j + 1]);
            }
            if (i < m - 1)
            {
                Console.WriteLine("Down: " + mat[i + 1, j]);
            }
        }
    }
}