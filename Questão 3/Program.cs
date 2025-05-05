using System;

namespace CalculoAreaFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Cálculo de Área de um Retângulo ===");

            // Solicita a base do retângulo
            Console.Write("Informe a base (em metros): ");
            double baseRetangulo = Convert.ToDouble(Console.ReadLine());

            // Solicita a altura do retângulo
            Console.Write("Informe a altura (em metros): ");
            double alturaRetangulo = Convert.ToDouble(Console.ReadLine());

            // Func que recebe a base e a altura e retorna a área
            Func<double, double, double> calcularArea = (baseR, altura) => baseR * altura;

            // Calcula a área usando o Func
            double area = calcularArea(baseRetangulo, alturaRetangulo);

            // Exibe o resultado final
            Console.WriteLine($"\nA área do retângulo é: {area} metros quadrados.");

            // Aguarda uma tecla para encerrar o programa
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
