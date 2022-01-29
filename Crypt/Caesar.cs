namespace Crypt
{
    public static class Caesar
    {
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
                if (tmp[i] == 0)
                    continue;
                else if ((tmp[i] + key) > 27)
                    tmp[i] += key - 26;

                else 
                    tmp[i] += key;
            }

            for (int i = 0; i < text.Length; i++)
            {
                if (tmp[i] <= 0)
                    result += " ";
                else
                    result += (char)(tmp[i]+96);
            }

            return result;
        }

        static public string Decryption(string text, int key)
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

                if ((tmp[i] - key) < 0)
                    tmp[i] -= key + 26;
                else if ((tmp[i] - key) > 0)
                    tmp[i] -= key;
                else
                    tmp[i] = 0;
            }

            for (int i = 0; i < text.Length; i++)
            {
                if (tmp[i] <= 0)
                    result += " ";
                else
                    result += (char)(tmp[i]+96);
            }
            return result;
        }
    }
}
