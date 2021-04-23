using System;

namespace DIO.bank
{
    public class Conta
    {
        private TipoConta TipoConta {get; set;}
        private string Nome {get; set;}
        private double Saldo {get; set;}
        private double Credito {get; set;}

    public Conta(TipoConta TipoConta, double Saldo, double Credito, string Nome)
    {

        this.TipoConta = TipoConta;
        this.Saldo = Saldo;
        this.Credito = Credito;
        this.Nome = Nome;
        
    }

    public bool Sacar (double ValorSaque)
    {
            if (this.Saldo - ValorSaque < (this.Credito * -1))
            {
                Console.WriteLine("Saldo insuficiente!");
                return false;
            }

            this.Saldo = ValorSaque;

            Console.WriteLine("Saldo atual da conta de {0} é de {1}:", this.Nome, this.Saldo);
            return true;
         
    }

    public void Depositar (double ValorDeposito)
    {
        this.Saldo += ValorDeposito;
        Console.WriteLine("Saldo atual da conta de {0} é de {1}:", this.Nome, this.Saldo);

    }

    public void Transferir (double ValorTransferencia, Conta ContaDestino)
    {

       if (this.Sacar (ValorTransferencia))
            {
                ContaDestino.Depositar(ValorTransferencia);
            }  

    }

        public override string ToString()
        {
            string Retorno = "";
            Retorno += "TipoConta " + this.TipoConta + " | ";
            Retorno += "Nome " + this.Nome + " | ";
            Retorno += "Saldo " + this.Saldo + " | ";
            Retorno += "Credito " + this.Credito + " | ";
            return Retorno;
                
        }

    }
}