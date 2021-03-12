namespace DesignPatternStrategyDemo.SemStrategy
{
    public class CalculadorDeImpostos
    {
        public decimal Calcular(string imposto, decimal valor)
        {
            if (imposto == "ICMS")
                return valor * 0.10m;
            else if (imposto == "IPI")
                return valor * 0.20m;
            else if (imposto == "ISS")
                return valor * 0.30m;
            // e se surgissem novos impostos?

            return 0;
        }
    }
}
