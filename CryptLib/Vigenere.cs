using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptLib
{
    public class Vigenere
    {

        public static string Encrypt (string text, string key)
        {
            if (text == "" || text == " " || key == "" || key == " ")
                throw new ArgumentException("Пустое значение");

            string result = "";

            string key_2 = "";

            for (int i = 0; i < text.Length; i++)
            {
                key_2 += key[i % key.Length];
                if (text[i] == ' ')
                    result += " ";
                else
                    result += Caesar.Encrypt(text[i].ToString(), Cipher.TextToAlph(key_2[i]) - 1);
                
            }

            return result;
        }

        public static string Decrypt(string text, string key)
        {
            if (text == "" || text == " " || key == "" || key == " ")
                throw new ArgumentException("Пустое значение");
            string result = "";
            string key_2 = "";

            for (int i = 0; i < text.Length; i++)
            {
                key_2 += key[i % key.Length];
                if (text[i] == ' ')
                    result += " ";
                else
                    result += Caesar.Decrypt(text[i].ToString(), Cipher.TextToAlph(key_2[i])-1);
                
            }

            return result;
        }
    }
}
