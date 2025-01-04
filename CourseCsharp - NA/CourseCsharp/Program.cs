using System;
using System.Globalization;
using System.Xml;


namespace CourseCsharp
{
    class Course
    {
       
        static void Main(string[] args)
        {
            ContaCorrente conta;

            Console.Write("Entre com o número da Conta: ");
            int numero = int.Parse(Console.ReadLine());
            
            Console.Write("Entre o titular da Conta: ");
            string titular = Console.ReadLine();
            
            Console.WriteLine("Haverá o valor de deposito inicial (s/n)");
            char resp = char.Parse(Console.ReadLine()); 
            
            if( resp == 's' || resp == 'S')
            {
                Console.WriteLine("Entre o valor de depósito inicial : ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaCorrente( titular, depositoInicial,numero );
                
              
            }
            else
            {
                conta = new ContaCorrente(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: " );
            Console.WriteLine(conta);
            Console.WriteLine();
            Console.WriteLine("Entre um valor para deposito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados Atualizados");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.WriteLine("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados Atualizados:");
            Console.WriteLine(conta);

        }



    }
}
