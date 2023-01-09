namespace Notificacoes
{
    public abstract class Notificacao
    {
        public string Destinatario { get; set;}
        public string Mensagem { get; set; }

        public Notificacao(string destinatario, string mensagem)
        {
            Destinatario = destinatario;
            Mensagem = mensagem;
        }
        
        public abstract void Enviar();
    }
}