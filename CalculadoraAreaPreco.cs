using System;
using System.Globalization;

namespace areapreco
{
    class areaPreco
    {
        static void Main(String[] args)
        {
            double largura, comprimento, precoMetroQuadrado, area, precoarea;
            Console.WriteLine("Digite a largura do terreno:");
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o comprimento do terreno:");
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o preço do metro quadrado:");
            precoMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = largura * comprimento;
            precoarea = area * precoMetroQuadrado;
            Console.WriteLine("Tamanho do terreno: " +  area.ToString("f2"));
            Console.WriteLine("Preço do Terreno: " + precoarea.ToString("f2"));
        }
    }
}

        
