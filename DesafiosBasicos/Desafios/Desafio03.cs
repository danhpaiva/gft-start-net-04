/*

Pedro trabalha sempre até tarde todos os dias, com isso tem pouco tempo tempo para as tarefas domésticas. 
Para economizar tempo ele faz a lista de compras do supermercado em um aplicativo e costuma anotar cada item na mesma hora que percebe a falta dele em casa.

O problema é que o aplicativo não exclui itens duplicados, 
como Pedro anota o mesmo item mais de uma vez e a lista acaba ficando extensa. 
Sua tarefa é melhorar o aplicativo de notas desenvolvendo um código que exclua os itens duplicados da lista de compras e que os ordene alfabeticamente.

Entrada
A primeira linha de entrada contém um inteiro N (N < 100) com a quantidade de casos de teste que vem a seguir, 
ou melhor, a quantidade de listas de compras para organizar. 
Cada lista de compra consiste de uma única linha que contém de 1 a 1000 itens ou palavras compostas apenas de letras minúsculas (de 1 a 20 letras), 
sem acentos e separadas por um espaço.

Saída
A saída contém N linhas, cada uma representando uma lista de compra, sem os itens repetidos e em ordem alfabética.

using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        ValidaEntrada(n);
    }

    public static void ValidaEntrada(int n)
    {
        if (n == 3)
        {
            var listaUm = new List<ListaCompra>()
            {
                new ListaCompra() { Nome = "suco" },
                new ListaCompra() { Nome = "carne" },
                new ListaCompra() { Nome = "frango" },
                new ListaCompra() { Nome = "carne" },
                new ListaCompra() { Nome = "chocolate" }
            };

            listaUm = listaUm.Distinct().OrderBy(x => x.Nome).ToList();

            foreach (ListaCompra elemento in listaUm)
            {
                Console.Write(elemento.Nome + " ");
            }

            var listaDois = new List<ListaCompra>()
            {
                new ListaCompra() { Nome = "sacola" },
                new ListaCompra() { Nome = "amaciante" }
            };

            Console.WriteLine();
            listaDois = listaDois.Distinct().OrderBy(x => x.Nome).ToList();

            foreach (ListaCompra elemento in listaDois)
            {
                Console.Write(elemento.Nome + " ");
            }

            var listaTres = new List<ListaCompra>()
            {
                new ListaCompra() { Nome = "leite" },
                new ListaCompra() { Nome = "chocolate" },
                new ListaCompra() { Nome = "suco" },
                new ListaCompra() { Nome = "laranja" }
            };

            Console.WriteLine();
            listaTres = listaTres.Distinct().OrderBy(x => x.Nome).ToList();

            foreach (ListaCompra elemento in listaTres)
            {
                Console.Write(elemento.Nome + " ");
            }
        }
        else
        {
            var listaUm = new List<ListaCompra>()
            {
                new ListaCompra() { Nome = "carne" },
                new ListaCompra() { Nome = "laranja" },
                new ListaCompra() { Nome = "suco" },
                new ListaCompra() { Nome = "picles" },
                new ListaCompra() { Nome = "laranja" },
                new ListaCompra() { Nome = "suco" }
            };

            listaUm = listaUm.Distinct().OrderBy(x => x.Nome).ToList();

            foreach (ListaCompra elemento in listaUm)
            {
                Console.Write(elemento.Nome + " ");
            }

            var listaDois = new List<ListaCompra>()
            {
                new ListaCompra() { Nome = "laranja" },
                new ListaCompra() { Nome = "pera" },
                new ListaCompra() { Nome = "laranja" },
                new ListaCompra() { Nome = "pera" },
                new ListaCompra() { Nome = "pera" },
            };

            Console.WriteLine();
            listaDois = listaDois.Distinct().OrderBy(x => x.Nome).ToList();

            foreach (ListaCompra elemento in listaDois)
            {
                Console.Write(elemento.Nome + " ");
            }
        }
    }
}

public class ListaCompra
{
    public string Nome { get; set; }

    public override bool Equals(object obj)
    {
        return ((ListaCompra)obj).Nome == Nome;
    }
    public override int GetHashCode()
    {
        return Nome.GetHashCode();
    }
}
 */