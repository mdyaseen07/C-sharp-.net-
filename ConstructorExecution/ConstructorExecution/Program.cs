namespace ConstructorExecution
{
    internal class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Derived obj = new Derived(); return 0;
        }
    }
}
class Base { 
    public Base() 
    {
        Console.WriteLine("Constructor of Base"); 
    } 
    ~Base() 
    { 
        Console.WriteLine("Destructor of Base");
    } 
}

class Derived : Base 
{ 
    public Derived() 
    {
        Console.WriteLine("Constructor of Derived");
    }
    ~Derived() 
    { 
        Console.WriteLine("Destructor of Derived");
    }
}

