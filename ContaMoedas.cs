using System;

namespace contamoeda
{
    class ContaMoedas
    {
        static void Main(string[] args)
        {
            double N, valor, resto;
            int quantidade;

            Console.WriteLine("Digite a quantidade de dinheiro a ser contado: (Ex: 689.76)");
            N = double.Parse(Console.ReadLine());
            Console.WriteLine(N);

            Console.WriteLine("NOTAS:");
            valor = 100.00;
            quantidade = (int)(N / valor);
            Console.WriteLine(quantidade + " nota(s) de R$ " + valor.ToString("f2"));
            resto = N % valor;

            valor = 50.00;
            quantidade = (int)(resto / valor);
            Console.WriteLine(quantidade + " nota(s) de R$ " + valor.ToString("f2"));
            resto = resto % valor;

            valor = 20.00;
            quantidade = (int)(resto / valor);
            Console.WriteLine(quantidade + " nota(s) de R$ " + valor.ToString("f2"));
            resto = resto % valor;

            valor = 10.00;
            quantidade = (int)(resto / valor);
            Console.WriteLine(quantidade + " nota(s) de R$ " + valor.ToString("f2"));
            resto = resto % valor;

            valor = 5.00;
            quantidade = (int)(resto / valor);
            Console.WriteLine(quantidade + " nota(s) de R$ " + valor.ToString("f2"));
            resto = resto % valor;

            valor = 2.00;
            quantidade = (int)(resto / valor);
            Console.WriteLine(quantidade + " nota(s) de R$ " + valor.ToString("f2"));
            resto = resto % valor;

            // Contando suas valiosas moedinhas :)

            Console.WriteLine("MOEDAS:");
            valor = 1.00;
            quantidade = (int)(resto / valor);
            Console.WriteLine(quantidade + " moeda(s) de R$ " + valor.ToString("f2"));
            resto = resto % valor;

            valor = 0.50;
            quantidade = (int)(resto / valor);
            Console.WriteLine(quantidade + " moeda(s) de R$ " + valor.ToString("f2"));
            resto = resto % valor;

            valor = 0.25;
            quantidade = (int)(resto / valor);
            Console.WriteLine(quantidade + " moeda(s) de R$ " + valor.ToString("f2"));
            resto = resto % valor;

            valor = 0.10;
            quantidade = (int)(resto / valor);
            Console.WriteLine(quantidade + " moeda(s) de R$ " + valor.ToString("f2"));
            resto = resto % valor;

            valor = 0.05;
            quantidade = (int)(resto / valor);
            Console.WriteLine(quantidade + " moeda(s) de R$ " + valor.ToString("f2"));
            resto = resto % valor;

            // Tentando varias gambiarras aqui sem alterar todas as estruturas ;) supunhamos que resto = 0.004 se * 100 = 3.999... para arredondar na int add 0.01 

            valor = 0.01;
            resto = (resto * 100) + 0.01;
            quantidade = (int)resto;
            Console.WriteLine(quantidade + " moeda(s) de R$ " + valor.ToString("f2"));

        }
    }
}