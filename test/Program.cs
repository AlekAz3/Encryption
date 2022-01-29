using Crypt;

namespace test
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Crypt.morse.Encrypt("hello world"));
        }
    }
}