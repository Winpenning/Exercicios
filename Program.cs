
using Exercícios;
using System.Globalization;

namespace Exercicios 
{
    class Principal
    {
        public static void Main(string[] args)
        {
            Console.Write("Entre o número da conta: ");
            int nconta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titular= Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            string esc = Console.ReadLine();

            double valor = 0;

            if (esc == "s")
            {
                Console.Write("Entre o valor de depósito inicial: ");
                valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            
            Conta c = new Conta(titular, nconta, valor);

            Console.WriteLine("\nDados da conta:");
            Console.WriteLine(c);

            Console.Write("\nEntre com o valor para depósito: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            c.Deposito(valor);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(c);

            Console.Write("\nEntre com o valor para saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            c.Saque(valor);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(c);


        }
    }

}