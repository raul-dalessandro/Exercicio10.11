int numero = 0;
Console.WriteLine("---------Primo---------");
Console.WriteLine("-----------------------");
Console.WriteLine("Digite um número qualquer inteiro:");
numero = int.Parse(Console.ReadLine());
if (numero < 2)
{
    Console.WriteLine("Nenhum número primo!");
}

for (int i = 0; i <= numero; i++)
{
    if (i == 1 || i % 2 == 0 && i != 2 || i % 3 == 0 && i != 3 || i % 4 == 0 && i != 4 || i % 5 == 0 && i != 5 || i % 6 == 0 && i != 6 || i % 7 == 0 && i != 7)
    {
        //
    }
    else
    {
        Console.WriteLine(i);
    }
}