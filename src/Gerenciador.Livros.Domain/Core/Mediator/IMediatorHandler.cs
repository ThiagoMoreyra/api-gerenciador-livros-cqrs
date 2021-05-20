using Gerenciador.Livros.Domain.Core.Messages;
using System.Threading.Tasks;

namespace Gerenciador.Livros.Domain.Core.Mediator
{
    public interface IMediatorHandler
    {
        Task PublicarEvento<T>(T evento) where T : Evento;
        Task<bool> EnviarComando<T>(T comando) where T : Comando;        
    }
}
