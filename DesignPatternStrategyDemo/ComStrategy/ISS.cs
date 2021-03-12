using DesignPatternStrategyDemo.ComStrategy.Interfaces;

namespace DesignPatternStrategyDemo.ComStrategy
{
    public class ISS : IImposto
    {
        private decimal _valor;

        public ISS(decimal valor)
        {
            _valor = valor;
        }

        public decimal Calcular()
        {
            return _valor * 0.30m;
        }
    }
}
