using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Soma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1° passo - Declarar as variáveis
            float numero1, numero2, total;
            string nome;

            Console.WriteLine("Projeto Soma");

            Console.WriteLine("Digite o seu nome: ");
            nome= Console.ReadLine();

            Console.WriteLine("Digite o primeiro numero: ");
            numero1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            numero2 = float.Parse(Console.ReadLine());

            // 2ª Etapa - Processamento
            // + -> Adição; - -> Subtração
            // * -> Multiplicação; / -> Divisão
            total = numero1 + numero2;

            // 3ª Etapa - Saída

            Console.WriteLine("Olá" + nome +" o resultado é: " + total);

            Console.WriteLine("Pressione <ENTER> para Continuar");

            Console.ReadKey();
        } 
             
    }
}
