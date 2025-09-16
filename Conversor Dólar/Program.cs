using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_Dólar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1° Passo - Declarar as variaveis
            float cotacaoDolar, quantiaDolar, totalReais;
            // 2° Passo - Receber os valores (ENTRADA)
            Console.WriteLine("BEM VINDO AO CONVERSOR DE DOLARES PARA REAIS");
            

                Console.Write("Digite a cotação atual do dólar");
            cotacaoDolar = float.Parse(Console.ReadLine());

            Console.Write("Digite a quantia a ser convertida ; ");
            quantiaDolar = float.Parse(Console.ReadLine());

            // 3° passo - Processamento 
            totalReais = quantiaDolar * cotacaoDolar; 

            // 4° Passo - Saída
            Console.WriteLine("O valor convertido é:" + totalReais);


            Console.ReadKey();     
        }
    }
}
