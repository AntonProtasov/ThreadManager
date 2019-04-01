using System;
using System.Linq;

namespace ThreadManager
{
    public class RecordManagerHelper
    {
        private const string Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        public static string GenerateRandomString(Random randomFunction, int length)
        {
            if(length == 0)
                return String.Empty;

            if(length < 0)
                throw new Exception("Попытка генерации случайной строки недопустимого размера");

            char[] chars = Enumerable.Repeat(Chars, length)
                .Select(s => s[randomFunction.Next(s.Length)]).ToArray();

            return new string(chars);
        }
    }
}