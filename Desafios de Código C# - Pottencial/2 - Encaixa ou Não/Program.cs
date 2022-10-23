// Susing System;
using System.IO;
using System.Linq;

/*
Desafio
    Paulinho tem em suas mãos um novo problema. Agora a sua professora lhe pediu que construísse um programa para verificar, à partir de dois valores muito grandes A e B, se B corresponde aos últimos dígitos de A.

Entrada
    A entrada consiste de vários casos de teste. A primeira linha de entrada contém um inteiro N que indica a quantidade de casos de teste. Cada caso de teste consiste de dois valores A e B maiores que zero, cada um deles podendo ter até 1000 dígitos.

Saída
    Para cada caso de entrada imprima uma mensagem indicando se o segundo valor encaixa no primeiro valor, confome exemplo abaixo.

 
Exemplo de Entrada	                            Exemplo de Saída
    4                                           
    56234523485723854755454545478690 78690      encaixa
    5434554 543                                 nao encaixa
    1243 1243                                   encaixa
    54 64545454545454545454545454545454554      nao encaixa
 */

class DIO
{

    static void Main(string[] args)
    {
        int qt = int.Parse(Console.ReadLine());
        // TODO: Crie as outras condições necessárias para a resolução do desafio:
        string[] v = new String[2];
        for (int i = 0; i < qt; i++)
        {
            v = Console.ReadLine().Split(" ");
            string a = v[0];
            string b = v[1];

            if (a.Length > 0 && a.Length <= 1000 && b.Length < 0 && b.Length >= 1000)
                Console.WriteLine("nao encaixa");
            else if (a.EndsWith(b))
                Console.WriteLine("encaixa");
            else
                Console.WriteLine("nao encaixa");

        }

    }

}