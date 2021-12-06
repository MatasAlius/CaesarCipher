using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Cipher cipher = new Cipher();

            Console.WriteLine("Do you want to Encrypt or Decrypt? 1 - Encrypt, 2 - Decrypt");
            Console.Write("Enter value 1 or 2 : ");

            // Checks if entered value is int
            if (Int32.TryParse(Console.ReadLine(), out int value))
            {
                string enteredString;
                string result;

                switch (value)
                {
                    case 1:
                        Console.WriteLine("Type a string to encrypt: ");
                        enteredString = Console.ReadLine();

                        if (OnlyLetters(enteredString))
                        {
                            Console.Write("Enter your key [-25; 25]: ");

                            // Checks if entered value is int
                            if (Int32.TryParse(Console.ReadLine(), out int key))
                            {
                                if (key >= -25 && key <= 25)
                                {
                                    Console.WriteLine("Encrypted Data: ");
                                    result = cipher.Encryption(enteredString, key);
                                    Console.WriteLine(result);
                                    Console.Write("\n");
                                }
                                else
                                    EnteredWrongValue();
                            }
                            else
                                EnteredWrongValue();
                        }
                        break;
                    case 2:
                        Console.WriteLine("Type a string to decrypt: ");
                        enteredString = Console.ReadLine();

                        if (OnlyLetters(enteredString))
                        {
                            Console.Write("Enter your key: ");

                            // Checks if entered value is int
                            if (Int32.TryParse(Console.ReadLine(), out int key))
                            {
                                if (key >= -25 && key <= 25)
                                {

                                    Console.WriteLine("Decrypted Data: ");
                                    result = cipher.Decryption(enteredString, key);
                                    Console.WriteLine(result);
                                    Console.Write("\n");
                                }
                                else
                                    EnteredWrongValue();
                            }
                            else
                                EnteredWrongValue();
                        }

                        break;
                    default:
                        Console.WriteLine("Entered wrong value, please enter 1 or 2");
                        break;
                }
            }
            else
                Console.WriteLine("Entered wrong value, please enter 1 or 2");

        }
        /// <summary>
        /// Checks if string contains only letters
        /// </summary>
        /// <param name="input">entered string</param>
        /// <returns></returns>
        static bool OnlyLetters(string input)
        {
            foreach (char ch in input)
            {
                if (!char.IsLetter(ch))
                {
                    Console.WriteLine("String must contain only letters");
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Prints out text "Entered wrong value"
        /// </summary>
        static void EnteredWrongValue()
        {
            Console.WriteLine("Entered wrong value");
        }
    }
}
