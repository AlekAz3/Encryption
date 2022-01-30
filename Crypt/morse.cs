using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypt
{
    public class morse
    {
        private static string[] alphabet = new string[] { "*-", "-***", "-*-*", "-**", "*", "**-*", "--*", "****", "**", "*---", "-*-", "*-**", "--", "-*", "---", "*--*", "--*-", "*-*", "***", "-", "**-", "***-", "*--", "-**-", "-*--", "--**" };

        public static string Encrypt(string text)
        {
            string result = "";
            int[] tmp = new int[text.Length];
            Cipher.TextToAlph(text, ref tmp);

            for (int i = 0; i < text.Length; i++)
            {
                if (tmp[i] == 0)
                    result += "///";
                else
                    result += alphabet[tmp[i]+1]+" ";
            }

            return result;
        }
        public static string Decrypt(string text)
        {
            throw new Exception("Я тупой и не придумал ещё как эту хуйню сделать");
        }
    }
}