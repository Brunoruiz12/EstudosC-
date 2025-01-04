using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;


namespace CourseCsharp
{
    class ContaCorrente
    {
        public int NumeroConta { get; private set; }
        public string NomeTitular { get; set; }

        public double Saldo { get; private set; }


        public ContaCorrente(int numero, string titular)
        {
            NumeroConta = numero;
            NomeTitular = titular;
        }


        public ContaCorrente(string titular, int numero , double depositoInicial): this(numero,titular)
        {
            Deposito(depositoInicial);

        }

        public void Deposito (double quantia)
        {
            Saldo = Saldo + quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
            
        }


        
        public override string ToString()
        {
            return "Conta " + NumeroConta 
            + " , Titular " + NomeTitular +  " , Saldo: R$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }




    }
}
