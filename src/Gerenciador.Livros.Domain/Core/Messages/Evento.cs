using MediatR;
using System;

namespace Gerenciador.Livros.Domain.Core.Messages
{
    public abstract class Evento: Message, INotification
    {
        public DateTime Timestamp { get; private set; }

        protected Evento()
        {
            Timestamp = DateTime.Now;
        }
    }
}
