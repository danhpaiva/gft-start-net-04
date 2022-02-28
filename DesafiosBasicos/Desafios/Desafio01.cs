/*
 Faça a leitura de um valor inteiro. 
Em seguida, calcule o menor número de notas possíveis (cédulas) onde o valor pode ser decomposto. 
As notas que você deve considerar são de 100, 50, 20, 10, 5, 2 e 1. 
Na sequência mostre o valor lido e a relação de notas necessárias.

Entrada
Você receberá um valor inteiro N (0 < N < 1000000).

Saída
Exiba o valor lido e a quantidade mínima de notas de cada tipo necessárias, seguindo o exemplo de saída abaixo. 
Após cada linha deve ser imprimido o fim de linha.

--------------------------------------------------------------

using System;

namespace DIO
{
   class Program
{
    static void Main(string[] args)
    {
        int n, nota, quociente, resto;

        n = int.Parse(Console.ReadLine());
        Console.WriteLine(n);

        resto = n;

        nota = 100;
        quociente = resto / 100;
        Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
        resto = resto % 100;

        //Continue com a sua lógica aqui
        int[] notas = new int[] {50,20,10,5,2,1 };
        int contador = 0;

        while(contador <= 5)
        {
            if (resto >= notas[contador])
            {
                quociente = resto / notas[contador];
                Console.WriteLine($"{quociente} nota(s) de R$ {notas[contador]},00");
                resto = resto % notas[contador];
            } else
            {
                Console.WriteLine($"0 nota(s) de R$ {notas[contador]},00");
            }
            contador++;
        }

        Console.ReadLine();
    }
}
}

*/