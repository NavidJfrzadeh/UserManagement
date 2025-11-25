using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using App.Services.Contracts;
using System.Security.Cryptography;

namespace App.Infra.Security;

public class PasswordHasher : IPasswordHasher
{
    public string HashPassword(string password)
    {
        byte[] salt = RandomNumberGenerator.GetBytes(16);

        string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
        password: password!,
        salt: salt,
        prf: KeyDerivationPrf.HMACSHA256,
        iterationCount: 100000,
        numBytesRequested: 32));

        return hashed;
    }

    public bool VerifyPassword(string hash, string password)
    {
        //byte[] hashBytes = Convert.FromBase64String(hashBase64);

        //byte[] salt = new byte[16];
        //Buffer.BlockCopy(hashBytes, 0, salt, 0, 16);

        //var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000, HashAlgorithmName.SHA256);
        //var hash = pbkdf2.GetBytes(32);

        //for (int i = 0; i < 32; i++)
        //{
        //    if (hashBytes[i + 16] != hash[i])
        //        return false;
        //}

        return true;
    }
}
