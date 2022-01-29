using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypt
{
    static class Cipher
    {
        public static void TextToAlph(string text, ref int[] tmp)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                    tmp[i] = 0;
                else
                    tmp[i] = ((int)text[i] - 96);
            }
        }

        public static void AlphToText(int[] tmp, ref string result)
        {
            for (int i = 0; i < tmp.Length; i++)
            {
                if (tmp[i] <= 0)
                    result += " ";
                else
                    result += (char)(tmp[i] + 96);
            }
        }
    }
}
