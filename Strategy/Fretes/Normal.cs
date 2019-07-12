namespace Strategy.Fretes
{
    public class Normal : IFrete
    {
        public double CalculaFrete(int distancia)
        {
            return distancia * 1.2 + 10;
        }
    }
}
