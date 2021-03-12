using DesignPatternStrategyDemo.ComStrategy.Interfaces;

namespace DesignPatternStrategyDemo.ComStrategy
{
    public class ICMS : IImposto
    {
        private decimal _valor;

        public ICMS(decimal valor)
        {
            _valor = valor;
        }

        public decimal Calcular()
        {
            return _valor * 0.10m;
        }
    }
}
