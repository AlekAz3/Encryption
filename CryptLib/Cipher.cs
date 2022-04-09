namespace CryptLib
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
                    tmp[i] = (text[i] - 96);
            }
        }

        public static void AlphToText(int[] tmp, ref string result)
        {
            for (int i = 0; i < tmp.Length; i++)
            {
                if (tmp[i] == 0)
                    result += " ";
                else
                    result += (char)(tmp[i] + 96);
            }
        }


        public static char AlphToText(int tmp)
        {
            if (tmp <= 0)
                return ' ';
            else
                return (char)(tmp + 96);
        }

        public static int TextToAlph(char text)
        {
            if (text == ' ')
                return 0;
            else
                return (text - 96);
        }

    }
}
