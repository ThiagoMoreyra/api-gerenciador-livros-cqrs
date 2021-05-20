using MediatR;
using System;

namespace Gerenciador.Livros.Domain.Core.Messages
{
    public abstract class Comando : Message, IRequest<bool>
    {
        public DateTime Timestamp { get; private set; }
        protected Comando()
        {
            Timestamp = DateTime.Now;
        }

        public virtual bool EhValido()
        {
            throw new NotImplementedException();
        }
    }
}
