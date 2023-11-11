using System;

namespace Caesar_cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            //alphabet array
            char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f',
              'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r',
              's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

            Console.Write("Select 'e' to encrypt a message or 'd' to decrypt it: ");
            string choice = Console.ReadLine();

            switch (choice)
            {

                case "e":
                    Console.Write("\nEnter the message you want to encrypt: ");
                    break;

                case "d":
                    Console.Write("\nEnter the message you want to decrypt: ");
                    break;

            }

            string inputMessage = Console.ReadLine();

            Console.Write("\nEnter the key: ");
            int key = Convert.ToInt32(Console.ReadLine());

            char[] secretMessage = inputMessage.ToCharArray();

            char[] encryptedMessage = new char[secretMessage.Length];

            switch (choice)
            {

                case "e":

                    for (int i = 0; i < secretMessage.Length; i++)
                    {

                        char letter = secretMessage[i];

                        int letterPosition = Array.IndexOf(alphabet, letter);

                        int newLetterPosition = (letterPosition + key) % 26;

                        char encryptedLetter = alphabet[newLetterPosition];
                       
                        encryptedMessage[i] = encryptedLetter;
                    }
                    break;

                case "d":

                    for (int i = 0; i < secretMessage.Length; i++)
                    {

                        char letter = secretMessage[i];
                       
                        int letterPosition = Array.IndexOf(alphabet, letter);

                        int r = letterPosition - key;

                        if (r<0) {
                            r+=26;
                        }
                        
                        int newLetterPosition = (r) % 26;
                        
                        char encryptedLetter = alphabet[newLetterPosition];
                        
                        encryptedMessage[i] = encryptedLetter;
                    }
                    break;
            }

           
            string finalMessage = String.Join("", encryptedMessage);
            Console.WriteLine("\n" + finalMessage);

            Console.ReadKey();
        }
    }
}
