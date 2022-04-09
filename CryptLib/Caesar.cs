using System;

namespace CryptLib
{
    public static class Caesar
    {
        public static string Encrypt(string text, int key)
        {
            if (text == "" || text == " ")
                throw new ArgumentOutOfRangeException("Пустая строка");

            string result = "";

            int[] tmp = new int[text.Length];

            text = text.ToLower();

            Cipher.TextToAlph(text, ref tmp);

            for (int i = 0; i < text.Length; i++)
            {
                if (tmp[i] == 0)
                    continue;
                else if ((tmp[i] + key) > 27)
                    tmp[i] += key - 26;

                else 
                    tmp[i] += key;
            }

            Cipher.AlphToText(tmp, ref result);

            return result;
        }

        public static string Decrypt(string text, int key)
        {
            if (text == "" || text == " ")
                throw new ArgumentOutOfRangeException("Пустая строка");

            string result = "";

            int[] tmp = new int[text.Length];

            text = text.ToLower();

            Cipher.TextToAlph(text, ref tmp);

            for (int i = 0; i < text.Length; i++)
            {
                if (tmp[i] == 0)
                    tmp[i] = 0;
                else if ((tmp[i] - key) < 0)
                    tmp[i] += 26 - key;
                else if ((tmp[i] - key) > 0)
                    tmp[i] -= key;
            }
            Cipher.AlphToText(tmp, ref result);
            return result;
        }
    }
}
