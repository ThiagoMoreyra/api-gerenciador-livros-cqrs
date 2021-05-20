using Gerenciador.Livros.Domain.Core.DomainObjects;
using System.Linq;
using Xunit;

namespace Gerenciador.Livros.Tests.Livros
{
    [Collection(nameof(LivroCollection))]
    public class LivroTests
    {
        readonly LivroTestsFixture _livroTestsFixture;
        public LivroTests(LivroTestsFixture livroTestsFixture)
        {
            _livroTestsFixture = livroTestsFixture;
        }

        [Fact(DisplayName = "Novo Livro Válido")]
        [Trait("Livro", "Livro Trait Testes")]
        public void Livro_NovoLivro_DeveEstarValido()
        {
            var livro = _livroTestsFixture.GerarLivroValido();

            Assert.False(Validacoes.ObtemErros().Any());
        }

        [Fact(DisplayName = "Novo Livro Inválido")]
        [Trait("Livro", "Livro Trait Testes")]
        public void Livro_NovoLivro_DeveEstarInvalido()
        {
            var livro = _livroTestsFixture.GerarLivroInvalido();

            Assert.True(Validacoes.ObtemErros().Any());
            Assert.Equal(6, Validacoes.ObtemErros().Count());
        }
    }
}
