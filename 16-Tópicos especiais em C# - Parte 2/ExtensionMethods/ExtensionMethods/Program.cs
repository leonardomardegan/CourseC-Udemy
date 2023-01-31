namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2023, 1, 30, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}