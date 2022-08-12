namespace firstCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int first, second, result;
            Console.WriteLine("Enter two numbers to add");
            first = Convert.ToInt16(Console.ReadLine());
            second = Convert.ToInt16(Console.ReadLine());
            result = first + second;
            Console.WriteLine("Sum of {0} and {1} is {2}", first, second, result);
        }
    }
}