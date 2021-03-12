using DesignPatternStrategyDemo.ComStrategy.Interfaces;

namespace DesignPatternStrategyDemo.ComStrategy
{
    public class IPI : IImposto
    {
        private decimal _valor;

        public IPI(decimal valor)
        {
            _valor = valor;
        }

        public decimal Calcular()
        {
            return _valor * 0.20m;
        }
    }
}
