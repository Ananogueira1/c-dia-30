using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do seu salario");
            int salario=int.Parse(Console.ReadLine());

            int porcentagemReajuste=(salario/100) *30;

            int salarioReajustado= salario + porcentagemReajuste;

            if(salario < 500){
                Console.WriteLine("Seu salario foi reajustado para: " + salarioReajustado);
            } else{
                Console.WriteLine("Seu salario não foi reajustado");
            }
        }
    }
}
