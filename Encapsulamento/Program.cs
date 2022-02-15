using System;
using System.Globalization;
namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            //CONTA BANCARIA//

            Console.WriteLine("entre com o numero da conta");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("nome do titular da conta");
            string titular = Console.ReadLine();

            Console.WriteLine("havera deposito inicial[s/n]?");
            string RES = Console.ReadLine();

            ContaBancaria bank = new ContaBancaria(numero, titular, 0);





            switch (RES)
            {
                case "s":
                    Console.WriteLine("digite o valor do deposito:");
                    double quantinha = double.Parse(Console.ReadLine());
                    bank.Deposito(quantinha);
                    break;


            }
            Console.WriteLine();
            Console.WriteLine("____________________________________________________________________");
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");

            Console.WriteLine("Dados da conta:"   + bank.ToString());

            Console.WriteLine();
            Console.WriteLine("__________________________________________________________________");
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");

            Console.WriteLine("ENTRE COM VALOR PARA DEPOSITO:");
            double dep=double.Parse(Console.ReadLine());    
            bank.Deposito(dep);

            Console.WriteLine();
            Console.WriteLine("_________________________________________________________________");
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");

            Console.WriteLine("Dados da conta:"   + bank.ToString());

            Console.WriteLine();
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");

            Console.WriteLine("ENTRE COM O VALOR DO SAQUE:");
            double saq =double.Parse(Console.ReadLine());
            bank.Saque(saq);

            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine();
            Console.WriteLine("______________________________________________________________");
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");

            Console.WriteLine("Dados da conta:"   + bank.ToString());

            Console.ReadKey();

        }

    }
}