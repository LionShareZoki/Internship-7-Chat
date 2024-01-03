using System;
using System.Security.Cryptography;

namespace Chat.Data.Utilities
{
    public static class PasswordUtility
    {
        private const byte SaltSize = 16;
        private const byte KeySize = 32;
        private const int Iterations = 100000;
        private static readonly HashAlgorithmName Algorithm = HashAlgorithmName.SHA256;

        public static string HashPassword(string input)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(SaltSize);
            byte[] hash = Rfc2898DeriveBytes.Pbkdf2(
                input,
                salt,
                Iterations,
                Algorithm,
                KeySize
            );

            return string.Join(
                "_",
                Convert.ToHexString(hash),
                Convert.ToHexString(salt),
                Iterations
            );
        }
    }
}