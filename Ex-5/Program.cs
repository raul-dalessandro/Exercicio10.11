int n1 = 0;
long fatorial = 1;

Console.WriteLine("---------Fatorial---------");
Console.WriteLine("--------------------------");
Console.WriteLine("Digite um número qualquer inteiro:");
n1 = int.Parse(Console.ReadLine());

for (int i = 1; i <= n1 ; i++)
{
    fatorial = fatorial * i;
    Console.WriteLine($"{n1}! = {fatorial}");
}

