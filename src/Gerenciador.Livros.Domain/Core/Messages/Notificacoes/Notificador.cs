using System.Collections.Generic;
using System.Linq;

namespace Gerenciador.Livros.Domain.Core.Messages.Notificacoes
{
    public abstract class Notificador
    {
        private readonly List<Notificacao> _notificacoes;
        protected Notificador() => _notificacoes = new List<Notificacao>();
        public IReadOnlyCollection<Notificacao> Notificacoes => _notificacoes;

        public void AdicionaNotificacao(string property, string message)
        {
            _notificacoes.Add(new Notificacao(property, message));
        }

        public void AdicionaNotificacao(Notificacao notificacao)
        {
            _notificacoes.Add(notificacao);
        }

        public void AdicionaNotificacoes(IReadOnlyCollection<Notificacao> notificacoes)
        {
            _notificacoes.AddRange(notificacoes);
        }

        public void AdicionaNotificacoes(IList<Notificacao> notificacoes)
        {
            _notificacoes.AddRange(notificacoes);
        }

        public void AdicionaNotificacoes(ICollection<Notificacao> notificacoes)
        {
            _notificacoes.AddRange(notificacoes);
        }

        public void AdicionaNotificacoes(Notificador item)
        {
            AdicionaNotificacoes(item.Notificacoes);
        }

        public void AdicionaNotificacoes(params Notificador[] items)
        {
            foreach (var item in items)
                AdicionaNotificacoes(item);
        }

        public void Clear()
        {
            _notificacoes.Clear();
        }

        public bool Invalido => _notificacoes.Any();
        public bool Valido => !Invalido;
    }
}
