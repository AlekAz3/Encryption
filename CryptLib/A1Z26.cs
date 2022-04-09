using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptLib
{
    public class A1Z26
    {
        public static string Encrypt(string text)
        {
            if (text == "" || text == " ")
                throw new ArgumentOutOfRangeException("Пустая строка");
            string result = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    result += " ";
                }
                else
                    result += $"{Cipher.TextToAlph(text[i])} ";
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
                if (text[i] == ' ' && tmp == "")
                    result += " ";
                
                else if (text[i] == ' ')
                {
                    result += Cipher.AlphToText(Convert.ToInt32(tmp));
                    tmp = "";
                }
                else
                    tmp += text[i];
            }
            
            return result;
        }
    }
}
