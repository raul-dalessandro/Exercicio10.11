int numero = 0;
Console.WriteLine("---------Primo---------");
Console.WriteLine("-----------------------");
Console.WriteLine("Digite um número qualquer inteiro:");
numero = int.Parse(Console.ReadLine());
if (numero < 2)
{
    Console.WriteLine("Nenhum número primo!");
}
else
{
    for(int i = 2; i <= numero; i++)
    {
        bool ehPrimo = true;

        for(int j = 2; j * j <= i; j++)
        {
            if (i % j == 0)
            {
                ehPrimo = false;
                break;
            }
        }
        if (ehPrimo)
        {
            Console.WriteLine(i);
        }
    }
}
