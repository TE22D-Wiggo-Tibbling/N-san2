// Steg 1
string[] strings = ["bowser", "mowser", "bolser", "bomser", "comser"];

// steg 2
string[] strings2 = ["bowser", "mowser", "bolser", "bomser", "comser"];
foreach (string leksak in strings2)
{
    System.Console.WriteLine(leksak);
}
Console.ReadLine();

// Steg 3
int[] ints = [1, 2, 3, 4, 5];

// Steg 4

int[] ints2 = [1, 2, 3, 4, 5];

for (int i = 0; i < ints2.Length; i++)
{
    System.Console.WriteLine($"Pelle ger {strings2[i]} betyget {ints2[i]}");
}

// Steg 5

List<string> cities = new();
string awnser = "";

while (awnser.ToLower() != "exit")
{
    awnser = Console.ReadLine();
    if (awnser.ToLower() != "exit")
    {
        cities.Add(awnser);
    }
}

// Steg 6
List<string> cities2 = new();
string awnser2 = "";

while (awnser2.ToLower() != "exit")
{
    awnser2 = Console.ReadLine();
    if (awnser2.ToLower() != "exit")
    {
        cities2.Add(awnser2);
    }
}
foreach (string citiesAwnsers in cities2)
{
    System.Console.WriteLine($"{citiesAwnsers}, ");
}