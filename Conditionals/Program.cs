// See https://aka.ms/new-console-template for more information

var number = 90;
if (number == 10)
{
    Console.WriteLine("Number is 10");
}
else if (number == 20)
{
    Console.WriteLine("Number is 20");
}
else
{
    Console.WriteLine("Number is not 10 or 20");
}

switch (number)
{
    case 10:
        Console.WriteLine("Number is 10");
        break;
    case 20:
        Console.WriteLine("Number is 20");
        break;
    default:
        Console.WriteLine("Number is not 10 or 20");
        break;
}

if (number >= 0 && number <= 100)
{
    Console.WriteLine("Number is between 0-100");
}
else if (number > 100 && number <= 200)
{
    Console.WriteLine("Number is between 101-200 ");
}
else if (number > 200 || number < 0)
{
    Console.WriteLine("Number is greater than 200 or less than 0");
}

if (number < 100)
{
    if (number >= 90 && number < 95)
    {
        Console.WriteLine("number is between 90-95");
    }

}
//Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10"); //single lineIf
//Console.WriteLine("Hello, World!");
Console.ReadLine();