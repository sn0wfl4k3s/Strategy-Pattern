namespace Strategy.Contratos
{
    public interface IFrete
    {
        string Tipo { get; }
        double CalculaFrete(int distancia);
    }
}
