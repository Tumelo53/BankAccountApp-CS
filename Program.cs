using System.Formats.Asn1;
using System.Net.Http.Headers;

BankAccount Thandeka = new BankAccount("thandeka", 2002, 74500);
BankAccount Kagiso = new BankAccount("kagiso", 2004, 108200);
BankAccount Celiwe = new BankAccount("celiwe", 2154, -200);

Console.WriteLine("Hello User");
//aUTH


Console.WriteLine("Enter Your Pin: ");

int answer1 = Convert.ToInt32(Console.ReadLine());

if (answer1 == Thandeka.Pin)
{
    Console.WriteLine("Do you want to Transfer/Withdraw/Deposit?");
    string answer2 = Console.ReadLine()ToUpper();
    

    if (answer2 == "Withdraw")
    {
        Console.WriteLine("Enter the amount?");
        double withamount = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine($"Withdrawal successfully you current balance is {Thandeka.Withdraw(withamount)}");


        

    }
    else if (answer2 == "Deposit")
    {
        Console.WriteLine("Enter the amount");
        double depositamount = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Deposit succesfully");

    }
    else if (answer2 == "Transfer")
    {
        Console.WriteLine("Enter the amount");
        double transferamount = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Transfer successfully");

        Console.WriteLine("Insufficient funds");
    }
    else if (answer1 == Kagiso.Pin)
    {
        Console.WriteLine("Do you want to Transfer/Withdraw/Deposit?");
        string answer3 = Console.ReadLine();
        //cONDITION

        if (answer3 == "withdrawal")
        {
            Console.WriteLine("Enter the amount?");
            double withamount = Convert.ToDouble(Console.ReadLine());
            //call method
            Console.WriteLine("Withdrawal successfully");
            ;
            

        }
        else if (answer3 == "Deposit")
        {
            Console.WriteLine("Enter the amount");
            double depositamount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Deposit succesfully");

        }
        else if (answer3 == "Transfer")
        {
            Console.WriteLine("Enter the amount");
            double transferamount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Transfer successfully");

            Console.WriteLine("Insufficient funds");

        }


        Console.WriteLine("Welcome Kagiso your balance is R108 200.00");
    }
    else if (answer1 == Celiwe.Pin)
    {
        Console.WriteLine("Do you want to Transfer/Withdraw/Deposit?");
        string answer4 = Console.ReadLine();
        //cONDITION

        if (answer4 == "withdrawal")
        {
            Console.WriteLine("Enter the amount?");
            double withamount = Convert.ToDouble(Console.ReadLine());
            //call method
            Console.WriteLine("withdrawal successfully");
            ;
            Console.WriteLine("Insufficient funds");

        }
        else if (answer4 == "Deposit")
        {
            Console.WriteLine("Enter the amount");
            double depositamount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Deposit succesfully");

        }
        else if (answer4 == "Transfer")
        {
            Console.WriteLine("Enter the amount");
            double transferamount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Transfer successfully");

            Console.WriteLine("Insufficient funds");

        }


        Console.WriteLine("Welcome Celiwe your balance is R-200.00");
    }


    else
    {
        Console.WriteLine("invalid pin");
    }
}






public class BankAccount
{
    public string AccountHolder;
    public int Pin;
    public double Balance;
    public BankAccount(string accountHolder, int pin, double balance = 0)
    {
        AccountHolder = accountHolder;
        Pin = pin;
        Balance = balance;
    }



    public double Deposit(double amount)
    {
        Balance += amount;

        return Balance;
    }
    public double Withdraw(double amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;

            return Balance;
        }
        else
        {
            Console.WriteLine(" Declined , online transaction deducted");
      
            return Balance -10;
        }
    }
    public double CheckBalance()
    {
        return Balance;
    }
    public double Transferout(double amount)
    {
        Balance += amount;

        return Balance;
    }
    public double Transferin(double amount)
    {
        if (Balance <= amount)
        {
            Balance -= amount;

            return Balance;
        }
        else
        {
            return Balance;
        }
    }
}
