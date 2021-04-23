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
                        //ListarConta();
                        break;

                     case "2":
                        InserirConta();
                        break;

                     case "3":
                        //Transferir();
                        break;

                     case "4":
                       //Sacar());
                        break;

                      case "5":
                        //Depositar();
                        break;

                       case "C":
                        Console.Clear();xx
                        break;

                       default:
                        throw new ArgumentOutOfRangeException ();      

                }

                    OpcaoUsuario = ObterOpcaoUsuario();

            }    

            Console.WriteLine("Obrigado!!!");
            Console.ReadLine();
        }

        private static void InserirConta()
        {
            throw new NotImplementedException();

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
