using Gerenciador.Livros.Domain.Core.DomainObjects;
using Gerenciador.Livros.Domain.Core.ValueObjects;
using System;
using System.Linq;

namespace Gerenciador.Livros.Domain.Entities
{
    public class Livro : Entity
    {
        public Livro(string titulo, DateTime dataDeLancamento, Isbn isbn, string categoria, Autor autor)
        {
            Id = Guid.NewGuid();
            Titulo = titulo;
            DataDeLancamento = dataDeLancamento;
            Isbn = isbn;
            Categoria = categoria;
            Autor = autor;

            Validar();
        }

        public string Titulo { get; private set; }
        public DateTime DataDeLancamento { get; private set; }
        public Isbn Isbn { get; private set; }
        public string Categoria { get; private set; }
        public Autor Autor { get; private set; }


        public override void Validar()
        {
            Validacoes.ValidarSeNulo(this.Titulo, "O título não pode ser nulo");
            Validacoes.ValidarSeVazio(this.Titulo, "O título não pode ser vazio");
            Validacoes.ValidarSeNulo(this.Categoria, "A categoria não pode ser nula");
            Validacoes.ValidarSeVazio(this.Categoria, "A categoria não pode ser vazia");
            Validacoes.ValidaIsbn(this.Isbn, "O ISBN informado é inválido");
            Validacoes.ValidarSeNulo(this.Autor, "O autor não pode ser nulo");            
        }
    }
}