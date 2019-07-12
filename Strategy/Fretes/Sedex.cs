namespace Strategy.Fretes
{
    public class Sedex : IFrete
    {
        public double CalculaFrete(int distancia)
        {
            return distancia * 1.75;
        }
    }
}
