using System.Security.Cryptography;

namespace Chat.Domain.Cryptography;

public class Password
{
    private const byte _saltSize = 16;
    private const byte _keySize = 32;
    private const int _iterations = 100000;
    private static readonly HashAlgorithmName _algorithm = HashAlgorithmName.SHA256;

    public static string Hash(string input)
    {
        byte[] salt = RandomNumberGenerator.GetBytes(_saltSize);
        byte[] hash = Rfc2898DeriveBytes.Pbkdf2(
            input,
            salt,
            _iterations,
            _algorithm,
            _keySize
        );

        return string.Join(
            "_",
            Convert.ToHexString(hash),
            Convert.ToHexString(salt),
            _iterations // No need to store the algorithm name
        );
    }

    public static bool Verify(string input, string hashString)
    {
        string[] segments = hashString.Split("_");

        if (segments.Length != 3) // Now expecting only 3 segments: hash, salt, iterations
        {
            throw new InvalidOperationException("Invalid hash format.");
        }

        byte[] hash = Convert.FromHexString(segments[0]);
        byte[] salt = Convert.FromHexString(segments[1]);
        int iterations = int.Parse(segments[2]);

        byte[] inputHash = Rfc2898DeriveBytes.Pbkdf2(
            input,
            salt,
            iterations,
            _algorithm, // Use the constant algorithm
            hash.Length
        );

        return CryptographicOperations.FixedTimeEquals(inputHash, hash);
    }

}