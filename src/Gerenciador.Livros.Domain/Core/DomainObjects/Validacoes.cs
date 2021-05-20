using Gerenciador.Livros.Core.ValueObjets;
using Gerenciador.Livros.Domain.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Gerenciador.Livros.Domain.Core.DomainObjects
{
    public class Validacoes
    {
        private static List<string> Erros = new List<string>();
        public static void ValidarSeIgual(object object1, object object2, string mensagem)
        {
            if (object1.Equals(object2))
                Erros.Add(mensagem);
        }

        public static void ValidarSeDiferente(object object1, object object2, string mensagem)
        {
            if (!object1.Equals(object2))
                Erros.Add(mensagem);
        }

        public static void ValidarSeDiferente(string pattern, string valor, string mensagem)
        {
            var regex = new Regex(pattern);

            if (!regex.IsMatch(valor))
                Erros.Add(mensagem);
        }

        public static void ValidarTamanho(string valor, int maximo, string mensagem)
        {
            var length = valor.Trim().Length;
            if (length > maximo)
                Erros.Add(mensagem);
        }

        public static void ValidarTamanho(string valor, int minimo, int maximo, string mensagem)
        {
            var length = valor.Trim().Length;
            if (length < minimo || length > maximo)
                Erros.Add(mensagem);
        }

        public static void ValidarSeVazio(string valor, string mensagem)
        {
            if (valor == null || valor.Trim().Length == 0)
                Erros.Add(mensagem);
        }

        public static void ValidarSeNulo(object object1, string mensagem)
        {
            if (object1 == null)
                Erros.Add(mensagem);
        }

        public static void ValidarMinimoMaximo(double valor, double minimo, double maximo, string mensagem)
        {
            if (valor < minimo || valor > maximo)
                Erros.Add(mensagem);
        }

        public static void ValidarMinimoMaximo(float valor, float minimo, float maximo, string mensagem)
        {
            if (valor < minimo || valor > maximo)
                Erros.Add(mensagem);
        }

        public static void ValidarMinimoMaximo(int valor, int minimo, int maximo, string mensagem)
        {
            if (valor < minimo || valor > maximo)
                Erros.Add(mensagem);
        }

        public static void ValidarMinimoMaximo(long valor, long minimo, long maximo, string mensagem)
        {
            if (valor < minimo || valor > maximo)
                Erros.Add(mensagem);
        }

        public static void ValidarMinimoMaximo(decimal valor, decimal minimo, decimal maximo, string mensagem)
        {
            if (valor < minimo || valor > maximo)
                Erros.Add(mensagem);
        }

        public static void ValidarSeMenorQue(long valor, long minimo, string mensagem)
        {
            if (valor < minimo)
                Erros.Add(mensagem);
        }

        public static void ValidarSeMenorQue(double valor, double minimo, string mensagem)
        {
            if (valor < minimo)
                Erros.Add(mensagem);
        }

        public static void ValidarSeMenorQue(decimal valor, decimal minimo, string mensagem)
        {
            if (valor < minimo)
                Erros.Add(mensagem);
        }

        public static void ValidarSeMenorQue(int valor, int minimo, string mensagem)
        {
            if (valor < minimo)
                Erros.Add(mensagem);
        }

        public static void ValidarSeFalso(bool boolvalor, string mensagem)
        {
            if (!boolvalor)
                Erros.Add(mensagem);
        }

        public static void ValidarSeVerdadeiro(bool boolvalor, string mensagem)
        {
            if (boolvalor)
                Erros.Add(mensagem);
        }

        public static void ValidaCpf(Cpf cpf, string mensagem)
        {
            if (cpf.EhValido() is false)
                Erros.Add(mensagem);
        }

        public static void ValidaIsbn(Isbn isbn, string mensagem)
        {
            if (isbn.EhValido() is false)
                Erros.Add(mensagem);
        }

        public static void ValidaIdade(DateTime dataNascimento, string mensagem)
        {
            int idade = DateTime.Now.Year - dataNascimento.Year;
            if (DateTime.Now.DayOfYear < dataNascimento.DayOfYear)
                idade = idade - 1;

            if (idade <= 30)
                Erros.Add(mensagem);
        }
        public static void ValidaNome(Nome nome, string mensagem)
        {
            if (nome.EhValido() is false)
                Erros.Add(mensagem);
        }


        public static List<string> ObtemErros() => Erros;

        public static void LimparErros() => Erros.Clear();
    }
}
