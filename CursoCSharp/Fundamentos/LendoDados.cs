using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.WriteLine("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual é a sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual é o seu salario? ");
            double salario = double.Parse(Console.ReadLine(),
                CultureInfo.InvariantCulture); // Para mudar questão de cultura dos valores

            Console.WriteLine($"{nome} {idade} R${salario}");
        }
    }
}
