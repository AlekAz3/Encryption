using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public static class Caesar
    {
        //enum alphabet
        //{
        //    a = 1,
        //    b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z
        //}

        static public string Encrypt(string text, int key)
        {
            string result = "";

            int[] t = new int[text.Length];

            int[] b = new int[text.Length];

            _ = text.ToLower();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ') 
                    t[i] = 0;
                else
                    t[i] = ((int)text[i] - 96);
            }

            for (int i = 0; i < text.Length; i++)
            {
                if ((t[i] + key) > 27)
                    b[i] = t[i] - 26 + key;

                else if (t[i] == 0)
                    b[i] += ' ';

                else
                    b[i] = t[i] + key;

            }

            for (int i = 0; i < text.Length; i++)
            {
                result += (char)(b[i]+96);
            }

            return result;
        }

    }
}
