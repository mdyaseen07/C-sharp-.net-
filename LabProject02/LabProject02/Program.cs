namespace LabProject02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Book Details");
            MyBooks b1 = new MyBooks();
            b1.enterDetails();
            b1.calculatePrice();
            b1.display();

            MyBooks b2 = new MyBooks();
            b1.enterDetails();
            b1.calculatePrice(0.18f);
            b1.display();

        }
    }
}

class MyBooks
{
    string bookName, authorName;
    float price, tprice;

    public MyBooks()
    {
        authorName = "Yaseen";
    }
    public void enterDetails()
    {
        Console.WriteLine("Enter the book name \t");
        bookName = Console.ReadLine();
        //Console.WriteLine("Enter the author name \t");
        //authorName = Console.ReadLine();
        Console.WriteLine("Enter the book price \t");
        price = Convert.ToSingle(Console.ReadLine());

    }

    public void calculatePrice()  //default method
    {
        tprice = price + 30;
    }

    public void calculatePrice(float gst) //parametarized method
    {
        tprice = price + (price*gst) ;
    }

    public void display()
    {
        Console.WriteLine("Book Name \t:" + bookName);
        Console.WriteLine("Author Name \t:" + authorName);
        Console.WriteLine("Book Price \t:" + price);
        Console.WriteLine("The Total price of the book is \t:" + tprice);
    }
}