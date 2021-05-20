using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade");
            int idade= int.Parse(Console.ReadLine());

            if(idade < 5){
                Console.WriteLine("Você não pode participar");
            }

            else if(idade < 8){
                Console.WriteLine("Você pode participar do infantil A");
            }

            else if(idade < 11){
                Console.WriteLine("Você pode participar do infantil B");
            }

            else if(idade < 14){
                Console.WriteLine("Você pode participar do juvenil A");
            }

            else if(idade < 18){
                Console.WriteLine("Você pode participar do Juvenil B");
            }

            else{
                Console.WriteLine("Você pode participar do senior");
            }
        }
    }
}
