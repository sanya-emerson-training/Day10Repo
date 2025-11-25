using CustomerEmersonExceptionApp.Domain;

Account acc1 = new Account(101,"Sanya",7000);

try
{
    acc1.Withdraw(10000);
}
catch (EmersonInsufficientFundsException ex)
{
    Console.WriteLine($"{ex.Message} by child class");

}
catch (Exception excep)
{
    Console.WriteLine($"{excep.Message} by parent class");
}
