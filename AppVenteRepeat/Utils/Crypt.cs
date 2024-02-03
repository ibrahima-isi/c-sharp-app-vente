using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AppVenteRepeat.Utils
{
    public static class Crypt
    {
        static string GetMD5Hash(MD5 md5Hash, string inputString)
        {
            // converting the inputString to a byte array and compute the hash
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(inputString));

            // create a new stringBuilder  to collect the bytes and create a new string
            StringBuilder stringBuilder = new StringBuilder();

            // looping to each byte of the hashed data and convert to hexadecimal string
            for (int i = 0; i < data.Length; i++)
            {
                stringBuilder.Append(data[i].ToString("x2"));
            }
            // now return the hexadecimal string

            return stringBuilder.ToString();
        }

        // now verify a hash against a string
        static bool VerifyingMD5Hash(string inputString, string hash, MD5 md5hash)
        {
            // hashing the input string
            string hashOfInputString = GetMD5Hash(md5hash, inputString);
            // create a string comparer
            StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;
            
            return 0 == stringComparer.Compare(hashOfInputString, hash);
        }
    }
}
