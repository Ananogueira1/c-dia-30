using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o ano de seu nascimento");
            int anoPessoa=int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o ano atual");
            int anoAtual=int.Parse(Console.ReadLine());

            int idade= anoAtual - anoPessoa;
            int semana= idade * 52;

            Console.WriteLine("Você tem: ");
            Console.WriteLine(idade+ " anos");
            Console.WriteLine(semana + " semanas");

        }
    }
}
