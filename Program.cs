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
            int key = 111;

            Console.WriteLine($"Message: {message}");
            Console.WriteLine($"Encrypt: {Encrypt(message, key)}");

            string encrypted = Encrypt(message, key);

            Console.WriteLine($"Decrypt: {Decrypt(encrypted, key)}");
            Console.ReadLine();
        }

        static string Encrypt(string message, int key)
        {
            List<int> encryptedArray = new List<int>();

            int[] messageArray = message.ToCharArray().Select(item => (int)item).ToArray<int>();

            foreach (int item in messageArray)
            {
                encryptedArray.Add(item ^ key);
            }

            return string.Join(".", encryptedArray);
        }

        static string Decrypt(string message, int key)
        {
            List<int> decryptedArray = new List<int>();

            int[] messageArray = message.Split('.').Select(item => int.Parse(item)).ToArray();

            foreach (int item in messageArray)
            {
                decryptedArray.Add(item ^ key);
            }

            return string.Join("", decryptedArray.Select(item => (char)item));
        }
    }
}
