using Strategy.Contratos;

namespace Strategy.Fretes
{
    public class Normal : IFrete
    {
        public string Tipo => nameof(Normal);

        public double CalculaFrete(int distancia)
        {
            return distancia * 1.2 + 10;
        }
    }
}
