using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descobrindo_a_idade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1° Passo - Declarar as variaveis 
            float anoatual, anodenascimento, idadeatual;
            //2° Passo - Receber os valores (ENTRADA)
            Console.WriteLine("BEM VINDO A CALCULADORA DE IDADE");

            Console.Write("Digite o ano atual: ");
            anoatual = float.Parse(Console.ReadLine());

            Console.Write("Digite o ano de nascimento: ");
            anodenascimento = float.Parse(Console.ReadLine());
             // 3° Passo - Processamento 
             idadeatual= anoatual - anodenascimento ;

            // 4° Passo - Saída 
            Console.WriteLine("A idade é equivalente a: " + idadeatual);

            Console.ReadKey();


        }
    }
}
