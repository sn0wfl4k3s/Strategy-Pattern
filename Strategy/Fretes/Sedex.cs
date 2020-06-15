using Strategy.Contratos;

namespace Strategy.Fretes
{
    public class Sedex : IFrete
    {
        public string Tipo => nameof(Sedex);

        public double CalculaFrete(int distancia)
        {
            return distancia * 1.75;
        }
    }
}
