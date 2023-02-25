using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1passwordGenerator.Console
{
  
    public class Generator

    {
        public static string GeneratePassword(bool useUpper,
        bool useLower,
        bool useNumbers,
        bool useSpecialChars,
        int length)
        {
            string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowerCase = "abcdefghijklmnopqrstuvwxyz";
            string numbers = "0123456789";
            string specialChars = "!@#$%^&*()";

            Random random = new Random(); 
            string charSet = string.Empty;
            char[] password = new char[length];
        
            if (useUpper) charSet += upperCase;
            if (useLower)  charSet += lowerCase;
            if (useNumbers) charSet += numbers;
            if (useSpecialChars) charSet += specialChars;

            for (int i = 0; i < length; i++)
            {
                password[i] = charSet[random.Next(charSet.Length -1)];
            }
            return string.Join(null, password);
        }
    }
}
