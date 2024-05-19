// See https://aka.ms/new-console-template for more information

using Classes;

CustomerManager customerManager = new CustomerManager();
customerManager.Add();
customerManager.Update();

ProductManager productManager = new ProductManager();
productManager.Add();
productManager.Update();

Customer customer = new Customer();
customer.City = "Ankara";
customer.Id = 1;
customer.FirstName = "Ceylan";  //property de ki set kısmını kullanır
customer.LastName = "Cansaran";

Customer customer2 = new Customer
{
    Id = 2,
    FirstName = "Can",
    LastName = "Cansaran",
    City = "Ankara"
};

Console.WriteLine(customer2.FirstName); //property de ki get kısmını kullanır

Console.ReadLine();

//Console.WriteLine("Hello, World!");

