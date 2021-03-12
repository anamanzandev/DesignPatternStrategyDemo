using DesignPatternStrategyDemo.ComStrategy.Interfaces;

namespace DesignPatternStrategyDemo.ComStrategy
{
    public class CalculadorDeImpostos
    {
        public decimal Calcular(IImposto imposto)
        {
            return imposto.Calcular();
        }
    }
}
