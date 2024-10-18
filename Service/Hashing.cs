using System.Security.Cryptography;
using System.Text;

namespace desafio_criptografia.Service
{
    public static class Hashing
    {
        public static string? ToSHA512(string? s)
        {
            using var sha512 = SHA512.Create();
            byte[] bytes = sha512.ComputeHash(Encoding.UTF8.GetBytes(s));

            var sb = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString("x2"));
            }
            return sb.ToString();
        }
    }
}
