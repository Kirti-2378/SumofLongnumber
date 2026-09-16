using System;

class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string message) : base(message)
    {
    }
}

class ATM
{
    static void Main()
    {
        try
        {
            Console.Write("Enter account balance: ");
            double balance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter withdrawal amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            if (amount > balance)
            {
                throw new InsufficientBalanceException(
                    "Insufficient balance. Withdrawal cannot be processed."
                );
            }

            balance = balance - amount;

            Console.WriteLine("Withdrawal successful.");
            Console.WriteLine("Remaining balance: " + balance);
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter a valid amount.");
        }
        finally
        {
            Console.WriteLine("Thank you for using the ATM.");
        }
    }
}
