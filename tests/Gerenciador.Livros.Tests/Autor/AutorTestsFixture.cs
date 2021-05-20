using Gerenciador.Livros.Core.ValueObjets;
using Gerenciador.Livros.Domain.Core.ValueObjects;
using Gerenciador.Livros.Domain.Entities;
using System;
using Xunit;

namespace Gerenciador.Livros.Tests.Autors
{
    [CollectionDefinition(nameof(AutorCollection))]
    public class AutorCollection : ICollectionFixture<AutorTestsFixture> { }
    public class AutorTestsFixture : IDisposable
    {
        public Autor GerarAutorValido()
        {
            Cpf cpf = new Cpf("515.523.840-47");
            Nome nome = new Nome("Thiago", "Moreira");
            return new Autor(nome, new DateTime(1982, 4, 6), cpf);
        }

        public Autor GerarAutorInvalido()
        {
            Cpf cpf = new Cpf("000000000000");
            Nome nome = new Nome("", "");
            return new Autor(nome, new DateTime(2000, 4, 6), cpf);
        }
        public void Dispose()
        {
            
        }
    }
}
