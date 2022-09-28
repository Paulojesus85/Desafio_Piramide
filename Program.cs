int n, a, c, l;

Console.WriteLine("Digite quantos níveis vai ter o seu triângulo");
n = Convert.ToInt32(Console.ReadLine());
c = n;
l = n;
string[,] nivel = new string[l, c];
a = n - 1;

if (n < 3 || n > 8)
{
    Console.WriteLine("ERRO: Digite um valor entre 3 e 8");
}
else
{

    for (int linha = 0; linha < n; linha++)
    {
        for (int coluna = 0; coluna < c; coluna++)
        {
            if (coluna >= a)
            {
                Console.Write("#");

            }
            else
            {
                Console.Write(' ');
            }

        }
        c++;
        a = a - 1;
        Console.WriteLine();
    }

}