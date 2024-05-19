Intro();

string sentence = "My name is Ceylan Cansaran";
var result = sentence.Length; 
var result2 = sentence.Clone();
sentence = "My name is Can Cansaran";
bool result3 = sentence.EndsWith("n");
bool result4 = sentence.StartsWith("My name");
var result5 = sentence.IndexOf("name");
var result6 = sentence.IndexOf(" ");
var result7 = sentence.LastIndexOf("s");
var result8 = sentence.Insert(0, "Hello, ");
var result9 = sentence.Substring(3,4);
var result10 = sentence.ToLower();
var result11 = sentence.ToUpper();
var result12 = sentence.Replace(" ","_");
var result13 = sentence.Remove(2,5);
Console.WriteLine(result13);


Console.ReadLine();

static void Intro()
{
    string city = "Ankara"; //string aslında char array 
    Console.WriteLine(city[0]);

    foreach (var item in city)
    {
        Console.WriteLine(item);
    }

    string city2 = "İstanbul";
    //string result = city + ' ' + city2;
    Console.WriteLine(String.Format("{0} {1}", city, city2));
}

//Console.WriteLine("Hello, World!");
