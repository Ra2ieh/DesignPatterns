namespace Signletone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var lazy=LazySingletone.Instance;
        }
    }
}