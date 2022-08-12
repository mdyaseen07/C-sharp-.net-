namespace LabProject01Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            /*  Furniture chair = new Furniture(); //constructor automatically invoked i.e default constructor
              Furniture table = new Furniture("Steel");
              chair.getDetails();
              chair.showDetails();
              table.getDetails();
              table.showDetails(); */
            chair c1 = new chair();
            //c1.getDetails();// included in child
            c1.acceptDetails();
           // c1.showDetails();// included in child
            c1.disDetails();
        }
    }
}

class Furniture  //base class
{
    string Fname, color, material;
    int price;
    public Furniture() // default constructor
    {
        material = "Wood";
    }

    public Furniture(String Steel) //parametarized constructor or Overloaded consructor
    {
        material = Steel;
    }
    public void getDetails()

    {
        Console.WriteLine("Furniture Details nedded ");

        while (true)
        {
            Console.WriteLine("Furniture name ");
            Fname = Console.ReadLine();
            if (Fname.Length == 0)
            {
                Console.WriteLine("Furniture name cannot be blank ");
                continue;
            }
            else
                break;
        }

        Console.WriteLine("Furniture color ");
        color = Console.ReadLine();

        /*Console.WriteLine("Furniture Material ");
        material = Console.ReadLine(); Initialized using Constructor*/

        while (true)
        {
            Console.WriteLine("Furniture price ");
            price = Convert.ToInt16(Console.ReadLine());
            if (price < 4000)
            {
                Console.WriteLine("Please enter higher range price above 4000");
                continue;
            }
            else
            {
                break;
            }
        }

    }

    public void showDetails()
    {
        Console.WriteLine($"Furniture name is {Fname}");
        Console.WriteLine("Furniture color is : "+color);
        Console.WriteLine("Furniture material is : "+material); //No need to enter material name for common material
        Console.WriteLine("Furniture price is : "+price.ToString());
    }

    ~Furniture(){             //distructor
        material = " ";
        price = 0;

    }
}

class chair : Furniture  //inheritance child/derived class chair
{
    int no_legs;
    string manufName,emailId;
    public chair() :base("Aluminium"){ } //calling the parametarized constructor of base class
    public void acceptDetails()
    {
        base.getDetails();
        Console.WriteLine("Enter the number of legs \t");
        no_legs = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Enter manufacturer name ");
        manufName = Console.ReadLine().ToUpper();

        while (true) {
            Console.WriteLine("Enter email-id ");
            emailId = Console.ReadLine();
                if (emailId.EndsWith("@gmail.com"))
                break;
            else
            {
                Console.WriteLine("Enter a proper email id ");
                continue;
            }
        }

    }
    public void disDetails()
    {
        base.showDetails();
        Console.WriteLine("Total number of legs " + no_legs);
        Console.WriteLine("Manufacturer is " + manufName);
    }
}