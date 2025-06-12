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
    string answer2 = Console.ReadLine().ToLower();


    if (answer2 == "Withdraw")
    {
        Console.WriteLine("Enter the amount?");
        double withamount = Convert.ToDouble(Console.ReadLine());

        if (withamount <= Thandeka.Balance)
        {
            Console.WriteLine($" Withdrawal Successfully! your new balance is: {Thandeka.Withdraw(withamount)}");
        }
        else
        { Console.WriteLine($" Declined , online transaction deducted {Thandeka.Withdraw(withamount)}"); }
    }
    
    else if (answer2 == "deposit")
    {
        Console.WriteLine("Enter the amount");
        double depositamount = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Deposit succesfully your new amount is" + Thandeka.Balance + depositamount);

    }
    else if (answer2 == "Transfer")
    {
        Console.WriteLine("Enter the amount");
        double transferamount = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("To which account?");
        string accountHolder = Console.ReadLine().ToLower();
        if (accountHolder == "Kagiso")
        {
            Console.WriteLine("Transfer successfully, Kagiso's Balance is: R" + Kagiso.Transferin(transferamount));
        }
        else if (accountHolder == "Celiwe")
        {
            Console.WriteLine("Transfer successfully, Celiwe's Balance is: R" + Celiwe.Transferin(transferamount));
        }

        else if (transferamount > Thandeka.Balance)
        {
            Console.WriteLine("Insufficient funds!");
        }


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

            if (withamount <= Kagiso.Balance)
            {
                Console.WriteLine($" Withdrawal Successfully! your new balance is: {Kagiso.Withdraw(withamount)}");
            }
            else if (withamount > Kagiso.Balance)
            { Console.WriteLine($" Declined , online transaction deducted {Kagiso.Withdraw(withamount)}"); }






        }
        //call method
       


        else if (answer3 == "deposit")
        {
            Console.WriteLine("Enter the amount");
            double depositamount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Deposit succesfully");

        }
        else if (answer3 == "transfer")
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



        if (answer4 == "Withdraw")
        {
            Console.WriteLine("Enter the amount?");
            double withamount = Convert.ToDouble(Console.ReadLine());

            if (withamount <= Celiwe.Balance)
            {
                Console.WriteLine($" Withdrawal Successfully! your new balance is: {Celiwe.Withdraw(withamount)}");
            }
            else
            { Console.WriteLine($" Declined , online transaction deducted {Celiwe.Withdraw(withamount)}"); }

        }

        //call method
       

    else if (answer4 == "deposit")
        {
            Console.WriteLine("Enter the amount");
            double depositamount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Deposit succesfully");

        }
        else if (answer4 == "transfer")
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
            
      
            return Balance -10;
        }
    }
    public double CheckBalance()
    {
        return Balance;
    }
    public double Transferin(double amount)
    {
        Balance += amount;

        return Balance;
    }
    public double Transferout(double amount)
    {
        if (Balance >= amount)
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
