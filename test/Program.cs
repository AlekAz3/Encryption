using Crypt;

namespace test
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine(Vigenere.Encrypt("ATTACKATDAWN".ToLower(), "LEMON".ToLower()));
            Console.WriteLine(Vigenere.Decrypt("LXFOPVEFRNHR".ToLower(), "LEMON".ToLower()));
        }
    }
}