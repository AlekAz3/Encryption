namespace Crypt
{
    public static class Caesar
    {
        static public string Encrypt(string text, int key)
        {
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

        static public string Decrypt(string text, int key)
        {
            string result = "";

            int[] tmp = new int[text.Length];

            text = text.ToLower();

            Cipher.TextToAlph(text, ref tmp);

            for (int i = 0; i < text.Length; i++)
            {
                if ((tmp[i] - key) < 0)
                    tmp[i] -= key + 26;
                else if ((tmp[i] - key) > 0)
                    tmp[i] -= key;
                else
                    tmp[i] = 0;
            }

            Cipher.AlphToText(tmp, ref result);
            return result;
        }
    }
}
