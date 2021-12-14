namespace Bank
{
    public class Program
    {
        static List<Conta> listConta = new List<Conta>();
        public static void Main(string [] args)
        {
           string opcao = ObterOpcaoUsuario();

           while(opcao.ToUpper() != "X")
           {
                switch (opcao){
                    case "1":
                        InserirConta();
                        break;
                    case "2":
                        VerSaldoConta();
                        break;
                    case "3":
                        Depositar();
                        break;
                    case "4":
                        Sacar();
                        break;
                    case "5":
                        Transferir();
                        break;
                    case "6":
                        VerContas();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
               }
               opcao = ObterOpcaoUsuario();
           }
        }

        private static void Transferir()
        {
            System.Console.WriteLine(".......Transferencia........");

            System.Console.WriteLine("Informe o numero da conta de origem: ");
            int contaOrigem = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Informe o numero da conta de destino: ");
            int contaDestino = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Informe o valor da transferencia: ");
            double valorTransferencia = double.Parse(Console.ReadLine());

            listConta[contaOrigem].Transferir(listConta[contaDestino], valorTransferencia);
        }

        private static void Sacar()
        {
            System.Console.WriteLine("........Saque........");
            
            System.Console.WriteLine("Informe o numero da conta: ");
            int numConta = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Informe o valor do saque: ");
            double valorSaque = double.Parse(Console.ReadLine());

            listConta[numConta].Sacar(valorSaque);
        }

        private static void Depositar()
        {
            System.Console.WriteLine(".......Deposito.......");
            
            System.Console.WriteLine("informe o numero da conta");
            int numConta = int.Parse(Console.ReadLine());

            System.Console.WriteLine("informe o valor a depositar: ");
            double valorDeposito = double.Parse(Console.ReadLine());

            listConta[numConta].Depositar(valorDeposito);

        }

        private static void VerSaldoConta()
        {
            System.Console.WriteLine(".......Saldo........");

            System.Console.WriteLine("Informe a conta");
            int entradaConta = int.Parse(Console.ReadLine());
            listConta[entradaConta].VerSaldo();
        }

        private static void VerContas()
        {
            for (int i =0; i < listConta.Count; i++)
            {
                System.Console.WriteLine($"# {i} "+ listConta[i].ToString());
            }
        }

        private static void InserirConta()
        {
            System.Console.WriteLine(".......Inserir Conta......");

            System.Console.WriteLine("Escolher o tipo de pessoa 1 para Fisica e 2 para Juridica:");
            int entradaTipo = int.Parse(Console.ReadLine());
            

            System.Console.WriteLine("Inserir o nome: ");
            string entradaNome = Console.ReadLine();

            System.Console.WriteLine("Insira o saldo: ");
            double entradaSaldo = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Insira o credito: ");
            double entradaCredito = double.Parse(Console.ReadLine());

            Conta novaConta = new Conta(nome: entradaNome, 
                                        tipoConta: (TipoConta)entradaTipo,
                                        saldo: entradaSaldo, 
                                        credito: entradaCredito);
            listConta.Add(novaConta);

        }

        public static string ObterOpcaoUsuario()
        {
            System.Console.WriteLine("Bem vindo ao Bank.");
            string opcaoUsuario;
            System.Console.WriteLine("Escolha a opção desejada");
            System.Console.WriteLine("");
            System.Console.WriteLine("1 - Inserir Nova Conta");
            System.Console.WriteLine("2 - Ver saldo da Conta");
            System.Console.WriteLine("3 - Depositar");
            System.Console.WriteLine("4 - Sacar");
            System.Console.WriteLine("5 - Transferir");
            System.Console.WriteLine("6 - Ver Todas as Contas");
            opcaoUsuario = Console.ReadLine();
            return opcaoUsuario;
        }
    }
}