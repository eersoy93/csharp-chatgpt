internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        if (args.Length == 0)
        {
            Console.WriteLine("No argument has been given!!!");
        }
        else
        {
            foreach (string arg in args)
            {
                Console.WriteLine(arg);
            }
        }
        
    }
}