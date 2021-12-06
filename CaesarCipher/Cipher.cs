using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    public class Cipher
    {
        // Alphabet for cryption
        private char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        //                                      0    1    2    3    4    5    6    7    8    9   10   11   12   13   14   15   16   17   18   19   20   21   22   23   24   25

        /// <summary>
        /// Encrypts entered string
        /// </summary>
        /// <param name="input">Entered string</param>
        /// <param name="key">Entered shift/key</param>
        /// <returns></returns>
        public string Encryption(string input, int key)
        {
            return Cryption(input, key);
        }

        /// <summary>
        /// Decrypts entered string
        /// </summary>
        /// <param name="input">Entered string</param>
        /// <param name="key">Entered shift/key</param>
        /// <returns></returns>
        public string Decryption(string input, int key)
        {
            return Cryption(input, -key);
        }

        /// <summary>
        /// Encrypts/Decrypts entered string
        /// </summary>
        /// <param name="input">Entered string</param>
        /// <param name="key">Entered shift/key</param>
        /// <returns></returns>
        private string Cryption(string input, int key)
        {
            int index;
            string result = string.Empty;
            foreach (char ch in input)
            {
                index = Array.IndexOf(alphabet, char.ToLower(ch));
                index = index + key;

                if (index < 0)
                    index = index + 26;
                else if (index > 25)
                    index = index - 26;

                if (char.IsUpper(ch))
                    result += char.ToUpper(alphabet[index]);
                else
                    result += alphabet[index];
            }
            return result;
        }
    }
}
