using Contas;
using RH;
using Personagens;
using Notificacoes;

namespace orientacao_a_objetos_treinaweb
{
    class Program
    {
        static void Main(string[] args)
        {
            // Conta
            var conta = new Conta();
            Console.WriteLine(conta.ExibirExtrato());

            conta.Depositar(1000);
            Console.WriteLine(conta.ExibirExtrato());

            conta.Sacar(100);
            Console.WriteLine(conta.ExibirExtrato());

            conta.RealizarEmprestimo(1000, 10);  
            Console.WriteLine(conta.ExibirExtrato());

            // RH
            var funcionario = new Funcionario("Janio Alexandre", "065.065.065-06");
            funcionario.CPF = "111.111.111-11";
            Console.WriteLine(funcionario.CPF);

            // Personagens 
            var cavaleiro = new Cavaleiro("Aragorn", 100);
            var arqueiro = new Arqueiro("Legolas", 100);
            var mago = new Mago("Gandalf", 100, 100);

            cavaleiro.Atacar();
            cavaleiro.AtacarEspecial();
            cavaleiro.Defender();

            arqueiro.Atacar();
            arqueiro.AtacarEspecial();
            arqueiro.Defender();

            mago.Atacar();
            arqueiro.AtacarEspecial();
            mago.Defender();

            // Notificacoes
            Console.WriteLine("Selecione o tipo de notificação: 1-Email | 2-SMS | 3-WhatsApp");
            var tipo = Console.ReadLine();

            Console.WriteLine("Digite o destinatário: ");
            var destinatario = Console.ReadLine();

            Console.WriteLine("Digite a menasgem: ");
            var mensagem = Console.ReadLine();

            Notificacao notificacao;

            switch(tipo)
            {
                case "1":
                    notificacao = new NotificacaoEmail(destinatario, mensagem);
                    break;
                case "2":
                    notificacao = new NotificacaoSms(destinatario, mensagem);
                    break; 
                case "3":
                    notificacao = new NotificacaoWhatsApp(destinatario, mensagem);
                    break;   
                default:
                    notificacao = new NotificacaoEmail(destinatario, mensagem);
                    break;          
            }
            notificacao.Enviar();
        }
    }
}