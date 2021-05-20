using Gerenciador.Livros.Core.ValueObjets;
using Gerenciador.Livros.Domain.Core.ValueObjects;
using Gerenciador.Livros.Domain.Entities;
using System;
using Xunit;

namespace Gerenciador.Livros.Tests.Livros
{
    [CollectionDefinition(nameof(LivroCollection))]
    public class LivroCollection : ICollectionFixture<LivroTestsFixture> { }
    public class LivroTestsFixture : IDisposable
    {
        public Livro GerarLivroValido()
        {
            Cpf cpf = new Cpf("515.523.840-47");
            Nome nome = new Nome("Thiago", "Moreira");
            Autor autor = new Autor(nome, new DateTime(1982, 4, 6), cpf);
            Isbn isbn = new Isbn("978-12-345-6789-7");
            return new Livro("teste", DateTime.Now, isbn, "ficção", autor);
        }

        public Livro GerarLivroInvalido()
        {
            Cpf cpf = new Cpf("515.523.840-47");
            Nome nome = new Nome("Thiago", "Moreira");
            Autor autor = new Autor(nome, new DateTime(1982, 4, 6), cpf);
            Isbn isbn = new Isbn("111-11-111-1111-1");
            return new Livro("", DateTime.Now, isbn, "", autor);
        }

        public void Dispose()
        {
            
        }
    }
}
