using System;

namespace DesignPatternStrategyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá! Digite um valor para calcular o imposto: ");
            decimal valor = decimal.Parse(Console.ReadLine());

            // ------------------------------------------------

            var calculador = new SemStrategy.CalculadorDeImpostos();
            var valorIcms = calculador.Calcular("ICMS", valor);
            Console.WriteLine($"O valor de ICMS para {valor} é de {valorIcms} ");

            // ------------------------------------------------

            var calculadorStrategry = new ComStrategy.CalculadorDeImpostos();
            valorIcms = calculadorStrategry.Calcular(new ComStrategy.ICMS(valor));
            Console.WriteLine($"O valor de ICMS para {valor} é de {valorIcms} ");

            Console.ReadKey();
        }
    }
}
