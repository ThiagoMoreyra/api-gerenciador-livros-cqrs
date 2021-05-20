using Gerenciador.Livros.Domain.Core.Messages.Notificacoes;
using System;

namespace Gerenciador.Livros.Domain.Core.DomainObjects
{
    public abstract class Entity : Notificador
    {
        public Guid Id { get; set; }

        protected Entity()
        {
            Id = Guid.NewGuid();
        }

        public virtual void Validar()
        {
            throw new NotImplementedException();
        }
    }
}
