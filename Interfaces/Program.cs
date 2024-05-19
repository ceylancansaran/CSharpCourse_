using Interfaces;

InterfaceIntro();

Demo2();

ICustomerDal[] customerDals = new ICustomerDal[3]
{
    new SqlServerCustomerDal(),
    new OracleCustomerDal(),
    new MySqlCustomerDal()
};

foreach (var customerDal in customerDals)
{
    customerDal.Add();
}


Console.ReadLine();

static void InterfaceIntro()
{
    PersonManager personManager = new PersonManager();
    Customer customer = new Customer
    {
        Id = 1,
        FirstName = "Ceylan",
        LastName = "Cansaran",
        Address = "Ankara"
    };

    Student student = new Student
    {
        Id = 1,
        FirstName = "deneme",
        LastName = "Test",
        Department = "Arge"
    };

    personManager.Add(customer);
    personManager.Add(student);
}

static void Demo2()
{
    CustomerManager customerManager = new CustomerManager();
    customerManager.Add(new SqlServerCustomerDal());
}

interface IPerson
{
    int Id { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }

}

class Customer : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
}

class Student : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Department { get; set; }
}

class Worker : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Department { get; set; }
}

class PersonManager
{
    public void Add(IPerson person)
    {
        Console.WriteLine(person.FirstName);
    }
}

//Console.WriteLine("Hello, World!");

