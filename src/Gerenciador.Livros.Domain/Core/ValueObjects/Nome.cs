using System;

namespace Gerenciador.Livros.Core.ValueObjets
{
    public class Nome
    {
        public Nome(string nome, string sobreNome)
        {
            NomeInfo = nome;
            SobreNome = sobreNome;
        }

        public string NomeInfo { get; private set; }
        public string SobreNome { get; private set; }

        public bool EhValido()
        {
            if (String.IsNullOrEmpty(this.NomeInfo) && String.IsNullOrEmpty(this.SobreNome)) return false;

            return true;
        }
    }
}