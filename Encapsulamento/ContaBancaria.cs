using System;
using System.Globalization;

namespace Encapsulamento{
    internal class ContaBancaria {

        public int Numero { get;private set; }
        public string Titular { get;private set; }
        public double Saldo { get; private set; }
        
       
        //cosntrutor//
        public ContaBancaria(int numero, string titular) 
        {
            Numero = numero;
            Titular = titular;
            
            
        }
        public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular)
        {
            Saldo = saldo;
        }


        public void Deposito( double quantinha)
        {
             Saldo += quantinha;
            
            
        }
        public void Saque(double quantia)
        {
             Saldo -= quantia + 5.0;
           
        }

        public override string ToString()
        {
            return "conta:"  +   Numero   +  ",Titular:"   +  Titular   +   ",saldo:R$:"
                +   Saldo.ToString("F2" , CultureInfo.InvariantCulture) ;


        }





    }
}
