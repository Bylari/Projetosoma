using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter_Temperatura
{
    internal class Program
    {
        static void Main(string[] args)
        { // 1° Passo - declarar as variaveis
            float temperaturaC, temperaturaF;
            // 2/ Passo - Receber oa valores (ENTRADA)
            Console.WriteLine("Conversão de Temperatura");
            Console.Write("Entre com a temperatura em C°:");
          temperaturaC = float.Parse( Console.ReadLine());

            //3 Passo - Processamento
            temperaturaF = (9 * temperaturaC + 160) / 5;

            // 4 ° Passo - Saída 
            Console.Write("A temperatura em fahrenheit é:" + temperaturaF);

                Console.ReadKey();

        }
    }
}
