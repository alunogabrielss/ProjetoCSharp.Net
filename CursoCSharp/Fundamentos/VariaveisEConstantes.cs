using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            // area de circunferencia
            // c# é uma linguagem fortemente tipada
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            // PI = 3.1415;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é: " + area);

            // Tipos internos

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo: " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade: " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de gols: " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário: " + salario);

            int menorValorInt = int.MinValue; // Mais usado dos inteiros!
            Console.WriteLine("Menor Int: " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População Brasileira: " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long: " + menorValorInt);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Mundial: " + populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("Preço Computador: " + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00; // Mais  usado dos reais!
            Console.WriteLine("Valor Apple: " + valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distância entre Estrelas: " + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra: " + letra);

            string texto = "Seja bem vindo ao Curso de C#!";
            Console.WriteLine(texto);
        }
    }
}
