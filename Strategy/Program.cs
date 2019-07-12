using Strategy.Fretes;
using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a distância: ");
            int distancia = int.Parse(Console.ReadLine());

            Console.Write("Qual o tipo de Frete? [0-Normal / 1-Sedex]");
            int escolha = int.Parse(Console.ReadLine());

            TipoFrete tipo = (TipoFrete) escolha;
            IFrete frete = tipo.ObterFrete();
            Console.WriteLine(frete.CalculaFrete(distancia));
        }
    }
}
