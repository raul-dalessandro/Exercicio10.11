// 3) Impares e pares
// Faca um programa que leia um numero inteiro
// e mostre primeiramente so os valores impares
// em ordem crescente e depois os pares em
// ordem decrescente.

int numero = 0;
Console.WriteLine("---------Ímpar Par---------");
Console.WriteLine("-------------------------");
Console.WriteLine("Digite um número qualquer inteiro:");
numero = int.Parse(Console.ReadLine());
Console.WriteLine("Números ímpares em ordem crescente:");
for (int i = 0; i <= numero; i++)
{
    if (i % 2 != 0)
        Console.WriteLine(i); 
}
Console.WriteLine("Números pares em ordem decrescente:");
for (int i = numero; i >= 0; i--)
{
    if (i % 2 == 0)
        Console.WriteLine(i);
}