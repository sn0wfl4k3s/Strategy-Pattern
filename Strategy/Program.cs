using Strategy.Contratos;
using Strategy.Fretes;
using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a distância: ");
            
            var distancia = int.Parse(Console.ReadLine());

            IFrete frete = distancia switch
            {
                var d when d < 200 => new Normal(),
                _ => new Sedex(),
            };

            var valor = frete.CalculaFrete(distancia);

            Console.WriteLine("Valor do frete: {0}", valor);
            Console.WriteLine("Tipo..........: {0}", frete.Tipo);
        }
    }
}
