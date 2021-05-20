using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos anos você tem?");
            int idadePessoa=int.Parse(Console.ReadLine());

            int meses= idadePessoa *12;
            int dias= idadePessoa *365;
            int horas= idadePessoa *8760;
            int minutos= idadePessoa *525600;

            Console.WriteLine("A sua idade em:");
            Console.WriteLine("meses: " + meses + " meses ");
            Console.WriteLine("dias: " + dias + " dias ");
            Console.WriteLine("horas: " + horas + " horas ");
            Console.WriteLine("minutos: " + minutos + " minutos ");
        
        }
    }
}
