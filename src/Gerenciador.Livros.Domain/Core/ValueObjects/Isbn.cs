using Gerenciador.Livros.Domain.Core.Validations;

namespace Gerenciador.Livros.Domain.Core.ValueObjects
{
    public class Isbn
    {
        public Isbn(string numero)
        {
            Numero = numero;
        }

        public string Numero { get; private set; }

        public bool EhValido()
        {
            return ValidadorIsbn.EhIsbn13Valido(this.Numero);
        }
    }
}
