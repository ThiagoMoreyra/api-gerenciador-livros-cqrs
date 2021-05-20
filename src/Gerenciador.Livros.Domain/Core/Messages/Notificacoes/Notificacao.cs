namespace Gerenciador.Livros.Domain.Core.Messages.Notificacoes
{
    public sealed class Notificacao
    {
        public Notificacao(string message, string property)
        {
            Message = message;
            Property = property;
        }

        public string Message { get; }
        public string Property { get; }
    }
}
