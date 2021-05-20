using System;

namespace Gerenciador.Livros.Domain.Core.Validations
{
    public class ValidadorIsbn
    {
        public static bool EhIsbn13Valido(string isbn13)
        {
            bool result = false;
            if (!string.IsNullOrEmpty(isbn13))
            {
                long j;

                if (isbn13.Length < 10) return false;

                if (isbn13.Contains('-'))
                {
                    isbn13 = isbn13.Replace("-", "");
                }
                // Check if it contains any non numeric chars, if yes, return false

                if (!Int64.TryParse(isbn13, out j))
                    result = false;
                int sum = 0;
                // The calculation of an ISBN-13 check digit begins with the first 12 digits of the thirteen-digit ISBN (thus excluding the check digit itself).
                // Each digit, from left to right, is alternately multiplied by 1 or 3, then those products are summed modulo 10 to give a value ranging from 0 to 9.
                // Subtracted from 10, that leaves a result from 1 to 10. A zero (0) replaces a ten (10), so, in all cases, a single check digit results.
                for (int i = 0; i < 12; i++)
                {
                    sum += Int32.Parse(isbn13[i].ToString()) * (i % 2 == 1 ? 3 : 1);
                }
                int remainder = sum % 10;
                int checkDigit = 10 - remainder;
                if (checkDigit == 10) checkDigit = 0;
                result = (checkDigit == int.Parse(isbn13[12].ToString()));
            }
            return result;
        }
    }
}
