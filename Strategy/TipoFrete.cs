using Strategy.Fretes;

namespace Strategy
{
    enum TipoFrete
    {
        NORMAL,
        SEDEX
    }

    static class TipoFreteExtension
    {
        public static IFrete ObterFrete(this TipoFrete t)
        {
            switch (t)
            {
                case TipoFrete.NORMAL:
                    return new Normal();
                case TipoFrete.SEDEX:
                    return new Sedex();
                default:
                    return null;
            }
        }
    }
}
