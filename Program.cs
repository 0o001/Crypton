using System;
using System.Collections.Generic;
using System.Linq;

namespace Crypton
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello World";
            int key = 11;

            Console.WriteLine($"Message: {message}");
            Console.WriteLine($"Encrypt: {Encrypt(message, key)}");

            string encrypted = Encrypt(message, key);

            Console.WriteLine($"Decrypt: {Decrypt(encrypted, key)}");
            Console.ReadLine();
        }

        static string Encrypt(string message, int key)
        {
            string encryptedText = null;

            foreach (int item in message)
            {
                encryptedText += (char) (item ^ key);
            }

            return encryptedText;
        }

        static string Decrypt(string message, int key)
        {
            string decryptedText = null;

            foreach (int item in message)
            {
                decryptedText += (char) (item ^ key);
            }

            return decryptedText;
        }
    }
}
