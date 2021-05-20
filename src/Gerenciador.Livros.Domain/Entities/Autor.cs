using Gerenciador.Livros.Core.ValueObjets;
using Gerenciador.Livros.Domain.Core.DomainObjects;
using Gerenciador.Livros.Domain.Core.ValueObjects;
using System;
using System.Collections.Generic;

namespace Gerenciador.Livros.Domain.Entities
{
    public class Autor : Entity
    {
        protected Autor() { }
        public Autor(Nome nome, DateTime dataNascimento, Cpf cpf)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            DataNascimento = dataNascimento;
            Cpf = cpf;
            Livros = new List<Livro>();

            Validar();
        }

        public Nome Nome { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public Cpf Cpf { get; private set; }
        public List<Livro> Livros { get; set; }

        public override void Validar()
        {
            Validacoes.ValidaIdade(this.DataNascimento, "O autor não pode ter menos de 30 anos");
            Validacoes.ValidaCpf(this.Cpf, "O cpf do autor está inválido");
            Validacoes.ValidaNome(this.Nome, "O nome do autor está inválido");
        }
    }
}
