using Crypt;

namespace test
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine(Morse.Encrypt("hello world"));
            Console.WriteLine(Morse.Decrypt("*--- --* -* -* --*-  | -*-- --*- - -* **-*"));
        }
    }
}