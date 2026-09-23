using System.Text;

const string TxtPath = "..\\..\\..\\data\\titanic.txt";

List<Category> categories = [];
using StreamReader sr = new(TxtPath, Encoding.UTF8);
while(!sr.EndOfStream) categories.Add(new(sr.ReadLine()));

Console.WriteLine($"kategóriák száma: {categories.Count} db");

int f3 = categories.Sum(c => c.AllPassanger);
Console.WriteLine(f3);

Console.Write("írd be a keresési kulcsszó egy részét: ");
string searchString = Console.ReadLine();
bool f4 = categories.Any(c => c.Name.Contains(searchString));
Console.WriteLine(f4 ? "van találat" : "nincs találat");

if (f4)
{
    Console.WriteLine("keresésmek megfelelő találatok:");
    var f5 = categories.Where(c => c.Name.Contains(searchString));
	foreach (var c in f5) Console.WriteLine($"\t{c.Name, -25} {c.AllPassanger, +3} fo");
}