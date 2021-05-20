using Gerenciador.Livros.Domain.Core.Validations;

namespace Gerenciador.Livros.Domain.Core.ValueObjects
{
    public class Cpf
    {
        public Cpf(string documento)
        {
            Documento = documento;
        }

        public string Documento { get; private set; }
        public bool EhValido()
        {
            return ValidadorCpf.Validar(this.Documento);
        }
    }
}
