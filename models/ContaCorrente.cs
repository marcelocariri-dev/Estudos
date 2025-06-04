using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXEMPLOF.models
{
    public sealed class  ContaCorrente : Conta //sealed ele sela a classe não permitindo ser heradada
    {
        public ContaCorrente(int numerodaconta) : base(numerodaconta)
        {

        }
        private decimal TaxaAdmin;
        public override void Creditar(decimal valor, decimal TaxaAdmin)
        {
            decimal valorfinal = valor -= TaxaAdmin;
            Saldo += valorfinal;

        }
        public override void Creditar(decimal valor)
        {
            Saldo += valor;
        }

        public override void MostrarNconta()
        {
            Console.WriteLine("O numero da contaCorrente é " + NumeroDaConta);
        }
    }
}