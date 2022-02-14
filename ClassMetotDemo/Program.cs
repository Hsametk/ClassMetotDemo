// See https://aka.ms/new-console-template for more information
using ClassMetotDemo;

Customer custmer1   = new Customer();
custmer1.Id = 001;
custmer1.Name = "Samet";
custmer1.Surname = "Kotu";
custmer1.CurrencyUnit = "TRY";

Customer custmer2 = new Customer();
custmer2.Id = 002;
custmer2.Name = "Mirac";
custmer2.Surname = "Kotu";
custmer2.CurrencyUnit = "USD";

Customer custmer3 = new Customer();
custmer3.Id = 002;
custmer3.Name = "Eyup";
custmer3.Surname = "Kotu";
custmer3.CurrencyUnit = "EUR";

Customer[] customers=new Customer[] { custmer1, custmer2,custmer3};

CustomerManager customerManager = new CustomerManager();
customerManager.Add(custmer1);
customerManager.Delete(custmer2);
Console.ReadLine();
foreach (Customer customer in customers)
{
    Console.WriteLine(customer.Id + " " + customer.Name + " " + customer.Surname + " " + customer.CurrencyUnit);
}

