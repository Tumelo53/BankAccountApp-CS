using System.Formats.Asn1;
using System.Net.Http.Headers;

BankAccount Thandeka = new BankAccount("thandeka", 2002, 74500);
BankAccount Kagiso = new BankAccount("kagiso", 2004, 108200);
BankAccount Celiwe = new BankAccount("celiwe", 2154, -200);

Console.WriteLine("goodbye");
//aUTH


Console.WriteLine("Enter Your Pin: ");

int answer1 = Convert.ToInt32(Console.ReadLine());

if (answer1 == Thandeka.Pin)
{
    Console.WriteLine("Do you want to Transfer/Withdraw/Deposit?");
    string answer2 = Console.ReadLine();


    if (answer2 == "Withdraw")
    {
        Console.WriteLine("Enter the amount?");
        double withamount = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Withdrawal successfully you current balance is {Thandeka.Withdraw(withamount)}");




    }
    else if (answer2 == "deposit")
    {
        Console.WriteLine("Enter the amount");
        double depositamount = Convert.ToDouble(Console.ReadLine());
        double balance1 = Thandeka.Deposit(depositamount);
        Console.WriteLine($"Deposit succesfully,your current balance is {balance1}");

    }
    else if (answer2 == "transfer")
    {
        Console.WriteLine("Enter the amount");
        double transferamount = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Account Name");
        string name2 = Console.ReadLine();

        if (name2 == "Kagiso")
        {
            Console.WriteLine($"transfer was successfully your current balance is {Thandeka.Transferout(transferamount)}");
            Console.WriteLine($"Money was successfully transfered!! {Kagiso.Transferin(transferamount)}");
        }
        else if (name2 == "Celiwe")
        {
            Console.WriteLine($"Transfer successfully your current balance is {Thandeka.Transferout(transferamount)}");
            Console.WriteLine($"Money was successfully transfered!! {Celiwe.Transferin(transferamount)}");
        }
        else
        {
            Console.WriteLine("invalid account");
        }
    }
}
if (answer1 == Kagiso.Pin)
    {
        Console.WriteLine("Do you want to Transfer/Withdraw/Deposit?");
        string answer3 = Console.ReadLine();
        //cONDITION

        if (answer3 == "withdraw")
        {
            Console.WriteLine("Enter the amount?");
            double withamount = Convert.ToDouble(Console.ReadLine());
            //call method
            Console.WriteLine("Withdrawal successfully");
            
        }
        else if (answer3 == "deposit")
        {
            Console.WriteLine("Enter the amount");
            double depositamount = Convert.ToDouble(Console.ReadLine());
            double balance1 = Thandeka.Deposit(depositamount);
            Console.WriteLine($"Deposit succesfully,your current balance is{balance1}");

        }
        else if (answer3 == "transfer")
        {
            Console.WriteLine("Enter the amount");
            double transferamount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Account Name");
            string name3 = Console.ReadLine();
            
         if (name3 == "Thandeka")
        {
            Console.WriteLine($"transfer was successfully your current balance is {Kagiso.Transferout(transferamount)}");
            Console.WriteLine($"Money was successfully transfered!! {Thandeka.Transferin(transferamount)}");
        }
        else if (name3 == "Celiwe")
        {
         Console.WriteLine($"Transfer successfully your current balance is {Kagiso.Transferout(transferamount)}"); 
          Console.WriteLine($"Money was successfully transfered!! {Celiwe.Transferin(transferamount)}");                 
        }
        else
        {
         Console.WriteLine("invalid account");
    }


        }


        
    }

if (answer1 == Celiwe.Pin)
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
