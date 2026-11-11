int numero = 0;
int tabuada = 0;

Console.WriteLine("---------Tabuada---------");
Console.WriteLine("-------------------------");
Console.WriteLine("Digite um número qualquer inteiro:");
numero = int.Parse(Console.ReadLine());

for (int i = 0; i <= 10; i++)
{
    tabuada = numero * i;
    Console.WriteLine($"{numero}x{i}= {tabuada}");
}