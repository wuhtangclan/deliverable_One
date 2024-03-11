public class Program
{
    public static void Main(string[] args)
    {
        int stockSoda = 100;
        int restockSoda = 40;
        int stockChips = 40;
        int restockChips = 20;
        int stockCandy = 60;
        int restockCandy = 40;
        int soldSoda;
        int soldChips;
        int soldCandy;
        int remainingSoda;
        int remainingChips;
        int remainingCandy;


        Console.WriteLine("Welcome to the restocking tool.");

        //ask user how many sodas have been sold today
        Console.WriteLine("How many Sodas have been sold today? 100 are in stock. ");
        soldSoda = int.Parse(Console.ReadLine());
        //calculate remaining soda and console output to user
        remainingSoda = stockSoda - soldSoda;
        if (remainingSoda <= 100 && remainingSoda >= 0)
        {
            Console.WriteLine("There are " + remainingSoda + " sodas left.");
        }
        else
        {
            Console.WriteLine("That value is too high. Stock not adjusted.");
        }

        // ask user how many chips have been sold today
        Console.WriteLine("How many Chips have been sold today? 40 are in stock. ");
        soldChips = int.Parse(Console.ReadLine());
        // calculate remaining chips and console output to user
        remainingChips = stockChips - soldChips;
        if (remainingChips <= 40  && remainingChips >= 0)
        {
            Console.WriteLine("There are " + remainingChips + " chips left.");
        }
        else
        {
            Console.WriteLine("That value is too high. Do not fuck with me.");
        }

        //ask user how many candys have been sold today
        Console.WriteLine("How many Candys have been sold today? 60 are in stock. ");
        soldCandy = int.Parse(Console.ReadLine());
        // calculate remaining candy and console output to user
        remainingCandy = stockCandy - soldCandy;
        if (remainingCandy <= 60 && remainingCandy >= 0)
        {
            Console.WriteLine("There are " + remainingCandy + " candys are left.");
        }
        else
        {
            Console.WriteLine("That value is too high. Stock not adjusted.");
        }

        //console output for what needs to be restock

        Console.WriteLine("Thank you for filling out the values. Here's what needs to be restocked. ");
       //Console output for soda restock 
        if (remainingSoda <= restockSoda)
        {
            Console.WriteLine("Soda needs to be restocked.");
        } 

        //Console output for chips restock

        if (remainingChips <= restockChips)
        {
            Console.WriteLine("Chips need to be restocked.");
        }

        //Console output for Candy restock

        if (remainingCandy <= restockCandy)
        {
            Console.WriteLine("Candy needs to be restock.");
        }

        Console.WriteLine("Goodbye!");
    }
}