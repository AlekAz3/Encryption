using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypt
{
    
    public class Morse
    {
        private static string[] morse_alphabet = new string[] { "*-", "-***", "-*-*", "-**", "*", "**-*", "--*", "****", "**", "*---", "-*-", "*-**", "--", "-*", "---", "*--*", "--*-", "*-*", "***", "-", "**-", "***-", "*--", "-**-", "-*--", "--**" };

        public static string Encrypt(string text)
        {
            if (text == "" || text == " ")
                throw new ArgumentOutOfRangeException("Пустая строка");

            string result = "";
            int[] tmp = new int[text.Length];
            Cipher.TextToAlph(text, ref tmp);

            for (int i = 0; i < text.Length; i++)
            {
                if (tmp[i] == 0)
                    result += " ";
                else
                    result += morse_alphabet[tmp[i]+1]+" ";
            }

            return result;
        }

        public static string Decrypt(string text)
        {
            if (text == "" || text == " ")
                throw new ArgumentOutOfRangeException("Пустая строка");
            

            string result = "";
            text += " ";
            string tmp = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '*' || text[i] == '-')
                    tmp += text[i];
                else if (text[i] == ' ')
                {
                    int index = Array.IndexOf(morse_alphabet, tmp) -1 ;
                    result +=$"{Cipher.AlphToText(index)}";
                    tmp = "";
                }
            }

            return result;
        }
    }
}