using System.Net;

namespace Exercícios
{
    public class Conta
    {
        private string _titular;
        private int NConta { get; set; }
        private double Valor { get; set; }

        public Conta(string titular, int nConta, double valor)
        {
            _titular = titular;
            NConta = nConta;
            Valor = valor;
        }

        public void Deposito(double v) { Valor += v; }
        public void Saque(double v) { Valor -= (v + 5); }

        public override string ToString()
        {
            return "Conta "+ NConta + ",Titular: " + _titular +", Saldo: $ "+ Valor;
        }
    }
}
