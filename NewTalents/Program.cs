using System;

namespace NewTalents
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Calculadora!");

            var calc = new Calculadora(DateTime.Today.ToString("dd/MM/yyyy"));

            calc.Somar(100, 25);
            calc.Subtrair(100, 25);
            calc.Dividir(100, 25);
            calc.Multiplicar(100, 25);

            calc.Historico().ForEach(hist => Console.WriteLine(hist));
        }
    }
}
