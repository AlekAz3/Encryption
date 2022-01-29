using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypt
{
    public static class Caesar
    {
        /// <summary>
        /// Метод для шифровки текста шифром цезаря
        /// </summary>
        /// <param name="text">Текст который надо зашифровать</param>
        /// <param name="key">Значение сдвига</param>
        /// <returns></returns>
        static public string Encrypt(string text, int key)
        {
            string result = "";

            int[] tmp = new int[text.Length];

            text = text.ToLower();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ') 
                    tmp[i] = 0;
                else
                    tmp[i] = ((int)text[i] - 96);
            }

            for (int i = 0; i < text.Length; i++)
            {
                if ((tmp[i] + key) > 27)
                    tmp[i] += key - 26;

                else if (tmp[i] == 0)
                    tmp[i] += ' ';

                else
                    tmp[i] += key;
            }

            for (int i = 0; i < text.Length; i++)
            {
                if (tmp[i] == ' ')
                    result += " ";

                else
                    result += (char)(tmp[i]+96);
            }
            return result;
        }
    }
}
