using System;
using System.Globalization;
namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("entre com o numero da conta");
            int numerodaconta=int.Parse(Console.ReadLine());

            Console.WriteLine("nome do titular da conta");
            string nome=Console.ReadLine();

            Console.WriteLine("havera deposito inicial[s/n]?");
            string RES=Console.ReadLine();

            ContaBancaria bank = new ContaBancaria(numerodaconta, nome);

            switch (RES) 
            {
                case "s":
                    Console.WriteLine("digite o valor do deposito:");
                    double quantinha = double.Parse(Console.ReadLine());
                   double V= bank.Deposito(quantinha);
                    break;
                    

            }
            
            

            Console.WriteLine("Dados da conta:" + bank.ToString);


        }

    }
}