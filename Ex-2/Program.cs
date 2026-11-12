// 2) Fibonacci
// Faca um programa que leia um numero inteiro.
// Esse numero e a posicao ate onde a sequencia
// de Fibonacci sera exibida.

int numero = 0;
int fibo = 0;
int f1 = 0;
int f2 = 1;
Console.WriteLine("---------Fibonnaci---------");
Console.WriteLine("-------------------------");
Console.WriteLine("Digite um número qualquer inteiro:");
numero = int.Parse(Console.ReadLine());
Console.WriteLine($"A sequência de Fibonnaci até a posição {numero} é:\n0\n1");
for (int i = 0; i <= numero; i++)
{
    fibo = f1 + f2;
    f1 = f2;
    f2 = fibo;
    Console.WriteLine($"{fibo}");
}

