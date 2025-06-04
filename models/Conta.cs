using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXEMPLOF.models
{
    public abstract class Conta
    {
        protected decimal Saldo;
        protected int NumeroDaConta;
        public Conta(int numerodaconta)
        {
            NumeroDaConta = numerodaconta;
        }

        public abstract void Creditar(decimal valor); /// assim como classe, o método tb é abstrato
        //ou seja somente precisa ser implementado nas classes filhas, 
        public abstract void Creditar(decimal valor, decimal TaxaAdmin); /// assim como classe, o método tb é abstrato
        //ou seja somente precisa ser implementado nas classes filhas, - POLIMORFISMO estático OVERLOADing

        public virtual void MostrarSaldo() // virtual server para declará que essa classe poderá sofrer um override.
        {
            Console.WriteLine($"O SALDO É:" + Saldo);
        }
        public virtual void MostrarNconta()
        {
            Console.WriteLine("O numero da conta é" + NumeroDaConta);
}



    }
}