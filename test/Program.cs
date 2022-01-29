using Crypt;

namespace test
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Caesar.Encrypt("hello world", 2));
        }
    }
}