// See https://aka.ms/new-console-template for more information

Add();
Add();
Add();
var result = Add2(3);
Console.WriteLine(result);
Add3(58, 99);

int number1 = 20;
int number2 = 100;
int number3;
int number4 = 500;
var result3 = Add4(ref number1, number2);
Console.WriteLine(result3);
var result4 = Add5(out number3, number4);
Console.WriteLine(result4);
Console.WriteLine(number3);
Console.WriteLine(Multiply(2,4));
//Console.WriteLine(Multiply(2,4,5));
Console.WriteLine(Add6(2,5,6,8,9,5,10));

static void Add()
{
    Console.WriteLine("Added!!!!");
}

static int Add2(int number1, int number2 = 30)
{
    var result = number1 + number2;
    return result;

}

static void Add3(int number1, int number2)
{
    var result2 = number1 + number2;
    Console.WriteLine(result2);

}

static int Add4(ref int number1, int number2)
{
    number1 = 30;
    return number1 + number2;

}

static int Add5(out int number3, int number4)
{
    number3 = 30;
    return number3 + number4;

}

static int Multiply(int number5, int number6)
{
    return number5 * number6;

}

static int Add6(params int[] numbers)
{
    return numbers.Sum();
}
//static int Multiply(int number5, int number6, long number7)
//{
//    return number5 * number6 * Convert.ToInt32(number7);

//}
//Console.WriteLine("Hello, World!");
Console.ReadLine();
