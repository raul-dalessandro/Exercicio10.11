int numero = 0;

bool EPrimo(int numero)
{
    if (numero <= 1)
    {
        return false;
    }
    int contador = 0;
    for (int i = 1; i <= numero; i++)
    {
        if (numero % i == 0)
        {
            contador++;
        }
    }
    if (contador > 2)
    {
        return false;
    }
    else
    {
        return true;
    }
}
void LeitorNumero(int numero)
{
    for (int i = 2; i <= numero; i++)
    {
        if (EPrimo(i))
        {
            Console.WriteLine(i);
        }
    }

}

Console.WriteLine("Informe o número desejeado");
numero = int.Parse(Console.ReadLine());
LeitorNumero(numero);


/////////////////////////////////


//void Primo(int numero)
//{
//    for (int i = 2; i <= numero; i++)
//    {
//        int contador = 0;
//        for (int j = i; j >= 2; j--)
//        {
//            if (i % j == 0)
//            {
//                contador++;
//            }
//            if (contador > 1)
//            {
//                break;
//            }
//        }

//        if (contador <= 1)
//        {
//            Console.WriteLine(i);
//        }
//    }
//}
//Console.WriteLine("Informe o número desejeado");
//Primo(int.Parse(Console.ReadLine()));
