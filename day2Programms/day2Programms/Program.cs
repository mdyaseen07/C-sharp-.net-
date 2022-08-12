namespace day2Programms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 cc = new Class1();
            cc.ShowHeading();
            Console.WriteLine("Testing A Number Divisible By 5 or 8");
            Newclass n1 = new Newclass();
            

        }
    }
}
class Newclass
{
    int myNo;
   
    private void checkstatus()

    {
        n1.checkstatus();
        Console.Write("Enter the number \n");
        myNo = Convert.ToInt16(Console.ReadLine());
        if(myNo%5 == 0 && myNo%8 == 0)
        {
            Console.Write("Entered number is divisible by 5 and 8");
        }
        else if (myNo%5 == 0 && myNo%8 != 0)
        {
            Console.Write("Number only divisible by 5");
        }
        else if (myNo%5 != 0 && myNo%8 == 0)
        {
            Console.Write("Number only divisible by 8");
        }
        else
        {
            Console.Write("Number is not divisible by both");
        }
    }

}