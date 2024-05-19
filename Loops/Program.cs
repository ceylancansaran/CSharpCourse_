// See https://aka.ms/new-console-template for more information

for (int i = 2; i <= 100; i += 2)
{
    Console.WriteLine(i);
}
Console.WriteLine("Finished");

ForLoop();

static void ForLoop()
{
    for (int i = 100; i >= 0; i -= 2)
    {
        Console.WriteLine(i);
    }
}

WhileLoop();

static void WhileLoop()
{
    int number = 100;
    while (number >= 0)
    {
        Console.Write(number);
        number--;
    }
    Console.WriteLine("Now number is {0}", number);
}

DoWhileLoop();

ForeachLoop();

if (IsPrimeNumber(7))
{
    Console.WriteLine("This is a prime number");
}
else
{
    Console.WriteLine("this is a not prime number");
}

static void DoWhileLoop()
{
    int number = 10;
    do
    {
        Console.WriteLine(number);
        number--;
    } while (number >= 11);
}

static void ForeachLoop()
{
    string[] students = new string[3] { "Ahmet", "Can", "Mehmet" };

    foreach (var student in students) //dizi temelli datalarda gezilmesi için kullanılır.
    {
        //student = "Can";  foreach içerisinde gezdiğim elemanlara döngü içerisinde değer atayamayız.
        Console.WriteLine(student);
    }
}


static bool IsPrimeNumber(int number)
{
    bool result = true;
    for (int i = 2; i < number-1; i++)
    {
        if (number % i == 0 )
        {
            result = false;
            continue;
        }
    }
    return result;
}


Console.ReadLine();
