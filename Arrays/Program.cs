// See https://aka.ms/new-console-template for more information

string student1 = "Ahmet";
string student2 = "Can";
string student3 = "Mehmet";

string[] students = { "Ahmet", "Can", "Mehmet" };
Console.WriteLine(students[1]);

string[] students1 = new string[] { student1, student2, student3 };
Console.WriteLine(students1[0]);

string[] students2 = new string[3];
students2[0] = "Ceylan";
students2[1] = "Ayşe";
students2[2] = "Fatma";


foreach (var student in students2)
{
    Console.WriteLine(student);
}

Console.WriteLine("**************");

string[,] regions = new string[5, 3] //7 satır, 3 sütun
{
    {"İstanbul","İzmit","Balıkesir" },
    { "Ankara","Konya","Kırıkkale"},
    { "Manisa", "İzmir","Muğla" },
    { "Rize","Trabzon","Samsun"},
    {"Antalya","Adana","Mersin" }
};
for (int i = 0; i <= regions.GetUpperBound(0); i++)
{
    for (int j = 0; j <= regions.GetUpperBound(1); j++)
    {
        Console.WriteLine(regions[i,j]);
    }
    Console.WriteLine("**************");
}

//Console.WriteLine("Hello, World!");
Console.ReadLine();