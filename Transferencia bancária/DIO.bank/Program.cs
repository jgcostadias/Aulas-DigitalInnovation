using System;
using System.Collections.Generic;


namespace DIO.bank
{
    class Program
    {
        static List<Conta> ListaContas = new List<Conta>();

        static void Main(string[] args)
        {
            string OpcaoUsuario = ObterOpcaoUsuario();   

            while (OpcaoUsuario.ToUpper() != "X")
            {
                switch (OpcaoUsuario)
                {
                    case "1":
                        ListarConta();
                        break;

                     case "2":
                        InserirConta();
                        break;

                     case "3":
                        //Transferir();
                        break;

                     case "4":
                       Sacar();
                        break;

                      case "5":
                        Depositar();
                        break;

                       case "C":
                        Console.Clear();
                        break;

                       default:
                        throw new ArgumentOutOfRangeException ();      

                }

                    OpcaoUsuario = ObterOpcaoUsuario();

            }    

            Console.WriteLine("Obrigado!!!");
            Console.ReadLine();
        }

        private static void ListarConta()
        {
            Console.WriteLine("Listar contas");

			if (ListaContas.Count == 0)
			{
				Console.WriteLine("Nenhuma conta cadastrada.");
				return;
			}

			for (int i = 0; i < ListaContas.Count; i++)
			{
				Conta Conta = ListaContas[i];
				Console.Write("#{0} - ", i);
				Console.WriteLine(Conta);
			}
           
        }

        private static void Sacar()
		{
			Console.Write("Digite o número da conta: ");
			int indiceConta = int.Parse(Console.ReadLine());

			Console.Write("Digite o valor a ser sacado: ");
			double valorSaque = double.Parse(Console.ReadLine());

            ListaContas[indiceConta].Sacar(valorSaque);
		}

        	private static void Depositar()
		{
			Console.Write("Digite o número da conta: ");
			int indiceConta = int.Parse(Console.ReadLine());

			Console.Write("Digite o valor a ser depositado: ");
			double valorDeposito = double.Parse(Console.ReadLine());

            ListaContas[indiceConta].Depositar(valorDeposito);
		}

        private static void Transferir()
		{
			Console.Write("Digite o número da conta de origem: ");
			int IndiceContaOrigem = int.Parse(Console.ReadLine());

            Console.Write("Digite o número da conta de destino: ");
			int IndiceContaDestino = int.Parse(Console.ReadLine());

			Console.Write("Digite o valor a ser transferido: ");
			double ValorTransferencia = double.Parse(Console.ReadLine());

            ListaContas[IndiceContaOrigem].Transferir(ValorTransferencia, ListaContas[IndiceContaDestino]);
		}

        private static void InserirConta()
        {

            Console.WriteLine("Inserir nova conta");

			Console.Write("Digite 1 para Conta Fisica ou 2 para Juridica: ");
			int EntradaTipoConta = int.Parse(Console.ReadLine());

			Console.Write("Digite o Nome do Cliente: ");
			string EntradaNome = Console.ReadLine();

			Console.Write("Digite o saldo inicial: ");
			double EntradaSaldo = double.Parse(Console.ReadLine());

			Console.Write("Digite o crédito: ");
			double EntradaCredito = double.Parse(Console.ReadLine());

			Conta NovaConta = new Conta(TipoConta: (TipoConta)EntradaTipoConta,
										Saldo: EntradaSaldo,
										Credito: EntradaCredito,
										Nome: EntradaNome);

			ListaContas.Add(NovaConta);
            
        }

        public static string ObterOpcaoUsuario()
        {

            Console.WriteLine();
            Console.WriteLine("Banco DIO:");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1 - Listar contas");
            Console.WriteLine("2 - Inserir nova conta");
            Console.WriteLine("3 - Transferir");
            Console.WriteLine("4 - Sacar");
            Console.WriteLine("5 - Depositar");
            Console.WriteLine("C - Limpar tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string OpcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return OpcaoUsuario;

        }
    }
}
