using Gerenciador.Livros.Domain.Core.DomainObjects;
using System.Linq;
using Xunit;

namespace Gerenciador.Livros.Tests.Autors
{
    [Collection(nameof(AutorCollection))]
    public class AutorTests
    {
        readonly AutorTestsFixture _autorTestsFixture;
        public AutorTests(AutorTestsFixture autorTestsFixture)
        {
            _autorTestsFixture = autorTestsFixture;
        }

        [Fact(DisplayName = "Novo Autor Válido")]
        [Trait("Autor", "Autor Trait Testes")]
        public void Autor_NovoAutor_DeveEstarValido()
        {
            var autor = _autorTestsFixture.GerarAutorValido();

            Assert.False(Validacoes.ObtemErros().Any());

        }

        [Fact(DisplayName = "Novo Autor Inválido")]
        [Trait("Autor", "Autor Trait Testes")]
        public void Autor_NovoAutor_DeveEstarInvalido()
        {
            var autor = _autorTestsFixture.GerarAutorInvalido();

            Assert.True(Validacoes.ObtemErros().Any());
            Assert.Equal(6, Validacoes.ObtemErros().Count());
        }
    }
}
